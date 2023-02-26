using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kitchen.Dal.Migrations
{
    /// <inheritdoc />
    public partial class NavigationPropertiesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("21930088-e904-4877-84b3-a954d368fae9"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("2b85f524-0d7e-447f-b9ac-b46023384992"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("712e518a-8125-4ec3-a5df-8c2a69c7f0de"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("9d7cb5e6-fe2e-440c-a4d5-2457f8ba8379"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("a2594f78-2b65-47b0-8921-4760158d4fe2"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("b4cc4130-cc96-47d2-b3a0-8359fb21f8bd"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("be5e9282-d654-4a9c-afb7-ab309b37509a"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("c033f364-deaa-47dc-bad0-c8058f5f20ea"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("cf60f7d5-0883-441d-9134-01449a413a9e"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("d2641291-0f29-4343-a150-74de7fb1f64f"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("ea7c27f4-60dc-4027-947e-0866d22fee4f"));

            migrationBuilder.DeleteData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: new Guid("fe911656-6bae-4b2a-9a6a-bc36436da66e"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
