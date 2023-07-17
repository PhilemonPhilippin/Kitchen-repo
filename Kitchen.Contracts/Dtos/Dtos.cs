using System.Runtime.Serialization;

namespace Kitchen.Contracts.Dtos;

[DataContract]
public record IngredientDto
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public string? Description { get; set; }
}

[DataContract]
public record IngredientNoDescDto
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }
}

[DataContract]
public record PreparationStepDto
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Title { get; set; }
    [DataMember]
    public int StepNumber { get; set; }
    [DataMember]
    public string Step { get; set; }
    [DataMember]
    public int RecipeId { get; set; }
}

[DataContract]
public record RecipeCategoryDto
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Title { get; set; }
    [DataMember]
    public string? Description { get; set; }
}

[DataContract]
public record RecipeDto
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Title { get; set; }
    [DataMember]
    public string? Description { get; set; }
    [DataMember]
    public RecipeCategoryDto RecipeCategory { get; set; }
}

[DataContract]
public record IngredientForSpecificRecipeDto
{
    [DataMember]
    public int Id { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public string? Description { get; set; }
    [DataMember]
    public string IngredientQuantity { get; set; }
}