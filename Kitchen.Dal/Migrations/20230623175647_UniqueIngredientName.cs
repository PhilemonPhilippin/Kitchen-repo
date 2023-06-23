using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kitchen.Dal.Migrations
{
    /// <inheritdoc />
    public partial class UniqueIngredientName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0001-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1283), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0002-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1286), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0003-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1288), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0004-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1290), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0005-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1291), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0006-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1293), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0007-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1295), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0008-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1297), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0009-0000-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1298), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1299) });

            migrationBuilder.InsertData(
                table: "PreparationStep",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "RecipeId", "Step", "StepNumber", "Title" },
                values: new object[,]
                {
                    { new Guid("18a6bb19-2769-4b45-8f3a-150003941648"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1508), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1508), new Guid("00000000-0000-0000-0003-000000000000"), "Fry the bacon", 1, "Fry bacon" },
                    { new Guid("2c6781ad-7f66-4a96-b84d-5c9c73ecdf5a"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1500), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1501), new Guid("00000000-0000-0000-0001-000000000000"), "Fry the bread", 3, "Fry bread" },
                    { new Guid("58f0e25c-aa46-4c12-be8b-b64dfbe8ea09"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1520), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1520), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bolognese", 1, "Prepare bolognese" },
                    { new Guid("97614178-174e-4578-a0d0-303912630916"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1513), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1513), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the beef and the bacon", 1, "Cook beef and bacon" },
                    { new Guid("a8f55d3d-8b9f-4225-9924-d8d6e6ef3ece"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1524), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1525), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the lasagna and place it in the oven.", 3, "Prepare lasagna" },
                    { new Guid("b7eb004f-304d-43aa-9a30-0800b3a2b8a4"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1503), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1503), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the guanciale", 1, "Cook guanciale" },
                    { new Guid("bc874d63-1e88-40dd-9b7c-89dc55466211"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1498), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1498), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the bacon", 2, "Cook bacon" },
                    { new Guid("bfc02844-cf71-44c5-9557-7900e5c7fe4c"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1510), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1511), new Guid("00000000-0000-0000-0003-000000000000"), "Cook the eggs", 2, "Cook eggs" },
                    { new Guid("cf49e458-b5b5-44e4-972a-14ecdc894d62"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1495), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1495), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the eggs", 1, "Cook eggs" },
                    { new Guid("debf39df-3a98-4bd7-b085-6a9c5463ea64"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1505), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1506), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" },
                    { new Guid("e5c19e1b-9c8a-49bb-848d-f07529226af1"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1522), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1522), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bechamel", 2, "Prepare bechamel" },
                    { new Guid("f3b22d7a-7a8b-413d-95c5-eaa489dafdb5"), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1517), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1518), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the spaghetti", 2, "Cook spaghetti" }
                });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1246), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1251), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1258), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1262), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1265), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1105), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1110), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1113), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1317), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0001-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1326), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1319), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1335), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0002-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1344), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1321), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0003-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1337), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1328), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0004-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1341), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0005-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1330), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0006-0000-000000000000"), new Guid("00000000-0000-0000-0002-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1332), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0001-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1323), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0003-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1339), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1380), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0007-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1385), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0008-0000-000000000000"), new Guid("00000000-0000-0000-0004-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1383), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0008-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1387), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { new Guid("00000000-0000-0009-0000-000000000000"), new Guid("00000000-0000-0000-0005-000000000000") },
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1389), new DateTime(2023, 6, 23, 17, 56, 47, 556, DateTimeKind.Utc).AddTicks(1390) });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_Name",
                table: "Ingredient",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ingredient_Name",
                table: "Ingredient");

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("18a6bb19-2769-4b45-8f3a-150003941648"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("2c6781ad-7f66-4a96-b84d-5c9c73ecdf5a"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("58f0e25c-aa46-4c12-be8b-b64dfbe8ea09"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("97614178-174e-4578-a0d0-303912630916"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a8f55d3d-8b9f-4225-9924-d8d6e6ef3ece"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("b7eb004f-304d-43aa-9a30-0800b3a2b8a4"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("bc874d63-1e88-40dd-9b7c-89dc55466211"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("bfc02844-cf71-44c5-9557-7900e5c7fe4c"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("cf49e458-b5b5-44e4-972a-14ecdc894d62"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("debf39df-3a98-4bd7-b085-6a9c5463ea64"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("e5c19e1b-9c8a-49bb-848d-f07529226af1"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f3b22d7a-7a8b-413d-95c5-eaa489dafdb5"));

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
    }
}
