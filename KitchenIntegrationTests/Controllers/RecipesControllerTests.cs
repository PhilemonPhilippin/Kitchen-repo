
namespace KitchenIntegrationTests.Controllers;

public class RecipesControllerTests : IClassFixture<WebApplicationFactoryKitchenTest<Program>>
{
    private readonly HttpClient _httpClient;
    public RecipesControllerTests(WebApplicationFactoryKitchenTest<Program> factory)
    {
        factory.ClientOptions.BaseAddress = new Uri("https://localhost:7049/api/recipes/");
        _httpClient = factory.CreateClient();
    }

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

    [Fact]
    public async Task GetRecipes_Zero_ReturnsNotFound()
    {
        var response = await _httpClient.GetAsync($"?pagenumber=1&pagesize=0");
        var status = response.StatusCode;

        Assert.Equal(HttpStatusCode.NotFound, status);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    public async Task GetRecipes_ValidQuery_ReturnsExpectedResponse(int pageSize)
    {
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<ExpectedRecipeDto>>($"?pagenumber=1&pagesize={pageSize}");

        Assert.NotNull(response);
        Assert.NotEmpty(response);
        Assert.Equal(pageSize, response.Count());
    }

    [Theory]
    [InlineData(5, 1)]
    [InlineData(10, 1)]
    public async Task GetRecipes_ValidQuery_ReturnsExpectedPaginationHeader(int pageSize, int pageNumber)
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
}
