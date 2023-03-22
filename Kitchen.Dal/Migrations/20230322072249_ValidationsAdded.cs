using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kitchen.Dal.Migrations
{
    /// <inheritdoc />
    public partial class ValidationsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("17894226-3453-4f7b-8595-7a1f8a4705b9"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("24115123-84ac-4fe2-8ad6-445f00dc5c18"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("4168f5ba-6759-4e42-b8b6-f9faa3216573"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("7484bd7b-2ea1-47d4-aa2f-f64cffcc752e"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("74bcfb3d-f016-4317-909e-6300cc8da44d"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("7c034664-9ed3-44c3-a3c6-4de1824bf6d9"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("82682061-4d5d-4a81-af3d-4ad692b3692b"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("8fe5eff8-5206-43ba-938c-9c6778e93f5a"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("97372c90-7480-42aa-93b0-e129e85870a6"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("b68a6568-638e-4c94-bf1f-3ba5c8bada37"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("bfd9fef8-ca01-4211-abb5-ed51bc771420"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("ee56ba65-d6d2-4cd6-8ea2-440279e96aef"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "RecipeCategory",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RecipeCategory",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Recipe",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Recipe",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "PreparationStep",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Step",
                table: "PreparationStep",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ingredient",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ingredient",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "RecipeCategory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RecipeCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Recipe",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Recipe",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "PreparationStep",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Step",
                table: "PreparationStep",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ingredient",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ingredient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "PreparationStep",
                columns: new[] { "Id", "RecipeId", "Step", "Title" },
                values: new object[,]
                {
                    { new Guid("17894226-3453-4f7b-8595-7a1f8a4705b9"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the eggs", "Cook eggs" },
                    { new Guid("24115123-84ac-4fe2-8ad6-445f00dc5c18"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the guanciale", "Cook guanciale" },
                    { new Guid("4168f5ba-6759-4e42-b8b6-f9faa3216573"), new Guid("00000000-0000-0000-0003-000000000000"), "Fry the bacon", "Fry bacon" },
                    { new Guid("7484bd7b-2ea1-47d4-aa2f-f64cffcc752e"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the spaghetti", "Cook spaghetti" },
                    { new Guid("74bcfb3d-f016-4317-909e-6300cc8da44d"), new Guid("00000000-0000-0000-0003-000000000000"), "Cook the eggs", "Cook eggs" },
                    { new Guid("7c034664-9ed3-44c3-a3c6-4de1824bf6d9"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the beef and the bacon", "Cook beef and bacon" },
                    { new Guid("82682061-4d5d-4a81-af3d-4ad692b3692b"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the lasagna and place it in the oven.", "Prepare lasagna" },
                    { new Guid("8fe5eff8-5206-43ba-938c-9c6778e93f5a"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bechamel", "Prepare bechamel" },
                    { new Guid("97372c90-7480-42aa-93b0-e129e85870a6"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the spaghetti", "Cook spaghetti" },
                    { new Guid("b68a6568-638e-4c94-bf1f-3ba5c8bada37"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the bacon", "Cook bacon" },
                    { new Guid("bfd9fef8-ca01-4211-abb5-ed51bc771420"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bolognese", "Prepare bolognese" },
                    { new Guid("ee56ba65-d6d2-4cd6-8ea2-440279e96aef"), new Guid("00000000-0000-0000-0001-000000000000"), "Fry the bread", "Fry bread" }
                });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0001-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 26, 15, 28, 31, 203, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0002-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 26, 15, 28, 31, 203, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0003-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 26, 15, 28, 31, 203, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0004-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 26, 15, 28, 31, 203, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0005-000000000000"),
                column: "CreatedOn",
                value: new DateTime(2023, 2, 26, 15, 28, 31, 203, DateTimeKind.Utc).AddTicks(9478));
        }
    }
}
