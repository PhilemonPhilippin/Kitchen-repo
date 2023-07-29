
using Kitchen.Contracts.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;

namespace Kitchen.Api.Controllers;

public class RecipesControllerTests
{
    [Fact]
    public async Task GetRecipes_Empty_ReturnsNotFound()
    {

        // Arrange
        Tools.RecipeService recipeService = new Tools.RecipeService();
        RecipesController controller = new (new NullLogger<RecipesController>(), recipeService);

        // Act
        ActionResult<IEnumerable<RecipeDto>> response = await controller.GetRecipes(1, 5, null, null);
        var result = response.Result;

        // Assert
        Assert.NotNull(result);
        Assert.IsType<NotFoundResult>(result);
    }
}
