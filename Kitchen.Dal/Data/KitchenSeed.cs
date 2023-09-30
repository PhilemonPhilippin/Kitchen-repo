using Kitchen.Entities.Entities;

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
                Title = "Salad",
                Description = "A cold dish of various mixtures of raw or cooked vegetables, usually seasoned with oil, vinegar, or other dressing and sometimes accompanied by meat, fish, or other ingredients.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeCategory()
            {
                Id = 3,
                Title = "Lunch",
                Description = "Lunch is a meal eaten around the middle of the day. It is commonly the second meal of the day, after breakfast, and varies in size by culture and region.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeCategory()
            {
                Id = 4,
                Title = "Appetizer",
                Description = "An appetizer is part of a meal that's served before the main course. Usually, an appetizer is a small serving of food — just a few bites — meant to be eaten before an entree, and often shared by several people. An appetizer is meant to stimulate your appetite, making you extra hungry for your meal.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeCategory()
            {
                Id = 5,
                Title = "Soup",
                Description = "Soup is a liquid or thick, creamy food that's usually hot and savory. Most soup is made by cooking vegetables, beans, meat, or fish (or a combination of these) in water for a long time. Sometimes soup is thickened with cream or flour, or by pureeing some of the ingredients.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeCategory()
            {
                Id = 6,
                Title = "Dinner",
                Description = "Dinner — also called supper — is the third meal of the day. It's the main meal, the one families often try to have together at the end of the day. Dinner has always been the main meal, but it used to be served in the middle of the day and supper was last.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeCategory()
            {
                Id = 7,
                Title = "Dessert",
                Description = """Served as the last course of a meal, a dessert is often sweet, like cake or pie. The word dessert originates from an interesting French word, desservir, which actually means to "clear the table". After the dinner dishes are removed, the host brings out the dessert.""",
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
                Title = "Chicken salad",
                Description = "Seasoned chicken, tortilla chips, and roasted corn pair perfectly together in this crunchy and craveable Tex-Mex chopped chicken salad with cilantro lime dressing.",
                RecipeCategoryId = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Recipe()
            {
                Id = 3,
                Title = "Kai Jeow (Thai omelet)",
                Description = "Kai jeow is a classic Thai omelet with the perfect balance of salty-sweet-hot flavors. Serve it simply, with rice and raw vegetables, for a quick and satisfying meal.",
                RecipeCategoryId = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Recipe()
            {
                Id = 4,
                Title = "Chopped italian salad",
                Description = "Classic chopped Italian salad has a pleasing mix of pickled vegetables, cured meats, and cheeses. Serve as a colorful dinner on its own, or a starter with pasta or pizza.",
                RecipeCategoryId = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Recipe()
            {
                Id = 5,
                Title = "Grilled peppers",
                Description = "Jazz up your al fresco menu with these grilled peppers—they are a quick and easy summer side dish for burgers, grilled meat, or grilled seafood.",
                RecipeCategoryId = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Recipe()
            {
                Id = 6,
                Title = "Plantain chips",
                Description = "Slicing into thin rounds on a mandoline and baking directly on a baking sheet is the key to making these golden, delicately crisp, baked plantain chips.",
                RecipeCategoryId = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Recipe()
            {
                Id = 7,
                Title = "Tomato soup",
                Description = "This classic tomato soup is rich with a velvety texture. It's easy to make with canned tomatoes, and perfectly suited for all of your grilled cheese dipping needs.",
                RecipeCategoryId = 5,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Recipe()
            {
                Id = 8,
                Title = "Butternut squash soup",
                Description = "In search of a healthy butternut squash soup recipe that has a little something special? This is it! Even better, it's ready in an hour and freezes well for later.",
                RecipeCategoryId = 5,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Recipe()
            {
                Id = 9,
                Title = "Broccoli cheddar soup",
                Description = "This easy one-pot broccoli cheddar soup is so comforting during cold months. Simple ingredient list, and make it start to finish in under an hour.",
                RecipeCategoryId = 5,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Recipe()
            {
                Id = 10,
                Title = "Creamy cavatappi",
                Description = "Creamy cavatappi is a weeknight win. With a quick and easy cream and Parmesan sauce that feels indulgent, this simple recipe is easy to customize to suit your tastes.",
                RecipeCategoryId = 6,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Recipe()
            {
                Id = 11,
                Title = "Shrimp and asparagus pasta",
                Description = "This classic spring pasta dish combines the fresh, seasonal flavor of asparagus with sweet, tender shrimp.",
                RecipeCategoryId = 6,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Recipe()
            {
                Id = 12,
                Title = "Grilled chicken caprese sandwich",
                Description = "Fresh tomatoes, basil, mozzarella, and juicy chicken equals summer on a bun.",
                RecipeCategoryId = 6,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            }
            );
        #endregion

        #region SeedIngredients
        modelBuilder.Entity<Ingredient>().HasData(
            new Ingredient()
            {
                Id = 1,
                Name = "English breakfast sausage (Banger)",
                Description = "Although a variety of sausages can be used, bangers are usually a mild, fresh pork sausage made with a bread filler and seasoned with spices that may include pepper, thyme, sage, nutmeg and mace and stuffed into a natural casing.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 2,
                Name = "Back bacon",
                Description = "Back bacon is a cut of bacon that includes the pork loin from the back of the pig. It may also include a portion of the pork belly in the same cut.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 3,
                Name = "Egg",
                Description = "Chicken egg",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 4,
                Name = "Tomato",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 5,
                Name = "White button mushroom",
                Description = "White buttons feature the classic mushroom umami flavor that is slightly milder than other varieties of mushrooms.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 6,
                Name = "Bread",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 7,
                Name = "Navy beans",
                Description = """Also called "Haricot beans", or "Pea beans".""",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 8,
                Name = "Romaine lettuce",
                Description = "Romaine or cos lettuce is a variety of lettuce that grows in a tall head of sturdy dark green leaves with firm ribs down their centers.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 9,
                Name = "Red bell pepper",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 10,
                Name = "English cucumber",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 11,
                Name = "Cherry tomato",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 12,
                Name = "Scallion",
                Description = "Also known as green onions, and spring onions.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 13,
                Name = "Extra virgin olive oil",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 14,
                Name = "Fresh corn kernels",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 15,
                Name = "Chicken thighs",
                Description = "Boneless and skinless",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 16,
                Name = "Taco seasoning mix",
                Description = "This taco seasoning is a spice blend that’s smoky and herby. This taco seasoning begins with chili powder, cumin, oregano, coriander, garlic and onion.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 17,
                Name = "Corn tortilla chips",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 18,
                Name = "Cotija cheese",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 19,
                Name = "Fish sauce",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 20,
                Name = "Brown sugar",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 21,
                Name = "Black pepper",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 22,
                Name = "Jasmine rice",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 23,
                Name = "Lemon",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 24,
                Name = "Dijon mustard",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 25,
                Name = "Red wine vinegar",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 26,
                Name = "Sugar",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 27,
                Name = "Dried oregano",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 28,
                Name = "Red onion",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 29,
                Name = "Chickpeas",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 30,
                Name = "Genoa salami",
                Description = "Genoa salami is a variety of salami commonly believed to have originated in the area of Genoa, Italy. It is normally made from pork, but may also contain veal. It is seasoned with garlic, salt, black and white peppercorns, and red or white wine. Like many Italian sausages, it has a characteristic seasoned and aged flavor.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 31,
                Name = "Mozzarella",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 32,
                Name = "Hot chili peppers",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 33,
                Name = "Basil leaves",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 34,
                Name = "Balsamic vinegar",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 35,
                Name = "Plantains",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 36,
                Name = "Butter",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 37,
                Name = "Yellow onion",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 38,
                Name = "Flour",
                Description = "All-purpose flour",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 39,
                Name = "Can of crushed tomatoes",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 40,
                Name = "Can of tomato sauce",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 41,
                Name = "Chicken stock",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 42,
                Name = "Garlic",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 43,
                Name = "Celery",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 44,
                Name = "Carrot",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 45,
                Name = "Butternut",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 46,
                Name = "Green apple",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 47,
                Name = "Broccoli",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 48,
                Name = "Vegetable stock",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 49,
                Name = "Whole milk",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 50,
                Name = "Cheddar",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 51,
                Name = "Cavatappi pasta",
                Description = "Cavatappi are short, ridged corkscrew-shaped pasta. If you can't find them, substitute another short, sturdy pasta shape, such as rigatoni or even farfalle.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 52,
                Name = "Heavy cream",
                Description = "At least 36% fat.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 53,
                Name = "Parmesan",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 54,
                Name = "Peas",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 55,
                Name = "Spaghetti",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 56,
                Name = "Shrimps",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 57,
                Name = "Asparagus",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 58,
                Name = "White wine",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 59,
                Name = "Chicken breasts",
                Description = "Boneless and skinless",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 60,
                Name = "Italian seasoning",
                Description = "Contains dried oregano, basil, rosemary, and thyme. Many also include marjoram and/or sage. Store-bought seasoning will sometimes include garlic powder, red pepper flakes, and/or salt.",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 61,
                Name = "Ciabatta rolls",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new Ingredient()
            {
                Id = 62,
                Name = "Pesto",
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
                IngredientQuantity = "4",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 2,
                RecipeId = 1,
                IngredientQuantity = "4 slices",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 3,
                RecipeId = 1,
                IngredientQuantity = "2",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 4,
                RecipeId = 1,
                IngredientQuantity = "1",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 5,
                RecipeId = 1,
                IngredientQuantity = "4",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 6,
                RecipeId = 1,
                IngredientQuantity = "4 slices",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 7,
                RecipeId = 1,
                IngredientQuantity = "200 g",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 8,
                RecipeId = 2,
                IngredientQuantity = "6 cups, chopped and packed",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 9,
                RecipeId = 2,
                IngredientQuantity = "1",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 10,
                RecipeId = 2,
                IngredientQuantity = "1 cup, diced",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 11,
                RecipeId = 2,
                IngredientQuantity = "1 cup, halved",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 12,
                RecipeId = 2,
                IngredientQuantity = "3",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 13,
                RecipeId = 2,
                IngredientQuantity = "1 tablespoon plus 1 teaspoon",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 14,
                RecipeId = 2,
                IngredientQuantity = "1 1/2 cups",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 15,
                RecipeId = 2,
                IngredientQuantity = "450 g",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 16,
                RecipeId = 2,
                IngredientQuantity = "1 tablespoon",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 17,
                RecipeId = 2,
                IngredientQuantity = "12 chips",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 18,
                RecipeId = 2,
                IngredientQuantity = "1/4 cup, crumbled",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 3,
                RecipeId = 3,
                IngredientQuantity = "3",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 19,
                RecipeId = 3,
                IngredientQuantity = "2 teaspoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 20,
                RecipeId = 3,
                IngredientQuantity = "1/4 teaspoon",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 12,
                RecipeId = 3,
                IngredientQuantity = "1",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 21,
                RecipeId = 3,
                IngredientQuantity = "1/4 teaspoon",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 13,
                RecipeId = 3,
                IngredientQuantity = "3 tablespoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 22,
                RecipeId = 3,
                IngredientQuantity = "1 cup",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 10,
                RecipeId = 3,
                IngredientQuantity = "4 slices",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 8,
                RecipeId = 3,
                IngredientQuantity = "2 cups, chopped",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 23,
                RecipeId = 4,
                IngredientQuantity = "1",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 24,
                RecipeId = 4,
                IngredientQuantity = "1 tablespoon",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 25,
                RecipeId = 4,
                IngredientQuantity = "2 tablespoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 26,
                RecipeId = 4,
                IngredientQuantity = "2 teaspoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 27,
                RecipeId = 4,
                IngredientQuantity = "1 teaspoon",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 13,
                RecipeId = 4,
                IngredientQuantity = "1/2 cup",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 21,
                RecipeId = 4,
                IngredientQuantity = "1/4 teaspoon",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 8,
                RecipeId = 4,
                IngredientQuantity = "2 heads, chopped",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 28,
                RecipeId = 4,
                IngredientQuantity = "1/2",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 29,
                RecipeId = 4,
                IngredientQuantity = "425 g",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 11,
                RecipeId = 4,
                IngredientQuantity = "1 pint, halved",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 30,
                RecipeId = 4,
                IngredientQuantity = "115 g",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 31,
                RecipeId = 4,
                IngredientQuantity = "230 g",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 32,
                RecipeId = 4,
                IngredientQuantity = "1/2 cup, sliced",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 9,
                RecipeId = 4,
                IngredientQuantity = "1/4 cup, sliced and roasted",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 33,
                RecipeId = 4,
                IngredientQuantity = "10 fresh leaves, chopped",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 34,
                RecipeId = 5,
                IngredientQuantity = "As  much as you want",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 13,
                RecipeId = 5,
                IngredientQuantity = "1/4 cup",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 9,
                RecipeId = 5,
                IngredientQuantity = "4",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 35,
                RecipeId = 6,
                IngredientQuantity = "2 medium-sized green plantains",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 13,
                RecipeId = 6,
                IngredientQuantity = "2 tablespoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 36,
                RecipeId = 7,
                IngredientQuantity = "5 tablespoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 37,
                RecipeId = 7,
                IngredientQuantity = "1, diced",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 42,
                RecipeId = 7,
                IngredientQuantity = "4 cloves, minced",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 21,
                RecipeId = 7,
                IngredientQuantity = "1 1/2 teaspoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 38,
                RecipeId = 7,
                IngredientQuantity = "3 tablespoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 39,
                RecipeId = 7,
                IngredientQuantity = "1 can (800 g)",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 40,
                RecipeId = 7,
                IngredientQuantity = "1 can (225 g)",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 41,
                RecipeId = 7,
                IngredientQuantity = "4 cups (900 g)",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 26,
                RecipeId = 7,
                IngredientQuantity = "1 tablespoon",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 37,
                RecipeId = 8,
                IngredientQuantity = "1, chopped",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 43,
                RecipeId = 8,
                IngredientQuantity = "1 rib, chopped",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 44,
                RecipeId = 8,
                IngredientQuantity = "1, chopped",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 36,
                RecipeId = 8,
                IngredientQuantity = "2 tablespoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 45,
                RecipeId = 8,
                IngredientQuantity = "1 squash, seeded, peeled and chopped",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 46,
                RecipeId = 8,
                IngredientQuantity = "1 tart green apple, peeled, cored and chopped",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 41,
                RecipeId = 8,
                IngredientQuantity = "3 cups",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 47,
                RecipeId = 9,
                IngredientQuantity = "1 large head (500 g)",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 36,
                RecipeId = 9,
                IngredientQuantity = "1/4 cup",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 37,
                RecipeId = 9,
                IngredientQuantity = "1/2 medium, chopped",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 44,
                RecipeId = 9,
                IngredientQuantity = "1",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 38,
                RecipeId = 9,
                IngredientQuantity = "1/4 cup",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 48,
                RecipeId = 9,
                IngredientQuantity = "1 quart",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 49,
                RecipeId = 9,
                IngredientQuantity = "2 cups",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 50,
                RecipeId = 9,
                IngredientQuantity = "225 g, grated",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 21,
                RecipeId = 9,
                IngredientQuantity = "1/8 teaspoon",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 51,
                RecipeId = 10,
                IngredientQuantity = "225 g",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 36,
                RecipeId = 10,
                IngredientQuantity = "1 tablespoon",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 42,
                RecipeId = 10,
                IngredientQuantity = "2 cloves, minced",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 52,
                RecipeId = 10,
                IngredientQuantity = "3/4 cup",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 53,
                RecipeId = 10,
                IngredientQuantity = "1/2 cup, grated",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 23,
                RecipeId = 10,
                IngredientQuantity = "1 tablespoon of fresh juice",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 54,
                RecipeId = 10,
                IngredientQuantity = "1 cup",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 55,
                RecipeId = 11,
                IngredientQuantity = "350 g",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 13,
                RecipeId = 11,
                IngredientQuantity = "3 tablespoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 37,
                RecipeId = 11,
                IngredientQuantity = "1, diced",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 56,
                RecipeId = 11,
                IngredientQuantity = "450 g, uncooked",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 57,
                RecipeId = 11,
                IngredientQuantity = "1 bunch, tough ends removed, and cut",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 42,
                RecipeId = 11,
                IngredientQuantity = "4 cloves, minced",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 58,
                RecipeId = 11,
                IngredientQuantity = "1/2 cup",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 36,
                RecipeId = 11,
                IngredientQuantity = "3 tablespoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 59,
                RecipeId = 12,
                IngredientQuantity = "2 (700 g total)",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 13,
                RecipeId = 12,
                IngredientQuantity = "2 tablespoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 60,
                RecipeId = 12,
                IngredientQuantity = "2 teaspoons",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 61,
                RecipeId = 12,
                IngredientQuantity = "4 rolls",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 62,
                RecipeId = 12,
                IngredientQuantity = "1/4 cup",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 31,
                RecipeId = 12,
                IngredientQuantity = "1 ball (225 g)",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 4,
                RecipeId = 12,
                IngredientQuantity = "2 (225 g total)",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 33,
                RecipeId = 12,
                IngredientQuantity = "20 leaves",
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new RecipeIngredient()
            {
                IngredientId = 34,
                RecipeId = 12,
                IngredientQuantity = "2 tablespoons",
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
                Title = "Warm the beans",
                Step = "Open the can of beans and warm in a small pot over low heat, stirring occasionally.",
                RecipeId = 1,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 2,
                Title = "Cook the sausages and bacon",
                Step = "While the beans are warming, cook the sausages over medium to medium low, until browned and cooked through, turning as needed. Push the sausages to one side and add the bacon and fry, flipping as needed.",
                RecipeId = 1,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 3,
                Title = "Cook the mushrooms and tomatoes",
                Step = "In another pan, sear the mushrooms until brown and caramelized. Move to one side. Add the tomatoes, cut side down and sear.",
                RecipeId = 1,
                StepNumber = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 4,
                Title = "Fry the bread and cook the eggs",
                Step = "Move the meats from the pan and fry the bread in the drippings until golden and crisp. Cook the eggs in the pan that the mushrooms and tomatoes were in.",
                RecipeId = 1,
                StepNumber = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 5,
                Title = "Combine salad ingredients",
                Step = "Combine the lettuce, red pepper, cucumber, tomatoes, and scallions in a large serving bowl.",
                RecipeId = 2,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 6,
                Title = "Char the corn",
                Step = "Heat 1 teaspoon olive oil in a medium or large heavy-bottomed skillet over high heat. When the oil is hot, add the corn. Season corn with 1/4 teaspoon salt and cook, stirring occasionally, until blackened in spots and tender, about 3 minutes.",
                RecipeId = 2,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 7,
                Title = "Season the chicken",
                Step = "Sprinkle the taco seasoning and 1/2 teaspoon salt over the surface of the chicken, rubbing it in and coating so chicken is fully seasoned.",
                RecipeId = 2,
                StepNumber = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 8,
                Title = "Cook the chicken",
                Step = "In the same skillet used to cook the corn add 1 tablespoon of olive oil and set over medium-high heat. When the oil is hot, add the chicken and cook until deeply brown along the bottom and the flesh turns opaque about halfway up the side, 4 to 5 minutes. Flip the chicken and continue cooking, until brown on the second side and fully cooked through, another 3 to 5 minutes.",
                RecipeId = 2,
                StepNumber = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 9,
                Title = "Cut the chicken",
                Step = "Transfer the cooked chicken to a cutting board. Once it is cool enough to handle, cut into bite-sized pieces.",
                RecipeId = 2,
                StepNumber = 5,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 10,
                Title = "Make the salad dressing",
                Step = "Place the lime juice, vinegar, honey, cumin, salt, pepper, cilantro, and olive oil into a blender and blend until smooth. Add 1 tablespoon of water, if needed, to get the blender going. Finely chop the cilantro and place in a medium bowl. Combine all salad dressing ingredients and whisk until smooth.",
                RecipeId = 2,
                StepNumber = 6,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 11,
                Title = "Finish",
                Step = "Add the corn and chicken into the bowl with the salad ingredients. Crumble the tortilla chips over the top.",
                RecipeId = 2,
                StepNumber = 7,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 12,
                Title = "Whisk the eggs",
                Step = "In a medium bowl, combine the eggs, fish sauce, brown sugar, scallion and black pepper in a medium bowl. Whisk vigorously until well combined and no egg whites are visible.",
                RecipeId = 3,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 13,
                Title = "Heat the oil smoking hot",
                Step = "Heat vegetable oil in a small (about 8-inch diameter) nonstick skillet over medium-high heat until the oil is hot. You will know when the oil is ready when it smokes lightly.",
                RecipeId = 3,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 14,
                Title = "Pour the eggs into the hot skillet and cook",
                Step = "The egg will immediately start to fry and become puffy. Cook until lightly browned on the bottom. While you wait, use a small spatula or chopsticks to push the edges of the omelet inward and tilt the pan to encourage the raw eggs in the center to come in contact with the pan. Cook the first side for approximately 3 minutes. Once the omelet is firm, flip the omelet.",
                RecipeId = 3,
                StepNumber = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 15,
                Title = "Serve",
                Step = "Serve immediately with cooked rice, cucumber slices, romaine lettuce.",
                RecipeId = 3,
                StepNumber = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 16,
                Title = "Making the dressing",
                Step = "In a jar with a lid add the lemon juice, mustard, vinegar, sugar, oregano, olive oil, kosher, salt, and black pepper. Add the lid and shake for 10 seconds until all of the ingredients are thoroughly combined.",
                RecipeId = 4,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 17,
                Title = "Make the salad",
                Step = "Add the chopped Romaine to a large bowl and drizzle with a few tablespoons of dressing. Top the romaine with the red onion, chickpeas, cherry tomatoes, mozzarella, pepperoncini, roasted red peppers and basil. Stir together well before serving.",
                RecipeId = 4,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 18,
                Title = "Turn the gas grill on",
                Step = "To medium-high (about 205ºC). Dip a wadded paper towel into vegetable oil and brush the grill grates.",
                RecipeId = 5,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 19,
                Title = "Prep the peppers",
                Step = "While the grill heats, halve the peppers from top to bottom, cutting through the stems if they are attached. Pull off the stems and seeds and discard. With your hand, flatten each pepper.",
                RecipeId = 5,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 20,
                Title = "Toss peppers with olive oil and salt",
                Step = "Add the peppers into a large bowl. Toss with olive oil and salt.",
                RecipeId = 5,
                StepNumber = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 21,
                Title = "Grill the peppers",
                Step = "Using tongs, set the peppers on the oiled grill grates with the skin sides down. Close the cover and grill for 6 to 8 minutes, or until the skins are wrinkled and blackened. The blacker the skins, the easier they will be to peel. They also take on a more charred color. Flip them over and grill for another 3 to 4 minutes, or until softened.",
                RecipeId = 5,
                StepNumber = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 22,
                Title = "Peel the peppers",
                Step = "Let them steam for about 10 minutes. With your fingers, pull off and discard the skins. Resist running them under cold water because that will dilute the smoky sweet flavor of the peppers. Remove stubborn bits by scraping with the dull end of a paring knife.",
                RecipeId = 5,
                StepNumber = 5,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 23,
                Title = "Serve",
                Step = "Pile the peppers on a platter and drizzle with olive oil and vinegar. Season with salt, to taste. Serve.",
                RecipeId = 5,
                StepNumber = 6,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 24,
                Title = "Preheat the oven",
                Step = "Arrange the racks in the top and bottom thirds of the oven. Preheat the oven to 190°C.",
                RecipeId = 6,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 25,
                Title = "Prepare the plantains",
                Step = "Rinse the plantains and pat them dry. Trim the ends off each with a sharp knife. Use the knife to score the skin of the plantain lengthwise, taking care to not cut into the flesh. Shimmy your thumb between the skin where it is scored and the flesh of the plantain to separate the two and peel the plantains.",
                RecipeId = 6,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 26,
                Title = "Cut the plantains",
                Step = "Using a mandoline, carefully slice the plantains into 1/16-inch thick rounds. Alternatively, use a sharp knife to cut the plantain by hand into 1/16-inch thick rounds. If cutting by hand, take care to cut them as close to 1/16-inch thick and as evenly as possible. Thicker rounds will result in a more toothsome crunch rather than a delicate crisp.",
                RecipeId = 6,
                StepNumber = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 27,
                Title = "Toss the plantains",
                Step = "In a large bowl, combine the olive oil and 1 teaspoon kosher salt. Add the sliced plantain rounds to the oil and salt mixture and toss by hand to coat each round. Take care to separate and coat any plantain slices that may have stuck together.",
                RecipeId = 6,
                StepNumber = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 28,
                Title = "Spread the plantains on rimmed baking sheets",
                Step = "Arrange the coated plantain rounds in a single layer across two (unlined) rimmed baking sheets. It's okay if the edges of the rounds are touching as they will shrink in the oven, but do not let them overlap.",
                RecipeId = 6,
                StepNumber = 5,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 29,
                Title = "Bake the plantain chips",
                Step = "Arrange the chips in the top and bottom thirds of the oven. Bake at 190°C for 7 minutes. Rotate the pans from front to back and top to bottom. Bake for another 8 to 9 minutes until the plantain chips are golden to golden brown, dry and firm to the touch, and easily release from the pan.",
                RecipeId = 6,
                StepNumber = 6,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 30,
                Title = "Finish the plantain chips and serve",
                Step = "Sprinkle the plantain chips with more salt, if desired, while still warm from the oven. Serve warm or at room temperature.",
                RecipeId = 6,
                StepNumber = 7,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 31,
                Title = "Sauté the onions and garlic",
                Step = "In a Dutch oven set over medium heat, add the butter. Once it starts to foam, add the onion, garlic, salt, and pepper. Stir until both have softened and are fragrant, about 7 minutes.",
                RecipeId = 7,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 32,
                Title = "Make the roux",
                Step = "Add flour. Stir to make a paste. Continue stirring until the flour has taken on a light brown color. Stir and scrape with wooden spoon, 5 to 7 minutes. The onion paste should look golden with a little brown caramelization.",
                RecipeId = 7,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 33,
                Title = "Add tomatoes and stock",
                Step = "Add crushed tomatoes, tomato sauce, chicken stock, and sugar. Stir to combine. Cover the pot and bring to a boil over medium high heat, then reduce heat to medium and let simmer uncovered for about 20 minutes.",
                RecipeId = 7,
                StepNumber = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 34,
                Title = "Purée and serve",
                Step = "Purée the soup with an immersion blender. Alternatively, fill a countertop blender less than halfway with the hot soup. Remove the center lid insert. This allows the hot steam to escape. Cover the hole with a folded kitchen towel and place your hand over the top. Blend. Repeat as necessary until all of the soup has been puréed.",
                RecipeId = 7,
                StepNumber = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 35,
                Title = "Sauté the onion, carrot, and celery in butter",
                Step = "Heat a large thick-bottomed pot on medium-high heat. Melt the butter in the pot and let it foam up and recede. Add the onion, carrot, and celery and sauté for 5 minutes. Lower the heat if the vegetables begin to brown.",
                RecipeId = 8,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 36,
                Title = "Cook the soup",
                Step = "Add the butternut squash, apple, stock, and water. Bring to boil. Reduce to a simmer, cover, and simmer for 30 minutes or so, until the squash and carrots have softened.",
                RecipeId = 8,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 37,
                Title = "Purée the soup",
                Step = "Use an immersion blender to purée the soup, or work in batches and purée the soup in a stand blender.",
                RecipeId = 8,
                StepNumber = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 38,
                Title = "Add the seasonings",
                Step = "Add pinches of nutmeg, cinnamon, and cayenne. Add salt and pepper to taste.",
                RecipeId = 8,
                StepNumber = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 39,
                Title = "Blanch the broccoli",
                Step = "Bring a large pot of water to a boil and add a few big pinches of salt. Add broccoli stalks and blanch for 2 to 3 minutes until they are bright green and fork tender, but still slightly crispy. Drain broccoli. Scoop out and set aside about 1 cup of the florets for the topping.",
                RecipeId = 9,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 40,
                Title = "Cook the onions and carrots",
                Step = "Wipe out the pot, place over medium heat, and melt the butter. Once melted, add the onions and carrots, and cook until veggies soften, 4 to 5 minutes, stirring regularly.",
                RecipeId = 9,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 41,
                Title = "Cook the soup",
                Step = "Stir in the all-purpose flour. The flour will form a paste with the veggies. Cook for a minute or two to coat the vegetables, and then start to slowly pour in vegetable stock. Stir constantly as you pour in the stock to avoid lumps. Once all the stock is added, bring soup up to a low simmer. Add milk and the blanched broccoli (except what you're saving for the topping). Simmer for about 10 minutes over low heat.",
                RecipeId = 9,
                StepNumber = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 42,
                Title = "Puree the soup",
                Step = "Blend with an immersion blender, or let the soup cool until no longer steaming and blend in batches in a blender.",
                RecipeId = 9,
                StepNumber = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 43,
                Title = "Season to taste and serve",
                Step = "Add the grated cheese, salt, and pepper to the pureed soup and stir over low heat until the cheese has melted. Taste the soup and season with additional salt and pepper to your liking. Ladle the soup into bowls and garnish with some reserved broccoli and extra cheese on top. Serve with bread.",
                RecipeId = 9,
                StepNumber = 5,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 44,
                Title = "Cook the pasta",
                Step = "Put a large pot of water on to boil over high heat. Season generously with salt. Once the water is boiling, add the pasta and stir. Cook until just short of al dente, according to the package directions.",
                RecipeId = 10,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 45,
                Title = "Meanwhile, make the sauce, part 1",
                Step = "While the pasta cooks, add the butter to a large skillet over medium heat. Once melted, add the garlic and cook just until fragrant but not browned, about 30 seconds. Slowly add the cream while stirring and season with salt and pepper. Bring to a simmer, reducing the heat if needed to maintain a simmer.",
                RecipeId = 10,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 46,
                Title = "Meanwhile, make the sauce, part 2",
                Step = "Cook, while stirring, until slightly thickened, about 3 minutes. Add the Parmesan a small handful at a time, sprinkling it over top and stirring each time until melted. Add the lemon juice and stir. Turn the heat as low as it’ll go until the pasta is ready, stirring occasionally.",
                RecipeId = 10,
                StepNumber = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 47,
                Title = "Drain the pasta and thaw the peas",
                Step = "Reserve 1/2 cup of the pasta water. Add the frozen peas to a colander. Drain the pasta over the frozen peas (the hot pasta will help defrost the peas).",
                RecipeId = 10,
                StepNumber = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 48,
                Title = "Toss the pasta and serve",
                Step = "If your skillet is big enough, add the pasta and peas to the sauce. Otherwise, add the pasta and peas back to the pasta pot and pour the sauce over the top. Add 1/4 cup of the reserved pasta water and turn the heat to medium. Toss constantly until you have a creamy sauce that coats the noodles, 3 to 5 minutes. If the sauce seems too thick, add more pasta water a small splash at a time, tossing in between. Add salt and pepper.",
                RecipeId = 10,
                StepNumber = 5,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 49,
                Title = "Cook the pasta",
                Step = "When the salted water is at a rolling boil, add the pasta. Cook the pasta according to the package instructions, until it is just 1 minute shy of al dente, very nearly cooked but slightly too firm in the center, about 10 minutes. Drain the pasta in a colander, reserving 1 cup of pasta water to add to the shrimp and asparagus.",
                RecipeId = 11,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 50,
                Title = "Cook the shrimp and asparagus, part 1",
                Step = "While the pasta is cooking, start cooking the other ingredients. In a Dutch oven over medium-high heat, add the olive oil. When the oil is hot, add the onions and cook, stirring frequently, until it begins to soften, about 3 minutes. Add the shrimp, asparagus, and garlic. Increase the heat on the stove to high, and cook, stirring occasionally, until the side of the shrimp have just turned pink, about 4 minutes. Season with the salt and pepper.",
                RecipeId = 11,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 51,
                Title = "Cook the shrimp and asparagus, part 2",
                Step = "Reduce the heat to medium and add the white wine and 2 tablespoons of the butter to the pan. Bring the sauce to a simmer and cook for about 2 minutes. Add the lemon juice to the pan. Season with additional salt and pepper, to taste. Continue to cook until the asparagus is just tender and the widest part of the shrimp has turned from translucent to opaque, about 2 minutes.",
                RecipeId = 11,
                StepNumber = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 52,
                Title = "Finish the dish",
                Step = "Add the drained pasta to the pan with 1/2 cup of the reserved pasta water and the remaining 1 tablespoon of butter. Cook, stirring occasionally and using tongs to coat the pasta with all of the ingredients in the pan. Stir, until the pasta is tender but still firm in the center, 1 to 2 minutes. You should end up with a slick of sauce coating all of the ingredients. Taste and adjust with more salt and pepper to taste.",
                RecipeId = 11,
                StepNumber = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 53,
                Title = "Serve",
                Step = "Portion the pasta onto four plates. Top each one with Parmesan and parsley. Serve with a lemon wedge on the side.",
                RecipeId = 11,
                StepNumber = 5,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 54,
                Title = "Prep the chicken",
                Step = "Cut the chicken breasts in half lengthwise, creating 4 thin filets. Sandwich a piece between two pieces of parchment paper or plastic wrap. Use a meat mallet or rolling pin to beat it to an even 1/4-inch thickness. Repeat with the remaining 3 filets.",
                RecipeId = 12,
                StepNumber = 1,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 55,
                Title = "Marinate the chicken",
                Step = "In a shallow dish, whisk together the olive oil, Italian seasoning, salt, and pepper. Place the chicken in the dish and turn to coat. Cover with plastic wrap and transfer to the fridge to marinate for at least 30 minutes or up to 8 hours.",
                RecipeId = 12,
                StepNumber = 2,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 56,
                Title = "Grill the chicken and toast the buns, part 1",
                Step = "Preheat your grill to medium-high heat and lightly oil the grates. Remove the chicken from the marinade and place it on the grill. Cook on one side for 3 minutes, then flip and cook on the other side for 3 minutes. Try not to move the chicken while it cooks except for flipping once.",
                RecipeId = 12,
                StepNumber = 3,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 57,
                Title = "Grill the chicken and toast the buns, part 2",
                Step = "The chicken should be cooked through, golden with grill marks, and the internal temperature should be 75°C. Transfer the chicken to a plate and let it rest for 5 minutes. While the chicken is grilling, you can also toast the rolls by placing them cut-side down on the grill for 1 to 2 minutes.",
                RecipeId = 12,
                StepNumber = 4,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            },
            new PreparationStep()
            {
                Id = 58,
                Title = "Assemble the sandwich",
                Step = "Spread a generous layer of pesto on the bottom half of each ciabatta roll (about a tablespoon per roll). Add a layer of mozzarella slices, then a layer of tomato slices. Place a piece of grilled chicken on each sandwich. Finish off the sandwich with 5 to 6 fresh basil leaves and a drizzle of balsamic glaze, if desired. Place the other half of the roll on top.",
                RecipeId = 12,
                StepNumber = 5,
                CreatedOn = DateTime.UtcNow,
                ModifiedOn = DateTime.UtcNow,
                UniqueId = Guid.NewGuid()
            }
            );
        #endregion
    }
}
