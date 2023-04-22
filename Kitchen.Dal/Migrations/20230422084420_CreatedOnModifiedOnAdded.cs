using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kitchen.Dal.Migrations
{
    /// <inheritdoc />
    public partial class CreatedOnModifiedOnAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("0f923e74-5c88-4c77-84d6-f30aa8c3467c"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("2e47d757-562f-4b3d-ac62-ca97929d1bfd"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("47073443-4c87-439b-bcfc-180150aa2c32"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("93ebf5c1-9b19-4147-8511-28299c37d4ad"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("b530b834-c4a1-40c6-8406-c600b02be770"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("beae6240-0f85-486e-aeb7-26317a6a16f5"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("cd98a3ba-c379-4298-b086-4191842807f8"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("da3c28dc-0986-43d7-8776-9406b8a84316"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("da4a68d1-7c18-4c86-826a-ce6651b49e11"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f4631a1e-b36f-4fe6-ad0b-1c68ca83491d"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f6b26804-3802-45ca-9c31-0e81d9850a5e"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("fa214c86-eaf1-41a3-b163-bbf94b9415ed"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "RecipeIngredient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "RecipeIngredient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "RecipeCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "RecipeCategory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Recipe",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "PreparationStep",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "PreparationStep",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Ingredient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Ingredient",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0001-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9466), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0002-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9474), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0003-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9475), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0004-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9477), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0005-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9479), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0006-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9481), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0007-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9482), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0008-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9484), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0009-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9486), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.InsertData(
                table: "PreparationStep",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "RecipeId", "Step", "StepNumber", "Title" },
                values: new object[,]
                {
                    { new Guid("697b1ce9-3742-46a3-b4d3-1aac1c85ccc3"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9783), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9783), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" },
                    { new Guid("77453b9a-d280-46f7-9c2c-97e373beb347"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9776), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9776), new Guid("00000000-0000-0000-0003-000000000000"), "Fry the bacon", 1, "Fry bacon" },
                    { new Guid("83a983fe-cd31-49e1-931c-f1159d709224"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9778), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9779), new Guid("00000000-0000-0000-0003-000000000000"), "Cook the eggs", 2, "Cook eggs" },
                    { new Guid("936aaca7-e338-4dc4-a0b1-d1cec09e9f7e"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9788), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9788), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bechamel", 2, "Prepare bechamel" },
                    { new Guid("a0705644-1f40-4584-a099-febdc5c6ebfc"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9785), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9786), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bolognese", 1, "Prepare bolognese" },
                    { new Guid("a7507924-f063-4ace-82ae-f3b547c83679"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9790), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9791), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the lasagna and place it in the oven.", 3, "Prepare lasagna" },
                    { new Guid("c18c2dd8-b519-4e6a-b565-7dff0205816d"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9755), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9755), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the bacon", 2, "Cook bacon" },
                    { new Guid("d10b9555-89d4-41d1-9f9f-b79685f8720d"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9752), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9752), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the eggs", 1, "Cook eggs" },
                    { new Guid("da450b8c-3871-40a7-baf2-cff40a9c1a11"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9781), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9781), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the beef and the bacon", 1, "Cook beef and bacon" },
                    { new Guid("e77f5d3d-2f7e-41de-864d-462fcbba2be7"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9774), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9774), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" },
                    { new Guid("f171fb68-ec05-41d6-bd82-8a6f86dde823"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9760), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9760), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the guanciale", 1, "Cook guanciale" },
                    { new Guid("f6902172-eab3-4c6a-82b7-5e6a8aa24bda"), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9757), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9758), new Guid("00000000-0000-0000-0001-000000000000"), "Fry the bread", 3, "Fry bread" }
                });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9432), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9436), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9440), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9443), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9447), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9147), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9150), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9153), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9665), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9673), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9667), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9682), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9691), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9669), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9684), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9676), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9689), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9678), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0006-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9680), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9671), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9686), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9693), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9697), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0008-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9695), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0008-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9699), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0009-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9702), new DateTime(2023, 4, 22, 8, 44, 20, 102, DateTimeKind.Utc).AddTicks(9702) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("697b1ce9-3742-46a3-b4d3-1aac1c85ccc3"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("77453b9a-d280-46f7-9c2c-97e373beb347"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("83a983fe-cd31-49e1-931c-f1159d709224"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("936aaca7-e338-4dc4-a0b1-d1cec09e9f7e"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a0705644-1f40-4584-a099-febdc5c6ebfc"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a7507924-f063-4ace-82ae-f3b547c83679"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("c18c2dd8-b519-4e6a-b565-7dff0205816d"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("d10b9555-89d4-41d1-9f9f-b79685f8720d"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("da450b8c-3871-40a7-baf2-cff40a9c1a11"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("e77f5d3d-2f7e-41de-864d-462fcbba2be7"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f171fb68-ec05-41d6-bd82-8a6f86dde823"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f6902172-eab3-4c6a-82b7-5e6a8aa24bda"));

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "RecipeIngredient");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "RecipeIngredient");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "RecipeCategory");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "RecipeCategory");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "PreparationStep");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "PreparationStep");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Ingredient");

            migrationBuilder.InsertData(
                table: "PreparationStep",
                columns: new[] { "Id", "RecipeId", "Step", "StepNumber", "Title" },
                values: new object[,]
                {
                    { new Guid("0f923e74-5c88-4c77-84d6-f30aa8c3467c"), new Guid("00000000-0000-0000-0001-000000000000"), "Fry the bread", 3, "Fry bread" },
                    { new Guid("2e47d757-562f-4b3d-ac62-ca97929d1bfd"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the beef and the bacon", 1, "Cook beef and bacon" },
                    { new Guid("47073443-4c87-439b-bcfc-180150aa2c32"), new Guid("00000000-0000-0000-0003-000000000000"), "Fry the bacon", 1, "Fry bacon" },
                    { new Guid("93ebf5c1-9b19-4147-8511-28299c37d4ad"), new Guid("00000000-0000-0000-0003-000000000000"), "Cook the eggs", 2, "Cook eggs" },
                    { new Guid("b530b834-c4a1-40c6-8406-c600b02be770"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bechamel", 2, "Prepare bechamel" },
                    { new Guid("beae6240-0f85-486e-aeb7-26317a6a16f5"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the lasagna and place it in the oven.", 3, "Prepare lasagna" },
                    { new Guid("cd98a3ba-c379-4298-b086-4191842807f8"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" },
                    { new Guid("da3c28dc-0986-43d7-8776-9406b8a84316"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the guanciale", 1, "Cook guanciale" },
                    { new Guid("da4a68d1-7c18-4c86-826a-ce6651b49e11"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the bacon", 2, "Cook bacon" },
                    { new Guid("f4631a1e-b36f-4fe6-ad0b-1c68ca83491d"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the eggs", 1, "Cook eggs" },
                    { new Guid("f6b26804-3802-45ca-9c31-0e81d9850a5e"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bolognese", 1, "Prepare bolognese" },
                    { new Guid("fa214c86-eaf1-41a3-b163-bbf94b9415ed"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" }
                });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 19, 6, 41, 22, 36, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 19, 6, 41, 22, 36, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 19, 6, 41, 22, 36, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 19, 6, 41, 22, 36, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 4, 19, 6, 41, 22, 36, DateTimeKind.Utc).AddTicks(2166));
        }
    }
}
