using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Kitchen.Contracts.Dtos;

[DataContract]
public record IngredientDto
{
    [DataMember]
    public int Id { get; init; }
    [DataMember]
    public required string Name { get; init; }
    [DataMember]
    public string? Description { get; init; }
}

[DataContract]
public record IngredientNoDescDto
{
    [DataMember]
    public int Id { get; init; }
    [DataMember]
    public required string Name { get; init; }
}

[DataContract]
public record PreparationStepDto
{
    [DataMember]
    public int Id { get; init; }
    [DataMember]
    public required string Title { get; init; }
    [DataMember]
    public int StepNumber { get; init; }
    [DataMember]
    public required string Step { get; init; }
    [DataMember]
    public int RecipeId { get; init; }
}

[DataContract]
public record RecipeCategoryDto
{
    [DataMember]
    public int Id { get; init; }
    [DataMember]
    public required string Title { get; init; }
    [DataMember]
    public string? Description { get; init; }
}

[DataContract]
public record RecipeDto
{
    [DataMember]
    public int Id { get; init; }
    [DataMember]
    public required string Title { get; init; }
    [DataMember]
    public string? Description { get; init; }
    [DataMember]
    public required RecipeCategoryDto RecipeCategory { get; init; }
}

[DataContract]
public record IngredientForSpecificRecipeDto
{
    [DataMember]
    public int Id { get; init; }
    [DataMember]
    public required string Name { get; init; }
    [DataMember]
    public string? Description { get; init; }
    [DataMember]
    public required string IngredientQuantity { get; init; }
}