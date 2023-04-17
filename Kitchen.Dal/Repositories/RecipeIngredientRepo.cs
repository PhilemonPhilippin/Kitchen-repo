
namespace Kitchen.Dal.Repositories;

public class RecipeIngredientRepo : IRecipeIngredientRepo
{
    private readonly KitchenContext _context;

    public RecipeIngredientRepo(KitchenContext context)
    {
        _context = context;
    }


}
