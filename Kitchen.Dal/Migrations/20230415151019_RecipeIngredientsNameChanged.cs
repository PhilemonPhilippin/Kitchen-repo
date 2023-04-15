using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kitchen.Dal.Migrations
{
    /// <inheritdoc />
    public partial class RecipeIngredientsNameChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecipe");

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("1f91b104-744d-43ef-b89d-b2889078d1c7"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("53254823-e986-43f9-87f3-7110ddc3daab"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("63c7ef4c-7156-4402-857f-83c9fd47e180"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("68f4aebc-61a1-4b41-9408-fc900a2d792a"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("86418e6f-5599-48f5-aad6-967db8409910"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a3e438d1-2915-4d4a-9a7c-a29acd572b89"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a9fda9b3-2b9a-4944-9e2c-3e1498a9d271"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("abb0b251-9356-49c1-bef9-ff99d0dcef3d"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("d7481999-82ca-4cfc-beb0-15538fa58e16"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("d74d7340-ec4a-41a2-8127-7e42a5e75540"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f6d94b1f-c3d5-4cd6-8c03-c57b31f0d9fe"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("fc653634-f51e-40b6-882f-55f01d1aa158"));

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.IngredientId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PreparationStep",
                columns: new[] { "Id", "RecipeId", "Step", "StepNumber", "Title" },
                values: new object[,]
                {
                    { new Guid("09db086f-d6a9-47bf-b3bc-4cf7b9aaaef7"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the eggs", 1, "Cook eggs" },
                    { new Guid("0aa61d93-4a8e-40c4-9ebe-8d7b4c27951e"), new Guid("00000000-0000-0000-0003-000000000000"), "Fry the bacon", 1, "Fry bacon" },
                    { new Guid("1870be69-06b6-4431-809b-e537befb9b3e"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the guanciale", 1, "Cook guanciale" },
                    { new Guid("3bc54b3f-6628-4988-ab48-d5db32c96363"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the lasagna and place it in the oven.", 3, "Prepare lasagna" },
                    { new Guid("4724d284-cb2a-47d8-8d5c-11b8929ecd5e"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bolognese", 1, "Prepare bolognese" },
                    { new Guid("94acb1eb-cabd-4795-b827-805cc1bacfe0"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the beef and the bacon", 1, "Cook beef and bacon" },
                    { new Guid("977ba627-d938-4722-aa7e-96a47e345453"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bechamel", 2, "Prepare bechamel" },
                    { new Guid("a0acffd5-e432-4186-a34e-3fd79f1b4bb6"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the bacon", 2, "Cook bacon" },
                    { new Guid("a27109fe-5d02-4987-9e94-b87f481cc6c6"), new Guid("00000000-0000-0000-0001-000000000000"), "Fry the bread", 3, "Fry bread" },
                    { new Guid("af48172b-902c-470c-9e61-f93955a3b126"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" },
                    { new Guid("d110f763-ddd1-46d7-894d-74666d04ec29"), new Guid("00000000-0000-0000-0003-000000000000"), "Cook the eggs", 2, "Cook eggs" },
                    { new Guid("e0d33e6a-7ff6-448d-983d-34f096c3847b"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" }
                });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 15, 15, 10, 19, 53, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 15, 15, 10, 19, 53, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 15, 15, 10, 19, 53, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 15, 15, 10, 19, 53, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 15, 15, 10, 19, 53, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
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

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_RecipeId",
                table: "RecipeIngredients",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("09db086f-d6a9-47bf-b3bc-4cf7b9aaaef7"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("0aa61d93-4a8e-40c4-9ebe-8d7b4c27951e"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("1870be69-06b6-4431-809b-e537befb9b3e"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("3bc54b3f-6628-4988-ab48-d5db32c96363"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("4724d284-cb2a-47d8-8d5c-11b8929ecd5e"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("94acb1eb-cabd-4795-b827-805cc1bacfe0"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("977ba627-d938-4722-aa7e-96a47e345453"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a0acffd5-e432-4186-a34e-3fd79f1b4bb6"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a27109fe-5d02-4987-9e94-b87f481cc6c6"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("af48172b-902c-470c-9e61-f93955a3b126"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("d110f763-ddd1-46d7-894d-74666d04ec29"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("e0d33e6a-7ff6-448d-983d-34f096c3847b"));

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
                columns: new[] { "Id", "RecipeId", "Step", "StepNumber", "Title" },
                values: new object[,]
                {
                    { new Guid("1f91b104-744d-43ef-b89d-b2889078d1c7"), new Guid("00000000-0000-0000-0001-000000000000"), "Fry the bread", 3, "Fry bread" },
                    { new Guid("53254823-e986-43f9-87f3-7110ddc3daab"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the beef and the bacon", 1, "Cook beef and bacon" },
                    { new Guid("63c7ef4c-7156-4402-857f-83c9fd47e180"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the guanciale", 1, "Cook guanciale" },
                    { new Guid("68f4aebc-61a1-4b41-9408-fc900a2d792a"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the eggs", 1, "Cook eggs" },
                    { new Guid("86418e6f-5599-48f5-aad6-967db8409910"), new Guid("00000000-0000-0000-0003-000000000000"), "Fry the bacon", 1, "Fry bacon" },
                    { new Guid("a3e438d1-2915-4d4a-9a7c-a29acd572b89"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" },
                    { new Guid("a9fda9b3-2b9a-4944-9e2c-3e1498a9d271"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the bacon", 2, "Cook bacon" },
                    { new Guid("abb0b251-9356-49c1-bef9-ff99d0dcef3d"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the lasagna and place it in the oven.", 3, "Prepare lasagna" },
                    { new Guid("d7481999-82ca-4cfc-beb0-15538fa58e16"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bolognese", 1, "Prepare bolognese" },
                    { new Guid("d74d7340-ec4a-41a2-8127-7e42a5e75540"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bechamel", 2, "Prepare bechamel" },
                    { new Guid("f6d94b1f-c3d5-4cd6-8c03-c57b31f0d9fe"), new Guid("00000000-0000-0000-0003-000000000000"), "Cook the eggs", 2, "Cook eggs" },
                    { new Guid("fc653634-f51e-40b6-882f-55f01d1aa158"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" }
                });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 7, 5, 43, 54, 763, DateTimeKind.Utc).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 7, 5, 43, 54, 763, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 7, 5, 43, 54, 763, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 7, 5, 43, 54, 763, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 7, 5, 43, 54, 763, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipe_RecipeId",
                table: "IngredientRecipe",
                column: "RecipeId");
        }
    }
}
