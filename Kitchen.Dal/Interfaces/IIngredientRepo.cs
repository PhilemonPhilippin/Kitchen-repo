namespace Kitchen.Dal.Interfaces;

public interface IIngredientRepo
{
    Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetIngredientsAsync(int pageNumber, int pageSize);
    Task<IEnumerable<Ingredient>> GetIngredientsNoDescAsync();
    Task<Ingredient?> GetIngredientByIdAsync(int id);
    Task<bool> CreateIngredientAsync(Ingredient ingredient);
    Task<bool> UpdateIngredientAsync(Ingredient ingredient);
    Task<bool> DeleteIngredientAsync(int id);
    Task<bool> IngredientExistsAsync(int id);
    Task<bool> IngredientExistsAsync(string name);
}
