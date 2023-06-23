using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.Contracts.Requests;

public record RecipeRequest([Required][MaxLength(50)] string Title,
                            [MaxLength(500)] string? Description,
                            [Required] Guid RecipeCategoryId);
