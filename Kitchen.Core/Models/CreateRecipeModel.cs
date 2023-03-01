using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.Core.Models;

public class CreateRecipeModel
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Guid RecipeCategoryId { get; set; }
}
