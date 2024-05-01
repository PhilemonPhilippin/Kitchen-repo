namespace Kitchen.Api.Mappers.Customs;

public static class RecipeMapper
{
    public static RecipeDto MapToRecipeDto(this Recipe recipe)
    {
        string? image = null;
        if (recipe.Image is not null)
        {
            string? directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
            string imagePath = Path.Combine(directory, "Images", recipe.Image);
            byte[] imageArray = File.ReadAllBytes(imagePath);
            string base64Image = Convert.ToBase64String(imageArray);
            image = base64Image;
        }
        return new RecipeDto
        {
            Id = recipe.Id,
            Title = recipe.Title,
            Description = recipe.Description,
            Image = image,
            RecipeCategory = new RecipeCategoryDto
            {
                Id = recipe.RecipeCategory.Id,
                Title = recipe.RecipeCategory.Title,
                Description = recipe.RecipeCategory.Description,
            }
        };
    }
}
