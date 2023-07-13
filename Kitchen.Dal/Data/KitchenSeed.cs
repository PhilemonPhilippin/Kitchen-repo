namespace Kitchen.Dal.Data;

public static class KitchenSeed
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        #region SeedRecipeCategories
        modelBuilder.Entity<RecipeCategory>().HasData(
            new RecipeCategory()
            {
                Id = 1,
                Title = "Breakfast",
                Description = "Breakfast is the first meal of the day usually eaten in the morning. The word in English refers to breaking the fasting period of the previous night.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeCategory()
            {
                Id = 2,
                Title = "Lunch",
                Description = "Lunch is a meal eaten around the middle of the day. It is commonly the second meal of the day, after breakfast, and varies in size by culture and region.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeCategory()
            {
                Id = 3,
                Title = "Dinner",
                Description = "Dinner usually refers to what is in many Western cultures the largest and most formal meal of the day.Historically, the largest meal used to be eaten around midday, and called dinner.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            }
            );
        #endregion

        #region SeedRecipes
        modelBuilder.Entity<Recipe>().HasData(
                new Recipe()
                {
                    Id = 1,
                    Title = "English breakfast",
                    Description = "Sometimes also called a 'fry-up', the full English breakfast consists of fried eggs, sausages, back bacon, tomatoes, mushrooms, fried bread and often a slice of white or black pudding (similar to bloodwurst). It is accompanied by tea or coffee and hot, buttered toast.",
                    RecipeCategoryId = 1,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Recipe()
                {
                    Id = 2,
                    Title = "Spaghetti carbonara",
                    Description = "Spaghetti alla carbonara is an Italian pasta dish made with eggs, pecorino romano, guanciale and black pepper.",
                    RecipeCategoryId = 2,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Recipe()
                {
                    Id = 3,
                    Title = "Club sandwich",
                    Description = "A club sandwich, also called a clubhouse sandwich, is a sandwich consisting of bread (traditionally toasted), sliced cooked poultry, fried bacon, lettuce, tomato, and mayonnaise. It is often cut into quarters or halves and held together by cocktail sticks.",
                    RecipeCategoryId = 2,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Recipe()
                {
                    Id = 4,
                    Title = "Spaghetti bolognese",
                    Description = "Spaghetti bolognese consists of spaghetti (long strings of pasta) with an Italian ragù (meat sauce) made with minced beef, bacon and tomatoes, served with Parmesan cheese. Spaghetti bolognese is one of the most popular pasta dishes eaten outside of Italy.",
                    RecipeCategoryId = 3,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Recipe()
                {
                    Id = 5,
                    Title = "Lasagna bolognese",
                    Description = "Lasagna Bolognese includes only fresh egg pasta, Bolognese ragù (slow-cooked meat sauce), creamy béchamel (white sauce) and plenty of grated Parmigiano cheese. The result is a melt in your mouth, creamy, decadent, and satisfying lasagna that is distinct to Italy.",
                    RecipeCategoryId = 3,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                });
        #endregion

        #region SeedIngredients
        modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient()
                {
                    Id = 1,
                    Name = "Eggs",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Ingredient()
                {
                    Id = 2,
                    Name = "Bacon",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Ingredient()
                {
                    Id = 3,
                    Name = "Bread",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Ingredient()
                {
                    Id = 4,
                    Name = "Spaghettis",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Ingredient()
                {
                    Id = 5,
                    Name = "Guanciale",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Ingredient()
                {
                    Id = 6,
                    Name = "Pecorino romano",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Ingredient()
                {
                    Id = 7,
                    Name = "Tomatoes",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Ingredient()
                {
                    Id = 8,
                    Name = "Beef",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new Ingredient()
                {
                    Id = 9,
                    Name = "Pasta",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                }
                );
        #endregion

        #region SeedRecipeIngredients
        modelBuilder.Entity<RecipeIngredient>().HasData(
                new RecipeIngredient()
                {
                    IngredientId = 1,
                    RecipeId = 1,
                    IngredientQuantity = "2 whole",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 2,
                    RecipeId = 1,
                    IngredientQuantity = "100 g.",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 3,
                    RecipeId = 1,
                    IngredientQuantity = "2 slices",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 7,
                    RecipeId = 1,
                    IngredientQuantity = "1 whole",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 1,
                    RecipeId = 2,
                    IngredientQuantity = "1 whole",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 4,
                    RecipeId = 2,
                    IngredientQuantity = "500 g.",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 5,
                    RecipeId = 2,
                    IngredientQuantity = "200 g.",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 6,
                    RecipeId = 2,
                    IngredientQuantity = "50 g.",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 2,
                    RecipeId = 3,
                    IngredientQuantity = "75 g.",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 3,
                    RecipeId = 3,
                    IngredientQuantity = "4 slices",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 7,
                    RecipeId = 3,
                    IngredientQuantity = "1 whole",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 4,
                    RecipeId = 4,
                    IngredientQuantity = "500 g.",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 2,
                    RecipeId = 4,
                    IngredientQuantity = "100 g.",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 7,
                    RecipeId = 4,
                    IngredientQuantity = "3 tins of crushed tomatoes",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new RecipeIngredient()
                {
                    IngredientId = 8,
                    RecipeId = 4,
                    IngredientQuantity = "250 g.",
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                    new RecipeIngredient()
                    {
                        IngredientId = 7,
                        RecipeId = 5,
                        IngredientQuantity = "2 tins of crushed tomatoes",
                        CreatedOn = DateTime.UtcNow,
                        ModifiedOn = DateTime.UtcNow,
                        UniqueId = Guid.NewGuid()
                    },
                    new RecipeIngredient()
                    {
                        IngredientId = 8,
                        RecipeId = 5,
                        IngredientQuantity = "300 g.",
                        CreatedOn = DateTime.UtcNow,
                        ModifiedOn = DateTime.UtcNow,
                        UniqueId = Guid.NewGuid()
                    },
                    new RecipeIngredient()
                    {
                        IngredientId = 9,
                        RecipeId = 5,
                        IngredientQuantity = "250 g.",
                        CreatedOn = DateTime.UtcNow,
                        ModifiedOn = DateTime.UtcNow,
                        UniqueId = Guid.NewGuid()
                    }
                    );
        #endregion

        #region SeedPreparationSteps
        modelBuilder.Entity<PreparationStep>().HasData(
                new PreparationStep()
                {
                    Id = 1,
                    Title = "Cook eggs",
                    Step = "Cook the eggs",
                    RecipeId = 1,
                    StepNumber = 1,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new PreparationStep()
                {
                    Id = 2,
                    Title = "Cook bacon",
                    Step = "Cook the bacon",
                    RecipeId = 1,
                    StepNumber = 2,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new PreparationStep()
                {
                    Id = 3,
                    Title = "Fry bread",
                    Step = "Fry the bread",
                    RecipeId = 1,
                    StepNumber = 3,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new PreparationStep()
                {
                    Id = 4,
                    Title = "Cook guanciale",
                    Step = "Cook the guanciale",
                    RecipeId = 2,
                    StepNumber = 1,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new PreparationStep()
                {
                    Id = 5,
                    Title = "Cook spaghetti",
                    Step = "Cook the spaghetti",
                    RecipeId = 2,
                    StepNumber = 2,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new PreparationStep()
                {
                    Id = 6,
                    Title = "Fry bacon",
                    Step = "Fry the bacon",
                    RecipeId = 3,
                    StepNumber = 1,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new PreparationStep()
                {
                    Id = 7,
                    Title = "Cook eggs",
                    Step = "Cook the eggs",
                    RecipeId = 3,
                    StepNumber = 2,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new PreparationStep()
                {
                    Id = 8,
                    Title = "Cook beef and bacon",
                    Step = "Cook the beef and the bacon",
                    RecipeId = 4,
                    StepNumber = 1,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new PreparationStep()
                {
                    Id = 9,
                    Title = "Cook spaghetti",
                    Step = "Cook the spaghetti",
                    RecipeId = 4,
                    StepNumber = 2,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new PreparationStep()
                {
                    Id = 10,
                    Title = "Prepare bolognese",
                    Step = "Prepare the bolognese",
                    RecipeId = 5,
                    StepNumber = 1,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new PreparationStep()
                {
                    Id = 11,
                    Title = "Prepare bechamel",
                    Step = "Prepare the bechamel",
                    RecipeId = 5,
                    StepNumber = 2,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                },
                new PreparationStep()
                {
                    Id = 12,
                    Title = "Prepare lasagna",
                    Step = "Prepare the lasagna and place it in the oven.",
                    RecipeId = 5,
                    StepNumber = 3,
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    UniqueId = Guid.NewGuid()
                });
        #endregion
    }
}
