using System.ComponentModel.DataAnnotations;

namespace Kitchen.Contracts.Requests;

public class CreatePreparationStepRequest
{
    [Required]
    [MaxLength(50)]
    public string Title { get; set; }
    [Required]
    public int StepNumber { get; set; }
    [Required]
    [MaxLength(500)]
    public string Step { get; set; }
}
