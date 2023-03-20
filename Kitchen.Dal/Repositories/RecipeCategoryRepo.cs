﻿namespace Kitchen.Dal.Repositories;

public class RecipeCategoryRepo : IRecipeCategoryRepo
{
    private readonly KitchenContext _context;

    public RecipeCategoryRepo(KitchenContext context)
    {
        _context = context;
    }

    public async Task<RecipeCategory> GetRecipeCategoryByIdAsync(Guid id)
    {
        RecipeCategory category = await _context.RecipeCategories.FirstOrDefaultAsync(rc => rc.Id == id);

        return category;
    }
}