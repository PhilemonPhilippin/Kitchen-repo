using Kitchen.Entities;

namespace Kitchen.Dal.Data;

public static class KitchenSeed
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        #region SeedRecipeCategories
        modelBuilder.Entity<RecipeCategory>().HasData(
            new RecipeCategory()
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                Title = "Breakfast",
                Description = "Breakfast is the first meal of the day usually eaten in the morning. The word in English refers to breaking the fasting period of the previous night."
            },
            new RecipeCategory()
            {
                Id = new Guid("00000000-0000-0000-0000-000000000002"),
                Title = "Lunch",
                Description = "Lunch is a meal eaten around the middle of the day. It is commonly the second meal of the day, after breakfast, and varies in size by culture and region."
            },
            new RecipeCategory()
            {
                Id = new Guid("00000000-0000-0000-0000-000000000003"),
                Title = "Dinner",
                Description = "Dinner usually refers to what is in many Western cultures the largest and most formal meal of the day.Historically, the largest meal used to be eaten around midday, and called dinner."
            }
            );
        #endregion

        #region SeedRecipes
        modelBuilder.Entity<Recipe>().HasData(
                new Recipe()
                {
                    Id = new Guid("00000000-0000-0000-0001-000000000000"),
                    Title = "English breakfast",
                    Description = "Sometimes also called a 'fry-up', the full English breakfast consists of fried eggs, sausages, back bacon, tomatoes, mushrooms, fried bread and often a slice of white or black pudding (similar to bloodwurst). It is accompanied by tea or coffee and hot, buttered toast.",
                    RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000001")
                },
                new Recipe()
                {
                    Id = new Guid("00000000-0000-0000-0002-000000000000"),
                    Title = "Spaghetti carbonara",
                    Description = "Spaghetti alla carbonara is an Italian pasta dish made with eggs, pecorino romano, guanciale and black pepper.",
                    RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000002")
                },
                new Recipe()
                {
                    Id = new Guid("00000000-0000-0000-0003-000000000000"),
                    Title = "Club sandwich",
                    Description = "A club sandwich, also called a clubhouse sandwich, is a sandwich consisting of bread (traditionally toasted), sliced cooked poultry, fried bacon, lettuce, tomato, and mayonnaise. It is often cut into quarters or halves and held together by cocktail sticks.",
                    RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000002")
                },
                new Recipe()
                {
                    Id = new Guid("00000000-0000-0000-0004-000000000000"),
                    Title = "Spaghetti bolognese",
                    Description = "Spaghetti bolognese consists of spaghetti (long strings of pasta) with an Italian ragù (meat sauce) made with minced beef, bacon and tomatoes, served with Parmesan cheese. Spaghetti bolognese is one of the most popular pasta dishes eaten outside of Italy.",
                    RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000003")
                },
                new Recipe()
                {
                    Id = new Guid("00000000-0000-0000-0005-000000000000"),
                    Title = "Lasagna bolognese",
                    Description = "Lasagna Bolognese includes only fresh egg pasta, Bolognese ragù (slow-cooked meat sauce), creamy béchamel (white sauce) and plenty of grated Parmigiano cheese. The result is a melt in your mouth, creamy, decadent, and satisfying lasagna that is distinct to Italy.",
                    RecipeCategoryId = new Guid("00000000-0000-0000-0000-000000000003")
                });
        #endregion

        #region SeedIngredients
        modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient()
                {
                    Id = new Guid("00000000-0000-0001-0000-000000000000"),
                    Name = "Eggs"
                },
                new Ingredient()
                {
                    Id = new Guid("00000000-0000-0002-0000-000000000000"),
                    Name = "Bacon"
                },
                new Ingredient()
                {
                    Id = new Guid("00000000-0000-0003-0000-000000000000"),
                    Name = "Bread"
                },
                new Ingredient()
                {
                    Id = new Guid("00000000-0000-0004-0000-000000000000"),
                    Name = "Spaghettis"
                },
                new Ingredient()
                {
                    Id = new Guid("00000000-0000-0005-0000-000000000000"),
                    Name = "Guanciale"
                },
                new Ingredient()
                {
                    Id = new Guid("00000000-0000-0006-0000-000000000000"),
                    Name = "Pecorino romano"
                },
                new Ingredient()
                {
                    Id = new Guid("00000000-0000-0007-0000-000000000000"),
                    Name = "Tomatoes"
                },
                new Ingredient()
                {
                    Id = new Guid("00000000-0000-0008-0000-000000000000"),
                    Name = "Beef"
                },
                new Ingredient()
                {
                    Id = new Guid("00000000-0000-0009-0000-000000000000"),
                    Name = "Pasta"
                }
                );
        #endregion

        #region SeedIngredientRecipes
        modelBuilder.Entity<IngredientRecipe>().HasData(
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0001-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0001-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0002-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0001-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0003-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0001-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0001-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0001-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0002-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0004-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0002-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0005-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0002-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0006-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0002-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0002-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0003-000000000000")
                 },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0003-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0003-000000000000")
                 },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0003-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0004-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0004-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0002-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0004-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0004-000000000000")
                },
                new IngredientRecipe()
                {
                    IngredientId = new Guid("00000000-0000-0008-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0004-000000000000")
                },
                 new IngredientRecipe()
                 {
                    IngredientId = new Guid("00000000-0000-0007-0000-000000000000"),
                    RecipeId = new Guid("00000000-0000-0000-0005-000000000000")
                 },
                 new IngredientRecipe()
                 {
                     IngredientId = new Guid("00000000-0000-0008-0000-000000000000"),
                     RecipeId = new Guid("00000000-0000-0000-0005-000000000000")
                 },
                 new IngredientRecipe()
                 {
                     IngredientId = new Guid("00000000-0000-0009-0000-000000000000"),
                     RecipeId = new Guid("00000000-0000-0000-0005-000000000000")
                 }
                 );
        #endregion

        #region SeedPreparationSteps
        modelBuilder.Entity<PreparationStep>().HasData(
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Cook eggs",
                    Step = "Cook the eggs",
                    RecipeId = new Guid("00000000-0000-0000-0001-000000000000")
                },
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Cook bacon",
                    Step = "Cook the bacon",
                    RecipeId = new Guid("00000000-0000-0000-0001-000000000000")
                },
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Fry bread",
                    Step = "Fry the bread",
                    RecipeId = new Guid("00000000-0000-0000-0001-000000000000")
                },
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Cook guanciale",
                    Step = "Cook the guanciale",
                    RecipeId = new Guid("00000000-0000-0000-0002-000000000000")
                },
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Cook spaghetti",
                    Step = "Cook the spaghetti",
                    RecipeId = new Guid("00000000-0000-0000-0002-000000000000")
                },
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Fry bacon",
                    Step = "Fry the bacon",
                    RecipeId = new Guid("00000000-0000-0000-0003-000000000000")
                },
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Cook eggs",
                    Step = "Cook the eggs",
                    RecipeId = new Guid("00000000-0000-0000-0003-000000000000")
                },
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Cook beef and bacon",
                    Step = "Cook the beef and the bacon",
                    RecipeId = new Guid("00000000-0000-0000-0004-000000000000")
                },
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Cook spaghetti",
                    Step = "Cook the spaghetti",
                    RecipeId = new Guid("00000000-0000-0000-0004-000000000000")
                },
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Prepare bolognese",
                    Step = "Prepare the bolognese",
                    RecipeId = new Guid("00000000-0000-0000-0005-000000000000")
                },
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Prepare bechamel",
                    Step = "Prepare the bechamel",
                    RecipeId = new Guid("00000000-0000-0000-0005-000000000000")
                },
                new PreparationStep()
                {
                    Id = Guid.NewGuid(),
                    Title = "Prepare lasagna",
                    Step = "Prepare the lasagna and place it in the oven.",
                    RecipeId = new Guid("00000000-0000-0000-0005-000000000000")
                });
        #endregion
    }
}
