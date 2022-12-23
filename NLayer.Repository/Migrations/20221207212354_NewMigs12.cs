using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class NewMigs12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 5, 28, 21, 22, 31, 777, DateTimeKind.Unspecified).AddTicks(1751), "Phyllis", "Ullrich" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 12, 29, 4, 7, 40, 111, DateTimeKind.Unspecified).AddTicks(8812), "Allison", "VonRueden" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 7, 20, 7, 43, 18, 330, DateTimeKind.Unspecified).AddTicks(3195), "Eric", "Littel" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 5, 23, 8, 57, 59, 496, DateTimeKind.Unspecified).AddTicks(6558), "Alex", "Corkery" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 11, 26, 9, 22, 4, 590, DateTimeKind.Unspecified).AddTicks(3447), "Jeremy", "Goldner" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 3, 14, 1, 20, 43, 17, DateTimeKind.Unspecified).AddTicks(1397), "Lillian", "Crooks" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 9, 24, 13, 16, 21, 494, DateTimeKind.Unspecified).AddTicks(9766), "Lynette", "Veum" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 4, 59, 597, DateTimeKind.Unspecified).AddTicks(8479), "Tabitha", "VonRueden" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 11, 10, 7, 16, 12, 467, DateTimeKind.Unspecified).AddTicks(7627), "Rosalie", "Braun" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 11, 19, 7, 26, 53, 133, DateTimeKind.Unspecified).AddTicks(9569), "Shawna", "Cremin" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("42399926-e6fb-4ad8-9c30-1aaf89526a8b"), new DateTime(2021, 5, 31, 3, 34, 32, 715, DateTimeKind.Unspecified).AddTicks(9946), "Aron37" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("368cda2b-d95f-4bb3-904a-26931175e02f"), new DateTime(2022, 4, 5, 4, 2, 53, 276, DateTimeKind.Unspecified).AddTicks(3883), "Katelyn20" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("b9ec518f-8ad4-4690-885d-06cad27d238a"), new DateTime(2022, 3, 14, 18, 19, 9, 59, DateTimeKind.Unspecified).AddTicks(3025), "Delbert25" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("32b2c8b5-2ab4-4d5e-9fba-8079d369ee52"), new DateTime(2021, 11, 19, 9, 44, 12, 978, DateTimeKind.Unspecified).AddTicks(5036), "Raheem33" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("023fa736-dde9-479b-ac10-c7bf45afffa0"), new DateTime(2022, 3, 24, 20, 52, 9, 312, DateTimeKind.Unspecified).AddTicks(9217), "Allison_Hermann17" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("f326d1ef-36d9-42d8-a0ae-0023a4f80aa6"), new DateTime(2021, 10, 8, 5, 25, 19, 352, DateTimeKind.Unspecified).AddTicks(134), "Abraham.Nikolaus" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("856aedbc-04f9-4aca-8aca-42c5e01c942a"), new DateTime(2021, 7, 11, 5, 52, 48, 688, DateTimeKind.Unspecified).AddTicks(2248), "Ramon87" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("6db1c4f2-12f0-4931-b024-e2b56e901364"), new DateTime(2022, 5, 17, 0, 30, 57, 69, DateTimeKind.Unspecified).AddTicks(6408), "Alia.Lehner" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("8fe83c14-2492-47c5-8057-d64a8b186903"), new DateTime(2021, 10, 8, 18, 45, 32, 618, DateTimeKind.Unspecified).AddTicks(8978), "Harmon_Koch83" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("d06c6bcf-e3f6-47bb-b5d0-d416bfff978a"), new DateTime(2022, 1, 24, 13, 17, 15, 983, DateTimeKind.Unspecified).AddTicks(168), "Serena.White34" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 7, 23, 9, 25, 21, 228, DateTimeKind.Unspecified).AddTicks(1737), "Music" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 5, 13, 8, 26, 18, 406, DateTimeKind.Unspecified).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 14, 21, 10, 30, 844, DateTimeKind.Unspecified).AddTicks(8929), "Sports" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 1, 23, 29, 43, 791, DateTimeKind.Unspecified).AddTicks(7908), "Beauty" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 3, 5, 15, 54, 15, 214, DateTimeKind.Unspecified).AddTicks(9862), "Electronics" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 20, 8, 26, 45, 915, DateTimeKind.Unspecified).AddTicks(5857), "Tools" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 7, 9, 19, 11, 54, 524, DateTimeKind.Unspecified).AddTicks(2210), "Shoes" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 6, 8, 3, 21, 42, 634, DateTimeKind.Unspecified).AddTicks(9251), "Kids" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 2, 12, 18, 10, 11, 482, DateTimeKind.Unspecified).AddTicks(5649), "Grocery" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 6, 30, 2, 12, 22, 423, DateTimeKind.Unspecified).AddTicks(1035), "Grocery" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "LanguageName", "Level", "Status", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8326), null, "Turkish", 1, 1, null },
                    { 2, new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8330), null, "German", 1, 1, null },
                    { 3, new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8331), null, "English", 1, 1, null },
                    { 4, new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8332), null, "Korean", 1, 1, null },
                    { 5, new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8333), null, "Finnish", 1, 1, null },
                    { 6, new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8335), null, "French", 1, 1, null },
                    { 7, new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8336), null, "Czech", 1, 1, null },
                    { 8, new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8337), null, "Spanish ", 1, 1, null }
                });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#67501a", new DateTime(2022, 6, 17, 12, 14, 32, 626, DateTimeKind.Unspecified).AddTicks(8435), 105, 163 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#484307", new DateTime(2022, 3, 7, 8, 25, 31, 864, DateTimeKind.Unspecified).AddTicks(2793), 106, 5 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#320e2c", new DateTime(2022, 9, 6, 1, 26, 25, 160, DateTimeKind.Unspecified).AddTicks(4085), 156, 185 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#15000a", new DateTime(2021, 12, 22, 17, 13, 19, 825, DateTimeKind.Unspecified).AddTicks(1155), 109, 191 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#742344", new DateTime(2022, 4, 27, 21, 15, 48, 610, DateTimeKind.Unspecified).AddTicks(2358), 59, 133 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#595249", new DateTime(2022, 8, 6, 13, 44, 13, 632, DateTimeKind.Unspecified).AddTicks(101), 86, 141 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#486e3b", new DateTime(2021, 11, 21, 19, 23, 51, 498, DateTimeKind.Unspecified).AddTicks(2631), 183, 17 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#77143d", new DateTime(2021, 6, 2, 17, 46, 3, 781, DateTimeKind.Unspecified).AddTicks(496), 65, 168 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#160357", new DateTime(2022, 4, 24, 11, 45, 46, 773, DateTimeKind.Unspecified).AddTicks(6910), 14, 134 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#720b70", new DateTime(2022, 6, 30, 2, 3, 34, 457, DateTimeKind.Unspecified).AddTicks(2662), 160, 83 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#08300e", new DateTime(2021, 6, 11, 4, 4, 5, 629, DateTimeKind.Unspecified).AddTicks(6948), 149, 123 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#511b6a", new DateTime(2021, 8, 2, 13, 14, 58, 974, DateTimeKind.Unspecified).AddTicks(9050), 4, 166 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#673b3d", new DateTime(2021, 11, 22, 14, 17, 0, 68, DateTimeKind.Unspecified).AddTicks(7038), 86, 199 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#24656b", new DateTime(2021, 5, 6, 2, 46, 37, 645, DateTimeKind.Unspecified).AddTicks(2263), 137, 10 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#524f75", new DateTime(2022, 4, 26, 3, 45, 51, 803, DateTimeKind.Unspecified).AddTicks(7804), 22, 138 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#775900", new DateTime(2022, 1, 4, 22, 49, 26, 198, DateTimeKind.Unspecified).AddTicks(7980), 110, 186 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#681d7f", new DateTime(2021, 12, 10, 8, 37, 20, 160, DateTimeKind.Unspecified).AddTicks(8811), 96, 99 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#563d22", new DateTime(2021, 3, 19, 6, 59, 20, 651, DateTimeKind.Unspecified).AddTicks(5058), 145, 1 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#4a4e2a", new DateTime(2021, 8, 12, 17, 15, 50, 713, DateTimeKind.Unspecified).AddTicks(6373), 97, 35 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#59785f", new DateTime(2021, 8, 21, 14, 45, 38, 723, DateTimeKind.Unspecified).AddTicks(8107), 60, 57 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#5c323e", new DateTime(2022, 10, 5, 18, 39, 23, 758, DateTimeKind.Unspecified).AddTicks(4760), 134, 31 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#377772", new DateTime(2021, 8, 1, 4, 3, 36, 533, DateTimeKind.Unspecified).AddTicks(1984), 118, 151 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#6e394e", new DateTime(2021, 9, 22, 3, 5, 37, 940, DateTimeKind.Unspecified).AddTicks(4395), 15, 49 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#175503", new DateTime(2022, 11, 3, 9, 53, 45, 73, DateTimeKind.Unspecified).AddTicks(1978), 165, 22 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#192e1e", new DateTime(2021, 6, 10, 0, 19, 16, 60, DateTimeKind.Unspecified).AddTicks(8080), 26, 164 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#400940", new DateTime(2021, 11, 15, 12, 21, 16, 879, DateTimeKind.Unspecified).AddTicks(8939), 43, 118 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#796326", new DateTime(2022, 9, 2, 12, 22, 8, 564, DateTimeKind.Unspecified).AddTicks(5617), 140, 22 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#13652c", new DateTime(2022, 11, 5, 22, 31, 2, 122, DateTimeKind.Unspecified).AddTicks(4988), 94, 149 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#423024", new DateTime(2021, 7, 14, 7, 35, 53, 754, DateTimeKind.Unspecified).AddTicks(7670), 14, 183 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#57775c", new DateTime(2021, 6, 23, 4, 36, 56, 195, DateTimeKind.Unspecified).AddTicks(7003), 1, 107 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 6, 22, 10, 49, 45, 91, DateTimeKind.Unspecified).AddTicks(3352), "Practical Wooden Hat", 49m, 151 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 8, new DateTime(2022, 4, 13, 2, 21, 54, 274, DateTimeKind.Unspecified).AddTicks(3428), "Handmade Fresh Gloves", 24 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 54, 48, 462, DateTimeKind.Unspecified).AddTicks(8781), "Generic Soft Shirt", 125 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 6, 21, 18, 1, 39, 992, DateTimeKind.Unspecified).AddTicks(2094), "Handcrafted Metal Gloves", 53m, 89 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2021, 11, 22, 1, 38, 9, 821, DateTimeKind.Unspecified).AddTicks(2248), "Awesome Plastic Sausages", 52m, 112 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2021, 7, 21, 10, 4, 31, 337, DateTimeKind.Unspecified).AddTicks(6233), "Incredible Concrete Gloves", 55m, 152 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 6, 9, 20, 56, 22, 584, DateTimeKind.Unspecified).AddTicks(9376), "Incredible Soft Bacon", 51m, 77 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 3, 23, 15, 29, 11, 965, DateTimeKind.Unspecified).AddTicks(9811), "Practical Cotton Salad", 54m, 123 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2021, 4, 23, 9, 5, 19, 797, DateTimeKind.Unspecified).AddTicks(5343), "Sleek Metal Fish", 53m, 119 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 4, 10, 11, 42, 17, 229, DateTimeKind.Unspecified).AddTicks(3040), "Practical Concrete Keyboard", 52m, 163 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2021, 11, 16, 10, 22, 9, 529, DateTimeKind.Unspecified).AddTicks(8874), "Incredible Frozen Bacon", 52m, 107 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2021, 7, 27, 4, 18, 21, 965, DateTimeKind.Unspecified).AddTicks(6732), "Ergonomic Soft Towels", 53m, 55 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 7, 24, 17, 47, 50, 755, DateTimeKind.Unspecified).AddTicks(8351), "Practical Concrete Car", 53m, 47 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2021, 9, 18, 10, 25, 29, 359, DateTimeKind.Unspecified).AddTicks(6033), "Practical Fresh Sausages", 51m, 190 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 10, new DateTime(2022, 6, 6, 8, 9, 38, 403, DateTimeKind.Unspecified).AddTicks(9867), "Handcrafted Wooden Bike", 34 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 4, new DateTime(2022, 9, 16, 10, 29, 45, 204, DateTimeKind.Unspecified).AddTicks(6509), "Incredible Concrete Fish", 3 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2021, 3, 18, 12, 0, 32, 159, DateTimeKind.Unspecified).AddTicks(5890), "Tasty Granite Gloves", 54m, 107 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2021, 6, 2, 5, 11, 37, 184, DateTimeKind.Unspecified).AddTicks(6016), "Ergonomic Concrete Keyboard", 53m, 197 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 10, 11, 3, 22, 33, 232, DateTimeKind.Unspecified).AddTicks(5862), "Fantastic Plastic Table", 52m, 35 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 3, 17, 21, 56, 14, 578, DateTimeKind.Unspecified).AddTicks(7040), "Handcrafted Granite Mouse", 50m, 36 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2021, 5, 22, 8, 51, 19, 955, DateTimeKind.Unspecified).AddTicks(8532), "Small Soft Gloves", 54m, 28 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 4, 18, 3, 37, 39, 54, DateTimeKind.Unspecified).AddTicks(3390), "Refined Soft Keyboard", 50m, 59 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2021, 5, 1, 16, 56, 54, 485, DateTimeKind.Unspecified).AddTicks(2357), "Licensed Concrete Keyboard", 54m, 116 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 9, 30, 7, 7, 20, 398, DateTimeKind.Unspecified).AddTicks(7029), "Fantastic Soft Soap", 51m, 7 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2022, 5, 9, 11, 44, 20, 303, DateTimeKind.Unspecified).AddTicks(2776), "Tasty Steel Chicken", 57m, 71 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2021, 4, 23, 22, 49, 1, 32, DateTimeKind.Unspecified).AddTicks(6761), "Sleek Frozen Soap", 53m, 16 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 10, 8, 3, 1, 10, 624, DateTimeKind.Unspecified).AddTicks(7429), "Handmade Cotton Chicken", 53m, 38 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2022, 1, 2, 16, 23, 53, 432, DateTimeKind.Unspecified).AddTicks(7626), "Handmade Fresh Sausages", 50m, 26 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 3, 18, 3, 6, 17, 903, DateTimeKind.Unspecified).AddTicks(7926), "Handcrafted Soft Towels", 53m, 119 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 8, 4, 13, 11, 14, 135, DateTimeKind.Unspecified).AddTicks(4283), "Licensed Concrete Shirt", 51m, 107 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 11, 1, 2, 7, 59, 791, DateTimeKind.Unspecified).AddTicks(5104), "Megan", "Haley" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 3, 11, 10, 26, 24, 133, DateTimeKind.Unspecified).AddTicks(5065), "Melvin", "Cassin" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 3, 26, 2, 38, 37, 505, DateTimeKind.Unspecified).AddTicks(9707), "Vicki", "Heathcote" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 4, 6, 11, 34, 36, 0, DateTimeKind.Unspecified).AddTicks(554), "Harry", "Gislason" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 6, 5, 9, 59, 37, 758, DateTimeKind.Unspecified).AddTicks(2713), "Joey", "Schneider" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 9, 27, 18, 42, 12, 445, DateTimeKind.Unspecified).AddTicks(8725), "Marion", "Walter" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 5, 25, 13, 39, 21, 18, DateTimeKind.Unspecified).AddTicks(539), "Wendy", "Carroll" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 6, 14, 8, 49, 38, 530, DateTimeKind.Unspecified).AddTicks(8738), "Rodney", "Boyle" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 7, 4, 19, 2, 24, 199, DateTimeKind.Unspecified).AddTicks(6668), "Tony", "Skiles" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 8, 28, 16, 56, 25, 466, DateTimeKind.Unspecified).AddTicks(6904), "Norma", "Howell" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("9349893c-3159-4af5-ba50-029faee4b154"), new DateTime(2022, 8, 22, 11, 29, 43, 828, DateTimeKind.Unspecified).AddTicks(9625), "Walker4" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("0e5398ab-2bf2-4779-a5f7-f91d3b4e6935"), new DateTime(2021, 10, 24, 22, 34, 18, 369, DateTimeKind.Unspecified).AddTicks(3878), "Kianna_Berge79" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("c6adc029-75ea-4e78-8e9d-31122a4674a5"), new DateTime(2022, 11, 15, 22, 10, 33, 75, DateTimeKind.Unspecified).AddTicks(2914), "Bernardo0" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("50159c20-d6e9-4a9d-afa0-6bc75772c291"), new DateTime(2021, 12, 15, 5, 1, 31, 317, DateTimeKind.Unspecified).AddTicks(7347), "Neal65" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("e01160dd-c6c2-4e6b-a438-1d912447719c"), new DateTime(2022, 1, 28, 21, 48, 42, 665, DateTimeKind.Unspecified).AddTicks(4332), "Christop61" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("4370b3fb-6adb-47ea-9a73-2db3e0833883"), new DateTime(2022, 7, 6, 3, 59, 30, 16, DateTimeKind.Unspecified).AddTicks(4706), "Maida.Franecki53" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("6c499d90-9818-432f-8496-23cda4b8738f"), new DateTime(2021, 11, 16, 14, 3, 17, 755, DateTimeKind.Unspecified).AddTicks(5294), "Gisselle_Krajcik6" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("ed51ed80-fdca-44af-bdcd-feac1c179baf"), new DateTime(2022, 8, 27, 0, 16, 11, 641, DateTimeKind.Unspecified).AddTicks(7998), "Elna_Pagac10" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("05f395ce-5b0f-42ea-8572-616ff4a8799d"), new DateTime(2021, 12, 17, 3, 46, 46, 152, DateTimeKind.Unspecified).AddTicks(3366), "Braeden31" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("b9b073cd-87c2-488c-aafa-ca5028754fca"), new DateTime(2022, 2, 9, 10, 50, 16, 367, DateTimeKind.Unspecified).AddTicks(7838), "Bonnie_Sporer" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 5, 20, 8, 44, 51, 124, DateTimeKind.Unspecified).AddTicks(9928), "Outdoors" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 8, 17, 12, 4, 23, 555, DateTimeKind.Unspecified).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 2, 14, 8, 56, 36, 742, DateTimeKind.Unspecified).AddTicks(6302), "Kids" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 4, 17, 6, 23, 47, 739, DateTimeKind.Unspecified).AddTicks(8405), "Outdoors" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 1, 26, 16, 50, 46, 634, DateTimeKind.Unspecified).AddTicks(5265), "Garden" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 9, 16, 18, 24, 10, 575, DateTimeKind.Unspecified).AddTicks(3504), "Clothing" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 10, 17, 17, 16, 40, 377, DateTimeKind.Unspecified).AddTicks(9822), "Tools" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 7, 16, 8, 29, 50, 969, DateTimeKind.Unspecified).AddTicks(6643), "Grocery" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 9, 24, 12, 46, 53, 442, DateTimeKind.Unspecified).AddTicks(7905), "Electronics" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 1, 6, 6, 12, 46, 472, DateTimeKind.Unspecified).AddTicks(1633), "Health" });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#7c7247", new DateTime(2021, 11, 10, 20, 42, 15, 29, DateTimeKind.Unspecified).AddTicks(6236), 58, 177 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#4a062d", new DateTime(2021, 7, 10, 9, 41, 39, 258, DateTimeKind.Unspecified).AddTicks(7965), 91, 137 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#2f7b38", new DateTime(2021, 8, 31, 23, 33, 20, 868, DateTimeKind.Unspecified).AddTicks(3708), 140, 39 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#020044", new DateTime(2022, 3, 22, 13, 25, 19, 805, DateTimeKind.Unspecified).AddTicks(907), 127, 143 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#5c3e43", new DateTime(2022, 3, 29, 15, 38, 2, 209, DateTimeKind.Unspecified).AddTicks(344), 167, 31 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#004653", new DateTime(2022, 8, 30, 18, 36, 53, 528, DateTimeKind.Unspecified).AddTicks(3698), 53, 75 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#646d5b", new DateTime(2022, 12, 5, 0, 8, 35, 265, DateTimeKind.Unspecified).AddTicks(7555), 73, 65 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#455432", new DateTime(2022, 2, 2, 3, 25, 38, 658, DateTimeKind.Unspecified).AddTicks(4528), 66, 109 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#294003", new DateTime(2022, 3, 7, 5, 42, 58, 337, DateTimeKind.Unspecified).AddTicks(824), 179, 30 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#163f42", new DateTime(2022, 8, 14, 10, 28, 27, 34, DateTimeKind.Unspecified).AddTicks(54), 186, 46 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#274263", new DateTime(2022, 3, 14, 21, 7, 47, 969, DateTimeKind.Unspecified).AddTicks(7609), 61, 99 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#69015a", new DateTime(2022, 1, 3, 17, 27, 5, 761, DateTimeKind.Unspecified).AddTicks(7830), 54, 19 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#63451b", new DateTime(2022, 5, 23, 8, 17, 16, 738, DateTimeKind.Unspecified).AddTicks(768), 54, 145 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#121816", new DateTime(2022, 11, 27, 17, 34, 22, 204, DateTimeKind.Unspecified).AddTicks(2647), 167, 93 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#5d1628", new DateTime(2022, 11, 2, 12, 3, 47, 368, DateTimeKind.Unspecified).AddTicks(9305), 28, 147 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#16093c", new DateTime(2021, 5, 28, 8, 1, 55, 119, DateTimeKind.Unspecified).AddTicks(6932), 125, 98 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#5d6753", new DateTime(2022, 9, 9, 20, 10, 24, 44, DateTimeKind.Unspecified).AddTicks(5031), 94, 116 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#2c0d20", new DateTime(2021, 3, 18, 21, 44, 43, 135, DateTimeKind.Unspecified).AddTicks(1668), 14, 41 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#4c380c", new DateTime(2021, 7, 18, 10, 44, 41, 373, DateTimeKind.Unspecified).AddTicks(9832), 23, 189 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#0a1e61", new DateTime(2022, 4, 18, 21, 20, 31, 381, DateTimeKind.Unspecified).AddTicks(1788), 56, 22 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#7c3154", new DateTime(2022, 7, 30, 1, 42, 30, 291, DateTimeKind.Unspecified).AddTicks(1897), 35, 4 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#315a1a", new DateTime(2022, 10, 15, 23, 44, 7, 217, DateTimeKind.Unspecified).AddTicks(4997), 165, 6 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#133d66", new DateTime(2021, 9, 4, 2, 53, 24, 677, DateTimeKind.Unspecified).AddTicks(7373), 120, 32 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#01455b", new DateTime(2021, 7, 6, 19, 28, 13, 194, DateTimeKind.Unspecified).AddTicks(6914), 172, 39 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#170f5d", new DateTime(2022, 7, 24, 9, 31, 53, 278, DateTimeKind.Unspecified).AddTicks(847), 160, 145 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#05486e", new DateTime(2021, 9, 23, 16, 45, 46, 438, DateTimeKind.Unspecified).AddTicks(572), 74, 36 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#4f3b2e", new DateTime(2021, 6, 11, 4, 50, 7, 904, DateTimeKind.Unspecified).AddTicks(4049), 85, 43 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#6d7b47", new DateTime(2021, 12, 14, 4, 55, 1, 850, DateTimeKind.Unspecified).AddTicks(3639), 116, 186 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#570f56", new DateTime(2022, 9, 23, 9, 30, 12, 137, DateTimeKind.Unspecified).AddTicks(4962), 116, 105 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#7a2a4f", new DateTime(2022, 2, 16, 18, 10, 31, 741, DateTimeKind.Unspecified).AddTicks(9995), 138, 77 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2021, 5, 5, 3, 21, 45, 806, DateTimeKind.Unspecified).AddTicks(2239), "Intelligent Concrete Fish", 54m, 106 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 9, new DateTime(2021, 5, 2, 7, 19, 37, 48, DateTimeKind.Unspecified).AddTicks(8798), "Awesome Granite Ball", 38 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2021, 7, 19, 3, 7, 28, 410, DateTimeKind.Unspecified).AddTicks(5326), "Gorgeous Metal Chair", 113 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 6, 13, 13, 31, 36, 757, DateTimeKind.Unspecified).AddTicks(6100), "Gorgeous Concrete Shoes", 52m, 153 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2021, 4, 21, 19, 3, 12, 46, DateTimeKind.Unspecified).AddTicks(9923), "Small Granite Mouse", 53m, 123 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 11, 29, 18, 29, 17, 175, DateTimeKind.Unspecified).AddTicks(1282), "Sleek Wooden Bike", 49m, 145 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2021, 5, 9, 21, 38, 5, 111, DateTimeKind.Unspecified).AddTicks(4372), "Handcrafted Concrete Shoes", 53m, 127 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 6, 19, 3, 19, 30, 480, DateTimeKind.Unspecified).AddTicks(5341), "Licensed Concrete Ball", 52m, 82 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 10, 4, 21, 41, 0, 322, DateTimeKind.Unspecified).AddTicks(7568), "Incredible Metal Chicken", 49m, 115 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 5, 14, 15, 43, 52, 898, DateTimeKind.Unspecified).AddTicks(1521), "Licensed Granite Bike", 49m, 155 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2021, 11, 12, 15, 35, 0, 733, DateTimeKind.Unspecified).AddTicks(2671), "Rustic Metal Sausages", 54m, 84 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2021, 5, 6, 18, 49, 37, 837, DateTimeKind.Unspecified).AddTicks(6369), "Fantastic Concrete Chair", 54m, 148 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 8, 5, 9, 48, 3, 114, DateTimeKind.Unspecified).AddTicks(7960), "Practical Frozen Sausages", 50m, 22 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2021, 8, 6, 0, 45, 28, 77, DateTimeKind.Unspecified).AddTicks(2129), "Sleek Fresh Chicken", 53m, 10 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 1, new DateTime(2021, 8, 15, 6, 25, 59, 747, DateTimeKind.Unspecified).AddTicks(8192), "Tasty Soft Chair", 152 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 5, new DateTime(2022, 9, 11, 9, 9, 21, 416, DateTimeKind.Unspecified).AddTicks(6571), "Gorgeous Concrete Chips", 49 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 5, 6, 12, 5, 19, 410, DateTimeKind.Unspecified).AddTicks(971), "Rustic Fresh Hat", 51m, 56 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 11, 2, 1, 29, 54, 41, DateTimeKind.Unspecified).AddTicks(8823), "Licensed Metal Mouse", 56m, 22 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 4, 5, 21, 20, 34, 950, DateTimeKind.Unspecified).AddTicks(3792), "Gorgeous Metal Hat", 54m, 90 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 5, 13, 10, 37, 39, 911, DateTimeKind.Unspecified).AddTicks(324), "Refined Cotton Sausages", 56m, 17 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2022, 5, 26, 8, 48, 8, 847, DateTimeKind.Unspecified).AddTicks(1782), "Gorgeous Metal Keyboard", 51m, 61 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 6, 8, 1, 50, 10, 908, DateTimeKind.Unspecified).AddTicks(1864), "Ergonomic Frozen Fish", 55m, 21 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 9, 15, 21, 43, 2, 475, DateTimeKind.Unspecified).AddTicks(6177), "Unbranded Rubber Computer", 56m, 113 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2021, 3, 28, 20, 58, 12, 34, DateTimeKind.Unspecified).AddTicks(4432), "Intelligent Fresh Tuna", 52m, 197 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2021, 10, 4, 20, 57, 57, 83, DateTimeKind.Unspecified).AddTicks(8295), "Handcrafted Metal Cheese", 56m, 105 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 12, 2, 13, 23, 54, 68, DateTimeKind.Unspecified).AddTicks(4974), "Tasty Cotton Salad", 55m, 44 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 10, 25, 18, 56, 29, 883, DateTimeKind.Unspecified).AddTicks(4080), "Sleek Concrete Fish", 57m, 193 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 3, 27, 10, 39, 42, 508, DateTimeKind.Unspecified).AddTicks(19), "Intelligent Frozen Bacon", 56m, 126 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 8, 20, 14, 48, 38, 922, DateTimeKind.Unspecified).AddTicks(6044), "Incredible Fresh Gloves", 51m, 115 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2021, 8, 6, 15, 35, 50, 721, DateTimeKind.Unspecified).AddTicks(2337), "Intelligent Rubber Pizza", 53m, 44 });
        }
    }
}
