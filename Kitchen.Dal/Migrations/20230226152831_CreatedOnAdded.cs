using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kitchen.Dal.Migrations
{
    /// <inheritdoc />
    public partial class CreatedOnAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("0722f65b-9dc0-470f-9afb-c63123b2bb7d"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("1ad399bd-1a39-40c8-a136-68852b575c3c"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("83b3dfc8-748e-4bc4-a076-1a9d92447a64"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("91b2f40f-deb7-45e3-b349-aa47d9b25286"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a187d36d-3f26-4313-8b83-58266f91a787"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("b516d79d-687f-4066-9916-4110002452db"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("c11fa21c-eef8-482a-932d-60172151bf62"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("c13aa542-b531-43d8-acd6-5965003ebfac"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("dea0707e-aa8e-4b89-ab4f-9b5360f1a2e4"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("ea62ff61-ba4a-4f8e-804a-ff1c0b428d9f"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("f30bf39b-fd76-43a9-b7a5-de6f31512490"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("fd567ddf-8bee-41fb-bec2-aa06b1e1a296"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Recipe",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Recipe");

            migrationBuilder.InsertData(
                table: "PreparationStep",
                columns: new[] { "Id", "RecipeId", "Step", "Title" },
                values: new object[,]
                {
                    { new Guid("0722f65b-9dc0-470f-9afb-c63123b2bb7d"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the guanciale", "Cook guanciale" },
                    { new Guid("1ad399bd-1a39-40c8-a136-68852b575c3c"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the spaghetti", "Cook spaghetti" },
                    { new Guid("83b3dfc8-748e-4bc4-a076-1a9d92447a64"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the bacon", "Cook bacon" },
                    { new Guid("91b2f40f-deb7-45e3-b349-aa47d9b25286"), new Guid("00000000-0000-0000-0001-000000000000"), "Fry the bread", "Fry bread" },
                    { new Guid("a187d36d-3f26-4313-8b83-58266f91a787"), new Guid("00000000-0000-0000-0002-000000000000"), "Cook the spaghetti", "Cook spaghetti" },
                    { new Guid("b516d79d-687f-4066-9916-4110002452db"), new Guid("00000000-0000-0000-0001-000000000000"), "Cook the eggs", "Cook eggs" },
                    { new Guid("c11fa21c-eef8-482a-932d-60172151bf62"), new Guid("00000000-0000-0000-0003-000000000000"), "Fry the bacon", "Fry bacon" },
                    { new Guid("c13aa542-b531-43d8-acd6-5965003ebfac"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bolognese", "Prepare bolognese" },
                    { new Guid("dea0707e-aa8e-4b89-ab4f-9b5360f1a2e4"), new Guid("00000000-0000-0000-0003-000000000000"), "Cook the eggs", "Cook eggs" },
                    { new Guid("ea62ff61-ba4a-4f8e-804a-ff1c0b428d9f"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the bechamel", "Prepare bechamel" },
                    { new Guid("f30bf39b-fd76-43a9-b7a5-de6f31512490"), new Guid("00000000-0000-0000-0004-000000000000"), "Cook the beef and the bacon", "Cook beef and bacon" },
                    { new Guid("fd567ddf-8bee-41fb-bec2-aa06b1e1a296"), new Guid("00000000-0000-0000-0005-000000000000"), "Prepare the lasagna and place it in the oven.", "Prepare lasagna" }
                });
        }
    }
}
