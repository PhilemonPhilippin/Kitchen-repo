namespace KitchenIntegrationTests.Models.Requests;
public class RecipeRequestInput 
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public string RecipeCategoryId { get; set; }

    public RecipeRequestInput CloneWith(Action<RecipeRequestInput> changes)
    {
        var clone = (RecipeRequestInput)this.MemberwiseClone();
        changes(clone);
        return clone;
    }
}