namespace Kitchen.Core.Services;

//public class RecipeCategoryService : IRecipeCategoryService
//{
//    private readonly IRecipeCategoryRepository _recipeCategoryRepository;

//    public RecipeCategoryService(IRecipeCategoryRepository recipeCategoryRepository)
//    {
//        _recipeCategoryRepository = recipeCategoryRepository;
//    }

    //public async Task<IEnumerable<RecipeCategory>> GetAll() => await _recipeCategoryRepository.GetAll();

    //public async Task<DbResult<RecipeCategory>> Get(int id) => await _recipeCategoryRepository.Get(id);

    //public async Task<DbResult<RecipeCategory>> Add(RecipeCategoryRequest createRecipeCategoryRequest)
    //{
    //    RecipeCategory recipeCategory = new()
    //    {
    //        Title = createRecipeCategoryRequest.Title,
    //        Description = createRecipeCategoryRequest.Description,
    //        ModifiedOn = DateTime.UtcNow
    //    };

    //    var dbResult = await _recipeCategoryRepository.Add(recipeCategory);
    //    return dbResult;
    //}

    //public async Task<Status> Update(int id, RecipeCategoryRequest updateRecipeCategoryRequest)
    //{
    //    RecipeCategory recipeCategory = new()
    //    {
    //        Id = id,
    //        Title = updateRecipeCategoryRequest.Title,
    //        Description = updateRecipeCategoryRequest.Description,
    //        ModifiedOn = DateTime.UtcNow
    //    };

    //    return await _recipeCategoryRepository.Update(recipeCategory);
    //}

    //public async Task<Status> Delete(int id) => await _recipeCategoryRepository.Delete(id);
//}
