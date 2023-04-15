using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kitchen.Dal.Migrations
{
    /// <inheritdoc />
    public partial class RemovedSInClassNam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "RecipeIngredient",
                columns: table => new
                {
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                table: "PreparationStep",
                columns: new[] { "Id", "RecipeId", "Step", "StepNumber", "Title" },
                values: new object[,]
                {
                    { new Guid("0df8d63d-bd80-4c7c-bbf7-5c1f60fb617c"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bolognese", 1, "Prepare bolognese" },
                    { new Guid("237f9318-d851-425e-ac94-1275c11fdc8a"), new Guid("00000000-0000-0000-0001-000000000000"), "Fry the bread", 3, "Fry bread" },
                    { new Guid("39a41b07-4655-4a69-a0f1-ccdb3dabfb53"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the bacon", 2, "Cook bacon" },
                    { new Guid("3ac40bd1-4324-4911-83b1-420df21d5098"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" },
                    { new Guid("7adf5603-aa0c-42a7-a038-a76162136976"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bechamel", 2, "Prepare bechamel" },
                    { new Guid("a1944093-7e05-4216-bc6b-760cb028a3b9"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the lasagna and place it in the oven.", 3, "Prepare lasagna" },
                    { new Guid("a36041ca-d1d4-4a36-853f-54c961df4b2d"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" },
                    { new Guid("a3de63ef-178a-40fb-9579-185d3f554857"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the beef and the bacon", 1, "Cook beef and bacon" },
                    { new Guid("bba2ae4e-cdff-415f-b970-c27c10bd1960"), new Guid("00000000-0000-0000-0003-000000000000"), "Cook the eggs", 2, "Cook eggs" },
                    { new Guid("e2db5192-e44e-4863-b2bc-b6ddc7c173a5"), new Guid("00000000-0000-0000-0003-000000000000"), "Fry the bacon", 1, "Fry bacon" },
                    { new Guid("f3e85371-e6bc-47ff-ace3-bfb7e3fb702c"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the guanciale", 1, "Cook guanciale" },
                    { new Guid("f9fdbe21-1538-4f16-84ce-062ef7947d62"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the eggs", 1, "Cook eggs" }
                });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 15, 15, 15, 50, 600, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 15, 15, 15, 50, 600, DateTimeKind.Utc).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 15, 15, 15, 50, 600, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 15, 15, 15, 50, 600, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 15, 15, 15, 50, 600, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.InsertData(
                table: "RecipeIngredient",
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
                name: "IX_RecipeIngredient_RecipeId",
                table: "RecipeIngredient",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeIngredient");

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("0df8d63d-bd80-4c7c-bbf7-5c1f60fb617c"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("237f9318-d851-425e-ac94-1275c11fdc8a"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("39a41b07-4655-4a69-a0f1-ccdb3dabfb53"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("3ac40bd1-4324-4911-83b1-420df21d5098"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("7adf5603-aa0c-42a7-a038-a76162136976"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a1944093-7e05-4216-bc6b-760cb028a3b9"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a36041ca-d1d4-4a36-853f-54c961df4b2d"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a3de63ef-178a-40fb-9579-185d3f554857"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("bba2ae4e-cdff-415f-b970-c27c10bd1960"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("e2db5192-e44e-4863-b2bc-b6ddc7c173a5"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f3e85371-e6bc-47ff-ace3-bfb7e3fb702c"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f9fdbe21-1538-4f16-84ce-062ef7947d62"));

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
    }
}
