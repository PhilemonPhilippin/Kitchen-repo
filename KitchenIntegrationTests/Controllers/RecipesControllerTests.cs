using Kitchen.Contracts.Dtos;
using Kitchen.Models;
using System.Net;
using System.Text.Json;

namespace KitchenIntegrationTests.Controllers;

public class RecipesControllerTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    public RecipesControllerTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Theory]
    [InlineData(0)]
    [InlineData(10000)]
    public async Task GetRecipeById_InvalidId_ReturnsNotFound(int id)
    {
        var httpClient = _factory.CreateClient();

        var response = await httpClient.GetAsync($"/api/recipes/{id}");
        var status = response.StatusCode;

        Assert.Equal(HttpStatusCode.NotFound, status);
    }

    // Given actual seed in DB, id can't be more than 12
    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    public async Task GetRecipeById_ValidId_ReturnsExpectedResponse(int id)
    {
        var httpClient = _factory.CreateClient();

        var response = await httpClient.GetFromJsonAsync<RecipeDto>($"/api/recipes/{id}");

        Assert.NotNull(response);
        Assert.Equal(id, response.Id);
    }

    [Fact]
    public async Task GetRecipes_Zero_ReturnsNotFound()
    {
        var httpClient = _factory.CreateClient();

        var response = await httpClient.GetAsync($"/api/recipes?pagenumber=1&pagesize=0");
        var status = response.StatusCode;

        Assert.Equal(HttpStatusCode.NotFound, status);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(10)]
    public async Task GetRecipes_ValidQuery_ReturnsExpectedResponse(int pageSize)
    {
        var httpClient = _factory.CreateClient();

        var response = await httpClient.GetFromJsonAsync<IEnumerable<RecipeDto>>($"/api/recipes?pagenumber=1&pagesize={pageSize}");

        Assert.NotNull(response);
        Assert.NotEmpty(response);
        Assert.Equal(pageSize, response.Count());
    }

    [Fact]
    public async Task GetRecipes_ValidQuery_ReturnsExpectedPaginationHeader()
    {
        // Arrange
        var httpClient = _factory.CreateClient();
        int pageSize = 5;
        int pageNumber = 1;

        // Act
        var response = await httpClient.GetAsync($"/api/recipes?pagenumber={pageNumber}&pagesize={pageSize}");
        var header = response.Headers.FirstOrDefault(h => h.Key == "X-Pagination").Value.FirstOrDefault();

        // Assert
        var pagination = JsonSerializer.Deserialize<PaginationMetadata>(header);
        Assert.NotNull(pagination);
        Assert.Equal(pageNumber, pagination.PageNumber);
        Assert.Equal(pageSize, pagination.PageSize);
        Assert.Equal(12, pagination.TotalItemCount);
        Assert.Equal(3, pagination.TotalPageCount);
    }
}
