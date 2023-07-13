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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipeCategoryId = table.Column<int>(type: "int", nullable: false)
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
                name: "PreparationStep",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StepNumber = table.Column<int>(type: "int", nullable: false),
                    Step = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "RecipeIngredient",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    IngredientQuantity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredient", x => new { x.IngredientId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredient_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredient_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "CreatedOn", "Description", "ModifiedOn", "Name", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2089), null, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2090), "Eggs", new Guid("13f30ead-9983-4ae7-b46f-a2a96f6b2556") },
                    { 2, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2092), null, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2093), "Bacon", new Guid("1b9b9c61-dbda-4fd1-9138-04b9cc749097") },
                    { 3, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2094), null, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2095), "Bread", new Guid("9a8e3b60-c798-435e-ba14-4397534e9512") },
                    { 4, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2096), null, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2097), "Spaghettis", new Guid("c17b4c5a-3c45-45dc-beb2-f19cd9d32fd0") },
                    { 5, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2100), null, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2100), "Guanciale", new Guid("6aefa57f-5290-45d9-b32f-53e4487529a0") },
                    { 6, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2102), null, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2102), "Pecorino romano", new Guid("bb7c38ef-d6ea-4977-b8e2-414b3f5e67f3") },
                    { 7, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2104), null, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2104), "Tomatoes", new Guid("bb079408-06b9-48e4-a8fe-0676b61c13ee") },
                    { 8, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2105), null, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2106), "Beef", new Guid("3e90c13b-98ef-4763-ac4e-9149ebfc0f7f") },
                    { 9, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2108), null, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2109), "Pasta", new Guid("712c37b7-73fe-466d-9d1f-12d47ba9f660") }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategory",
                columns: new[] { "Id", "CreatedOn", "Description", "ModifiedOn", "Title", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(1898), "Breakfast is the first meal of the day usually eaten in the morning. The word in English refers to breaking the fasting period of the previous night.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(1898), "Breakfast", new Guid("1e14cf45-28cc-495a-ae52-f1e381d00213") },
                    { 2, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(1901), "Lunch is a meal eaten around the middle of the day. It is commonly the second meal of the day, after breakfast, and varies in size by culture and region.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(1901), "Lunch", new Guid("33d97ac3-5d1e-4d7b-88c0-c5f0711d3a28") },
                    { 3, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(1903), "Dinner usually refers to what is in many Western cultures the largest and most formal meal of the day.Historically, the largest meal used to be eaten around midday, and called dinner.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(1904), "Dinner", new Guid("bd2e03b5-8252-4d52-91b2-5a93da6c6009") }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CreatedOn", "Description", "ModifiedOn", "RecipeCategoryId", "Title", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(1975), "Sometimes also called a 'fry-up', the full English breakfast consists of fried eggs, sausages, back bacon, tomatoes, mushrooms, fried bread and often a slice of white or black pudding (similar to bloodwurst). It is accompanied by tea or coffee and hot, buttered toast.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(1976), 1, "English breakfast", new Guid("d9cac577-8b15-4628-b53d-f118ca8c39d4") },
                    { 2, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(1986), "Spaghetti alla carbonara is an Italian pasta dish made with eggs, pecorino romano, guanciale and black pepper.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(1986), 2, "Spaghetti carbonara", new Guid("ab65e457-9701-416d-a9b5-de9f88d53518") },
                    { 3, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2007), "A club sandwich, also called a clubhouse sandwich, is a sandwich consisting of bread (traditionally toasted), sliced cooked poultry, fried bacon, lettuce, tomato, and mayonnaise. It is often cut into quarters or halves and held together by cocktail sticks.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2007), 2, "Club sandwich", new Guid("e18e8bd4-5a9f-4f8f-9d25-0f20989f3550") },
                    { 4, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2010), "Spaghetti bolognese consists of spaghetti (long strings of pasta) with an Italian ragù (meat sauce) made with minced beef, bacon and tomatoes, served with Parmesan cheese. Spaghetti bolognese is one of the most popular pasta dishes eaten outside of Italy.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2010), 3, "Spaghetti bolognese", new Guid("2ab57e69-8dd1-4942-88e2-e39eace98291") },
                    { 5, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2012), "Lasagna Bolognese includes only fresh egg pasta, Bolognese ragù (slow-cooked meat sauce), creamy béchamel (white sauce) and plenty of grated Parmigiano cheese. The result is a melt in your mouth, creamy, decadent, and satisfying lasagna that is distinct to Italy.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2012), 3, "Lasagna bolognese", new Guid("354ec2fd-ad0a-4a32-b22a-4eadb615cb08") }
                });

            migrationBuilder.InsertData(
                table: "PreparationStep",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "RecipeId", "Step", "StepNumber", "Title", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2206), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2206), 1, "Cook the eggs", 1, "Cook eggs", new Guid("30e7c5fc-8b7f-4500-8a27-839dd477d187") },
                    { 2, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2210), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2211), 1, "Cook the bacon", 2, "Cook bacon", new Guid("0433efd9-b871-4ea4-bebb-8b81f1720de6") },
                    { 3, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2213), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2213), 1, "Fry the bread", 3, "Fry bread", new Guid("ecb1a991-5d5a-4ceb-8a60-66b57b92069e") },
                    { 4, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2215), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2215), 2, "Cook the guanciale", 1, "Cook guanciale", new Guid("ea6ac218-749f-40dc-a8ec-efc570d72402") },
                    { 5, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2217), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2217), 2, "Cook the spaghetti", 2, "Cook spaghetti", new Guid("0384cc8a-5647-4f6e-a90e-d895559a1f82") },
                    { 6, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2220), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2220), 3, "Fry the bacon", 1, "Fry bacon", new Guid("04887de2-e6ba-4d1b-acbd-d574a02b77e0") },
                    { 7, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2222), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2222), 3, "Cook the eggs", 2, "Cook eggs", new Guid("5b831497-e1aa-4060-aeb7-aa3046130a37") },
                    { 8, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2224), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2224), 4, "Cook the beef and the bacon", 1, "Cook beef and bacon", new Guid("b2f429df-fabd-4d61-8362-465c90ed1442") },
                    { 9, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2226), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2226), 4, "Cook the spaghetti", 2, "Cook spaghetti", new Guid("d667a68a-c7e3-4c34-aaca-61df92d5e1a5") },
                    { 10, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2229), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2229), 5, "Prepare the bolognese", 1, "Prepare bolognese", new Guid("0f0cf7ff-c321-45fe-8405-78f504e9ac1a") },
                    { 11, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2231), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2232), 5, "Prepare the bechamel", 2, "Prepare bechamel", new Guid("9ce7ca05-7561-4236-8e61-2a25a5866b77") },
                    { 12, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2233), new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2234), 5, "Prepare the lasagna and place it in the oven.", 3, "Prepare lasagna", new Guid("c6f50e96-5970-4f2f-974e-ef0769fbc072") }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredient",
                columns: new[] { "IngredientId", "RecipeId", "CreatedOn", "IngredientQuantity", "ModifiedOn", "UniqueId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2146), "2 whole", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2146), new Guid("b24efbe5-9083-40bc-9d3d-dd673186b018") },
                    { 1, 2, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2157), "1 whole", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2157), new Guid("c4372fa2-72f0-49d9-908d-8bf265719dbd") },
                    { 2, 1, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2149), "100 g.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2149), new Guid("52dee08d-31c3-44b8-8507-4430994b09f4") },
                    { 2, 3, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2166), "75 g.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2166), new Guid("ca54a8b6-15c6-4105-afc7-9f9cfabfdfd2") },
                    { 2, 4, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2175), "100 g.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2175), new Guid("b1ac180c-ef44-424f-9dac-864951ee378d") },
                    { 3, 1, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2151), "2 slices", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2152), new Guid("5ccc05a9-c666-4c5e-a2b8-9c9bbe9a198d") },
                    { 3, 3, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2168), "4 slices", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2168), new Guid("fdf7faa5-e713-4329-bac3-a6394d348bb0") },
                    { 4, 2, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2159), "500 g.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2160), new Guid("d4770a22-9656-4b31-a852-6d92ea4af9d9") },
                    { 4, 4, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2173), "500 g.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2173), new Guid("66588dc3-33ef-44c4-b304-8b9ad7a422f8") },
                    { 5, 2, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2161), "200 g.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2162), new Guid("6301b8fb-ec88-4f90-a76e-b4976ecb16ff") },
                    { 6, 2, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2164), "50 g.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2165), new Guid("70914b24-4c21-4dc9-91a8-5a1a2df583ea") },
                    { 7, 1, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2155), "1 whole", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2155), new Guid("708506f3-fe41-47fe-b734-f1557b0eb293") },
                    { 7, 3, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2170), "1 whole", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2170), new Guid("22e4ab15-f8ad-41b7-8687-4a96f8c87165") },
                    { 7, 4, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2177), "3 tins of crushed tomatoes", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2177), new Guid("1654a6a2-83b1-4517-b81e-fce4fdcf9c89") },
                    { 7, 5, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2182), "2 tins of crushed tomatoes", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2182), new Guid("a8de560d-36a3-489d-8611-de2a8edb0b77") },
                    { 8, 4, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2178), "250 g.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2179), new Guid("bea1f458-1f05-4e28-b1e7-5b06125646cb") },
                    { 8, 5, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2184), "300 g.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2184), new Guid("a991855a-1b29-4301-a19d-d4bdb318e479") },
                    { 9, 5, new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2186), "250 g.", new DateTime(2023, 7, 13, 7, 12, 43, 863, DateTimeKind.Utc).AddTicks(2186), new Guid("5ba2a43a-605d-42f0-9a21-02a573bc5f8b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_Name",
                table: "Ingredient",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PreparationStep_RecipeId",
                table: "PreparationStep",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_RecipeCategoryId",
                table: "Recipe",
                column: "RecipeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredient_RecipeId",
                table: "RecipeIngredient",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreparationStep");

            migrationBuilder.DropTable(
                name: "RecipeIngredient");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "RecipeCategory");
        }
    }
}
