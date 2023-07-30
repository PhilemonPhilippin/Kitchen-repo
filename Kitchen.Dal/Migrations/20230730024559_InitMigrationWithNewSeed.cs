using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kitchen.Dal.Migrations
{
    /// <inheritdoc />
    public partial class InitMigrationWithNewSeed : Migration
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
                    { 1, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9883), "Although a variety of sausages can be used, bangers are usually a mild, fresh pork sausage made with a bread filler and seasoned with spices that may include pepper, thyme, sage, nutmeg and mace and stuffed into a natural casing.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9884), "English breakfast sausage (Banger)", new Guid("94b0008c-c8ab-4209-bbd0-671050399aec") },
                    { 2, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9888), "Back bacon is a cut of bacon that includes the pork loin from the back of the pig. It may also include a portion of the pork belly in the same cut.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9888), "Back bacon", new Guid("79169bc5-914f-4106-9607-5dd592a0810b") },
                    { 3, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9890), "Chicken egg", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9890), "Egg", new Guid("1f7530b2-7396-462c-a2ac-eba84d22674e") },
                    { 4, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9892), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9892), "Tomato", new Guid("bb2a24a9-5839-4431-bf38-7411d4643b64") },
                    { 5, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9893), "White buttons feature the classic mushroom umami flavor that is slightly milder than other varieties of mushrooms.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9894), "White button mushroom", new Guid("0e2990c2-a5be-4d2b-94b3-a96a20c85df0") },
                    { 6, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9896), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9896), "Bread", new Guid("ad334efc-cae2-4f59-8520-d5e75b848d32") },
                    { 7, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9898), "Also called \"Haricot beans\", or \"Pea beans\".", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9898), "Navy beans", new Guid("565932f2-7f39-460e-b531-39df2a2b6302") },
                    { 8, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9900), "Romaine or cos lettuce is a variety of lettuce that grows in a tall head of sturdy dark green leaves with firm ribs down their centers.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9900), "Romaine lettuce", new Guid("fb1094a4-7671-4c91-bafa-ee82af1003a0") },
                    { 9, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9902), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9903), "Red bell pepper", new Guid("2b18e096-578c-439b-98c2-072c3366aafd") },
                    { 10, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9905), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9906), "English cucumber", new Guid("0a64804b-c331-4f8f-91a3-74a5b1585ec4") },
                    { 11, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9907), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9908), "Cherry tomato", new Guid("7e70ae41-1c50-43f7-a703-a56385eee1db") },
                    { 12, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9909), "Also known as green onions, and spring onions.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9910), "Scallion", new Guid("25bf666c-b597-4f1b-9285-d294f0b1b1c4") },
                    { 13, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9911), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9911), "Extra virgin olive oil", new Guid("c6e5dd62-e3d4-4b53-a62a-aa670f281f52") },
                    { 14, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9914), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9914), "Fresh corn kernels", new Guid("6239d4c6-8a36-4c6d-bab2-33903263445f") },
                    { 15, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9915), "Boneless and skinless", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9916), "Chicken thighs", new Guid("ab4c9124-8c86-49fa-8e53-21da7f004e74") },
                    { 16, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9917), "This taco seasoning is a spice blend that’s smoky and herby. This taco seasoning begins with chili powder, cumin, oregano, coriander, garlic and onion.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9917), "Taco seasoning mix", new Guid("0698676f-995e-43e7-a3b4-ecbc178f3b10") },
                    { 17, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9919), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9919), "Corn tortilla chips", new Guid("7373d5d0-5346-4feb-b5d0-93a0cfb74a15") },
                    { 18, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9923), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9923), "Cotija cheese", new Guid("e3a9c8bf-52a1-4477-ab7f-da2a5e3ac741") },
                    { 19, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9924), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9925), "Fish sauce", new Guid("63e1c3c4-9a3d-4d9a-a9bb-77b388788478") },
                    { 20, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9926), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9926), "Brown sugar", new Guid("d22615ab-ee83-4a1b-8e09-f97920cf25e3") },
                    { 21, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9928), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9928), "Black pepper", new Guid("4a0f4e83-451b-4764-be6b-b5c203b3094e") },
                    { 22, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9931), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9931), "Jasmine rice", new Guid("c8e0d070-f027-4844-a4d1-a9477911cd92") },
                    { 23, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9932), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9933), "Lemon", new Guid("c4ae08f3-2666-4fd4-97f7-92fa3bed5ec2") },
                    { 24, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9934), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9934), "Dijon mustard", new Guid("16174c96-3c3f-4916-816c-e8a400cd2903") },
                    { 25, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9936), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9936), "Red wine vinegar", new Guid("601f88f4-633e-4a70-b5b9-71a68ff9ab94") },
                    { 26, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9938), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9939), "Sugar", new Guid("ea64500d-1ef3-460e-a53f-ff946c274904") },
                    { 27, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9940), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9941), "Dried oregano", new Guid("3d0a0abd-b9e5-4453-99bb-6eb71ea8c15d") },
                    { 28, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9942), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9942), "Red onion", new Guid("0dcb0f51-4e2f-4830-a2bc-20554eec7fe4") },
                    { 29, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9944), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9944), "Chickpeas", new Guid("22fc6b05-605a-4e93-9ab3-05274ffb1c05") },
                    { 30, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9947), "Genoa salami is a variety of salami commonly believed to have originated in the area of Genoa, Italy. It is normally made from pork, but may also contain veal. It is seasoned with garlic, salt, black and white peppercorns, and red or white wine. Like many Italian sausages, it has a characteristic seasoned and aged flavor.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9947), "Genoa salami", new Guid("84a2022b-584e-4c4d-97f4-c2fc9ad4a8cc") },
                    { 31, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9948), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9949), "Mozzarella", new Guid("ea7bc0ea-30d6-4b5a-88cd-c4b6660989cb") },
                    { 32, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9950), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9950), "Hot chili peppers", new Guid("e07519d4-7985-41fe-942c-1b1dcf19d6c6") },
                    { 33, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9952), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9952), "Basil leaves", new Guid("4c797852-e97f-4bc0-819b-47c8ddf1dfe6") },
                    { 34, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9955), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9955), "Balsamic vinegar", new Guid("a17e4e7f-81ee-4f97-99aa-b6a8a6c1dedf") },
                    { 35, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9956), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9957), "Plantains", new Guid("dd83ebe7-fd8c-44a4-8ba0-96e97828cc01") },
                    { 36, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9958), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9958), "Butter", new Guid("43b76b72-1d9f-4f42-8b31-2111655fd7bd") },
                    { 37, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9960), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9960), "Yellow onion", new Guid("8ae9439c-50eb-40fe-8d3e-eccf4f6ebcfd") },
                    { 38, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9963), "All-purpose flour", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9963), "Flour", new Guid("6b8ffd92-4f71-4006-964d-fbf78fa8516a") },
                    { 39, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9964), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9965), "Can of crushed tomatoes", new Guid("4968579b-9760-4392-89cc-868482cb049e") },
                    { 40, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9966), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9966), "Can of tomato sauce", new Guid("96d55998-8c41-4cd4-a7c4-ec363c4b2977") },
                    { 41, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9968), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9968), "Chicken stock", new Guid("d296f688-a743-4d2a-826c-07ce56e98f48") },
                    { 42, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9970), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9971), "Garlic", new Guid("e924a269-c7f4-4465-88a7-e9d567f7caf9") },
                    { 43, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9992), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9992), "Celery", new Guid("257308ac-9df6-4b6a-a283-97b3f89abb0e") },
                    { 44, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9994), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9994), "Carrot", new Guid("8d316ee4-95ff-419f-a94c-c96462d1aabe") },
                    { 45, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9995), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9996), "Butternut", new Guid("96b45c53-58aa-470b-8fd1-5f1e7ee60114") },
                    { 46, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9999), null, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9999), "Green apple", new Guid("e351528b-b4ac-4e04-9e5a-3276af1a5a64") },
                    { 47, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(1), "Broccoli", new Guid("aff04658-9ac6-485d-9f00-3585f62ae9e1") },
                    { 48, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(2), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(2), "Vegetable stock", new Guid("8413a2f3-6037-4d52-9b5c-e692eaa235d5") },
                    { 49, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(5), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(5), "Whole milk", new Guid("e6ad399e-00cb-4ad1-9a58-637f2b186c9c") },
                    { 50, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(8), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(8), "Cheddar", new Guid("2388cba7-a654-4aa6-8000-87f367502e23") },
                    { 51, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(10), "Cavatappi are short, ridged corkscrew-shaped pasta. If you can't find them, substitute another short, sturdy pasta shape, such as rigatoni or even farfalle.", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(10), "Cavatappi pasta", new Guid("116d1ec4-352f-47ae-b04c-336ca03caf6f") },
                    { 52, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(11), "At least 36% fat.", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(12), "Heavy cream", new Guid("12838913-70eb-44c1-a067-e4f69f3e7d38") },
                    { 53, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(13), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(13), "Parmesan", new Guid("2ba1e835-18a1-431b-b4db-8e1fb209bc52") },
                    { 54, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(16), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(16), "Peas", new Guid("0d384a1f-1e58-4ef1-92da-92f72357aba8") },
                    { 55, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(18), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(18), "Spaghetti", new Guid("e038ff90-f637-4f61-8b30-dc2962c017e6") },
                    { 56, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(19), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(20), "Shrimps", new Guid("71de2435-5117-405e-ae9b-cf719bafdaf5") },
                    { 57, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(21), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(21), "Asparagus", new Guid("04f2fb41-2a98-4ac2-8438-7aeba506ceea") },
                    { 58, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(24), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(24), "White wine", new Guid("dc0fa34a-ded4-434f-ada5-7a78ac4db48b") },
                    { 59, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(26), "Boneless and skinless", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(26), "Chicken breasts", new Guid("31d5e0c5-d8b8-4c17-810f-1d8938ba0032") },
                    { 60, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(27), "Contains dried oregano, basil, rosemary, and thyme. Many also include marjoram and/or sage. Store-bought seasoning will sometimes include garlic powder, red pepper flakes, and/or salt.", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(28), "Italian seasoning", new Guid("31bedc81-3e3f-4b80-84e6-bfe2d457d66b") },
                    { 61, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(29), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(29), "Ciabatta rolls", new Guid("99235c7c-08a5-463d-8a84-f6c8f7076ebd") },
                    { 62, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(32), null, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(32), "Pesto", new Guid("36c3cc80-1c39-4af3-88d6-0ee9bded43de") }
                });

            migrationBuilder.InsertData(
                table: "RecipeCategory",
                columns: new[] { "Id", "CreatedOn", "Description", "ModifiedOn", "Title", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9720), "Breakfast is the first meal of the day usually eaten in the morning. The word in English refers to breaking the fasting period of the previous night.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9720), "Breakfast", new Guid("b97edd5b-4dfa-4b92-be59-1a206f6510d3") },
                    { 2, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9744), "A cold dish of various mixtures of raw or cooked vegetables, usually seasoned with oil, vinegar, or other dressing and sometimes accompanied by meat, fish, or other ingredients.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9745), "Salad", new Guid("d02a8acd-71ed-46f8-8375-43b0273a1c66") },
                    { 3, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9747), "Lunch is a meal eaten around the middle of the day. It is commonly the second meal of the day, after breakfast, and varies in size by culture and region.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9747), "Lunch", new Guid("37907377-80c8-4116-a033-68d2306d70e5") },
                    { 4, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9748), "An appetizer is part of a meal that's served before the main course. Usually, an appetizer is a small serving of food — just a few bites — meant to be eaten before an entree, and often shared by several people. An appetizer is meant to stimulate your appetite, making you extra hungry for your meal.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9749), "Appetizer", new Guid("8baa2ba3-e244-4b13-9d2b-188e62ac9fd3") },
                    { 5, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9752), "Soup is a liquid or thick, creamy food that's usually hot and savory. Most soup is made by cooking vegetables, beans, meat, or fish (or a combination of these) in water for a long time. Sometimes soup is thickened with cream or flour, or by pureeing some of the ingredients.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9752), "Soup", new Guid("e7f65d4b-55a6-4695-aa68-41c3ba4a4e37") },
                    { 6, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9754), "Dinner — also called supper — is the third meal of the day. It's the main meal, the one families often try to have together at the end of the day. Dinner has always been the main meal, but it used to be served in the middle of the day and supper was last.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9754), "Dinner", new Guid("503902f2-05de-4824-90c3-122c4b48302a") },
                    { 7, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9756), "Served as the last course of a meal, a dessert is often sweet, like cake or pie. The word dessert originates from an interesting French word, desservir, which actually means to \"clear the table\". After the dinner dishes are removed, the host brings out the dessert.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9756), "Dessert", new Guid("ff0f4e52-c922-4b66-9e3f-798c71fbf6c7") }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CreatedOn", "Description", "ModifiedOn", "RecipeCategoryId", "Title", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9842), "Sometimes also called a 'fry-up', the full English breakfast consists of fried eggs, sausages, back bacon, tomatoes, mushrooms, fried bread and often a slice of white or black pudding (similar to bloodwurst). It is accompanied by tea or coffee and hot, buttered toast.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9842), 1, "English breakfast", new Guid("fe298612-5a28-4604-aa17-c976a4ec5f88") },
                    { 2, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9846), "Seasoned chicken, tortilla chips, and roasted corn pair perfectly together in this crunchy and craveable Tex-Mex chopped chicken salad with cilantro lime dressing.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9846), 2, "Chicken salad", new Guid("45c6abae-3c86-4022-ace1-c3176daa55fe") },
                    { 3, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9848), "Kai jeow is a classic Thai omelet with the perfect balance of salty-sweet-hot flavors. Serve it simply, with rice and raw vegetables, for a quick and satisfying meal.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9849), 3, "Kai Jeow (Thai omelet)", new Guid("58fdb08b-5412-4176-9d24-e0e902a988e7") },
                    { 4, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9852), "Classic chopped Italian salad has a pleasing mix of pickled vegetables, cured meats, and cheeses. Serve as a colorful dinner on its own, or a starter with pasta or pizza.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9852), 2, "Chopped italian salad", new Guid("30ee59ea-698e-4473-99cf-6eb59b4d313a") },
                    { 5, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9854), "Jazz up your al fresco menu with these grilled peppers—they are a quick and easy summer side dish for burgers, grilled meat, or grilled seafood.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9855), 4, "Grilled peppers", new Guid("5c522499-6a19-4ef8-aed6-b61443aaec30") },
                    { 6, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9857), "Slicing into thin rounds on a mandoline and baking directly on a baking sheet is the key to making these golden, delicately crisp, baked plantain chips.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9858), 4, "Plantain chips", new Guid("90a0149f-3e3b-4ecf-88e1-362c575c47a1") },
                    { 7, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9859), "This classic tomato soup is rich with a velvety texture. It's easy to make with canned tomatoes, and perfectly suited for all of your grilled cheese dipping needs.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9860), 5, "Tomato soup", new Guid("19356021-fee2-4003-b312-a606574e27d6") },
                    { 8, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9861), "In search of a healthy butternut squash soup recipe that has a little something special? This is it! Even better, it's ready in an hour and freezes well for later.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9862), 5, "Butternut squash soup", new Guid("2d2d83eb-d646-4824-96df-9fd800c9b52d") },
                    { 9, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9863), "This easy one-pot broccoli cheddar soup is so comforting during cold months. Simple ingredient list, and make it start to finish in under an hour.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9864), 5, "Broccoli cheddar soup", new Guid("28ce9c38-94ba-4aae-8785-671cbef1eb95") },
                    { 10, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9866), "Creamy cavatappi is a weeknight win. With a quick and easy cream and Parmesan sauce that feels indulgent, this simple recipe is easy to customize to suit your tastes.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9867), 6, "Creamy cavatappi", new Guid("4e1e408c-ad45-4993-9ccb-69dcce479d88") },
                    { 11, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9868), "This classic spring pasta dish combines the fresh, seasonal flavor of asparagus with sweet, tender shrimp.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9869), 6, "Shrimp and asparagus pasta", new Guid("74723dae-9efb-4406-adaa-104c3bd57470") },
                    { 12, new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9870), "Fresh tomatoes, basil, mozzarella, and juicy chicken equals summer on a bun.", new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9870), 6, "Grilled chicken caprese sandwich", new Guid("ff5a121d-4b1f-4f1e-bf3f-d44f3343e421") }
                });

            migrationBuilder.InsertData(
                table: "PreparationStep",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "RecipeId", "Step", "StepNumber", "Title", "UniqueId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(298), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(299), 1, "Open the can of beans and warm in a small pot over low heat, stirring occasionally.", 1, "Warm the beans", new Guid("e807cab5-07da-42ea-a760-28f17912f369") },
                    { 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(301), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(301), 1, "While the beans are warming, cook the sausages over medium to medium low, until browned and cooked through, turning as needed. Push the sausages to one side and add the bacon and fry, flipping as needed.", 2, "Cook the sausages and bacon", new Guid("5e9f7de8-5249-4464-88a1-2ed01e86c0ce") },
                    { 3, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(304), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(305), 1, "In another pan, sear the mushrooms until brown and caramelized. Move to one side. Add the tomatoes, cut side down and sear.", 3, "Cook the mushrooms and tomatoes", new Guid("b7d9a5f0-b380-4d38-b3ed-1f0002f2e7b5") },
                    { 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(307), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(307), 1, "Move the meats from the pan and fry the bread in the drippings until golden and crisp. Cook the eggs in the pan that the mushrooms and tomatoes were in.", 4, "Fry the bread and cook the eggs", new Guid("4aec61b6-9c73-4e06-abfd-81a313a71552") },
                    { 5, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(309), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(309), 2, "Combine the lettuce, red pepper, cucumber, tomatoes, and scallions in a large serving bowl.", 1, "Combine salad ingredients", new Guid("8776a416-34b1-4def-beca-4284787a7b09") },
                    { 6, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(311), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(311), 2, "Heat 1 teaspoon olive oil in a medium or large heavy-bottomed skillet over high heat. When the oil is hot, add the corn. Season corn with 1/4 teaspoon salt and cook, stirring occasionally, until blackened in spots and tender, about 3 minutes.", 2, "Char the corn", new Guid("4bb355af-275c-4153-af9b-eade3cc5344e") },
                    { 7, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(314), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(314), 2, "Sprinkle the taco seasoning and 1/2 teaspoon salt over the surface of the chicken, rubbing it in and coating so chicken is fully seasoned.", 3, "Season the chicken", new Guid("9b58dda6-379c-4ee3-8776-ec8a2587021c") },
                    { 8, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(316), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(316), 2, "In the same skillet used to cook the corn add 1 tablespoon of olive oil and set over medium-high heat. When the oil is hot, add the chicken and cook until deeply brown along the bottom and the flesh turns opaque about halfway up the side, 4 to 5 minutes. Flip the chicken and continue cooking, until brown on the second side and fully cooked through, another 3 to 5 minutes.", 4, "Cook the chicken", new Guid("e71f21d5-8157-4ce6-9d00-617663bb6d81") },
                    { 9, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(318), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(318), 2, "Transfer the cooked chicken to a cutting board. Once it is cool enough to handle, cut into bite-sized pieces.", 5, "Cut the chicken", new Guid("51c0717d-4866-4fdc-a556-5591fc5efb58") },
                    { 10, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(320), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(320), 2, "Place the lime juice, vinegar, honey, cumin, salt, pepper, cilantro, and olive oil into a blender and blend until smooth. Add 1 tablespoon of water, if needed, to get the blender going. Finely chop the cilantro and place in a medium bowl. Combine all salad dressing ingredients and whisk until smooth.", 6, "Make the salad dressing", new Guid("5dd3c820-d826-4164-b2fc-6b8b4a5c50b8") },
                    { 11, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(323), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(324), 2, "Add the corn and chicken into the bowl with the salad ingredients. Crumble the tortilla chips over the top.", 7, "Finish", new Guid("4b92952d-d201-4944-8c7d-e306bfe781cf") },
                    { 12, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(325), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(326), 3, "In a medium bowl, combine the eggs, fish sauce, brown sugar, scallion and black pepper in a medium bowl. Whisk vigorously until well combined and no egg whites are visible.", 1, "Whisk the eggs", new Guid("6ead958c-4df5-4130-b6ad-8e858dab25cb") },
                    { 13, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(327), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(328), 3, "Heat vegetable oil in a small (about 8-inch diameter) nonstick skillet over medium-high heat until the oil is hot. You will know when the oil is ready when it smokes lightly.", 2, "Heat the oil smoking hot", new Guid("6cf73eb5-e225-45e7-9249-3368ecb8e06c") },
                    { 14, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(329), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(330), 3, "The egg will immediately start to fry and become puffy. Cook until lightly browned on the bottom. While you wait, use a small spatula or chopsticks to push the edges of the omelet inward and tilt the pan to encourage the raw eggs in the center to come in contact with the pan. Cook the first side for approximately 3 minutes. Once the omelet is firm, flip the omelet.", 3, "Pour the eggs into the hot skillet and cook", new Guid("122c0ac2-514a-4eb4-9d03-ebd027bf2968") },
                    { 15, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(332), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(333), 3, "Serve immediately with cooked rice, cucumber slices, romaine lettuce.", 4, "Serve", new Guid("c44f1cea-5c67-4bfe-bc6a-5defcdc044e5") },
                    { 16, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(334), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(335), 4, "In a jar with a lid add the lemon juice, mustard, vinegar, sugar, oregano, olive oil, kosher, salt, and black pepper. Add the lid and shake for 10 seconds until all of the ingredients are thoroughly combined.", 1, "Making the dressing", new Guid("446baa7e-13c9-431b-b95d-c80104eb7a87") },
                    { 17, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(356), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(357), 4, "Add the chopped Romaine to a large bowl and drizzle with a few tablespoons of dressing. Top the romaine with the red onion, chickpeas, cherry tomatoes, mozzarella, pepperoncini, roasted red peppers and basil. Stir together well before serving.", 2, "Make the salad", new Guid("be71756b-ae05-4a5e-9ea3-322fe8a9564a") },
                    { 18, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(359), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(359), 5, "To medium-high (about 205ºC). Dip a wadded paper towel into vegetable oil and brush the grill grates.", 1, "Turn the gas grill on", new Guid("26961468-2cb0-4b62-8142-42c3a8c29da1") },
                    { 19, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(362), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(362), 5, "While the grill heats, halve the peppers from top to bottom, cutting through the stems if they are attached. Pull off the stems and seeds and discard. With your hand, flatten each pepper.", 2, "Prep the peppers", new Guid("fea5760b-c469-4284-9ad3-2fa902d4437e") },
                    { 20, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(364), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(364), 5, "Add the peppers into a large bowl. Toss with olive oil and salt.", 3, "Toss peppers with olive oil and salt", new Guid("a60ee218-ebff-4f12-8d89-086291528547") },
                    { 21, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(366), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(366), 5, "Using tongs, set the peppers on the oiled grill grates with the skin sides down. Close the cover and grill for 6 to 8 minutes, or until the skins are wrinkled and blackened. The blacker the skins, the easier they will be to peel. They also take on a more charred color. Flip them over and grill for another 3 to 4 minutes, or until softened.", 4, "Grill the peppers", new Guid("b2dbe131-907d-4435-931e-5fc15a62c15e") },
                    { 22, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(368), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(368), 5, "Let them steam for about 10 minutes. With your fingers, pull off and discard the skins. Resist running them under cold water because that will dilute the smoky sweet flavor of the peppers. Remove stubborn bits by scraping with the dull end of a paring knife.", 5, "Peel the peppers", new Guid("affb9c8c-2eda-44a9-bf7a-ed0c0f31f6af") },
                    { 23, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(371), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(372), 5, "Pile the peppers on a platter and drizzle with olive oil and vinegar. Season with salt, to taste. Serve.", 6, "Serve", new Guid("9d4adcdc-8e87-40e1-83f4-4002a7c409cc") },
                    { 24, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(373), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(374), 6, "Arrange the racks in the top and bottom thirds of the oven. Preheat the oven to 190°C.", 1, "Preheat the oven", new Guid("75701b0e-81c8-42c3-9031-686005bf2237") },
                    { 25, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(375), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(376), 6, "Rinse the plantains and pat them dry. Trim the ends off each with a sharp knife. Use the knife to score the skin of the plantain lengthwise, taking care to not cut into the flesh. Shimmy your thumb between the skin where it is scored and the flesh of the plantain to separate the two and peel the plantains.", 2, "Prepare the plantains", new Guid("fa3d0ff9-a193-45eb-ae1e-30fc6e7c82fc") },
                    { 26, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(377), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(378), 6, "Using a mandoline, carefully slice the plantains into 1/16-inch thick rounds. Alternatively, use a sharp knife to cut the plantain by hand into 1/16-inch thick rounds. If cutting by hand, take care to cut them as close to 1/16-inch thick and as evenly as possible. Thicker rounds will result in a more toothsome crunch rather than a delicate crisp.", 3, "Cut the plantains", new Guid("cc3baa17-e16e-4eb2-8c6d-b3c3a6211a14") },
                    { 27, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(380), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(381), 6, "In a large bowl, combine the olive oil and 1 teaspoon kosher salt. Add the sliced plantain rounds to the oil and salt mixture and toss by hand to coat each round. Take care to separate and coat any plantain slices that may have stuck together.", 4, "Toss the plantains", new Guid("b4268826-f845-4a4c-a56d-575df74325bb") },
                    { 28, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(383), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(383), 6, "Arrange the coated plantain rounds in a single layer across two (unlined) rimmed baking sheets. It's okay if the edges of the rounds are touching as they will shrink in the oven, but do not let them overlap.", 5, "Spread the plantains on rimmed baking sheets", new Guid("251813de-49b5-4052-a3ee-bac12cc0dcf9") },
                    { 29, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(385), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(385), 6, "Arrange the chips in the top and bottom thirds of the oven. Bake at 190°C for 7 minutes. Rotate the pans from front to back and top to bottom. Bake for another 8 to 9 minutes until the plantain chips are golden to golden brown, dry and firm to the touch, and easily release from the pan.", 6, "Bake the plantain chips", new Guid("f10685dd-214b-44df-88a9-cec9960b4196") },
                    { 30, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(388), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(388), 6, "Sprinkle the plantain chips with more salt, if desired, while still warm from the oven. Serve warm or at room temperature.", 7, "Finish the plantain chips and serve", new Guid("eba9fe00-4004-4806-8280-540b1ab9d21b") },
                    { 31, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(391), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(391), 7, "In a Dutch oven set over medium heat, add the butter. Once it starts to foam, add the onion, garlic, salt, and pepper. Stir until both have softened and are fragrant, about 7 minutes.", 1, "Sauté the onions and garlic", new Guid("5f4efa53-656b-4a69-b94f-4ae5282d43da") },
                    { 32, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(393), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(393), 7, "Add flour. Stir to make a paste. Continue stirring until the flour has taken on a light brown color. Stir and scrape with wooden spoon, 5 to 7 minutes. The onion paste should look golden with a little brown caramelization.", 2, "Make the roux", new Guid("33d6d5a7-b046-40ce-b311-ddb9730dfe5a") },
                    { 33, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(395), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(395), 7, "Add crushed tomatoes, tomato sauce, chicken stock, and sugar. Stir to combine. Cover the pot and bring to a boil over medium high heat, then reduce heat to medium and let simmer uncovered for about 20 minutes.", 3, "Add tomatoes and stock", new Guid("9ecc2a74-3ad4-4c66-8690-6bc96e617249") },
                    { 34, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(397), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(397), 7, "Purée the soup with an immersion blender. Alternatively, fill a countertop blender less than halfway with the hot soup. Remove the center lid insert. This allows the hot steam to escape. Cover the hole with a folded kitchen towel and place your hand over the top. Blend. Repeat as necessary until all of the soup has been puréed.", 4, "Purée and serve", new Guid("0dbdb5c0-6a5a-4682-950e-55fa0edea88a") },
                    { 35, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(401), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(401), 8, "Heat a large thick-bottomed pot on medium-high heat. Melt the butter in the pot and let it foam up and recede. Add the onion, carrot, and celery and sauté for 5 minutes. Lower the heat if the vegetables begin to brown.", 1, "Sauté the onion, carrot, and celery in butter", new Guid("669c0920-de47-4a67-b8a5-ac9e491128ac") },
                    { 36, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(403), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(403), 8, "Add the butternut squash, apple, stock, and water. Bring to boil. Reduce to a simmer, cover, and simmer for 30 minutes or so, until the squash and carrots have softened.", 2, "Cook the soup", new Guid("d8e4da95-2d2c-46a2-b465-a1f67ee5cee4") },
                    { 37, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(405), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(405), 8, "Use an immersion blender to purée the soup, or work in batches and purée the soup in a stand blender.", 3, "Purée the soup", new Guid("8c812c44-4c50-454b-aa60-8a39c000b256") },
                    { 38, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(407), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(407), 8, "Add pinches of nutmeg, cinnamon, and cayenne. Add salt and pepper to taste.", 4, "Add the seasonings", new Guid("944cb2f8-3e8d-4b89-844e-f52f9456249d") },
                    { 39, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(410), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(410), 9, "Bring a large pot of water to a boil and add a few big pinches of salt. Add broccoli stalks and blanch for 2 to 3 minutes until they are bright green and fork tender, but still slightly crispy. Drain broccoli. Scoop out and set aside about 1 cup of the florets for the topping.", 1, "Blanch the broccoli", new Guid("77a0f144-636b-480b-8086-3685f3f00c8e") },
                    { 40, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(412), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(412), 9, "Wipe out the pot, place over medium heat, and melt the butter. Once melted, add the onions and carrots, and cook until veggies soften, 4 to 5 minutes, stirring regularly.", 2, "Cook the onions and carrots", new Guid("4ff3fd96-758b-4678-b67f-f2a9f6e4974c") },
                    { 41, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(414), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(414), 9, "Stir in the all-purpose flour. The flour will form a paste with the veggies. Cook for a minute or two to coat the vegetables, and then start to slowly pour in vegetable stock. Stir constantly as you pour in the stock to avoid lumps. Once all the stock is added, bring soup up to a low simmer. Add milk and the blanched broccoli (except what you're saving for the topping). Simmer for about 10 minutes over low heat.", 3, "Cook the soup", new Guid("09064669-97e6-48c6-9e59-0cf6cd474e6f") },
                    { 42, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(417), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(417), 9, "Blend with an immersion blender, or let the soup cool until no longer steaming and blend in batches in a blender.", 4, "Puree the soup", new Guid("c6873da7-acbb-4476-bcd9-cbed070904ad") },
                    { 43, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(420), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(420), 9, "Add the grated cheese, salt, and pepper to the pureed soup and stir over low heat until the cheese has melted. Taste the soup and season with additional salt and pepper to your liking. Ladle the soup into bowls and garnish with some reserved broccoli and extra cheese on top. Serve with bread.", 5, "Season to taste and serve", new Guid("8b7df522-812b-4b2b-976c-a7a4644b7fd9") },
                    { 44, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(422), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(422), 10, "Put a large pot of water on to boil over high heat. Season generously with salt. Once the water is boiling, add the pasta and stir. Cook until just short of al dente, according to the package directions.", 1, "Cook the pasta", new Guid("2adf933c-1b75-4d74-804b-e7182ce4f48d") },
                    { 45, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(424), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(424), 10, "While the pasta cooks, add the butter to a large skillet over medium heat. Once melted, add the garlic and cook just until fragrant but not browned, about 30 seconds. Slowly add the cream while stirring and season with salt and pepper. Bring to a simmer, reducing the heat if needed to maintain a simmer.", 2, "Meanwhile, make the sauce, part 1", new Guid("1db3a98d-0a30-4be9-99b3-8328d486d303") },
                    { 46, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(426), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(426), 10, "Cook, while stirring, until slightly thickened, about 3 minutes. Add the Parmesan a small handful at a time, sprinkling it over top and stirring each time until melted. Add the lemon juice and stir. Turn the heat as low as it’ll go until the pasta is ready, stirring occasionally.", 3, "Meanwhile, make the sauce, part 2", new Guid("8d61d79d-fba5-4748-b9a3-1f835c560d5f") },
                    { 47, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(429), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(430), 10, "Reserve 1/2 cup of the pasta water. Add the frozen peas to a colander. Drain the pasta over the frozen peas (the hot pasta will help defrost the peas).", 4, "Drain the pasta and thaw the peas", new Guid("7c9c4330-7f0a-4076-8012-b038594671d2") },
                    { 48, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(431), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(432), 10, "If your skillet is big enough, add the pasta and peas to the sauce. Otherwise, add the pasta and peas back to the pasta pot and pour the sauce over the top. Add 1/4 cup of the reserved pasta water and turn the heat to medium. Toss constantly until you have a creamy sauce that coats the noodles, 3 to 5 minutes. If the sauce seems too thick, add more pasta water a small splash at a time, tossing in between. Add salt and pepper.", 5, "Toss the pasta and serve", new Guid("e674656f-60fc-4e23-84c2-fdaba47a10e4") },
                    { 49, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(433), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(434), 11, "When the salted water is at a rolling boil, add the pasta. Cook the pasta according to the package instructions, until it is just 1 minute shy of al dente, very nearly cooked but slightly too firm in the center, about 10 minutes. Drain the pasta in a colander, reserving 1 cup of pasta water to add to the shrimp and asparagus.", 1, "Cook the pasta", new Guid("6b62bc8d-3fdf-45f3-9a4e-1b153df962c1") },
                    { 50, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(435), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(436), 11, "While the pasta is cooking, start cooking the other ingredients. In a Dutch oven over medium-high heat, add the olive oil. When the oil is hot, add the onions and cook, stirring frequently, until it begins to soften, about 3 minutes. Add the shrimp, asparagus, and garlic. Increase the heat on the stove to high, and cook, stirring occasionally, until the side of the shrimp have just turned pink, about 4 minutes. Season with the salt and pepper.", 2, "Cook the shrimp and asparagus, part 1", new Guid("89e61db4-a580-4d0e-a5c3-00e036a444dd") },
                    { 51, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(438), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(439), 11, "Reduce the heat to medium and add the white wine and 2 tablespoons of the butter to the pan. Bring the sauce to a simmer and cook for about 2 minutes. Add the lemon juice to the pan. Season with additional salt and pepper, to taste. Continue to cook until the asparagus is just tender and the widest part of the shrimp has turned from translucent to opaque, about 2 minutes.", 3, "Cook the shrimp and asparagus, part 2", new Guid("92424209-8023-440a-9f26-d86d77147d57") },
                    { 52, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(441), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(441), 11, "Add the drained pasta to the pan with 1/2 cup of the reserved pasta water and the remaining 1 tablespoon of butter. Cook, stirring occasionally and using tongs to coat the pasta with all of the ingredients in the pan. Stir, until the pasta is tender but still firm in the center, 1 to 2 minutes. You should end up with a slick of sauce coating all of the ingredients. Taste and adjust with more salt and pepper to taste.", 4, "Finish the dish", new Guid("5ccd9a0f-57af-4e20-beb0-1e8fb76de567") },
                    { 53, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(442), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(443), 11, "Portion the pasta onto four plates. Top each one with Parmesan and parsley. Serve with a lemon wedge on the side.", 5, "Serve", new Guid("4a0cbb01-e6a2-489f-a15f-c104a80deeb0") },
                    { 54, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(444), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(445), 12, "Cut the chicken breasts in half lengthwise, creating 4 thin filets. Sandwich a piece between two pieces of parchment paper or plastic wrap. Use a meat mallet or rolling pin to beat it to an even 1/4-inch thickness. Repeat with the remaining 3 filets.", 1, "Prep the chicken", new Guid("6b348226-d7dc-4671-99f1-730ce5bf5c28") },
                    { 55, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(448), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(448), 12, "In a shallow dish, whisk together the olive oil, Italian seasoning, salt, and pepper. Place the chicken in the dish and turn to coat. Cover with plastic wrap and transfer to the fridge to marinate for at least 30 minutes or up to 8 hours.", 2, "Marinate the chicken", new Guid("d4c14b2c-689c-44ad-959b-8c08f49a2739") },
                    { 56, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(450), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(450), 12, "Preheat your grill to medium-high heat and lightly oil the grates. Remove the chicken from the marinade and place it on the grill. Cook on one side for 3 minutes, then flip and cook on the other side for 3 minutes. Try not to move the chicken while it cooks except for flipping once.", 3, "Grill the chicken and toast the buns, part 1", new Guid("77e63ad2-9607-4793-9236-b02bec797008") },
                    { 57, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(452), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(452), 12, "The chicken should be cooked through, golden with grill marks, and the internal temperature should be 75°C. Transfer the chicken to a plate and let it rest for 5 minutes. While the chicken is grilling, you can also toast the rolls by placing them cut-side down on the grill for 1 to 2 minutes.", 4, "Grill the chicken and toast the buns, part 2", new Guid("4c7abc5b-044f-472d-ba16-1b1030ced013") },
                    { 58, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(454), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(454), 12, "Spread a generous layer of pesto on the bottom half of each ciabatta roll (about a tablespoon per roll). Add a layer of mozzarella slices, then a layer of tomato slices. Place a piece of grilled chicken on each sandwich. Finish off the sandwich with 5 to 6 fresh basil leaves and a drizzle of balsamic glaze, if desired. Place the other half of the roll on top.", 5, "Assemble the sandwich", new Guid("97a90160-3f9e-4f51-af1b-8e2ce58e32da") }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredient",
                columns: new[] { "IngredientId", "RecipeId", "CreatedOn", "IngredientQuantity", "ModifiedOn", "UniqueId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(55), "4", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(55), new Guid("665266ef-7b5e-4061-b19f-bc9eb698d8fa") },
                    { 2, 1, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(57), "4 slices", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(58), new Guid("a097cd7b-af26-477d-a023-91ed4c1fff71") },
                    { 3, 1, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(60), "2", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(60), new Guid("45282416-5acc-40e9-b45c-75e45a0d39f4") },
                    { 3, 3, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(93), "3", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(94), new Guid("bf1624c1-f90b-46bf-abcb-ba96eb1cd474") },
                    { 4, 1, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(63), "1", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(63), new Guid("539ed258-9cb8-4cc0-973c-62a0633dceec") },
                    { 4, 12, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(269), "2 (225 g total)", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(270), new Guid("1fc152e9-5e1c-4fb9-a07d-b450c0e4d9f8") },
                    { 5, 1, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(65), "4", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(65), new Guid("3ab3012a-3adb-43d2-b9fb-79c10143c36f") },
                    { 6, 1, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(66), "4 slices", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(67), new Guid("cfb052d2-f9ae-40fb-86e9-5aa69280db50") },
                    { 7, 1, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(68), "200 g", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(68), new Guid("a2fa1369-2ad7-437d-81a9-ffd090278f4c") },
                    { 8, 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(71), "6 cups, chopped and packed", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(71), new Guid("3efca760-7fde-444e-ba0f-3183747a9711") },
                    { 8, 3, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(109), "2 cups, chopped", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(109), new Guid("04496f66-a10e-40d1-b1e4-6b1e0cff6934") },
                    { 8, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(126), "2 heads, chopped", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(127), new Guid("223e93b1-5e6a-4c2a-863c-96608ef03104") },
                    { 9, 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(73), "1", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(73), new Guid("30c69286-8b83-4e69-99a5-231d75142986") },
                    { 9, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(141), "1/4 cup, sliced and roasted", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(141), new Guid("8ca3f5b0-d705-41fd-b582-d034af1b68e6") },
                    { 9, 5, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(150), "4", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(150), new Guid("326d05d2-c0da-41fb-8c53-908889a13744") },
                    { 10, 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(74), "1 cup, diced", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(75), new Guid("aeb4ec58-fe81-40ab-a40b-ba7ca2ce21d2") },
                    { 10, 3, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(107), "4 slices", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(108), new Guid("ccd1012a-2832-4b6c-b161-863d72ae7a1d") },
                    { 11, 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(76), "1 cup, halved", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(76), new Guid("0e33a8c4-d3b9-4f3f-a338-397f473790be") },
                    { 11, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(133), "1 pint, halved", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(133), new Guid("db72f176-e23a-4204-a766-6b44df47ef1e") },
                    { 12, 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(79), "3", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(79), new Guid("688dd536-90b9-4ff1-918d-565e76136e5b") },
                    { 12, 3, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(100), "1", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(100), new Guid("98b35bde-8291-4930-b8d6-8670154c3e94") },
                    { 13, 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(81), "1 tablespoon plus 1 teaspoon", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(81), new Guid("e5a62f64-e2e8-41f4-a556-c2785c37902b") },
                    { 13, 3, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(104), "3 tablespoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(104), new Guid("8a78d521-b2ff-47f2-89b8-2ec3cfa2a41d") },
                    { 13, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(123), "1/2 cup", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(123), new Guid("1df0b042-a91c-4d4f-9ae5-f3ee32f5a1ff") },
                    { 13, 5, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(148), "1/4 cup", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(148), new Guid("76739c86-8782-4286-ac68-a4c37b7e3990") },
                    { 13, 6, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(154), "2 tablespoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(155), new Guid("c0282a93-b647-464c-9a2c-62b056ab52f5") },
                    { 13, 11, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(243), "3 tablespoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(243), new Guid("d5b8c043-4540-4dc8-875b-9216e1308da4") },
                    { 13, 12, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(260), "2 tablespoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(260), new Guid("1830f727-869a-4556-afc5-69cb1cdb1a6e") },
                    { 14, 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(83), "1 1/2 cups", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(83), new Guid("0a4800e9-b087-4bc7-9880-094cbe62c890") },
                    { 15, 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(85), "450 g", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(85), new Guid("bda3cf70-05b2-42b7-87e5-e22038c7e024") },
                    { 16, 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(88), "1 tablespoon", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(89), new Guid("0002723b-21e7-4e2a-a346-54fc6ebed7a8") },
                    { 17, 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(90), "12 chips", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(90), new Guid("a415d405-a724-4f01-91b2-a6a14c7f319b") },
                    { 18, 2, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(92), "1/4 cup, crumbled", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(92), new Guid("fb8e6082-6805-4d2e-af75-62cd90a68857") },
                    { 19, 3, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(96), "2 teaspoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(96), new Guid("1bba590a-934f-471e-ab7c-90eb2be93b24") },
                    { 20, 3, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(98), "1/4 teaspoon", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(98), new Guid("ff5ea177-ecc1-42d5-b3c7-a2689ecb3b43") },
                    { 21, 3, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(101), "1/4 teaspoon", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(101), new Guid("811a9143-750b-494a-bb06-0a72ba3f6615") },
                    { 21, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(125), "1/4 teaspoon", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(125), new Guid("a5517406-5c67-4410-94f7-001d0576d5f9") },
                    { 21, 7, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(181), "1 1/2 teaspoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(181), new Guid("57d6cfe2-d2fb-4277-9e71-1c68613e6a60") },
                    { 21, 9, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(224), "1/8 teaspoon", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(225), new Guid("c03661cd-f987-40e8-90a7-502ec55e3040") },
                    { 22, 3, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(106), "1 cup", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(106), new Guid("9f67a01c-3558-4cbd-9f27-6d6fc2b49738") },
                    { 23, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(112), "1", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(112), new Guid("d4c58a85-193d-4118-8326-ef92e1b1779a") },
                    { 23, 10, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(236), "1 tablespoon of fresh juice", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(237), new Guid("3fcfa6c5-dd9b-4e55-bd31-c5d5f9f2ba1d") },
                    { 24, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(114), "1 tablespoon", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(114), new Guid("b629f356-a90e-4c56-a669-4c9b8eb13726") },
                    { 25, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(116), "2 tablespoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(116), new Guid("2b3c77cc-6966-48d9-b788-8760730973f2") },
                    { 26, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(118), "2 teaspoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(118), new Guid("495d47e9-d861-49ac-8404-20b37ab9e3d8") },
                    { 26, 7, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(191), "1 tablespoon", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(192), new Guid("f81f503c-f8aa-4875-b30c-aded64e0195f") },
                    { 27, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(121), "1 teaspoon", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(121), new Guid("996e4244-5f4d-4dc1-adbf-b2d4d0cceed5") },
                    { 28, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(129), "1/2", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(129), new Guid("086c3a92-aa03-447a-9287-7d79ba0b9df6") },
                    { 29, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(131), "425 g", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(131), new Guid("070d95c7-a326-4243-addc-eceb146ec661") },
                    { 30, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(134), "115 g", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(135), new Guid("51659266-41be-4a3d-81d1-3a159046a3f7") },
                    { 31, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(137), "230 g", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(138), new Guid("9982ecec-b00a-47df-82ef-1dc39da63753") },
                    { 31, 12, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(268), "1 ball (225 g)", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(268), new Guid("b20eee0c-5bf7-483d-b3af-2bb96858c368") },
                    { 32, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(139), "1/2 cup, sliced", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(139), new Guid("cafc3b22-a73d-47a0-9dcb-a0125b59095e") },
                    { 33, 4, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(142), "10 fresh leaves, chopped", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(143), new Guid("58e21e8f-1bbf-4500-816c-3610a67d2a99") },
                    { 33, 12, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(272), "20 leaves", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(272), new Guid("c3bab370-eb6f-4afc-87f0-268af281e8e2") },
                    { 34, 5, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(145), "As  much as you want", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(145), new Guid("1fb47d3f-6e7b-4c81-857f-afec5949650e") },
                    { 34, 12, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(274), "2 tablespoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(274), new Guid("4b2f92eb-ff9a-4308-968f-acddc4b73bfd") },
                    { 35, 6, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(152), "2 medium-sized green plantains", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(152), new Guid("421c8b97-cbd7-401a-844b-b86a346795d8") },
                    { 36, 7, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(174), "5 tablespoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(175), new Guid("2961e597-fd73-47cb-9941-e3ad85a29407") },
                    { 36, 8, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(200), "2 tablespoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(201), new Guid("cfed43e2-1bed-4802-a37d-5d3b3c68144b") },
                    { 36, 9, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(210), "1/4 cup", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(211), new Guid("f995205a-e911-4c5b-af11-f02e637b13c9") },
                    { 36, 10, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(229), "1 tablespoon", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(229), new Guid("2b918dbf-8416-4c28-8aa0-0e18ad350f1b") },
                    { 36, 11, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(255), "3 tablespoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(255), new Guid("030adc18-b360-4700-91d4-29c622452108") },
                    { 37, 7, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(177), "1, diced", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(177), new Guid("ccd00dd3-f8ca-4830-ab15-eadf6087860a") },
                    { 37, 8, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(193), "1, chopped", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(193), new Guid("093c7780-0d39-4a13-9219-01b8d897b65b") },
                    { 37, 9, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(212), "1/2 medium, chopped", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(212), new Guid("e69136c6-bb92-4dc9-a13a-0dd8f435ce7e") },
                    { 37, 11, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(244), "1, diced", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(245), new Guid("3e061a99-7d97-4c09-9d60-ddf3ca3fac24") },
                    { 38, 7, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(183), "3 tablespoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(183), new Guid("f2203489-72f2-42c8-8322-4170547032a2") },
                    { 38, 9, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(216), "1/4 cup", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(217), new Guid("6c6628e6-843e-4b7c-9622-d47a71435b6e") },
                    { 39, 7, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(185), "1 can (800 g)", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(185), new Guid("299adbf5-db03-44a3-b02f-bf79eda93841") },
                    { 40, 7, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(187), "1 can (225 g)", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(187), new Guid("5fd8b52b-49b6-40c1-822a-5123449e7f36") },
                    { 41, 7, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(189), "4 cups (900 g)", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(190), new Guid("3fa33391-07fc-4828-acab-5c16db5b8cbd") },
                    { 41, 8, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(207), "3 cups", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(207), new Guid("71097b02-f32a-441c-a203-2391a0fb10da") },
                    { 42, 7, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(178), "4 cloves, minced", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(179), new Guid("dd1e3987-0108-4af8-80d2-dced03586cfd") },
                    { 42, 10, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(231), "2 cloves, minced", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(232), new Guid("95927771-17ba-42ba-8351-9ce5059c181b") },
                    { 42, 11, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(251), "4 cloves, minced", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(251), new Guid("8f59a8dc-8b4c-43fa-959c-109d7105e913") },
                    { 43, 8, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(195), "1 rib, chopped", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(195), new Guid("60b1fdd4-2fbe-47c1-bc1e-a577ce2d53c9") },
                    { 44, 8, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(199), "1, chopped", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(199), new Guid("7def4fca-a106-45ba-9bd4-6671579f05ec") },
                    { 44, 9, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(215), "1", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(215), new Guid("4a436865-5017-4d62-b099-63bf2f48fc4d") },
                    { 45, 8, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(202), "1 squash, seeded, peeled and chopped", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(202), new Guid("29163c5a-b15e-4e05-8206-83f312c524c7") },
                    { 46, 8, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(204), "1 tart green apple, peeled, cored and chopped", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(204), new Guid("611d56ee-8cf0-4e92-9139-347ff8584ff9") },
                    { 47, 9, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(209), "1 large head (500 g)", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(209), new Guid("8021d719-e375-4a41-b4c6-f72e5ed95e71") },
                    { 48, 9, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(218), "1 quart", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(218), new Guid("24d3cbf1-dfda-4b34-aa13-a9999f048f8c") },
                    { 49, 9, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(220), "2 cups", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(220), new Guid("fc30bbf5-af49-4fdc-855c-dd74bb5bbbca") },
                    { 50, 9, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(223), "225 g, grated", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(223), new Guid("5732a304-3d31-4d83-980d-2bd54a0072cf") },
                    { 51, 10, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(227), "225 g", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(227), new Guid("a6c53de0-e54a-48b3-991d-da7d4ed46831") },
                    { 52, 10, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(233), "3/4 cup", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(233), new Guid("765f0b84-c94a-454d-a574-beb251772257") },
                    { 53, 10, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(235), "1/2 cup, grated", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(235), new Guid("03125faf-db6f-42b7-850d-97c327a65788") },
                    { 54, 10, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(239), "1 cup", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(240), new Guid("d17ff761-3e55-4b00-9b78-d12949f10c93") },
                    { 55, 11, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(241), "350 g", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(241), new Guid("a537f7d7-9d27-4169-aa5f-4b3d7eb98cb8") },
                    { 56, 11, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(247), "450 g, uncooked", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(247), new Guid("3078ff9e-0d3e-4b7a-b401-1bb889d98702") },
                    { 57, 11, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(249), "1 bunch, tough ends removed, and cut", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(249), new Guid("7f8a5f4a-78e6-4928-a065-69e3540c3de8") },
                    { 58, 11, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(252), "1/2 cup", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(253), new Guid("33ad9599-f95a-455f-a11e-fe8a146e584f") },
                    { 59, 12, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(258), "2 (700 g total)", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(258), new Guid("f0dbdb40-ba02-4248-a868-6a50cd51698a") },
                    { 60, 12, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(261), "2 teaspoons", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(262), new Guid("7583e5f1-e0c6-4fc9-9248-bf3f4f5abe52") },
                    { 61, 12, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(264), "4 rolls", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(265), new Guid("0aab561c-d345-4702-8a62-b69740554780") },
                    { 62, 12, new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(266), "1/4 cup", new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(266), new Guid("938127dd-fcdd-4330-90aa-a8e486292e1a") }
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
