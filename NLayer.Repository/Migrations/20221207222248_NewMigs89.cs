using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class NewMigs89 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 12, 2, 8, 49, 10, 384, DateTimeKind.Unspecified).AddTicks(6722), "Margie", "Hamill" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 12, 31, 4, 21, 20, 584, DateTimeKind.Unspecified).AddTicks(1808), "Donna", "Armstrong" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 11, 14, 14, 48, 10, 846, DateTimeKind.Unspecified).AddTicks(5440), "Dominick", "Williamson" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 4, 12, 21, 33, 32, 527, DateTimeKind.Unspecified).AddTicks(8694), "Ed", "Smitham" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 8, 18, 7, 27, 24, 356, DateTimeKind.Unspecified).AddTicks(1776), "Gail", "Lindgren" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 4, 15, 9, 52, 24, 321, DateTimeKind.Unspecified).AddTicks(5950), "Fredrick", "Cartwright" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 22, 25, 53, DateTimeKind.Unspecified).AddTicks(1236), "Brandon", "Ziemann" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 5, 4, 18, 35, 59, 165, DateTimeKind.Unspecified).AddTicks(4090), "Jose", "Ledner" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2021, 12, 26, 11, 24, 37, 457, DateTimeKind.Unspecified).AddTicks(3189), "Bill", "Von" });

            migrationBuilder.UpdateData(
                table: "AppUserProfile",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2022, 5, 9, 8, 49, 9, 882, DateTimeKind.Unspecified).AddTicks(2961), "Casey", "Harvey" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("eaf41c8c-3d98-4c9e-8761-9680c76f19fe"), new DateTime(2021, 9, 12, 22, 18, 11, 42, DateTimeKind.Unspecified).AddTicks(3318), "Yvette_Stoltenberg7" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("287a7dfe-8fbd-41ca-ab43-00dfa1a29976"), new DateTime(2021, 3, 24, 13, 30, 49, 705, DateTimeKind.Unspecified).AddTicks(9769), "Jarret_Feeney" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("999275ad-ff37-43a2-a440-44bad87aeab0"), new DateTime(2022, 3, 21, 14, 5, 39, 255, DateTimeKind.Unspecified).AddTicks(4865), "Lue35" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("0ca8dac3-f6ae-4e3e-ad2f-7d314e70ddc7"), new DateTime(2022, 10, 13, 18, 46, 8, 6, DateTimeKind.Unspecified).AddTicks(534), "Zita.Harris" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("bfb2ab5e-4b48-4e0c-ab51-8b3574505e27"), new DateTime(2021, 7, 2, 1, 1, 37, 209, DateTimeKind.Unspecified).AddTicks(7486), "Lonie.Rolfson" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("7f3474f9-7f5c-4d3f-a63e-8e3415205282"), new DateTime(2022, 9, 10, 14, 22, 35, 666, DateTimeKind.Unspecified).AddTicks(2183), "Rozella.Gislason75" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("626a4996-d19c-4bc5-bd57-77bacd47cf94"), new DateTime(2021, 9, 26, 15, 41, 50, 288, DateTimeKind.Unspecified).AddTicks(6585), "Katarina_Metz47" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("a67af677-8127-41a0-849d-3d8c73658b78"), new DateTime(2022, 3, 28, 2, 53, 42, 300, DateTimeKind.Unspecified).AddTicks(5269), "Violet_Wisozk" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("50d79478-3e64-4cbb-aab0-cad8f11248d1"), new DateTime(2021, 6, 20, 7, 32, 7, 872, DateTimeKind.Unspecified).AddTicks(9940), "Lesly.Johnson68" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActivationCode", "CreatedDate", "UserName" },
                values: new object[] { new Guid("ba0ac7df-8310-4111-9b05-6da63d3efb48"), new DateTime(2022, 10, 5, 8, 1, 43, 893, DateTimeKind.Unspecified).AddTicks(3690), "Maegan.Wiza" });

            migrationBuilder.InsertData(
                table: "AppUsersLanguages",
                columns: new[] { "AppUserID", "LanguageID", "CreatedDate", "DeletedDate", "GivenBy", "Status", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1291), null, "Rex22", 1, null },
                    { 2, 1, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1728), null, "Fabiola21", 1, null },
                    { 3, 1, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(2343), null, "Cade.Boyer97", 1, null },
                    { 4, 1, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3149), null, "Sarai36", 1, null },
                    { 5, 1, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3756), null, "Aliyah.Howell", 1, null },
                    { 6, 1, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4289), null, "Florence_Mitchell", 1, null },
                    { 7, 1, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4841), null, "Charlotte.Ortiz72", 1, null },
                    { 8, 1, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5410), null, "Vella.Sauer93", 1, null },
                    { 9, 1, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5963), null, "Kirstin1", 1, null },
                    { 10, 1, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6551), null, "Dangelo22", 1, null },
                    { 1, 2, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1350), null, "Prudence.Olson83", 1, null },
                    { 2, 2, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1780), null, "Ryleigh78", 1, null },
                    { 3, 2, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(2415), null, "Briana54", 1, null },
                    { 4, 2, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3222), null, "Griffin_Kessler", 1, null },
                    { 5, 2, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3824), null, "Luisa_Larkin74", 1, null },
                    { 6, 2, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4346), null, "Sincere.Olson", 1, null },
                    { 7, 2, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4909), null, "Keith_Keebler", 1, null },
                    { 8, 2, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5480), null, "Osvaldo.Walsh", 1, null },
                    { 9, 2, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6028), null, "Dora.Hilpert13", 1, null },
                    { 10, 2, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6631), null, "Maximo_Marvin89", 1, null },
                    { 1, 3, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1402), null, "Colleen_Kohler", 1, null },
                    { 2, 3, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1835), null, "Adalberto.Stokes", 1, null },
                    { 3, 3, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(2530), null, "Destiney.DAmore26", 1, null },
                    { 4, 3, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3289), null, "Brayan44", 1, null },
                    { 5, 3, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3887), null, "Dewayne7", 1, null },
                    { 6, 3, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4412), null, "Kassandra_Maggio", 1, null },
                    { 7, 3, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4989), null, "Johnny6", 1, null },
                    { 8, 3, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5546), null, "Jack_Herman35", 1, null },
                    { 9, 3, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6096), null, "Brody.Spencer20", 1, null },
                    { 10, 3, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6705), null, "Rosa.Kris6", 1, null },
                    { 1, 4, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1458), null, "Janice.Sipes12", 1, null },
                    { 2, 4, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1889), null, "Sally.Dickinson76", 1, null },
                    { 3, 4, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(2610), null, "Hortense.Fisher2", 1, null },
                    { 4, 4, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3407), null, "Freeda88", 1, null },
                    { 5, 4, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3954), null, "Frank.Lindgren33", 1, null },
                    { 6, 4, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4479), null, "Robin60", 1, null },
                    { 7, 4, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5055), null, "Kiana_Wiegand", 1, null },
                    { 8, 4, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5610), null, "Lynn_Abshire63", 1, null },
                    { 9, 4, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6173), null, "Marianna_Murray36", 1, null },
                    { 10, 4, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6768), null, "Rod.Hayes75", 1, null },
                    { 1, 5, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1507), null, "Colleen_Harvey42", 1, null },
                    { 2, 5, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1936), null, "Oran8", 1, null },
                    { 3, 5, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(2703), null, "Drew22", 1, null },
                    { 4, 5, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3475), null, "Cicero16", 1, null },
                    { 5, 5, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4016), null, "Joseph72", 1, null },
                    { 6, 5, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4538), null, "Rita.Hoppe27", 1, null },
                    { 7, 5, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5122), null, "Karolann.Yost", 1, null },
                    { 8, 5, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5681), null, "Brigitte.Sanford57", 1, null },
                    { 9, 5, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6252), null, "Trystan.Cartwright44", 1, null },
                    { 10, 5, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6832), null, "Quincy.Ortiz12", 1, null },
                    { 1, 6, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1556), null, "Fleta.Sipes15", 1, null },
                    { 2, 6, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1994), null, "Makenzie_Dietrich35", 1, null },
                    { 3, 6, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(2778), null, "Michele48", 1, null },
                    { 4, 6, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3564), null, "Cleora52", 1, null },
                    { 5, 6, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4084), null, "Wilson_Beatty85", 1, null },
                    { 6, 6, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4608), null, "Demario_Bins", 1, null },
                    { 7, 6, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5192), null, "Kenyon38", 1, null },
                    { 8, 6, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5755), null, "Alexanne.Berge", 1, null },
                    { 9, 6, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6320), null, "Nico_Bogan6", 1, null },
                    { 10, 6, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6912), null, "Alvah.Bechtelar57", 1, null },
                    { 1, 7, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1624), null, "Xander.Ferry83", 1, null },
                    { 2, 7, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(2202), null, "Sadye_Schaefer", 1, null },
                    { 3, 7, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3004), null, "Linda.Schaden", 1, null },
                    { 4, 7, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3628), null, "Isaias.Crona47", 1, null },
                    { 5, 7, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4149), null, "Junius23", 1, null },
                    { 6, 7, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4679), null, "Delaney.Kuhic", 1, null },
                    { 7, 7, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5268), null, "Lenny55", 1, null },
                    { 8, 7, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5821), null, "Charley_Prohaska54", 1, null },
                    { 9, 7, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6392), null, "Kamren_Mosciski", 1, null },
                    { 10, 7, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6985), null, "Mohammad_Schaefer76", 1, null },
                    { 1, 8, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1675), null, "Clifford.Dach", 1, null },
                    { 2, 8, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(2271), null, "Elnora_Welch", 1, null },
                    { 3, 8, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3077), null, "Eliza.Crooks", 1, null },
                    { 4, 8, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(3692), null, "Jamey.Kovacek94", 1, null },
                    { 5, 8, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4215), null, "Susanna36", 1, null },
                    { 6, 8, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(4765), null, "Mitchell_Baumbach31", 1, null },
                    { 7, 8, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5344), null, "Marguerite_Weissnat46", 1, null },
                    { 8, 8, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(5885), null, "Eric95", 1, null },
                    { 9, 8, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(6457), null, "Lionel_Wehner41", 1, null },
                    { 10, 8, new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(7056), null, "Jameson_Reilly23", 1, null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 11, 4, 20, 44, 8, 933, DateTimeKind.Unspecified).AddTicks(9184), "Outdoors" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 3, 4, 6, 33, 43, 424, DateTimeKind.Unspecified).AddTicks(6915), "Jewelery" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 12, 30, 23, 8, 59, 760, DateTimeKind.Unspecified).AddTicks(1799), "Computers" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 6, 24, 18, 35, 34, 708, DateTimeKind.Unspecified).AddTicks(4695), "Movies" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 8, 5, 5, 48, 39, 290, DateTimeKind.Unspecified).AddTicks(2096), "Books" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 9, 24, 8, 55, 8, 37, DateTimeKind.Unspecified).AddTicks(2399), "Automotive" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 7, 1, 20, 2, 18, 157, DateTimeKind.Unspecified).AddTicks(9119), "Tools" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 9, 22, 10, 1, 50, 494, DateTimeKind.Unspecified).AddTicks(428), "Music" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2021, 9, 20, 7, 36, 21, 137, DateTimeKind.Unspecified).AddTicks(8228), "Baby" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 7, 12, 4, 44, 5, 56, DateTimeKind.Unspecified).AddTicks(3925), "Automotive" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 1, 22, 48, 577, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#320035", new DateTime(2022, 7, 27, 2, 15, 10, 948, DateTimeKind.Unspecified).AddTicks(6492), 102, 99 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#105a58", new DateTime(2022, 9, 18, 12, 30, 43, 507, DateTimeKind.Unspecified).AddTicks(5678), 200, 53 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#701b67", new DateTime(2022, 9, 17, 0, 40, 55, 651, DateTimeKind.Unspecified).AddTicks(6007), 159, 21 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#523f07", new DateTime(2022, 11, 8, 15, 45, 46, 209, DateTimeKind.Unspecified).AddTicks(802), 24, 165 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#282b57", new DateTime(2021, 4, 14, 1, 40, 11, 330, DateTimeKind.Unspecified).AddTicks(5489), 71, 200 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#7b6a62", new DateTime(2021, 8, 2, 13, 44, 34, 256, DateTimeKind.Unspecified).AddTicks(8499), 72, 190 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#600c76", new DateTime(2021, 12, 26, 1, 18, 2, 546, DateTimeKind.Unspecified).AddTicks(6197), 150, 117 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#361d37", new DateTime(2021, 10, 21, 3, 17, 38, 926, DateTimeKind.Unspecified).AddTicks(3219), 191, 148 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#172978", new DateTime(2021, 4, 11, 2, 56, 32, 547, DateTimeKind.Unspecified).AddTicks(9551), 1, 130 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#151570", new DateTime(2021, 4, 11, 20, 38, 42, 718, DateTimeKind.Unspecified).AddTicks(4907), 175, 163 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#2f7166", new DateTime(2022, 5, 9, 15, 36, 43, 344, DateTimeKind.Unspecified).AddTicks(6433), 17, 7 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#756d27", new DateTime(2021, 10, 26, 9, 46, 13, 42, DateTimeKind.Unspecified).AddTicks(3943), 57, 150 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#623400", new DateTime(2022, 3, 18, 10, 36, 59, 729, DateTimeKind.Unspecified).AddTicks(9956), 132, 98 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#6c1d5b", new DateTime(2021, 10, 9, 23, 33, 6, 722, DateTimeKind.Unspecified).AddTicks(9766), 134, 175 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#6c3461", new DateTime(2022, 3, 9, 12, 34, 55, 336, DateTimeKind.Unspecified).AddTicks(2269), 169, 87 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#134632", new DateTime(2022, 11, 19, 4, 36, 6, 115, DateTimeKind.Unspecified).AddTicks(4226), 130, 154 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#143f71", new DateTime(2022, 2, 1, 18, 23, 28, 973, DateTimeKind.Unspecified).AddTicks(1051), 90, 42 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#7f3f0e", new DateTime(2022, 2, 28, 6, 52, 48, 575, DateTimeKind.Unspecified).AddTicks(9068), 119, 87 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#7b741d", new DateTime(2022, 6, 9, 20, 13, 34, 928, DateTimeKind.Unspecified).AddTicks(4255), 122, 166 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#121a51", new DateTime(2021, 10, 22, 16, 23, 59, 748, DateTimeKind.Unspecified).AddTicks(1392), 31, 39 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#5a3c2c", new DateTime(2022, 8, 31, 23, 47, 57, 602, DateTimeKind.Unspecified).AddTicks(8434), 27, 15 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#39137e", new DateTime(2022, 2, 3, 17, 38, 18, 628, DateTimeKind.Unspecified).AddTicks(3826), 23, 84 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#30723d", new DateTime(2022, 7, 21, 11, 57, 40, 611, DateTimeKind.Unspecified).AddTicks(3664), 173, 160 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#6c7b7e", new DateTime(2021, 6, 4, 4, 22, 13, 427, DateTimeKind.Unspecified).AddTicks(4912), 191, 114 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#0b2b22", new DateTime(2022, 8, 25, 13, 32, 51, 822, DateTimeKind.Unspecified).AddTicks(3847), 38, 110 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#1a6423", new DateTime(2021, 12, 18, 21, 13, 25, 30, DateTimeKind.Unspecified).AddTicks(7637), 45, 132 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#583725", new DateTime(2022, 6, 14, 7, 10, 38, 165, DateTimeKind.Unspecified).AddTicks(8860), 128, 191 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#102577", new DateTime(2022, 2, 8, 18, 31, 13, 526, DateTimeKind.Unspecified).AddTicks(3946), 140, 78 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#721165", new DateTime(2022, 10, 30, 2, 58, 18, 355, DateTimeKind.Unspecified).AddTicks(988), 149, 138 });

            migrationBuilder.UpdateData(
                table: "UrunOzellikleri",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Color", "CreatedDate", "Height", "Width" },
                values: new object[] { "#6f0d57", new DateTime(2022, 1, 24, 5, 27, 54, 738, DateTimeKind.Unspecified).AddTicks(529), 169, 41 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 11, 27, 15, 26, 57, 859, DateTimeKind.Unspecified).AddTicks(9412), "Intelligent Fresh Table", 57m, 103 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 12, 13, 8, 55, 16, 172, DateTimeKind.Unspecified).AddTicks(2318), "Handmade Soft Sausages", 50m, 92 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2021, 7, 2, 17, 51, 41, 60, DateTimeKind.Unspecified).AddTicks(4444), "Practical Cotton Hat", 57m, 155 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 5, new DateTime(2022, 3, 24, 9, 15, 46, 467, DateTimeKind.Unspecified).AddTicks(4984), "Small Rubber Gloves", 130 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 9, 18, 6, 36, 49, 994, DateTimeKind.Unspecified).AddTicks(6410), "Ergonomic Concrete Chicken", 51m, 104 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 9, 16, 7, 17, 37, 580, DateTimeKind.Unspecified).AddTicks(3791), "Handcrafted Fresh Mouse", 56m, 45 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 10, 1, 10, 26, 52, 789, DateTimeKind.Unspecified).AddTicks(6567), "Fantastic Granite Bike", 54m, 30 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 10, 29, 22, 18, 31, 895, DateTimeKind.Unspecified).AddTicks(2790), "Sleek Concrete Table", 56m, 152 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 3, 29, 22, 0, 26, 890, DateTimeKind.Unspecified).AddTicks(8020), "Incredible Metal Computer", 166 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2021, 6, 1, 6, 47, 41, 20, DateTimeKind.Unspecified).AddTicks(941), "Generic Plastic Ball", 56m, 26 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 10, 5, 0, 4, 36, 952, DateTimeKind.Unspecified).AddTicks(2162), "Awesome Concrete Car", 53m, 165 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 9, new DateTime(2022, 1, 27, 11, 50, 19, 434, DateTimeKind.Unspecified).AddTicks(9368), "Small Granite Gloves", 49m, 165 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2021, 4, 28, 16, 3, 48, 650, DateTimeKind.Unspecified).AddTicks(5635), "Awesome Soft Soap", 66 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2021, 9, 13, 16, 18, 45, 87, DateTimeKind.Unspecified).AddTicks(31), "Refined Plastic Ball", 56m, 16 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2021, 11, 1, 19, 54, 51, 231, DateTimeKind.Unspecified).AddTicks(7638), "Fantastic Cotton Table", 49m, 76 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 10, new DateTime(2022, 5, 15, 3, 5, 54, 274, DateTimeKind.Unspecified).AddTicks(6115), "Rustic Wooden Chair", 117 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 8, 30, 4, 50, 13, 954, DateTimeKind.Unspecified).AddTicks(1615), "Awesome Fresh Chicken", 52m, 141 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 7, 14, 8, 1, 6, 390, DateTimeKind.Unspecified).AddTicks(5722), "Awesome Metal Fish", 56m, 62 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 6, 27, 22, 15, 22, 975, DateTimeKind.Unspecified).AddTicks(5918), "Sleek Cotton Table", 56m, 105 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 11, 13, 22, 3, 18, 950, DateTimeKind.Unspecified).AddTicks(104), "Tasty Soft Cheese", 54m, 164 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 9, 13, 3, 51, 50, 250, DateTimeKind.Unspecified).AddTicks(4578), "Refined Rubber Car", 55m, 180 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 3, new DateTime(2022, 8, 23, 1, 8, 25, 29, DateTimeKind.Unspecified).AddTicks(6891), "Ergonomic Rubber Shoes", 56m, 104 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2022, 6, 26, 9, 27, 10, 379, DateTimeKind.Unspecified).AddTicks(7736), "Ergonomic Wooden Table", 52m, 141 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 11, 13, 12, 16, 51, 2, DateTimeKind.Unspecified).AddTicks(3990), "Rustic Cotton Shoes", 49m, 70 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 7, new DateTime(2022, 8, 17, 13, 7, 38, 62, DateTimeKind.Unspecified).AddTicks(9093), "Handcrafted Cotton Tuna", 51m, 43 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 6, new DateTime(2022, 4, 21, 20, 11, 26, 891, DateTimeKind.Unspecified).AddTicks(3283), "Small Soft Pizza", 52m, 108 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2021, 5, 9, 7, 21, 2, 780, DateTimeKind.Unspecified).AddTicks(5899), "Refined Metal Tuna", 56m, 82 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 6, 27, 22, 41, 35, 991, DateTimeKind.Unspecified).AddTicks(7746), "Sleek Wooden Mouse", 51m, 22 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2022, 10, 23, 22, 59, 37, 153, DateTimeKind.Unspecified).AddTicks(7229), "Tasty Rubber Cheese", 54m, 123 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2021, 9, 18, 19, 46, 40, 776, DateTimeKind.Unspecified).AddTicks(5131), "Generic Granite Tuna", 54m, 189 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 10, 5 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 5, 8 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "AppUsersLanguages",
                keyColumns: new[] { "AppUserID", "LanguageID" },
                keyValues: new object[] { 10, 8 });

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
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2022, 5, 13, 8, 26, 18, 406, DateTimeKind.Unspecified).AddTicks(7972), "Electronics" });

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

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 8, 0, 23, 54, 742, DateTimeKind.Local).AddTicks(8337));

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
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 4, 13, 2, 21, 54, 274, DateTimeKind.Unspecified).AddTicks(3428), "Handmade Fresh Gloves", 52m, 24 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 5, new DateTime(2022, 9, 4, 20, 54, 48, 462, DateTimeKind.Unspecified).AddTicks(8781), "Generic Soft Shirt", 54m, 125 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Stock" },
                values: new object[] { 1, new DateTime(2022, 6, 21, 18, 1, 39, 992, DateTimeKind.Unspecified).AddTicks(2094), "Handcrafted Metal Gloves", 89 });

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
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 7, 21, 10, 4, 31, 337, DateTimeKind.Unspecified).AddTicks(6233), "Incredible Concrete Gloves", 55m, 152 });

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
                columns: new[] { "CreatedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2021, 4, 23, 9, 5, 19, 797, DateTimeKind.Unspecified).AddTicks(5343), "Sleek Metal Fish", 119 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 4, new DateTime(2021, 4, 10, 11, 42, 17, 229, DateTimeKind.Unspecified).AddTicks(3040), "Practical Concrete Keyboard", 52m, 163 });

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
                columns: new[] { "CreatedDate", "Name", "Stock" },
                values: new object[] { new DateTime(2022, 7, 24, 17, 47, 50, 755, DateTimeKind.Unspecified).AddTicks(8351), "Practical Concrete Car", 47 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2022, 6, 6, 8, 9, 38, 403, DateTimeKind.Unspecified).AddTicks(9867), "Handcrafted Wooden Bike", 53m, 34 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 1, new DateTime(2022, 10, 11, 3, 22, 33, 232, DateTimeKind.Unspecified).AddTicks(5862), "Fantastic Plastic Table", 52m, 35 });

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
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2021, 5, 22, 8, 51, 19, 955, DateTimeKind.Unspecified).AddTicks(8532), "Small Soft Gloves", 54m, 28 });

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
                columns: new[] { "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { new DateTime(2022, 9, 30, 7, 7, 20, 398, DateTimeKind.Unspecified).AddTicks(7029), "Fantastic Soft Soap", 51m, 7 });

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
                columns: new[] { "CategoryId", "CreatedDate", "Name", "Price", "Stock" },
                values: new object[] { 8, new DateTime(2021, 10, 8, 3, 1, 10, 624, DateTimeKind.Unspecified).AddTicks(7429), "Handmade Cotton Chicken", 53m, 38 });

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
    }
}
