using Kitchen.Models;

namespace Kitchen.Core.Services;

public class IngredientService : IIngredientService
{
    private readonly IIngredientRepository _ingredientRepository;
    private const int _maxPageSize = 40;
    public IngredientService(IIngredientRepository ingredientRepository)
    {
        _ingredientRepository = ingredientRepository;
    }

    public async Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize)
    {
        if (pageSize > _maxPageSize)
            pageSize = _maxPageSize;

        return await _ingredientRepository.GetPage(pageNumber, pageSize);
    }

    public async Task<IEnumerable<Ingredient>> GetAllNoDescription() => await _ingredientRepository.GetAllNoDescription();

    public async Task<Ingredient?> Get(int id) => await _ingredientRepository.Get(id);

    public async Task<Ingredient?> Add(IngredientRequest createIngredientRequest)
    {
        Ingredient ingredient = new()
        {
            Name = createIngredientRequest.Name,
            Description = createIngredientRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        Ingredient? created = await _ingredientRepository.Add(ingredient);
        return created;
    }

    public async Task<bool> Update(int id, IngredientRequest updateIngredientRequest)
    {
        Ingredient ingredient = new()
        {
            Id = id,
            Name = updateIngredientRequest.Name,
            Description = updateIngredientRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        return await _ingredientRepository.Update(ingredient);
    }

    public async Task<DbResult<Ingredient>> UpdateWithDbResult(int id, IngredientRequest updateIngredientRequest)
    {
        Ingredient ingredient = new()
        {
            Id = id,
            Name = updateIngredientRequest.Name,
            Description = updateIngredientRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        return await _ingredientRepository.UpdateWithDbResult(ingredient);
    }

    public async Task<bool> Delete(int id) => await _ingredientRepository.Delete(id);

    public async Task<bool> IdExist(int id) => await _ingredientRepository.IdExist(id);

    public async Task<bool> NameExist(string name) => await _ingredientRepository.NameExist(name);
}
