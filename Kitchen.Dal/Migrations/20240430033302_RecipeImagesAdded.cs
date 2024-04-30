using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kitchen.Dal.Migrations
{
    /// <inheritdoc />
    public partial class RecipeImagesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Recipe",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6939), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6939), new Guid("f638afba-f44f-490a-b105-d78a40a22fd3") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6942), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6942), new Guid("8ccdc21d-37d4-4126-a375-c66a6afef4ed") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6944), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6944), new Guid("18e66d95-9b2a-4fc0-ade2-828e6f14025c") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6946), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6946), new Guid("6228f5a3-8661-4eda-8a42-63a363f0ce2f") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6949), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6950), new Guid("0de457a7-1e71-4654-8682-2fdf263aa9ab") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6951), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6951), new Guid("0cf3fe11-b1ec-4a35-9a7a-c00f5890bcaa") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6953), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6953), new Guid("07ba9342-3288-4070-b5bf-406713e53997") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6955), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6955), new Guid("e167b258-c6d2-4119-946f-0be34c6bd2b2") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6958), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6958), new Guid("d7a5cf6d-44ed-4376-a66d-28b24005c241") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6960), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6960), new Guid("222529ac-f3e7-4ba5-843d-e2016bdff4f2") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6962), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6962), new Guid("d13ffc2a-c951-43a1-a2c3-6828d5e2f132") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6964), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6964), new Guid("3048c07e-783a-4906-820c-f24cdd254231") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6967), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6967), new Guid("4e921ad5-0896-433f-b9da-886358abae6c") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6969), new Guid("027f3e44-f777-4ee6-bb74-e5034d48c6d7") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6970), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6971), new Guid("bd3b38cc-8aca-4368-bec5-f595c95ccc78") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6973), new Guid("930feb91-4603-477e-b040-9da3f012060e") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6976), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6977), new Guid("ceafd697-bd8e-4e26-a756-89ffef952725") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6978), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6978), new Guid("920cc516-7bf4-41fb-adbe-026eb9a78e1b") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6980), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6980), new Guid("9f100267-0464-40e2-bf65-f86f41ffb546") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6982), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6982), new Guid("ec1fcad7-130a-4f18-8934-38ae1ac065a6") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6985), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6985), new Guid("756580fb-ea94-4edd-9318-55f11777f9b2") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6986), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6987), new Guid("93e786c7-c84b-4d9b-8a4d-ece72c0f1795") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6988), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6988), new Guid("15d15409-cca1-4a41-b565-f603dc0054be") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6990), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6990), new Guid("bd9f0741-8569-4a03-ad96-4b61993fb414") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6993), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6993), new Guid("6f9773da-bc9d-4602-bf12-0321cea52abf") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6995), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6995), new Guid("7239d792-5d9b-40af-9a87-75f7dfd94783") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6997), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6997), new Guid("260ddffa-2dd0-4c03-8b5b-918fa7c73378") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6998), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6999), new Guid("ef283c3c-cc3c-49fc-99ca-cf19b06aa556") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7001), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7002), new Guid("72c93e1d-8d47-436b-982b-89376146e836") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7004), new Guid("624ae1f1-66b8-4f0e-9e47-d6bfd4930a1b") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7005), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7005), new Guid("c96c41f7-b646-4eb3-ae5b-c6adb1785460") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7008), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7008), new Guid("ed1404f9-3bc7-44ad-aaa4-575ba4867aa8") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7011), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7011), new Guid("29f8ff4d-9b92-4839-bf86-596a34f78ff5") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7013), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7013), new Guid("b0ae0f16-ef7a-4be1-88af-9f786d3f4fcc") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7015), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7015), new Guid("1d2de715-cf46-4ee3-8d84-525b032c5806") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7016), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7017), new Guid("6c59f026-770d-4320-83e4-1c14167a93ce") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7019), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7020), new Guid("bfc3fd7c-3c0f-4ea8-9529-063a818cab24") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7042), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7043), new Guid("b9e6a025-4fcc-4905-8159-40562db54c02") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7044), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7045), new Guid("9f7c458b-a805-429c-8613-5a5f63dbc27c") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7046), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7047), new Guid("b1212ecd-3463-4534-995b-b2022e4ec680") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7049), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7050), new Guid("db62b139-f21b-4688-96c8-887128cc6669") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7052), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7052), new Guid("1fe22615-a71d-4dcd-a8bd-2309aaab6c4a") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7054), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7054), new Guid("dcec9454-6e76-4696-9e9f-25b710553724") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7055), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7056), new Guid("f34dbfd2-800e-4442-9035-efaebc7106a0") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7059), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7059), new Guid("117eb5b4-f40b-4a1d-9723-1da4156f9627") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7060), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7061), new Guid("e51312c4-1690-4bcd-bd65-0c6a7eda610c") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7062), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7062), new Guid("8930a1a4-b5ea-4611-9c8a-7b039ae2e497") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7065), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7065), new Guid("b966473a-04d3-417e-932a-9b217843989b") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7068), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7069), new Guid("1e4908da-6e3d-4318-96ce-fdedd841dac4") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7070), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7070), new Guid("e273c5ad-4934-45ad-b3ca-2f0e3a081bbf") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7072), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7072), new Guid("b20b0a87-b36f-4869-918d-265c13b658ea") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7074), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7074), new Guid("ca703ecd-0118-41d8-a203-552644bcbd95") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7077), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7077), new Guid("de269964-f9fa-4a7d-8f2b-8491a218184d") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7079), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7079), new Guid("82944bcc-1112-46cf-b964-63a2d30eda53") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7081), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7081), new Guid("9b362b5e-b3e3-48d1-b268-9bf8bf0408b7") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7082), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7083), new Guid("4b01ef4c-0f87-411d-8c82-c8f4d69e7d52") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7085), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7086), new Guid("e569beca-9e4f-485f-a41e-542de2ea2803") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7087), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7087), new Guid("38bf1088-dc7c-460d-9a4c-236435261625") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7089), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7089), new Guid("e88e0327-8e1f-4b04-8019-d57b7bfa140e") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7091), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7091), new Guid("2f4a7faa-eb04-4eb9-8e0f-4424e63d021f") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7094), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7094), new Guid("839286b5-b882-4831-8d48-ae5ac9aed460") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7096), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7096), new Guid("5b6ccb86-3127-4a0d-958d-460c03ed4736") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7383), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7383), new Guid("8bb13062-3390-46e1-980e-c123a5eca3f1") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7387), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7388), new Guid("c64a7178-6d87-410a-8189-7914bcfdbed9") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7390), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7390), new Guid("b3fc4168-2371-461a-a3ee-018fba269aae") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7392), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7392), new Guid("167eddae-629e-4b47-a921-72b3b1cee1ef") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7394), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7394), new Guid("428d4397-041d-463f-ad86-12b19fa3605a") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7397), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7398), new Guid("d890b893-f359-43b9-9e36-cb8d91a16435") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7399), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7400), new Guid("6371fd30-94a6-4935-9c0f-8ef51f86f940") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7402), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7402), new Guid("751ecfa2-9211-482b-8428-4f041d948755") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7423), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7423), new Guid("2834eebb-69b9-4f88-98e3-b7ffdd863e7f") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7427), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7427), new Guid("fe2298b0-8577-4861-8957-2cda823c3b66") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7429), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7429), new Guid("85d5bbd6-2742-4ca9-b623-788ad7aad768") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7431), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7431), new Guid("f5d35365-481f-4461-a3ef-9c1a7402da97") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7433), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7433), new Guid("845f52f9-9203-427a-bc33-71a4450a97e4") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7436), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7436), new Guid("efea25b8-1c20-4d9f-bfc0-1bbee77688bf") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7438), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7438), new Guid("34d6a0bb-ebab-4f7e-8d66-29322f11a3c5") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7440), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7441), new Guid("522dec3a-d1c5-482f-9a48-1363506f1334") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7443), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7443), new Guid("b2f67c1f-9d11-473f-90a7-5f6f9dca8d15") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7446), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7447), new Guid("fa9709b1-44f8-4fff-8262-527f78d46a7c") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7448), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7449), new Guid("aebd6622-ec1d-449a-bff3-c0114c8ef533") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7450), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7451), new Guid("42f3368c-2530-4dd9-a174-b26f91742e54") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7452), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7453), new Guid("7958ece8-42a5-4234-8c28-8554f29a2c39") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7455), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7456), new Guid("96ced847-a455-446d-9201-24b07dad57e9") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7457), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7458), new Guid("769bdd9b-1efb-4649-82e1-29be6319cc2a") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7459), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7460), new Guid("b55c7a8c-db87-4b00-903d-080a64ecffdb") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7462), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7462), new Guid("3e11f739-6a44-4675-b850-baa73c3a6031") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7465), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7465), new Guid("a1c8b500-a1de-4f32-8759-c6a3df0c02b2") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7467), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7467), new Guid("17dd0291-1edd-43f8-875e-e2b6d227ba3d") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7469), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7469), new Guid("a018ea07-503a-4d59-9791-1e44861fb346") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7472), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7472), new Guid("3b29b0e1-6de5-4520-9bc8-9eef50f78a17") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7475), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7475), new Guid("db5a4efe-e9c3-44fc-b2a8-e70f661016da") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7477), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7478), new Guid("73db3fcf-8940-4df0-966e-152b7ed8a31f") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7479), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7480), new Guid("c13738e8-a58b-45d6-a1d9-00ac555bd68d") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7482), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7482), new Guid("e5db665b-15d4-4222-a31a-5de3e86a9c17") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7485), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7485), new Guid("3a1be0ae-2554-4f78-b9a5-1155348a0494") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7487), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7487), new Guid("4ec1b204-5a28-4cd0-95dd-10735af155dd") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7489), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7489), new Guid("56aa9cdd-1973-4691-96e3-c02bd46eb1b8") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7491), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7491), new Guid("b9aa497c-2c0a-45f4-9bd9-f4e4cdad9501") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7494), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7494), new Guid("806bcf68-6c20-4c8a-99fc-36c9c8e6db58") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7496), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7496), new Guid("96cf0065-74d1-457f-a916-f080b199e513") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7498), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7498), new Guid("58781f0d-8a6b-4321-9042-5c6c96ba17ef") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7501), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7501), new Guid("78db4825-8dfc-49ef-b7e0-5d347c61401e") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7504), new Guid("51f7ddd8-445f-4381-82b8-d4400cd01465") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7506), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7506), new Guid("68c49208-f1c5-447c-b3d3-942b9cf94f53") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7508), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7508), new Guid("a951f784-9958-44e1-8d64-1b2dd95e7753") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7510), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7510), new Guid("2074fdbf-87a1-4502-b2d5-2443e59f678f") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7513), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7513), new Guid("17079a84-0561-4a67-bbc0-3781b07b5fed") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7515), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7515), new Guid("835d5214-3509-4eb4-90b6-8c1eb1b78ccf") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7517), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7517), new Guid("3d3f6327-e66b-4a80-9b09-0865652d748b") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7519), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7520), new Guid("b47c4c53-9e24-418b-887d-d71452c46ac7") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7522), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7523), new Guid("33d3c9f1-f9cc-4760-a8f3-50edf425d900") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7524), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7525), new Guid("b2c3b43a-0229-4c60-a8cb-31db2af9aea5") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7526), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7527), new Guid("a24cc51d-e841-41fa-bb4e-f1892c8bd397") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7529), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7529), new Guid("71358af4-3c44-4c32-893f-4ec6f3e02cee") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7532), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7532), new Guid("2543daaf-177a-4786-b830-4b45262c7c3b") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7534), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7534), new Guid("c4426499-e83e-454f-8c31-a20de7bb6da7") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7536), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7536), new Guid("73caeeac-14f7-44cf-bbc0-9f5c6e549d3c") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7538), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7538), new Guid("5ac95473-56b1-44d0-9bd1-856cd54a9996") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7541), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7541), new Guid("76e86378-7249-4990-9cc9-a7a68254bd1c") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6887), "english_breakfast.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6888), new Guid("340fa37b-32d8-429a-b6b2-d04607f288f3") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6891), "chicken_salad.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6891), new Guid("fd9fb483-a555-4585-a2c6-a92f4c869281") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6895), "thai_omelet.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6896), new Guid("ab6bb581-154e-4256-806f-7667abfbaf67") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6901), "italian_salad.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6901), new Guid("aa414ed7-e6a8-4642-9766-a5d910c1ee87") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6905), "grilled_peppers.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6906), new Guid("85d70cc8-21a2-439e-ac4a-d51f4fa6572a") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6908), "plantain_chips.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6908), new Guid("46b6ec32-b09a-46e1-bf9d-ef5cad23bf09") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6911), "tomato_soup.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6911), new Guid("4ae7a1ac-6a06-4c5b-bcfa-eb3d4c75d905") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6913), "butternut_squash_apple_soup.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6913), new Guid("9df9fc35-de28-4dbf-b72b-96213dd2aa9c") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6916), "broccoli_cheddar_soup.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6917), new Guid("47c90f54-180f-4aa7-8cf7-da594e98f91c") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6918), "cavatappi_pasta.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6919), new Guid("1260a9c4-7af7-4a24-8505-51e434dd3c2a") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6920), "shrimp_and_asparagus_pasta.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6921), new Guid("5a40f457-9c14-464c-8e1d-9e96b623d203") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "Image", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6923), "grilled_chicken_caprese_sandwich.png", new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6923), new Guid("16d1e009-530e-4d07-9084-4337376a5268") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6784), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6785), new Guid("2d920299-0ef4-4678-ba67-5d8f6dae1c9d") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6787), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6788), new Guid("971d6952-6d63-47de-b845-232185e10649") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6790), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6790), new Guid("c8e0bcef-ac34-4cb2-acfb-cd41e591aa2f") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6799), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6800), new Guid("8738326d-13e4-436e-ac7b-2b566d78785b") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6802), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6802), new Guid("e2c6d00f-6a87-469d-9fe1-3c28ab309f94") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6804), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6804), new Guid("4e9b5357-9dcc-4eff-816c-f51ab2968069") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6806), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(6806), new Guid("05fbb377-d7f1-4b7a-ae6a-5d0c24ee02db") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7119), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7120), new Guid("86971bec-b27e-495d-8873-039503c8e0de") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7122), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7122), new Guid("b33069d5-e433-4806-bcea-39aaeb62db30") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7125), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7126), new Guid("b3603a93-9588-44d3-a98d-3cb3ae3e7f33") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7161), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7161), new Guid("d5a8624f-b4f7-4ed5-b15a-600d0b7690f5") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7127), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7128), new Guid("99dccdc2-c6bc-4d05-9a01-368218650dc5") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7351), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7351), new Guid("62b82a20-a57e-428e-a613-17e7bd05eafc") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7129), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7130), new Guid("5b27d6c8-e780-4a46-bb7e-a21f7108fad8") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7131), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7132), new Guid("87b3622f-b4d8-4dd7-9131-8892ffe118ab") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7134), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7135), new Guid("a761455d-a171-46e3-8302-fdce2696691f") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7136), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7136), new Guid("e5f25d01-0ee3-486a-a2e2-06ec450b4c31") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7178), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7178), new Guid("e99f303e-b7ca-49b6-84a1-45d69644f2f7") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7196), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7196), new Guid("22915ab0-f832-404d-93cf-c09972ac9af7") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7138), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7138), new Guid("7ef4f374-cce9-4964-8358-1dc2b4ba0db4") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7230), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7230), new Guid("db3da527-6ceb-42b3-b6b3-8de76a517e31") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 5 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7240), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7240), new Guid("78f19e4a-4b6e-4b62-8dce-bdcaecabb526") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7140), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7140), new Guid("bdfe02f6-4787-489c-83f6-3e5f9e5cdc66") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7175), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7175), new Guid("1c469fdb-2920-457d-9f9a-53f868c97181") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7143), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7143), new Guid("991cdf7d-89b7-4db3-81b7-fe84b7dde950") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7201), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7202), new Guid("37046992-2c8d-40f8-a2f4-18ae261e856b") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7145), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7145), new Guid("2412d928-b326-49b3-b9ca-f935fe8c4d54") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7166), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7167), new Guid("e2c82be5-dad6-4950-a17d-1822ca53559d") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7147), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7147), new Guid("ddfff879-ea81-4ea6-a465-b4c3d0b8c8f9") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7171), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7171), new Guid("8656a2f0-cc8a-4bbf-adf6-e0f3794f2d8d") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7191), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7192), new Guid("24e99ad6-5776-4b29-9e72-a45577ed6cec") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 5 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7238), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7238), new Guid("581f9fc8-fedd-4db2-9e44-a8fb2b8d7b7f") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 6 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7245), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7245), new Guid("3a819252-fa49-4e00-9381-c297268eb977") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7320), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7321), new Guid("9f1c9ea1-7974-4d63-98e7-fd0dda593dca") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7339), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7339), new Guid("48d21ac4-0955-4cd5-9303-50de28d693f3") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7148), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7149), new Guid("451379f6-a84f-4462-adcf-c1f99b20cc6a") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7152), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7153), new Guid("a43b0ecb-e4a1-4a76-af24-719b9fd00067") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7154), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7154), new Guid("976f2acf-c4da-4490-8ec3-861116ce5c89") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7156), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7156), new Guid("c9bb5ab3-0068-4414-a9fe-010881872048") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7158), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7158), new Guid("4182eb08-8288-412c-b508-7291932ee7d5") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 19, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7163), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7163), new Guid("5a038d3a-71a6-4197-8e6c-1573f0e1faeb") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7165), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7165), new Guid("fd81c805-47b0-4b5c-8cbb-695309b4f5a5") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7169), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7170), new Guid("b8f41d09-529e-4e9e-9548-c74bdb4b4350") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7193), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7193), new Guid("c8640f70-3116-4263-a864-912f5d6bcfa9") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7253), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7254), new Guid("fb5737c3-feae-43ab-baf1-ca643b2c19bc") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7301), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7301), new Guid("a8756d20-6fce-4655-b2c1-a12d30334902") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7173), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7173), new Guid("c27455f1-2e1e-4261-8e10-53792edad3ff") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7180), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7180), new Guid("e0064468-d72a-4aed-84f2-cc9336163f59") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7315), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7315), new Guid("ca196b50-0dd3-4c0a-b469-6da5c8e4bd65") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7182), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7182), new Guid("6ac61e80-ee68-43fa-9ccf-5783c242c552") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7184), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7185), new Guid("f761961f-ead1-442b-95ed-2d7d3de24ca3") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7188), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7188), new Guid("f7d6e2bf-a805-4793-bfc3-891da3895451") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7264), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7264), new Guid("01f93e13-07b2-44ab-bdda-39cfb1540dcd") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 27, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7189), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7190), new Guid("06988453-b732-459f-81e3-242f30befbf6") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 28, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7198), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7198), new Guid("f9c5b37e-4fbc-4253-ace0-c2f26e8ad62c") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 29, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7200), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7200), new Guid("46d9d72a-58e0-4c63-a3a0-57ddd30ce2c7") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7205), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7205), new Guid("8acb12e7-daaa-4844-bc99-6f05f1ca5655") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7207), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7207), new Guid("5ea7a455-f117-447d-ba59-4236e996e7ab") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7347), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7348), new Guid("713dc12d-4956-4ddf-98aa-095ee499b182") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7228), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7228), new Guid("c67cfc9a-8b74-452c-82b3-f33dde447b53") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7233), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7233), new Guid("d5e9a580-e7f8-4153-9cd1-c339f6059a97") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7353), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7353), new Guid("512a56d9-6212-4ea9-8c5e-46f57a99cf26") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 5 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7236), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7236), new Guid("d8f8261f-8803-4420-a1fd-52cd23baff70") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7354), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7355), new Guid("d70455c2-be09-4762-8d1a-ae9a58ae39a8") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, 6 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7243), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7243), new Guid("ccb158dd-3fba-42b1-9578-c817b9d49b94") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7246), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7247), new Guid("a495eab1-c040-4cc3-9928-48206a6cd42b") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7273), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7274), new Guid("5677f8de-dc88-47b7-b3a8-50ff6173c841") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7284), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7284), new Guid("92a96435-faa2-474f-8580-9439e206b0b2") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7306), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7306), new Guid("b3874ec0-45ef-4b52-bbbd-444982ac5c96") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7335), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7335), new Guid("0a0a5e6a-7525-4907-b470-ca8ed657b117") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7248), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7249), new Guid("c5bf2c8a-18ba-4580-b622-66b231b652d3") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7266), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7266), new Guid("4728e8ee-74e8-4ed9-879b-7f9193ac86cb") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7287), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7288), new Guid("6a7804fa-b50d-4c14-a9e6-8290005187cb") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7323), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7324), new Guid("ee63e6c9-67d8-490c-b729-25a0876935de") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7255), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7256), new Guid("9a142803-f1d5-4a1c-be2f-4e5d6e250347") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7291), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7291), new Guid("d4551fbd-81ec-4ef1-81f4-1435433613f8") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7257), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7257), new Guid("b1b03811-fa14-4caa-b39e-cc7d4c5c706d") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7260), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7260), new Guid("eee5fe0b-d88d-4112-9b73-b0403fd86c9d") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 41, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7262), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7262), new Guid("88bbedda-72d7-498f-aa1b-03d9e9bba9d9") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 41, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7280), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7281), new Guid("35976d88-cdea-4dcf-966c-b0463970f13c") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7251), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7252), new Guid("529382a6-8f08-4bb3-a47d-235ab79f1338") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7307), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7308), new Guid("3f91fdd0-4b96-490d-b8d5-13864aaeb26a") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7329), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7329), new Guid("d184e0ed-a48d-4639-a3ff-c7c9071ba3fb") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 43, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7270), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7270), new Guid("cec4d183-be9f-4881-be09-14e6f41ae681") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7272), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7272), new Guid("2aedea2c-0775-4fba-a560-0f777e32849d") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7289), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7289), new Guid("d6cc397e-c330-4e40-8205-d47045f9915c") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7275), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7276), new Guid("6190e6ea-b063-4f7a-95e7-c0d50cf21de0") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7278), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7279), new Guid("cfaa91a5-34bb-4407-a946-b4c09da296dc") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7282), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7283), new Guid("ae168ae2-0b1e-4173-bc00-2ceb44ebb86b") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7293), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7293), new Guid("75770cc2-9f1d-499d-8c3f-73a67324749b") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7296), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7296), new Guid("5ee166b5-5c47-4ee6-adae-e290fcd2cacd") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 50, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7298), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7298), new Guid("a56f5675-9d36-40de-87d6-be9ed9d036d6") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7303), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7303), new Guid("3a9f224d-93d0-40ac-b1d9-cfdabb5a5fcb") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 52, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7309), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7310), new Guid("ca4c4e1f-dcce-4ebc-9eea-edf98dbcf337") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7311), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7311), new Guid("215cff6d-f870-4979-9585-33679f9bde59") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7317), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7317), new Guid("f56e1820-a5bb-4fed-9c47-e9c45a342ee0") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7319), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7319), new Guid("064909b4-4cd6-4f75-82d9-ea9db3138b53") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 56, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7325), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7326), new Guid("9ccc15b9-94d4-4f0e-93f7-7d4524652599") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7327), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7327), new Guid("02380be8-cc24-4442-8669-75cc1bb9c529") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 58, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7332), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7332), new Guid("a6ebbca6-aa9b-40eb-9f6b-5d0c9dd874b1") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 59, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7337), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7337), new Guid("f20ccaf1-f819-4587-acdf-3c601d8946b1") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7342), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7342), new Guid("7d19321d-4bd7-4d97-ac21-885dba8ccab6") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7344), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7344), new Guid("c55ac1fa-78ca-41c1-8266-9ee9355249c1") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7346), new DateTime(2024, 4, 30, 3, 33, 2, 111, DateTimeKind.Utc).AddTicks(7346), new Guid("8b20002c-7b45-4c90-aa84-ec8489c7e34c") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Recipe");

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9883), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9884), new Guid("94b0008c-c8ab-4209-bbd0-671050399aec") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9888), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9888), new Guid("79169bc5-914f-4106-9607-5dd592a0810b") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9890), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9890), new Guid("1f7530b2-7396-462c-a2ac-eba84d22674e") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9892), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9892), new Guid("bb2a24a9-5839-4431-bf38-7411d4643b64") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9893), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9894), new Guid("0e2990c2-a5be-4d2b-94b3-a96a20c85df0") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9896), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9896), new Guid("ad334efc-cae2-4f59-8520-d5e75b848d32") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9898), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9898), new Guid("565932f2-7f39-460e-b531-39df2a2b6302") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9900), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9900), new Guid("fb1094a4-7671-4c91-bafa-ee82af1003a0") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9902), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9903), new Guid("2b18e096-578c-439b-98c2-072c3366aafd") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9905), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9906), new Guid("0a64804b-c331-4f8f-91a3-74a5b1585ec4") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9907), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9908), new Guid("7e70ae41-1c50-43f7-a703-a56385eee1db") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9909), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9910), new Guid("25bf666c-b597-4f1b-9285-d294f0b1b1c4") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9911), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9911), new Guid("c6e5dd62-e3d4-4b53-a62a-aa670f281f52") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9914), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9914), new Guid("6239d4c6-8a36-4c6d-bab2-33903263445f") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9915), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9916), new Guid("ab4c9124-8c86-49fa-8e53-21da7f004e74") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9917), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9917), new Guid("0698676f-995e-43e7-a3b4-ecbc178f3b10") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9919), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9919), new Guid("7373d5d0-5346-4feb-b5d0-93a0cfb74a15") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9923), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9923), new Guid("e3a9c8bf-52a1-4477-ab7f-da2a5e3ac741") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9924), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9925), new Guid("63e1c3c4-9a3d-4d9a-a9bb-77b388788478") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9926), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9926), new Guid("d22615ab-ee83-4a1b-8e09-f97920cf25e3") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9928), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9928), new Guid("4a0f4e83-451b-4764-be6b-b5c203b3094e") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9931), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9931), new Guid("c8e0d070-f027-4844-a4d1-a9477911cd92") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9932), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9933), new Guid("c4ae08f3-2666-4fd4-97f7-92fa3bed5ec2") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9934), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9934), new Guid("16174c96-3c3f-4916-816c-e8a400cd2903") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9936), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9936), new Guid("601f88f4-633e-4a70-b5b9-71a68ff9ab94") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9938), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9939), new Guid("ea64500d-1ef3-460e-a53f-ff946c274904") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9940), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9941), new Guid("3d0a0abd-b9e5-4453-99bb-6eb71ea8c15d") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9942), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9942), new Guid("0dcb0f51-4e2f-4830-a2bc-20554eec7fe4") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9944), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9944), new Guid("22fc6b05-605a-4e93-9ab3-05274ffb1c05") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9947), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9947), new Guid("84a2022b-584e-4c4d-97f4-c2fc9ad4a8cc") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9948), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9949), new Guid("ea7bc0ea-30d6-4b5a-88cd-c4b6660989cb") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9950), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9950), new Guid("e07519d4-7985-41fe-942c-1b1dcf19d6c6") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9952), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9952), new Guid("4c797852-e97f-4bc0-819b-47c8ddf1dfe6") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9955), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9955), new Guid("a17e4e7f-81ee-4f97-99aa-b6a8a6c1dedf") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9956), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9957), new Guid("dd83ebe7-fd8c-44a4-8ba0-96e97828cc01") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9958), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9958), new Guid("43b76b72-1d9f-4f42-8b31-2111655fd7bd") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9960), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9960), new Guid("8ae9439c-50eb-40fe-8d3e-eccf4f6ebcfd") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9963), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9963), new Guid("6b8ffd92-4f71-4006-964d-fbf78fa8516a") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9964), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9965), new Guid("4968579b-9760-4392-89cc-868482cb049e") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9966), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9966), new Guid("96d55998-8c41-4cd4-a7c4-ec363c4b2977") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9968), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9968), new Guid("d296f688-a743-4d2a-826c-07ce56e98f48") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9970), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9971), new Guid("e924a269-c7f4-4465-88a7-e9d567f7caf9") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9992), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9992), new Guid("257308ac-9df6-4b6a-a283-97b3f89abb0e") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9994), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9994), new Guid("8d316ee4-95ff-419f-a94c-c96462d1aabe") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9995), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9996), new Guid("96b45c53-58aa-470b-8fd1-5f1e7ee60114") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9999), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9999), new Guid("e351528b-b4ac-4e04-9e5a-3276af1a5a64") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(1), new Guid("aff04658-9ac6-485d-9f00-3585f62ae9e1") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(2), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(2), new Guid("8413a2f3-6037-4d52-9b5c-e692eaa235d5") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(5), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(5), new Guid("e6ad399e-00cb-4ad1-9a58-637f2b186c9c") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(8), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(8), new Guid("2388cba7-a654-4aa6-8000-87f367502e23") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(10), new Guid("116d1ec4-352f-47ae-b04c-336ca03caf6f") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(11), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(12), new Guid("12838913-70eb-44c1-a067-e4f69f3e7d38") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(13), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(13), new Guid("2ba1e835-18a1-431b-b4db-8e1fb209bc52") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(16), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(16), new Guid("0d384a1f-1e58-4ef1-92da-92f72357aba8") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(18), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(18), new Guid("e038ff90-f637-4f61-8b30-dc2962c017e6") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(19), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(20), new Guid("71de2435-5117-405e-ae9b-cf719bafdaf5") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(21), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(21), new Guid("04f2fb41-2a98-4ac2-8438-7aeba506ceea") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(24), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(24), new Guid("dc0fa34a-ded4-434f-ada5-7a78ac4db48b") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(26), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(26), new Guid("31d5e0c5-d8b8-4c17-810f-1d8938ba0032") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(27), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(28), new Guid("31bedc81-3e3f-4b80-84e6-bfe2d457d66b") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(29), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(29), new Guid("99235c7c-08a5-463d-8a84-f6c8f7076ebd") });

            migrationBuilder.UpdateData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(32), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(32), new Guid("36c3cc80-1c39-4af3-88d6-0ee9bded43de") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(298), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(299), new Guid("e807cab5-07da-42ea-a760-28f17912f369") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(301), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(301), new Guid("5e9f7de8-5249-4464-88a1-2ed01e86c0ce") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(304), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(305), new Guid("b7d9a5f0-b380-4d38-b3ed-1f0002f2e7b5") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(307), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(307), new Guid("4aec61b6-9c73-4e06-abfd-81a313a71552") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(309), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(309), new Guid("8776a416-34b1-4def-beca-4284787a7b09") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(311), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(311), new Guid("4bb355af-275c-4153-af9b-eade3cc5344e") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(314), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(314), new Guid("9b58dda6-379c-4ee3-8776-ec8a2587021c") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(316), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(316), new Guid("e71f21d5-8157-4ce6-9d00-617663bb6d81") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(318), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(318), new Guid("51c0717d-4866-4fdc-a556-5591fc5efb58") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(320), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(320), new Guid("5dd3c820-d826-4164-b2fc-6b8b4a5c50b8") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(323), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(324), new Guid("4b92952d-d201-4944-8c7d-e306bfe781cf") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(325), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(326), new Guid("6ead958c-4df5-4130-b6ad-8e858dab25cb") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(327), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(328), new Guid("6cf73eb5-e225-45e7-9249-3368ecb8e06c") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(329), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(330), new Guid("122c0ac2-514a-4eb4-9d03-ebd027bf2968") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(332), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(333), new Guid("c44f1cea-5c67-4bfe-bc6a-5defcdc044e5") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(334), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(335), new Guid("446baa7e-13c9-431b-b95d-c80104eb7a87") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(356), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(357), new Guid("be71756b-ae05-4a5e-9ea3-322fe8a9564a") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(359), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(359), new Guid("26961468-2cb0-4b62-8142-42c3a8c29da1") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(362), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(362), new Guid("fea5760b-c469-4284-9ad3-2fa902d4437e") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(364), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(364), new Guid("a60ee218-ebff-4f12-8d89-086291528547") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(366), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(366), new Guid("b2dbe131-907d-4435-931e-5fc15a62c15e") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(368), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(368), new Guid("affb9c8c-2eda-44a9-bf7a-ed0c0f31f6af") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(371), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(372), new Guid("9d4adcdc-8e87-40e1-83f4-4002a7c409cc") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(373), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(374), new Guid("75701b0e-81c8-42c3-9031-686005bf2237") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(375), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(376), new Guid("fa3d0ff9-a193-45eb-ae1e-30fc6e7c82fc") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(377), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(378), new Guid("cc3baa17-e16e-4eb2-8c6d-b3c3a6211a14") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(380), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(381), new Guid("b4268826-f845-4a4c-a56d-575df74325bb") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(383), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(383), new Guid("251813de-49b5-4052-a3ee-bac12cc0dcf9") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(385), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(385), new Guid("f10685dd-214b-44df-88a9-cec9960b4196") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(388), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(388), new Guid("eba9fe00-4004-4806-8280-540b1ab9d21b") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(391), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(391), new Guid("5f4efa53-656b-4a69-b94f-4ae5282d43da") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(393), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(393), new Guid("33d6d5a7-b046-40ce-b311-ddb9730dfe5a") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(395), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(395), new Guid("9ecc2a74-3ad4-4c66-8690-6bc96e617249") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(397), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(397), new Guid("0dbdb5c0-6a5a-4682-950e-55fa0edea88a") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(401), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(401), new Guid("669c0920-de47-4a67-b8a5-ac9e491128ac") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(403), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(403), new Guid("d8e4da95-2d2c-46a2-b465-a1f67ee5cee4") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(405), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(405), new Guid("8c812c44-4c50-454b-aa60-8a39c000b256") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(407), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(407), new Guid("944cb2f8-3e8d-4b89-844e-f52f9456249d") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(410), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(410), new Guid("77a0f144-636b-480b-8086-3685f3f00c8e") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(412), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(412), new Guid("4ff3fd96-758b-4678-b67f-f2a9f6e4974c") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(414), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(414), new Guid("09064669-97e6-48c6-9e59-0cf6cd474e6f") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(417), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(417), new Guid("c6873da7-acbb-4476-bcd9-cbed070904ad") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(420), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(420), new Guid("8b7df522-812b-4b2b-976c-a7a4644b7fd9") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(422), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(422), new Guid("2adf933c-1b75-4d74-804b-e7182ce4f48d") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(424), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(424), new Guid("1db3a98d-0a30-4be9-99b3-8328d486d303") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(426), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(426), new Guid("8d61d79d-fba5-4748-b9a3-1f835c560d5f") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(429), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(430), new Guid("7c9c4330-7f0a-4076-8012-b038594671d2") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(431), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(432), new Guid("e674656f-60fc-4e23-84c2-fdaba47a10e4") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(433), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(434), new Guid("6b62bc8d-3fdf-45f3-9a4e-1b153df962c1") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(435), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(436), new Guid("89e61db4-a580-4d0e-a5c3-00e036a444dd") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(438), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(439), new Guid("92424209-8023-440a-9f26-d86d77147d57") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(441), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(441), new Guid("5ccd9a0f-57af-4e20-beb0-1e8fb76de567") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(442), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(443), new Guid("4a0cbb01-e6a2-489f-a15f-c104a80deeb0") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(444), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(445), new Guid("6b348226-d7dc-4671-99f1-730ce5bf5c28") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(448), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(448), new Guid("d4c14b2c-689c-44ad-959b-8c08f49a2739") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(450), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(450), new Guid("77e63ad2-9607-4793-9236-b02bec797008") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(452), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(452), new Guid("4c7abc5b-044f-472d-ba16-1b1030ced013") });

            migrationBuilder.UpdateData(
                table: "PreparationStep",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(454), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(454), new Guid("97a90160-3f9e-4f51-af1b-8e2ce58e32da") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9842), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9842), new Guid("fe298612-5a28-4604-aa17-c976a4ec5f88") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9846), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9846), new Guid("45c6abae-3c86-4022-ace1-c3176daa55fe") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9848), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9849), new Guid("58fdb08b-5412-4176-9d24-e0e902a988e7") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9852), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9852), new Guid("30ee59ea-698e-4473-99cf-6eb59b4d313a") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9854), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9855), new Guid("5c522499-6a19-4ef8-aed6-b61443aaec30") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9857), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9858), new Guid("90a0149f-3e3b-4ecf-88e1-362c575c47a1") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9859), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9860), new Guid("19356021-fee2-4003-b312-a606574e27d6") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9861), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9862), new Guid("2d2d83eb-d646-4824-96df-9fd800c9b52d") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9863), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9864), new Guid("28ce9c38-94ba-4aae-8785-671cbef1eb95") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9866), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9867), new Guid("4e1e408c-ad45-4993-9ccb-69dcce479d88") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9868), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9869), new Guid("74723dae-9efb-4406-adaa-104c3bd57470") });

            migrationBuilder.UpdateData(
                table: "Recipe",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9870), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9870), new Guid("ff5a121d-4b1f-4f1e-bf3f-d44f3343e421") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9720), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9720), new Guid("b97edd5b-4dfa-4b92-be59-1a206f6510d3") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9744), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9745), new Guid("d02a8acd-71ed-46f8-8375-43b0273a1c66") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9747), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9747), new Guid("37907377-80c8-4116-a033-68d2306d70e5") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9748), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9749), new Guid("8baa2ba3-e244-4b13-9d2b-188e62ac9fd3") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9752), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9752), new Guid("e7f65d4b-55a6-4695-aa68-41c3ba4a4e37") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9754), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9754), new Guid("503902f2-05de-4824-90c3-122c4b48302a") });

            migrationBuilder.UpdateData(
                table: "RecipeCategory",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9756), new DateTime(2023, 7, 30, 2, 45, 59, 892, DateTimeKind.Utc).AddTicks(9756), new Guid("ff0f4e52-c922-4b66-9e3f-798c71fbf6c7") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(55), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(55), new Guid("665266ef-7b5e-4061-b19f-bc9eb698d8fa") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(57), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(58), new Guid("a097cd7b-af26-477d-a023-91ed4c1fff71") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(60), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(60), new Guid("45282416-5acc-40e9-b45c-75e45a0d39f4") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(93), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(94), new Guid("bf1624c1-f90b-46bf-abcb-ba96eb1cd474") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(63), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(63), new Guid("539ed258-9cb8-4cc0-973c-62a0633dceec") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(269), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(270), new Guid("1fc152e9-5e1c-4fb9-a07d-b450c0e4d9f8") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(65), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(65), new Guid("3ab3012a-3adb-43d2-b9fb-79c10143c36f") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(66), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(67), new Guid("cfb052d2-f9ae-40fb-86e9-5aa69280db50") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 1 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(68), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(68), new Guid("a2fa1369-2ad7-437d-81a9-ffd090278f4c") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(71), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(71), new Guid("3efca760-7fde-444e-ba0f-3183747a9711") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(109), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(109), new Guid("04496f66-a10e-40d1-b1e4-6b1e0cff6934") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(126), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(127), new Guid("223e93b1-5e6a-4c2a-863c-96608ef03104") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(73), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(73), new Guid("30c69286-8b83-4e69-99a5-231d75142986") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(141), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(141), new Guid("8ca3f5b0-d705-41fd-b582-d034af1b68e6") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 5 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(150), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(150), new Guid("326d05d2-c0da-41fb-8c53-908889a13744") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(74), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(75), new Guid("aeb4ec58-fe81-40ab-a40b-ba7ca2ce21d2") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(107), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(108), new Guid("ccd1012a-2832-4b6c-b161-863d72ae7a1d") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(76), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(76), new Guid("0e33a8c4-d3b9-4f3f-a338-397f473790be") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(133), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(133), new Guid("db72f176-e23a-4204-a766-6b44df47ef1e") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(79), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(79), new Guid("688dd536-90b9-4ff1-918d-565e76136e5b") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(100), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(100), new Guid("98b35bde-8291-4930-b8d6-8670154c3e94") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(81), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(81), new Guid("e5a62f64-e2e8-41f4-a556-c2785c37902b") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(104), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(104), new Guid("8a78d521-b2ff-47f2-89b8-2ec3cfa2a41d") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(123), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(123), new Guid("1df0b042-a91c-4d4f-9ae5-f3ee32f5a1ff") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 5 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(148), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(148), new Guid("76739c86-8782-4286-ac68-a4c37b7e3990") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 6 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(154), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(155), new Guid("c0282a93-b647-464c-9a2c-62b056ab52f5") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(243), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(243), new Guid("d5b8c043-4540-4dc8-875b-9216e1308da4") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(260), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(260), new Guid("1830f727-869a-4556-afc5-69cb1cdb1a6e") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(83), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(83), new Guid("0a4800e9-b087-4bc7-9880-094cbe62c890") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(85), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(85), new Guid("bda3cf70-05b2-42b7-87e5-e22038c7e024") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(88), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(89), new Guid("0002723b-21e7-4e2a-a346-54fc6ebed7a8") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(90), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(90), new Guid("a415d405-a724-4f01-91b2-a6a14c7f319b") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 2 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(92), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(92), new Guid("fb8e6082-6805-4d2e-af75-62cd90a68857") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 19, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(96), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(96), new Guid("1bba590a-934f-471e-ab7c-90eb2be93b24") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(98), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(98), new Guid("ff5ea177-ecc1-42d5-b3c7-a2689ecb3b43") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(101), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(101), new Guid("811a9143-750b-494a-bb06-0a72ba3f6615") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(125), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(125), new Guid("a5517406-5c67-4410-94f7-001d0576d5f9") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(181), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(181), new Guid("57d6cfe2-d2fb-4277-9e71-1c68613e6a60") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(224), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(225), new Guid("c03661cd-f987-40e8-90a7-502ec55e3040") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 3 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(106), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(106), new Guid("9f67a01c-3558-4cbd-9f27-6d6fc2b49738") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(112), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(112), new Guid("d4c58a85-193d-4118-8326-ef92e1b1779a") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(236), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(237), new Guid("3fcfa6c5-dd9b-4e55-bd31-c5d5f9f2ba1d") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(114), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(114), new Guid("b629f356-a90e-4c56-a669-4c9b8eb13726") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(116), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(116), new Guid("2b3c77cc-6966-48d9-b788-8760730973f2") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(118), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(118), new Guid("495d47e9-d861-49ac-8404-20b37ab9e3d8") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(191), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(192), new Guid("f81f503c-f8aa-4875-b30c-aded64e0195f") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 27, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(121), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(121), new Guid("996e4244-5f4d-4dc1-adbf-b2d4d0cceed5") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 28, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(129), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(129), new Guid("086c3a92-aa03-447a-9287-7d79ba0b9df6") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 29, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(131), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(131), new Guid("070d95c7-a326-4243-addc-eceb146ec661") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(134), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(135), new Guid("51659266-41be-4a3d-81d1-3a159046a3f7") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(137), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(138), new Guid("9982ecec-b00a-47df-82ef-1dc39da63753") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(268), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(268), new Guid("b20eee0c-5bf7-483d-b3af-2bb96858c368") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(139), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(139), new Guid("cafc3b22-a73d-47a0-9dcb-a0125b59095e") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 4 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(142), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(143), new Guid("58e21e8f-1bbf-4500-816c-3610a67d2a99") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(272), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(272), new Guid("c3bab370-eb6f-4afc-87f0-268af281e8e2") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 5 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(145), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(145), new Guid("1fb47d3f-6e7b-4c81-857f-afec5949650e") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(274), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(274), new Guid("4b2f92eb-ff9a-4308-968f-acddc4b73bfd") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, 6 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(152), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(152), new Guid("421c8b97-cbd7-401a-844b-b86a346795d8") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(174), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(175), new Guid("2961e597-fd73-47cb-9941-e3ad85a29407") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(200), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(201), new Guid("cfed43e2-1bed-4802-a37d-5d3b3c68144b") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(210), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(211), new Guid("f995205a-e911-4c5b-af11-f02e637b13c9") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(229), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(229), new Guid("2b918dbf-8416-4c28-8aa0-0e18ad350f1b") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(255), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(255), new Guid("030adc18-b360-4700-91d4-29c622452108") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(177), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(177), new Guid("ccd00dd3-f8ca-4830-ab15-eadf6087860a") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(193), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(193), new Guid("093c7780-0d39-4a13-9219-01b8d897b65b") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(212), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(212), new Guid("e69136c6-bb92-4dc9-a13a-0dd8f435ce7e") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(244), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(245), new Guid("3e061a99-7d97-4c09-9d60-ddf3ca3fac24") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(183), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(183), new Guid("f2203489-72f2-42c8-8322-4170547032a2") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(216), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(217), new Guid("6c6628e6-843e-4b7c-9622-d47a71435b6e") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(185), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(185), new Guid("299adbf5-db03-44a3-b02f-bf79eda93841") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(187), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(187), new Guid("5fd8b52b-49b6-40c1-822a-5123449e7f36") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 41, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(189), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(190), new Guid("3fa33391-07fc-4828-acab-5c16db5b8cbd") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 41, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(207), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(207), new Guid("71097b02-f32a-441c-a203-2391a0fb10da") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 7 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(178), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(179), new Guid("dd1e3987-0108-4af8-80d2-dced03586cfd") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(231), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(232), new Guid("95927771-17ba-42ba-8351-9ce5059c181b") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(251), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(251), new Guid("8f59a8dc-8b4c-43fa-959c-109d7105e913") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 43, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(195), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(195), new Guid("60b1fdd4-2fbe-47c1-bc1e-a577ce2d53c9") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(199), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(199), new Guid("7def4fca-a106-45ba-9bd4-6671579f05ec") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(215), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(215), new Guid("4a436865-5017-4d62-b099-63bf2f48fc4d") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(202), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(202), new Guid("29163c5a-b15e-4e05-8206-83f312c524c7") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 8 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(204), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(204), new Guid("611d56ee-8cf0-4e92-9139-347ff8584ff9") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(209), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(209), new Guid("8021d719-e375-4a41-b4c6-f72e5ed95e71") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(218), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(218), new Guid("24d3cbf1-dfda-4b34-aa13-a9999f048f8c") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(220), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(220), new Guid("fc30bbf5-af49-4fdc-855c-dd74bb5bbbca") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 50, 9 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(223), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(223), new Guid("5732a304-3d31-4d83-980d-2bd54a0072cf") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(227), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(227), new Guid("a6c53de0-e54a-48b3-991d-da7d4ed46831") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 52, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(233), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(233), new Guid("765f0b84-c94a-454d-a574-beb251772257") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(235), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(235), new Guid("03125faf-db6f-42b7-850d-97c327a65788") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 10 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(239), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(240), new Guid("d17ff761-3e55-4b00-9b78-d12949f10c93") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(241), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(241), new Guid("a537f7d7-9d27-4169-aa5f-4b3d7eb98cb8") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 56, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(247), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(247), new Guid("3078ff9e-0d3e-4b7a-b401-1bb889d98702") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(249), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(249), new Guid("7f8a5f4a-78e6-4928-a065-69e3540c3de8") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 58, 11 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(252), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(253), new Guid("33ad9599-f95a-455f-a11e-fe8a146e584f") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 59, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(258), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(258), new Guid("f0dbdb40-ba02-4248-a868-6a50cd51698a") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(261), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(262), new Guid("7583e5f1-e0c6-4fc9-9248-bf3f4f5abe52") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(264), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(265), new Guid("0aab561c-d345-4702-8a62-b69740554780") });

            migrationBuilder.UpdateData(
                table: "RecipeIngredient",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 12 },
                columns: new[] { "CreatedOn", "ModifiedOn", "UniqueId" },
                values: new object[] { new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(266), new DateTime(2023, 7, 30, 2, 45, 59, 893, DateTimeKind.Utc).AddTicks(266), new Guid("938127dd-fcdd-4330-90aa-a8e486292e1a") });
        }
    }
}
