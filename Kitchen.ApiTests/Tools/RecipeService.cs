using Kitchen.Contracts.Requests;
using Kitchen.Core.Interfaces;
using Kitchen.Entities;
using Kitchen.Models;

namespace Kitchen.Api.Tools;

internal class RecipeService : IRecipeService
{
    public Task<DbResult<Recipe>> Add(RecipeRequest createRecipeRequest)
    {
        throw new NotImplementedException();
    }

    public Task<Status> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbResult<Recipe>> Get(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<(IEnumerable<Recipe> recipes, PaginationMetadata metadata)> GetPage(int pageNumber, int pageSize, string? title, string? searchQuery)
    {
        return await Task.FromResult((Enumerable.Empty<Recipe>(), new PaginationMetadata(1,5,0)));
    }

    public Task<bool> IdExist(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Status> Update(int id, RecipeRequest updateRecipeRequest)
    {
        throw new NotImplementedException();
    }
}
