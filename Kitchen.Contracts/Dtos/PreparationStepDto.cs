namespace Kitchen.Contracts.Dtos;

public class PreparationStepDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int StepNumber { get; set; }
    public string Step { get; set; } = string.Empty;
}
