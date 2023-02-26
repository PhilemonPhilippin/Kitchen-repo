using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kitchen.Dal.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipeCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipe_RecipeCategory_RecipeCategoryId",
                        column: x => x.RecipeCategoryId,
                        principalTable: "RecipeCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientRecipe",
                columns: table => new
                {
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipe", x => new { x.IngredientId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreparationStep",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Step = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreparationStep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreparationStep_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0001-0000-000000000000"), null, "Eggs" },
                    { new Guid("00000000-0000-0002-0000-000000000000"), null, "Bacon" },
                    { new Guid("00000000-0000-0003-0000-000000000000"), null, "Bread" },
                    { new Guid("00000000-0000-0004-0000-000000000000"), null, "Spaghettis" },
                    { new Guid("00000000-0000-0005-0000-000000000000"), null, "Guanciale" },
                    { new Guid("00000000-0000-0006-0000-000000000000"), null, "Pecorino romano" },
                    { new Guid("00000000-0000-0007-0000-000000000000"), null, "Tomatoes" },
                    { new Guid("00000000-0000-0008-0000-000000000000"), null, "Beef" },
                    { new Guid("00000000-0000-0009-0000-000000000000"), null, "Pasta" }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategory",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Breakfast is the first meal of the day usually eaten in the morning. The word in English refers to breaking the fasting period of the previous night.", "Breakfast" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Lunch is a meal eaten around the middle of the day. It is commonly the second meal of the day, after breakfast, and varies in size by culture and region.", "Lunch" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Dinner usually refers to what is in many Western cultures the largest and most formal meal of the day.Historically, the largest meal used to be eaten around midday, and called dinner.", "Dinner" }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "Description", "RecipeCategoryId", "Title" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0001-000000000000"), "Sometimes also called a 'fry-up', the full English breakfast consists of fried eggs, sausages, back bacon, tomatoes, mushrooms, fried bread and often a slice of white or black pudding (similar to bloodwurst). It is accompanied by tea or coffee and hot, buttered toast.", new Guid("00000000-0000-0000-0000-000000000001"), "English breakfast" },
                    { new Guid("00000000-0000-0000-0002-000000000000"), "Spaghetti alla carbonara is an Italian pasta dish made with eggs, pecorino romano, guanciale and black pepper.", new Guid("00000000-0000-0000-0000-000000000002"), "Spaghetti carbonara" },
                    { new Guid("00000000-0000-0000-0003-000000000000"), "A club sandwich, also called a clubhouse sandwich, is a sandwich consisting of bread (traditionally toasted), sliced cooked poultry, fried bacon, lettuce, tomato, and mayonnaise. It is often cut into quarters or halves and held together by cocktail sticks.", new Guid("00000000-0000-0000-0000-000000000002"), "Club sandwich" },
                    { new Guid("00000000-0000-0000-0004-000000000000"), "Spaghetti bolognese consists of spaghetti (long strings of pasta) with an Italian ragù (meat sauce) made with minced beef, bacon and tomatoes, served with Parmesan cheese. Spaghetti bolognese is one of the most popular pasta dishes eaten outside of Italy.", new Guid("00000000-0000-0000-0000-000000000003"), "Spaghetti bolognese" },
                    { new Guid("00000000-0000-0000-0005-000000000000"), "Lasagna Bolognese includes only fresh egg pasta, Bolognese ragù (slow-cooked meat sauce), creamy béchamel (white sauce) and plenty of grated Parmigiano cheese. The result is a melt in your mouth, creamy, decadent, and satisfying lasagna that is distinct to Italy.", new Guid("00000000-0000-0000-0000-000000000003"), "Lasagna bolognese" }
                });

            migrationBuilder.InsertData(
                table: "IngredientRecipe",
                columns: new[] { "IngredientId", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                    { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                    { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0006-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                    { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                    { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                    { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0008-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                    { new Guid("00000000-0000-0008-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                    { new Guid("00000000-0000-0009-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "PreparationStep",
                columns: new[] { "Id", "RecipeId", "Step", "Title" },
                values: new object[,]
                {
                    { new Guid("21930088-e904-4877-84b3-a954d368fae9"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the spaghetti", "Cook spaghetti" },
                    { new Guid("2b85f524-0d7e-447f-b9ac-b46023384992"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bolognese", "Prepare bolognese" },
                    { new Guid("712e518a-8125-4ec3-a5df-8c2a69c7f0de"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the bacon", "Cook bacon" },
                    { new Guid("9d7cb5e6-fe2e-440c-a4d5-2457f8ba8379"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bechamel", "Prepare bechamel" },
                    { new Guid("a2594f78-2b65-47b0-8921-4760158d4fe2"), new Guid("00000000-0000-0000-0003-000000000000"), "Cook the eggs", "Cook eggs" },
                    { new Guid("b4cc4130-cc96-47d2-b3a0-8359fb21f8bd"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the beef and the bacon", "Cook beef and bacon" },
                    { new Guid("be5e9282-d654-4a9c-afb7-ab309b37509a"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the guanciale", "Cook guanciale" },
                    { new Guid("c033f364-deaa-47dc-bad0-c8058f5f20ea"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the eggs", "Cook eggs" },
                    { new Guid("cf60f7d5-0883-441d-9134-01449a413a9e"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the spaghetti", "Cook spaghetti" },
                    { new Guid("d2641291-0f29-4343-a150-74de7fb1f64f"), new Guid("00000000-0000-0000-0001-000000000000"), "Fry the bread", "Fry bread" },
                    { new Guid("ea7c27f4-60dc-4027-947e-0866d22fee4f"), new Guid("00000000-0000-0000-0003-000000000000"), "Fry the bacon", "Fry bacon" },
                    { new Guid("fe911656-6bae-4b2a-9a6a-bc36436da66e"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the lasagna and place it in the oven.", "Prepare lasagna" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipe_RecipeId",
                table: "IngredientRecipe",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_PreparationStep_RecipeId",
                table: "PreparationStep",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_RecipeCategoryId",
                table: "Recipe",
                column: "RecipeCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecipe");

            migrationBuilder.DropTable(
                name: "PreparationStep");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "RecipeCategory");
        }
    }
}
