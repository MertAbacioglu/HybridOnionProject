using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class NewMigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppUserProfile",
                columns: new[] { "Id", "Address", "CreatedDate", "DeletedDate", "FirstName", "LastName", "Status", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2022, 11, 1, 2, 7, 59, 791, DateTimeKind.Unspecified).AddTicks(5104), null, "Megan", "Haley", 1, null },
                    { 2, null, new DateTime(2022, 3, 11, 10, 26, 24, 133, DateTimeKind.Unspecified).AddTicks(5065), null, "Melvin", "Cassin", 1, null },
                    { 3, null, new DateTime(2021, 3, 26, 2, 38, 37, 505, DateTimeKind.Unspecified).AddTicks(9707), null, "Vicki", "Heathcote", 1, null },
                    { 4, null, new DateTime(2021, 4, 6, 11, 34, 36, 0, DateTimeKind.Unspecified).AddTicks(554), null, "Harry", "Gislason", 1, null },
                    { 5, null, new DateTime(2021, 6, 5, 9, 59, 37, 758, DateTimeKind.Unspecified).AddTicks(2713), null, "Joey", "Schneider", 1, null },
                    { 6, null, new DateTime(2022, 9, 27, 18, 42, 12, 445, DateTimeKind.Unspecified).AddTicks(8725), null, "Marion", "Walter", 1, null },
                    { 7, null, new DateTime(2021, 5, 25, 13, 39, 21, 18, DateTimeKind.Unspecified).AddTicks(539), null, "Wendy", "Carroll", 1, null },
                    { 8, null, new DateTime(2022, 6, 14, 8, 49, 38, 530, DateTimeKind.Unspecified).AddTicks(8738), null, "Rodney", "Boyle", 1, null },
                    { 9, null, new DateTime(2022, 7, 4, 19, 2, 24, 199, DateTimeKind.Unspecified).AddTicks(6668), null, "Tony", "Skiles", 1, null },
                    { 10, null, new DateTime(2021, 8, 28, 16, 56, 25, 466, DateTimeKind.Unspecified).AddTicks(6904), null, "Norma", "Howell", 1, null }
                });

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
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 8, 17, 12, 4, 23, 555, DateTimeKind.Unspecified).AddTicks(6348), "Electronics" });

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
                column: "CreatedDate",
                value: new DateTime(2022, 9, 24, 12, 46, 53, 442, DateTimeKind.Unspecified).AddTicks(7905));

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
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2021, 5, 2, 7, 19, 37, 48, DateTimeKind.Unspecified).AddTicks(8798), "Awesome Granite Ball", 52m, 38 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2021, 7, 19, 3, 7, 28, 410, DateTimeKind.Unspecified).AddTicks(5326), "Gorgeous Metal Chair", 54m, 113 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 6, 13, 13, 31, 36, 757, DateTimeKind.Unspecified).AddTicks(6100), "Gorgeous Concrete Shoes", 52m, 153 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 4, 21, 19, 3, 12, 46, DateTimeKind.Unspecified).AddTicks(9923), "Small Granite Mouse", 53m, 123 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 9, new DateTime(2022, 6, 19, 3, 19, 30, 480, DateTimeKind.Unspecified).AddTicks(5341), "Licensed Concrete Ball", 82 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 5, 14, 15, 43, 52, 898, DateTimeKind.Unspecified).AddTicks(1521), "Licensed Granite Bike", 49m, 155 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2021, 8, 15, 6, 25, 59, 747, DateTimeKind.Unspecified).AddTicks(8192), "Tasty Soft Chair", 53m, 152 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2021, 4, 5, 21, 20, 34, 950, DateTimeKind.Unspecified).AddTicks(3792), "Gorgeous Metal Hat", 54m, 90 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 4, new DateTime(2022, 9, 15, 21, 43, 2, 475, DateTimeKind.Unspecified).AddTicks(6177), "Unbranded Rubber Computer", 113 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2021, 10, 25, 18, 56, 29, 883, DateTimeKind.Unspecified).AddTicks(4080), "Sleek Concrete Fish", 57m, 193 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("95e9dd87-4d83-42c8-8a66-41eb4690d9ac"), new DateTime(2022, 8, 19, 22, 19, 31, 427, DateTimeKind.Unspecified).AddTicks(9622), "Citlalli_Sipes69" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("0c622f46-a541-44e0-9663-c19c20092339"), new DateTime(2021, 6, 13, 16, 47, 19, 49, DateTimeKind.Unspecified).AddTicks(8647), "Elizabeth7" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("e4571044-f763-41f1-951b-ecbc2484f452"), new DateTime(2022, 7, 21, 0, 56, 40, 853, DateTimeKind.Unspecified).AddTicks(4193), "Lillie.Steuber92" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("3f1a443d-39e4-4d7e-b902-db3a2ab267e9"), new DateTime(2022, 3, 11, 9, 15, 45, 755, DateTimeKind.Unspecified).AddTicks(9426), "Myrna58" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("7aedc4a4-de97-4792-b0fb-84b0bc9ee118"), new DateTime(2022, 6, 19, 13, 53, 33, 162, DateTimeKind.Unspecified).AddTicks(1499), "Cruz39" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("db1c5369-f674-4316-973b-6cdba1d8f021"), new DateTime(2022, 7, 10, 0, 54, 32, 781, DateTimeKind.Unspecified).AddTicks(4299), "Osborne5" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("be2a659a-456f-42c2-bf41-98afe920ade3"), new DateTime(2021, 10, 29, 11, 49, 31, 999, DateTimeKind.Unspecified).AddTicks(8573), "Johnny0" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("5dbc9080-768a-48d0-a058-0a093fbf1871"), new DateTime(2021, 10, 12, 8, 8, 17, 100, DateTimeKind.Unspecified).AddTicks(3624), "Emma.Larson66" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("02fe0787-ff84-4048-95e7-0a14e61b8fd9"), new DateTime(2021, 3, 28, 9, 2, 14, 448, DateTimeKind.Unspecified).AddTicks(2219), "Maximillian.Hilpert" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("aa35cfa2-5d15-4733-a60f-12e29754375c"), new DateTime(2022, 4, 5, 10, 43, 19, 306, DateTimeKind.Unspecified).AddTicks(4615), "Adela_Wisoky" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 1, 3, 18, 5, 10, 960, DateTimeKind.Unspecified).AddTicks(143), "Clothing" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 4, 6, 23, 56, 14, 69, DateTimeKind.Unspecified).AddTicks(4226), "Shoes" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 9, 21, 17, 26, 34, 546, DateTimeKind.Unspecified).AddTicks(5661), "Movies" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 5, 12, 8, 41, 11, 910, DateTimeKind.Unspecified).AddTicks(4876), "Automotive" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 10, 8, 7, 25, 31, 822, DateTimeKind.Unspecified).AddTicks(171), "Jewelery" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 10, 16, 5, 53, 12, 898, DateTimeKind.Unspecified).AddTicks(7271), "Jewelery" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 7, 13, 2, 27, 35, 107, DateTimeKind.Unspecified).AddTicks(1678), "Sports" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 8, 16, 4, 20, 12, 475, DateTimeKind.Unspecified).AddTicks(6354), "Automotive" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 8, 24, 10, 24, 2, 465, DateTimeKind.Unspecified).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 6, 8, 10, 58, 48, 979, DateTimeKind.Unspecified).AddTicks(7836), "Electronics" });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#2e662f", new DateTime(2021, 5, 3, 17, 9, 28, 529, DateTimeKind.Unspecified).AddTicks(7940), 195, 162 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#213221", new DateTime(2021, 8, 24, 8, 42, 7, 962, DateTimeKind.Unspecified).AddTicks(9615), 64, 62 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#043d27", new DateTime(2022, 2, 22, 23, 6, 26, 802, DateTimeKind.Unspecified).AddTicks(6006), 193, 61 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#430306", new DateTime(2021, 4, 1, 0, 26, 25, 837, DateTimeKind.Unspecified).AddTicks(984), 44, 163 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#034e22", new DateTime(2022, 5, 27, 18, 19, 4, 188, DateTimeKind.Unspecified).AddTicks(5514), 68, 10 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#5f5b66", new DateTime(2022, 2, 10, 0, 55, 32, 65, DateTimeKind.Unspecified).AddTicks(6980), 21, 128 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#783805", new DateTime(2022, 2, 1, 17, 53, 24, 632, DateTimeKind.Unspecified).AddTicks(1162), 39, 177 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#4c2553", new DateTime(2021, 7, 18, 23, 15, 33, 383, DateTimeKind.Unspecified).AddTicks(9138), 88, 78 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#161752", new DateTime(2022, 7, 4, 7, 32, 41, 120, DateTimeKind.Unspecified).AddTicks(230), 193, 169 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#740110", new DateTime(2021, 6, 26, 19, 26, 3, 516, DateTimeKind.Unspecified).AddTicks(8972), 10, 178 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#03180c", new DateTime(2022, 9, 3, 18, 57, 43, 469, DateTimeKind.Unspecified).AddTicks(3744), 93, 42 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#04211d", new DateTime(2021, 7, 14, 12, 16, 28, 630, DateTimeKind.Unspecified).AddTicks(7287), 161, 177 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#3b3b60", new DateTime(2021, 10, 16, 20, 33, 34, 800, DateTimeKind.Unspecified).AddTicks(2722), 31, 36 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#692610", new DateTime(2022, 5, 30, 13, 12, 25, 644, DateTimeKind.Unspecified).AddTicks(1962), 174, 197 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#567152", new DateTime(2022, 4, 14, 3, 42, 50, 325, DateTimeKind.Unspecified).AddTicks(5927), 164, 183 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#530f6d", new DateTime(2021, 4, 21, 6, 53, 56, 424, DateTimeKind.Unspecified).AddTicks(6906), 17, 2 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#1e440d", new DateTime(2021, 3, 21, 16, 18, 34, 305, DateTimeKind.Unspecified).AddTicks(685), 126, 193 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#1e1b25", new DateTime(2021, 11, 29, 15, 22, 50, 808, DateTimeKind.Unspecified).AddTicks(2925), 129, 89 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#6c401b", new DateTime(2021, 7, 28, 11, 24, 22, 797, DateTimeKind.Unspecified).AddTicks(6304), 96, 105 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#7d0b16", new DateTime(2021, 9, 15, 19, 11, 29, 481, DateTimeKind.Unspecified).AddTicks(6828), 72, 94 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#7a0c53", new DateTime(2021, 11, 15, 20, 38, 58, 515, DateTimeKind.Unspecified).AddTicks(2138), 183, 32 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#2e213b", new DateTime(2021, 8, 5, 0, 18, 40, 901, DateTimeKind.Unspecified).AddTicks(7681), 80, 110 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#39126d", new DateTime(2021, 12, 25, 1, 1, 3, 481, DateTimeKind.Unspecified).AddTicks(8845), 20, 100 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#127e4e", new DateTime(2022, 3, 1, 12, 7, 37, 226, DateTimeKind.Unspecified).AddTicks(7121), 9, 38 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#2d576a", new DateTime(2022, 10, 30, 8, 43, 48, 102, DateTimeKind.Unspecified).AddTicks(5411), 69, 196 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#394e68", new DateTime(2021, 12, 10, 8, 54, 42, 466, DateTimeKind.Unspecified).AddTicks(853), 190, 82 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#1e781c", new DateTime(2022, 7, 16, 17, 1, 9, 373, DateTimeKind.Unspecified).AddTicks(6085), 138, 177 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#6e203c", new DateTime(2021, 12, 4, 19, 9, 49, 290, DateTimeKind.Unspecified).AddTicks(5486), 137, 114 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#77761b", new DateTime(2022, 11, 9, 2, 55, 16, 365, DateTimeKind.Unspecified).AddTicks(4053), 154, 111 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#1e4705", new DateTime(2021, 5, 2, 20, 4, 44, 27, DateTimeKind.Unspecified).AddTicks(7195), 172, 56 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2021, 10, 6, 21, 43, 1, 957, DateTimeKind.Unspecified).AddTicks(8102), "Sleek Frozen Chicken", 52m, 30 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 10, 18, 3, 8, 23, 776, DateTimeKind.Unspecified).AddTicks(9138), "Refined Frozen Chair", 56m, 106 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2022, 8, 24, 2, 26, 25, 244, DateTimeKind.Unspecified).AddTicks(1206), "Small Steel Fish", 56m, 182 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 8, 14, 5, 1, 3, 858, DateTimeKind.Unspecified).AddTicks(3377), "Intelligent Wooden Computer", 56m, 119 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 7, 19, 4, 26, 25, 880, DateTimeKind.Unspecified).AddTicks(7013), "Fantastic Plastic Bike", 56m, 103 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 1, 4, 23, 46, 45, 713, DateTimeKind.Unspecified).AddTicks(5108), "Rustic Soft Towels", 51m, 163 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2022, 3, 27, 12, 32, 21, 359, DateTimeKind.Unspecified).AddTicks(3357), "Handcrafted Plastic Fish", 57m, 50 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 10, new DateTime(2021, 5, 28, 21, 37, 2, 993, DateTimeKind.Unspecified).AddTicks(7156), "Generic Frozen Shoes", 167 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2021, 8, 5, 4, 47, 10, 843, DateTimeKind.Unspecified).AddTicks(5556), "Tasty Metal Towels", 53m, 57 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 7, 5, 21, 26, 2, 966, DateTimeKind.Unspecified).AddTicks(4865), "Unbranded Soft Towels", 56m, 42 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 8, 27, 4, 46, 3, 910, DateTimeKind.Unspecified).AddTicks(5241), "Rustic Soft Shoes", 56m, 192 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 11, 20, 8, 34, 8, 380, DateTimeKind.Unspecified).AddTicks(596), "Licensed Fresh Car", 51m, 106 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2022, 11, 16, 20, 25, 1, 195, DateTimeKind.Unspecified).AddTicks(1662), "Refined Soft Hat", 53m, 176 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 4, 4, 21, 1, 29, 18, DateTimeKind.Unspecified).AddTicks(5188), "Licensed Soft Tuna", 56m, 133 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 5, 20, 17, 47, 15, 750, DateTimeKind.Unspecified).AddTicks(7804), "Small Wooden Gloves", 56m, 160 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 2, new DateTime(2022, 1, 9, 15, 50, 24, 893, DateTimeKind.Unspecified).AddTicks(2928), "Practical Steel Ball", 19 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 6, 24, 22, 34, 48, 864, DateTimeKind.Unspecified).AddTicks(9182), "Fantastic Concrete Chicken", 56m, 175 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2021, 6, 5, 23, 9, 8, 736, DateTimeKind.Unspecified).AddTicks(710), "Handmade Rubber Hat", 55m, 2 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 4, 12, 21, 55, 6, 563, DateTimeKind.Unspecified).AddTicks(3515), "Gorgeous Metal Pants", 56m, 52 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2021, 5, 15, 6, 56, 2, 51, DateTimeKind.Unspecified).AddTicks(9565), "Rustic Metal Table", 55m, 135 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2021, 6, 14, 4, 13, 50, 332, DateTimeKind.Unspecified).AddTicks(795), "Fantastic Steel Pants", 56m, 150 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 1, 21, 5, 22, 18, 909, DateTimeKind.Unspecified).AddTicks(3364), "Generic Rubber Table", 50m, 2 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 3, new DateTime(2022, 5, 14, 23, 36, 46, 512, DateTimeKind.Unspecified).AddTicks(9515), "Incredible Wooden Shirt", 36 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 9, 20, 21, 46, 27, 329, DateTimeKind.Unspecified).AddTicks(6629), "Generic Cotton Shoes", 56m, 105 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 2, 27, 3, 41, 36, 515, DateTimeKind.Unspecified).AddTicks(7861), "Generic Frozen Mouse", 53m, 178 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 10, 13, 18, 51, 59, 753, DateTimeKind.Unspecified).AddTicks(7729), "Sleek Fresh Bacon", 49m, 45 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2021, 11, 3, 19, 12, 23, 397, DateTimeKind.Unspecified).AddTicks(4826), "Generic Fresh Chair", 55m, 138 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2021, 5, 17, 15, 1, 25, 603, DateTimeKind.Unspecified).AddTicks(222), "Practical Granite Chicken", 53m, 4 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 4, 4, 1, 14, 52, 779, DateTimeKind.Unspecified).AddTicks(4472), "Licensed Metal Pizza", 50m, 8 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2021, 10, 13, 12, 40, 49, 768, DateTimeKind.Unspecified).AddTicks(9075), "Tasty Metal Car", 57m, 99 });
        }
    }
}
