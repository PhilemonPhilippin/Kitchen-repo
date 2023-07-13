﻿using Kitchen.Models;

namespace Kitchen.Core.Services;

public class IngredientService : IIngredientService
{
    private readonly IIngredientRepo _ingredientRepo;
    private const int _maxPageSize = 40;
    public IngredientService(IIngredientRepo ingredientRepo)
    {
        _ingredientRepo = ingredientRepo;
    }

    public async Task<(IEnumerable<Ingredient> ingredients, PaginationMetadata metadata)> GetIngredientsAsync(int pageNumber, int pageSize)
    {
        if (pageSize > _maxPageSize)
            pageSize = _maxPageSize;

        return await _ingredientRepo.GetIngredientsAsync(pageNumber, pageSize);
    }

    public async Task<IEnumerable<Ingredient>> GetIngredientsNoDescAsync() =>
        await _ingredientRepo.GetIngredientsNoDescAsync();

    public async Task<Ingredient?> GetIngredientByIdAsync(int id) =>
        await _ingredientRepo.GetIngredientByIdAsync(id);

    public async Task<Ingredient?> CreateIngredientAsync(IngredientRequest createIngredientRequest)
    {
        Ingredient ingredient = new()
        {
            Name = createIngredientRequest.Name,
            Description = createIngredientRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        bool isCreated = await _ingredientRepo.CreateIngredientAsync(ingredient);

        if (isCreated == false)
            return null;

        return ingredient;
    }

    public async Task<bool> UpdateIngredientAsync(int id, IngredientRequest updateIngredientRequest)
    {
        Ingredient ingredient = new()
        {
            Id = id,
            Name = updateIngredientRequest.Name,
            Description = updateIngredientRequest.Description,
            ModifiedOn = DateTime.UtcNow
        };

        return await _ingredientRepo.UpdateIngredientAsync(ingredient);
    }

    public async Task<bool> DeleteIngredientAsync(int id) =>
        await _ingredientRepo.DeleteIngredientAsync(id);


    public async Task<bool> IngredientExistsAsync(int id) =>
        await _ingredientRepo.IngredientExistsAsync(id);

    public async Task<bool> NameExistAsync(string name) => await _ingredientRepo.IngredientExistsAsync(name);
}
