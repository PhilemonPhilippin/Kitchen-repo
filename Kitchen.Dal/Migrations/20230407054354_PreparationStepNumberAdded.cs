using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kitchen.Dal.Migrations
{
    /// <inheritdoc />
    public partial class PreparationStepNumberAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("0f770cf3-f564-4b42-8b86-8608c38c5edb"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("11d067fa-2016-41e7-938d-7a95b8a87123"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("3e232b89-f30d-414a-b1bd-3a9b1b831daf"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("431df0bd-0577-4c0c-8c85-4f2226bbd4d0"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("530e710b-e1d8-42e4-a3b7-da500a781d89"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("8d04ce03-7802-4a52-ba5f-4ec86c28cf76"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("93a3d731-e8a8-44ae-a294-df977e747470"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a15293f3-57d4-4b70-b63e-9af2a069b452"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("c970f348-5137-44d1-ba90-c05c939b9062"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("cc17f8cf-09a4-485b-89b2-d8c1ed29fbc5"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("e365c528-d922-4765-a724-8786f0d16cb8"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("fb0e49e1-a5a3-464e-a573-a03e16162cac"));

            migrationBuilder.AddColumn<int>(
                name: "StepNumber",
                table: "PreparationStep",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "StepNumber",
                table: "PreparationStep");

            migrationBuilder.InsertData(
                table: "PreparationStep",
                columns: new[] { "Id", "RecipeId", "Step", "Title" },
                values: new object[,]
                {
                    { new Guid("0f770cf3-f564-4b42-8b86-8608c38c5edb"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bechamel", "Prepare bechamel" },
                    { new Guid("11d067fa-2016-41e7-938d-7a95b8a87123"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the bacon", "Cook bacon" },
                    { new Guid("3e232b89-f30d-414a-b1bd-3a9b1b831daf"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the spaghetti", "Cook spaghetti" },
                    { new Guid("431df0bd-0577-4c0c-8c85-4f2226bbd4d0"), new Guid("00000000-0000-0000-0003-000000000000"), "Cook the eggs", "Cook eggs" },
                    { new Guid("530e710b-e1d8-42e4-a3b7-da500a781d89"), new Guid("00000000-0000-0000-0003-000000000000"), "Fry the bacon", "Fry bacon" },
                    { new Guid("8d04ce03-7802-4a52-ba5f-4ec86c28cf76"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the eggs", "Cook eggs" },
                    { new Guid("93a3d731-e8a8-44ae-a294-df977e747470"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bolognese", "Prepare bolognese" },
                    { new Guid("a15293f3-57d4-4b70-b63e-9af2a069b452"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the spaghetti", "Cook spaghetti" },
                    { new Guid("c970f348-5137-44d1-ba90-c05c939b9062"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the guanciale", "Cook guanciale" },
                    { new Guid("cc17f8cf-09a4-485b-89b2-d8c1ed29fbc5"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the lasagna and place it in the oven.", "Prepare lasagna" },
                    { new Guid("e365c528-d922-4765-a724-8786f0d16cb8"), new Guid("00000000-0000-0000-0001-000000000000"), "Fry the bread", "Fry bread" },
                    { new Guid("fb0e49e1-a5a3-464e-a573-a03e16162cac"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the beef and the bacon", "Cook beef and bacon" }
                });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 3, 22, 7, 22, 49, 117, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 3, 22, 7, 22, 49, 117, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 3, 22, 7, 22, 49, 117, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 3, 22, 7, 22, 49, 117, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 3, 22, 7, 22, 49, 117, DateTimeKind.Utc).AddTicks(3262));
        }
    }
}
