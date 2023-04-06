namespace Kitchen.Dal.Interfaces;

public interface IPreparationStepRepo
{
    Task<IEnumerable<PreparationStep>> GetPreparationStepsAsync(Guid recipeId);
}
