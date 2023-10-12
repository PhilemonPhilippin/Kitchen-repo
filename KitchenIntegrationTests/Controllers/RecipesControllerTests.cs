using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace KitchenIntegrationTests.Controllers;

public class RecipesControllerTests : IClassFixture<WebApplicationFactoryKitchenTest<Program>>, IAsyncLifetime
{
    private readonly HttpClient _httpClient;
    private AuthAccessToken _authAccessToken;
    public RecipesControllerTests(WebApplicationFactoryKitchenTest<Program> factory)
    {
         factory.ClientOptions.BaseAddress = new Uri("https://localhost:7049/api/recipes/");
        _httpClient = factory.CreateClient();
    }

    public async Task InitializeAsync()
    {
        _authAccessToken = await GetAccessToken();
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _authAccessToken.AccessToken);
    }

    #region Get
    [Theory]
    [InlineData(0)]
    [InlineData(10000)]
    public async Task GetRecipeById_InvalidId_ReturnsNotFound(int id)
    {
        var response = await _httpClient.GetAsync(id.ToString());
        var status = response.StatusCode;

        Assert.Equal(HttpStatusCode.NotFound, status);
    }

    // Given actual seed in DB, id can't be more than 12
    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    public async Task GetRecipeById_ValidId_ReturnsExpectedResponse(int id)
    {
        var response = await _httpClient.GetFromJsonAsync<ExpectedRecipeDto>(id.ToString());

        Assert.NotNull(response);
        Assert.Equal(id, response.Id);
    }
    #endregion

    #region GetAll
    [Fact]
    public async Task GetRecipes_ZeroPagesize_ReturnsNotFound()
    {
        var response = await _httpClient.GetAsync($"?pagenumber=1&pagesize=0");
        var status = response.StatusCode;

        Assert.Equal(HttpStatusCode.NotFound, status);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(10000)]
    public async Task GetRecipes_InvalidPageNumber_ReturnsNotFound(int pageNumber)
    {
        var response = await _httpClient.GetAsync($"?pagenumber={pageNumber}&pagesize=5");
        var status = response.StatusCode;

        Assert.Equal(HttpStatusCode.NotFound, status);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    public async Task GetRecipes_ValidQuery_ReturnsExpectedCount(int pageSize)
    {
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<ExpectedRecipeDto>>($"?pagenumber=1&pagesize={pageSize}");

        Assert.NotNull(response);
        Assert.NotEmpty(response);
        Assert.Equal(pageSize, response.Count());
    }

    [Theory]
    [InlineData(5, 1)]
    [InlineData(10, 1)]
    public async Task GetRecipes_ValidQuery_ReturnsExpectedPagination(int pageSize, int pageNumber)
    {
        // Act
        var response = await _httpClient.GetAsync($"?pagenumber={pageNumber}&pagesize={pageSize}");
        var header = response.Headers.FirstOrDefault(h => h.Key == "X-Pagination").Value.FirstOrDefault();

        // Assert
        var pagination = JsonSerializer.Deserialize<ExpectedPaginationMetadata>(header);
        Assert.NotNull(pagination);
        Assert.Equal(pageNumber, pagination.PageNumber);
        Assert.Equal(pageSize, pagination.PageSize);
    }

    [Fact]
    public async Task GetRecipes_SearchQuery_ReturnsExpectedCount()
    {
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<ExpectedRecipeDto>>("?pageNumber=1&pageSize=5&searchQuery=soup");

        Assert.NotNull(response);
        Assert.NotEmpty(response);
        Assert.Equal(3, response.Count());
    }

    [Fact]
    public async Task GetRecipes_SearchQuery_ReturnsExpectedTotalItemCount()
    {
        var response = await _httpClient.GetAsync("?pageNumber=1&pageSize=5&searchQuery=soup");
        var header = response.Headers.FirstOrDefault(h => h.Key == "X-Pagination").Value.FirstOrDefault();

        var pagination = JsonSerializer.Deserialize<ExpectedPaginationMetadata>(header);
        Assert.NotNull(pagination);
        Assert.Equal(3, pagination.TotalItemCount);
    }

    [Fact]
    public async Task GetRecipes_ValidTitle_ReturnsEnglishBreakfast()
    {
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<ExpectedRecipeDto>>("?pageNumber=1&pageSize=5&title=English%20breakfast");

        Assert.NotNull(response);
        Assert.NotEmpty(response);
        Assert.Single(response);
        Assert.Equal(1, response.SingleOrDefault()?.Id);
        Assert.Equal("English breakfast", response.SingleOrDefault()?.Title);
    }

    [Fact]
    public async Task GetRecipes_InvalidTitle_ReturnsNotFound()
    {
        var response = await _httpClient.GetAsync("?pageNumber=1&pageSize=5&title=Double%20whopper%20cheese");
        var status = response.StatusCode;

        Assert.Equal(HttpStatusCode.NotFound, status);
    }

    [Fact]
    public async Task GetRecipes_InvalidSearchQuery_ReturnsNotFound()
    {
        var response = await _httpClient.GetAsync("?pageNumber=1&pageSize=5&searchQuery=Double%20whopper%20cheese");
        var status = response.StatusCode;

        Assert.Equal(HttpStatusCode.NotFound, status);
    }
    #endregion

    #region Post
    [Fact]
    public async Task CreateRecipe_NoTitle_ReturnsBadRequest()
    {
        var recipe = GetValidRecipeRequestInput().CloneWith(r => r.Title = null);
        var response = await _httpClient.PostAsJsonAsync("", recipe, JsonSerializerHelper.DefaultSerialisationOptions());

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task CreateRecipe_NoTitle_ReturnsTitleIsRequired()
    {
        var recipe = GetValidRecipeRequestInput().CloneWith(r => r.Title = null);
        var response = await _httpClient.PostAsJsonAsync("", recipe, JsonSerializerHelper.DefaultSerialisationOptions());

        var problemDetails = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>();
        Assert.NotNull(problemDetails);
        Assert.Collection(problemDetails.Errors, kvp =>
        {
            Assert.Equal("Title", kvp.Key);
            var error = Assert.Single(kvp.Value);
            Assert.Equal("The Title field is required.", error);
        });
    }

    [Fact]
    public async Task CreateRecipe_TitleTooLong_ReturnsTitleTooLong()
    {
        var recipe = GetValidRecipeRequestInput().CloneWith(r => r.Title = new string('a', 51));
        var response = await _httpClient.PostAsJsonAsync("", recipe, JsonSerializerHelper.DefaultSerialisationOptions());

        var problemDetails = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>();
        Assert.NotNull(problemDetails);
        Assert.Collection(problemDetails.Errors, kvp =>
        {
            Assert.Equal("Title", kvp.Key);
            var error = Assert.Single(kvp.Value);
            Assert.Equal("The field Title must be a string or array type with a maximum length of '50'.", error);
        });
    }

    [Fact]
    public async Task CreateRecipe_DescriptionTooLong_ReturnsDescriptionTooLong()
    {
        var recipe = GetValidRecipeRequestInput().CloneWith(r => r.Description = new string('a', 501));
        var response = await _httpClient.PostAsJsonAsync("", recipe, JsonSerializerHelper.DefaultSerialisationOptions());

        var problemDetails = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>();
        Assert.NotNull(problemDetails);
        Assert.Collection(problemDetails.Errors, kvp =>
        {
            Assert.Equal("Description", kvp.Key);
            var error = Assert.Single(kvp.Value);
            Assert.Equal("The field Description must be a string or array type with a maximum length of '500'.", error);
        });
    }

    [Fact]
    public async Task CreateRecipe_NoCategoryId_ReturnsCategoryIdIsRequired()
    {
        var recipe = GetValidRecipeRequestInput().CloneWith(r => r.RecipeCategoryId = null);
        var response = await _httpClient.PostAsJsonAsync("", recipe, JsonSerializerHelper.DefaultSerialisationOptions());

        var problemDetails = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>();
        Assert.NotNull(problemDetails);
        Assert.Collection(problemDetails.Errors, kvp =>
        {
            Assert.Equal("RecipeCategoryId", kvp.Key);
            var error = Assert.Single(kvp.Value);
            Assert.Equal("The RecipeCategoryId field is required.", error);
        });
    }

    [Fact]
    public async Task CreateRecipe_ValidRecipe_ReturnsCreatedResultThatCanBeRetrieved()
    {
        var recipe = GetValidRecipeRequestInput();
        var content = JsonContent.Create(recipe);
        var response = await _httpClient.PostAsync("", content);

        var location = response.Headers.Location?.ToString();
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        var getResponse = await _httpClient.GetAsync(location);
        getResponse.EnsureSuccessStatusCode();
    }
    #endregion

    #region Update

    [Fact]
    public async Task UpdateRecipe_NoTitle_ReturnsBadRequest()
    {
        var recipes = await GetAddedTestRecipes();
        if (recipes is not null)
        {
            int? id = recipes.ToList().FirstOrDefault()?.Id;

            var content = GetValidRecipeRequestInput().CloneWith(r => { 
                r.Title = null;
                r.Description += "(UPDATED)";
            });
            var response = await _httpClient.PutAsJsonAsync(id.ToString(), content, JsonSerializerHelper.DefaultSerialisationOptions());

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }

    [Fact]
    public async Task UpdateRecipe_NoTitle_ReturnsTitleIsRequired()
    {
        var recipes = await GetAddedTestRecipes();
        if (recipes is not null)
        {
            int? id = recipes.ToList().FirstOrDefault()?.Id;

            var content = GetValidRecipeRequestInput().CloneWith(r =>
            {
                r.Title = null;
                r.Description += "(UPDATED)";
            });
            var response = await _httpClient.PutAsJsonAsync(id.ToString(), content, JsonSerializerHelper.DefaultSerialisationOptions());

            var problemDetails = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>();
            Assert.NotNull(problemDetails);
            Assert.Collection(problemDetails.Errors, kvp =>
            {
                Assert.Equal("Title", kvp.Key);
                var error = Assert.Single(kvp.Value);
                Assert.Equal("The Title field is required.", error);
            });
        }
    }

    [Fact]
    public async Task UpdateRecipe_TitleTooLong_ReturnsTitleTooLong()
    {
        var recipes = await GetAddedTestRecipes();
        if (recipes is not null)
        {
            int? id = recipes.ToList().FirstOrDefault()?.Id;

            var content = GetValidRecipeRequestInput().CloneWith(r => {
                r.Title = new string('a', 51);
                r.Description += "(UPDATED)";
            });
            var response = await _httpClient.PutAsJsonAsync(id.ToString(), content, JsonSerializerHelper.DefaultSerialisationOptions());

            var problemDetails = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>();
            Assert.NotNull(problemDetails);
            Assert.Collection(problemDetails.Errors, kvp =>
            {
                Assert.Equal("Title", kvp.Key);
                var error = Assert.Single(kvp.Value);
                Assert.Equal("The field Title must be a string or array type with a maximum length of '50'.", error);
            });
        }
    }

    [Fact]
    public async Task UpdateRecipe_DescriptionTooLong_ReturnsDescriptionTooLong()
    {
        var recipes = await GetAddedTestRecipes();
        if (recipes is not null)
        {
            int? id = recipes.ToList().FirstOrDefault()?.Id;

            var content = GetValidRecipeRequestInput().CloneWith(r => r.Description = new string('a', 501) + "(UPDATED)");
            var response = await _httpClient.PutAsJsonAsync(id.ToString(), content, JsonSerializerHelper.DefaultSerialisationOptions());

            var problemDetails = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>();
            Assert.NotNull(problemDetails);
            Assert.Collection(problemDetails.Errors, kvp =>
            {
                Assert.Equal("Description", kvp.Key);
                var error = Assert.Single(kvp.Value);
                Assert.Equal("The field Description must be a string or array type with a maximum length of '500'.", error);
            });
        }
    }

    [Fact]
    public async Task UpdateRecipe_NoCategoryId_ReturnsCategoryIdIsRequired()
    {
        var recipes = await GetAddedTestRecipes();
        if (recipes is not null)
        {
            int? id = recipes.ToList().FirstOrDefault()?.Id;

            var content = GetValidRecipeRequestInput().CloneWith(r => { 
                r.RecipeCategoryId = null;
                r.Description += "(UPDATED)";
            });
            var response = await _httpClient.PutAsJsonAsync(id.ToString(), content, JsonSerializerHelper.DefaultSerialisationOptions());

            var problemDetails = await response.Content.ReadFromJsonAsync<ValidationProblemDetails>();
            Assert.NotNull(problemDetails);
            Assert.Collection(problemDetails.Errors, kvp =>
            {
                Assert.Equal("RecipeCategoryId", kvp.Key);
                var error = Assert.Single(kvp.Value);
                Assert.Equal("The RecipeCategoryId field is required.", error);
            });
        }
    }

    [Theory]
    [InlineData(0)]
    [InlineData(10000)]
    public async Task UpdateRecipe_InvalidId_ReturnsNotFound(int id)
    {
        var recipe = GetValidRecipeRequestInput().CloneWith(r => r.Description += "(UPDATED)");
        var response = await _httpClient.PutAsJsonAsync(id.ToString(), recipe);
        var status = response.StatusCode;

        Assert.Equal(HttpStatusCode.NotFound, status);
    }

    [Fact]
    public async Task UpdateRecipe_Valid_ReturnsNoContent()
    {
        var recipes = await GetAddedTestRecipes();
        if (recipes is not null)
        {
            int? id = recipes.ToList().FirstOrDefault()?.Id;

            var content = GetValidRecipeRequestInput().CloneWith(r => r.Description += "(UPDATED)");

            var response = await _httpClient.PutAsJsonAsync(id.ToString(), content);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }
    }
    #endregion

    #region Delete
    [Theory]
    [InlineData(0)]
    [InlineData(10000)]
    public async Task DeleteRecipe_InvalidId_ReturnsNotFound(int id)
    {
        var response = await _httpClient.DeleteAsync(id.ToString());
        var status = response.StatusCode;

        Assert.Equal(HttpStatusCode.NotFound, status);
    }

    [Fact]
    public async Task DeleteRecipe_ValidId_ReturnsNoContent()
    {
        // Arrange
        var recipes = await GetAddedTestRecipes();
        int? id = null;
        if (recipes is not null)
        {
            id = recipes.FirstOrDefault()?.Id;
        }

        // Act
        var response = await _httpClient.DeleteAsync(id.ToString());
        var status = response.StatusCode;

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.NoContent, status);
    }
    #endregion

    private static RecipeRequestInput GetValidRecipeRequestInput()
    {
        return new RecipeRequestInput
        {
            Title = "Some recipe",
            Description = "Some description",
            RecipeCategoryId = "1"
        };
    }

    private async Task<IEnumerable<ExpectedRecipeDto>> GetAddedTestRecipes()
    {
        var recipes = await _httpClient.GetFromJsonAsync<IEnumerable<ExpectedRecipeDto>>("?pageNumber=1&pageSize=20&title=Some%20recipe");
        return recipes?.OrderByDescending(r => r.Id);
    }

    public Task DisposeAsync()
    {
        return Task.CompletedTask;
    }

    public async Task<AuthAccessToken> GetAccessToken()
    {
        var authClient = new HttpClient();
        HttpRequestMessage request = new(HttpMethod.Post, "https://philauth.eu.auth0.com/oauth/token");
        string client_secret = Environment.GetEnvironmentVariable("KitchenClientSecret", EnvironmentVariableTarget.User) ?? "Environment variable for client_secret not found.";
        var body = $"{{\"client_id\":\"vMrTW3K4v8zL2dOxUBiafcwj1o4kkywx\",\"client_secret\":\"{client_secret}\",\"audience\":\"https://localhost:7049/api\",\"grant_type\":\"client_credentials\"}}";
        request.Content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
        using var response = await authClient.SendAsync(request);
        if (response.IsSuccessStatusCode == false)
            return new AuthAccessToken();
        else
        {
            var content = await response.Content.ReadFromJsonAsync<AuthAccessToken>();
            return content ?? new AuthAccessToken();
        }
    }
}
