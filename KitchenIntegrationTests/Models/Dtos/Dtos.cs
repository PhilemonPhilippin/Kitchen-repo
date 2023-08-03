namespace KitchenIntegrationTests.Models.Dtos;

public record ExpectedRecipeDto(int Id, string Title, string? Description, ExpectedRecipeCategoryDto RecipeCategory);

public record ExpectedRecipeCategoryDto(int Id, string Title, string? Description);

public record ExpectedPaginationMetadata(int PageNumber, int PageSize, int TotalItemCount, int TotalPageCount);