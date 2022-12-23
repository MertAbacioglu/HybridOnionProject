using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class NewMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivationCode = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserProfile_AppUsers_Id",
                        column: x => x.Id,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AppUsersLanguages",
                columns: table => new
                {
                    LanguageID = table.Column<int>(type: "int", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    GivenBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsersLanguages", x => new { x.LanguageID, x.AppUserID });
                    table.ForeignKey(
                        name: "FK_AppUsersLanguages_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUsersLanguages_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UrunOzellikleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunOzellikleri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UrunOzellikleri_Urunler_Id",
                        column: x => x.Id,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "ActivationCode", "Active", "CreatedDate", "DeletedDate", "Email", "Password", "Status", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new Guid("95e9dd87-4d83-42c8-8a66-41eb4690d9ac"), false, new DateTime(2022, 8, 19, 22, 19, 31, 427, DateTimeKind.Unspecified).AddTicks(9622), null, null, null, 1, null, "Citlalli_Sipes69" },
                    { 2, new Guid("0c622f46-a541-44e0-9663-c19c20092339"), false, new DateTime(2021, 6, 13, 16, 47, 19, 49, DateTimeKind.Unspecified).AddTicks(8647), null, null, null, 1, null, "Elizabeth7" },
                    { 3, new Guid("e4571044-f763-41f1-951b-ecbc2484f452"), false, new DateTime(2022, 7, 21, 0, 56, 40, 853, DateTimeKind.Unspecified).AddTicks(4193), null, null, null, 1, null, "Lillie.Steuber92" },
                    { 4, new Guid("3f1a443d-39e4-4d7e-b902-db3a2ab267e9"), false, new DateTime(2022, 3, 11, 9, 15, 45, 755, DateTimeKind.Unspecified).AddTicks(9426), null, null, null, 1, null, "Myrna58" },
                    { 5, new Guid("7aedc4a4-de97-4792-b0fb-84b0bc9ee118"), false, new DateTime(2022, 6, 19, 13, 53, 33, 162, DateTimeKind.Unspecified).AddTicks(1499), null, null, null, 1, null, "Cruz39" },
                    { 6, new Guid("db1c5369-f674-4316-973b-6cdba1d8f021"), false, new DateTime(2022, 7, 10, 0, 54, 32, 781, DateTimeKind.Unspecified).AddTicks(4299), null, null, null, 1, null, "Osborne5" },
                    { 7, new Guid("be2a659a-456f-42c2-bf41-98afe920ade3"), false, new DateTime(2021, 10, 29, 11, 49, 31, 999, DateTimeKind.Unspecified).AddTicks(8573), null, null, null, 1, null, "Johnny0" },
                    { 8, new Guid("5dbc9080-768a-48d0-a058-0a093fbf1871"), false, new DateTime(2021, 10, 12, 8, 8, 17, 100, DateTimeKind.Unspecified).AddTicks(3624), null, null, null, 1, null, "Emma.Larson66" },
                    { 9, new Guid("02fe0787-ff84-4048-95e7-0a14e61b8fd9"), false, new DateTime(2021, 3, 28, 9, 2, 14, 448, DateTimeKind.Unspecified).AddTicks(2219), null, null, null, 1, null, "Maximillian.Hilpert" },
                    { 10, new Guid("aa35cfa2-5d15-4733-a60f-12e29754375c"), false, new DateTime(2022, 4, 5, 10, 43, 19, 306, DateTimeKind.Unspecified).AddTicks(4615), null, null, null, 1, null, "Adela_Wisoky" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 3, 18, 5, 10, 960, DateTimeKind.Unspecified).AddTicks(143), null, "Clothing", 1, null },
                    { 2, new DateTime(2022, 4, 6, 23, 56, 14, 69, DateTimeKind.Unspecified).AddTicks(4226), null, "Shoes", 1, null },
                    { 3, new DateTime(2022, 9, 21, 17, 26, 34, 546, DateTimeKind.Unspecified).AddTicks(5661), null, "Movies", 1, null },
                    { 4, new DateTime(2021, 5, 12, 8, 41, 11, 910, DateTimeKind.Unspecified).AddTicks(4876), null, "Automotive", 1, null },
                    { 5, new DateTime(2021, 10, 8, 7, 25, 31, 822, DateTimeKind.Unspecified).AddTicks(171), null, "Jewelery", 1, null },
                    { 6, new DateTime(2022, 10, 16, 5, 53, 12, 898, DateTimeKind.Unspecified).AddTicks(7271), null, "Jewelery", 1, null },
                    { 7, new DateTime(2021, 7, 13, 2, 27, 35, 107, DateTimeKind.Unspecified).AddTicks(1678), null, "Sports", 1, null },
                    { 8, new DateTime(2022, 8, 16, 4, 20, 12, 475, DateTimeKind.Unspecified).AddTicks(6354), null, "Automotive", 1, null },
                    { 9, new DateTime(2022, 8, 24, 10, 24, 2, 465, DateTimeKind.Unspecified).AddTicks(9722), null, "Electronics", 1, null },
                    { 10, new DateTime(2022, 6, 8, 10, 58, 48, 979, DateTimeKind.Unspecified).AddTicks(7836), null, "Electronics", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Name", "Price", "Status", "Stock", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 10, 6, 21, 43, 1, 957, DateTimeKind.Unspecified).AddTicks(8102), null, "Sleek Frozen Chicken", 52m, 1, 30, null },
                    { 2, 6, new DateTime(2022, 10, 18, 3, 8, 23, 776, DateTimeKind.Unspecified).AddTicks(9138), null, "Refined Frozen Chair", 56m, 1, 106, null },
                    { 3, 2, new DateTime(2022, 8, 24, 2, 26, 25, 244, DateTimeKind.Unspecified).AddTicks(1206), null, "Small Steel Fish", 56m, 1, 182, null },
                    { 4, 6, new DateTime(2022, 8, 14, 5, 1, 3, 858, DateTimeKind.Unspecified).AddTicks(3377), null, "Intelligent Wooden Computer", 56m, 1, 119, null },
                    { 5, 5, new DateTime(2021, 7, 19, 4, 26, 25, 880, DateTimeKind.Unspecified).AddTicks(7013), null, "Fantastic Plastic Bike", 56m, 1, 103, null },
                    { 6, 1, new DateTime(2022, 1, 4, 23, 46, 45, 713, DateTimeKind.Unspecified).AddTicks(5108), null, "Rustic Soft Towels", 51m, 1, 163, null },
                    { 7, 3, new DateTime(2022, 3, 27, 12, 32, 21, 359, DateTimeKind.Unspecified).AddTicks(3357), null, "Handcrafted Plastic Fish", 57m, 1, 50, null },
                    { 8, 10, new DateTime(2021, 5, 28, 21, 37, 2, 993, DateTimeKind.Unspecified).AddTicks(7156), null, "Generic Frozen Shoes", 52m, 1, 167, null },
                    { 9, 5, new DateTime(2021, 8, 5, 4, 47, 10, 843, DateTimeKind.Unspecified).AddTicks(5556), null, "Tasty Metal Towels", 53m, 1, 57, null },
                    { 10, 7, new DateTime(2022, 7, 5, 21, 26, 2, 966, DateTimeKind.Unspecified).AddTicks(4865), null, "Unbranded Soft Towels", 56m, 1, 42, null },
                    { 11, 4, new DateTime(2021, 8, 27, 4, 46, 3, 910, DateTimeKind.Unspecified).AddTicks(5241), null, "Rustic Soft Shoes", 56m, 1, 192, null },
                    { 12, 8, new DateTime(2022, 11, 20, 8, 34, 8, 380, DateTimeKind.Unspecified).AddTicks(596), null, "Licensed Fresh Car", 51m, 1, 106, null },
                    { 13, 2, new DateTime(2022, 11, 16, 20, 25, 1, 195, DateTimeKind.Unspecified).AddTicks(1662), null, "Refined Soft Hat", 53m, 1, 176, null },
                    { 14, 4, new DateTime(2021, 4, 4, 21, 1, 29, 18, DateTimeKind.Unspecified).AddTicks(5188), null, "Licensed Soft Tuna", 56m, 1, 133, null },
                    { 15, 6, new DateTime(2022, 5, 20, 17, 47, 15, 750, DateTimeKind.Unspecified).AddTicks(7804), null, "Small Wooden Gloves", 56m, 1, 160, null },
                    { 16, 2, new DateTime(2022, 1, 9, 15, 50, 24, 893, DateTimeKind.Unspecified).AddTicks(2928), null, "Practical Steel Ball", 57m, 1, 19, null },
                    { 17, 4, new DateTime(2022, 6, 24, 22, 34, 48, 864, DateTimeKind.Unspecified).AddTicks(9182), null, "Fantastic Concrete Chicken", 56m, 1, 175, null },
                    { 18, 1, new DateTime(2021, 6, 5, 23, 9, 8, 736, DateTimeKind.Unspecified).AddTicks(710), null, "Handmade Rubber Hat", 55m, 1, 2, null },
                    { 19, 4, new DateTime(2021, 4, 12, 21, 55, 6, 563, DateTimeKind.Unspecified).AddTicks(3515), null, "Gorgeous Metal Pants", 56m, 1, 52, null },
                    { 20, 5, new DateTime(2021, 5, 15, 6, 56, 2, 51, DateTimeKind.Unspecified).AddTicks(9565), null, "Rustic Metal Table", 55m, 1, 135, null },
                    { 21, 5, new DateTime(2021, 6, 14, 4, 13, 50, 332, DateTimeKind.Unspecified).AddTicks(795), null, "Fantastic Steel Pants", 56m, 1, 150, null },
                    { 22, 1, new DateTime(2022, 1, 21, 5, 22, 18, 909, DateTimeKind.Unspecified).AddTicks(3364), null, "Generic Rubber Table", 50m, 1, 2, null },
                    { 23, 3, new DateTime(2022, 5, 14, 23, 36, 46, 512, DateTimeKind.Unspecified).AddTicks(9515), null, "Incredible Wooden Shirt", 56m, 1, 36, null },
                    { 24, 8, new DateTime(2022, 9, 20, 21, 46, 27, 329, DateTimeKind.Unspecified).AddTicks(6629), null, "Generic Cotton Shoes", 56m, 1, 105, null },
                    { 25, 4, new DateTime(2022, 2, 27, 3, 41, 36, 515, DateTimeKind.Unspecified).AddTicks(7861), null, "Generic Frozen Mouse", 53m, 1, 178, null },
                    { 26, 10, new DateTime(2022, 10, 13, 18, 51, 59, 753, DateTimeKind.Unspecified).AddTicks(7729), null, "Sleek Fresh Bacon", 49m, 1, 45, null },
                    { 27, 10, new DateTime(2021, 11, 3, 19, 12, 23, 397, DateTimeKind.Unspecified).AddTicks(4826), null, "Generic Fresh Chair", 55m, 1, 138, null },
                    { 28, 8, new DateTime(2021, 5, 17, 15, 1, 25, 603, DateTimeKind.Unspecified).AddTicks(222), null, "Practical Granite Chicken", 53m, 1, 4, null },
                    { 29, 7, new DateTime(2022, 4, 4, 1, 14, 52, 779, DateTimeKind.Unspecified).AddTicks(4472), null, "Licensed Metal Pizza", 50m, 1, 8, null },
                    { 30, 6, new DateTime(2021, 10, 13, 12, 40, 49, 768, DateTimeKind.Unspecified).AddTicks(9075), null, "Tasty Metal Car", 57m, 1, 99, null }
                });

            migrationBuilder.InsertData(
                table: "UrunOzellikleri",
                columns: new[] { "Id", "Color", "CreatedDate", "DeletedDate", "Height", "Status", "ModifiedDate", "Width" },
                values: new object[,]
                {
                    { 1, "#2e662f", new DateTime(2021, 5, 3, 17, 9, 28, 529, DateTimeKind.Unspecified).AddTicks(7940), null, 195, 1, null, 162 },
                    { 2, "#213221", new DateTime(2021, 8, 24, 8, 42, 7, 962, DateTimeKind.Unspecified).AddTicks(9615), null, 64, 1, null, 62 },
                    { 3, "#043d27", new DateTime(2022, 2, 22, 23, 6, 26, 802, DateTimeKind.Unspecified).AddTicks(6006), null, 193, 1, null, 61 },
                    { 4, "#430306", new DateTime(2021, 4, 1, 0, 26, 25, 837, DateTimeKind.Unspecified).AddTicks(984), null, 44, 1, null, 163 },
                    { 5, "#034e22", new DateTime(2022, 5, 27, 18, 19, 4, 188, DateTimeKind.Unspecified).AddTicks(5514), null, 68, 1, null, 10 },
                    { 6, "#5f5b66", new DateTime(2022, 2, 10, 0, 55, 32, 65, DateTimeKind.Unspecified).AddTicks(6980), null, 21, 1, null, 128 },
                    { 7, "#783805", new DateTime(2022, 2, 1, 17, 53, 24, 632, DateTimeKind.Unspecified).AddTicks(1162), null, 39, 1, null, 177 },
                    { 8, "#4c2553", new DateTime(2021, 7, 18, 23, 15, 33, 383, DateTimeKind.Unspecified).AddTicks(9138), null, 88, 1, null, 78 },
                    { 9, "#161752", new DateTime(2022, 7, 4, 7, 32, 41, 120, DateTimeKind.Unspecified).AddTicks(230), null, 193, 1, null, 169 },
                    { 10, "#740110", new DateTime(2021, 6, 26, 19, 26, 3, 516, DateTimeKind.Unspecified).AddTicks(8972), null, 10, 1, null, 178 },
                    { 11, "#03180c", new DateTime(2022, 9, 3, 18, 57, 43, 469, DateTimeKind.Unspecified).AddTicks(3744), null, 93, 1, null, 42 },
                    { 12, "#04211d", new DateTime(2021, 7, 14, 12, 16, 28, 630, DateTimeKind.Unspecified).AddTicks(7287), null, 161, 1, null, 177 },
                    { 13, "#3b3b60", new DateTime(2021, 10, 16, 20, 33, 34, 800, DateTimeKind.Unspecified).AddTicks(2722), null, 31, 1, null, 36 },
                    { 14, "#692610", new DateTime(2022, 5, 30, 13, 12, 25, 644, DateTimeKind.Unspecified).AddTicks(1962), null, 174, 1, null, 197 },
                    { 15, "#567152", new DateTime(2022, 4, 14, 3, 42, 50, 325, DateTimeKind.Unspecified).AddTicks(5927), null, 164, 1, null, 183 },
                    { 16, "#530f6d", new DateTime(2021, 4, 21, 6, 53, 56, 424, DateTimeKind.Unspecified).AddTicks(6906), null, 17, 1, null, 2 },
                    { 17, "#1e440d", new DateTime(2021, 3, 21, 16, 18, 34, 305, DateTimeKind.Unspecified).AddTicks(685), null, 126, 1, null, 193 },
                    { 18, "#1e1b25", new DateTime(2021, 11, 29, 15, 22, 50, 808, DateTimeKind.Unspecified).AddTicks(2925), null, 129, 1, null, 89 },
                    { 19, "#6c401b", new DateTime(2021, 7, 28, 11, 24, 22, 797, DateTimeKind.Unspecified).AddTicks(6304), null, 96, 1, null, 105 },
                    { 20, "#7d0b16", new DateTime(2021, 9, 15, 19, 11, 29, 481, DateTimeKind.Unspecified).AddTicks(6828), null, 72, 1, null, 94 },
                    { 21, "#7a0c53", new DateTime(2021, 11, 15, 20, 38, 58, 515, DateTimeKind.Unspecified).AddTicks(2138), null, 183, 1, null, 32 },
                    { 22, "#2e213b", new DateTime(2021, 8, 5, 0, 18, 40, 901, DateTimeKind.Unspecified).AddTicks(7681), null, 80, 1, null, 110 },
                    { 23, "#39126d", new DateTime(2021, 12, 25, 1, 1, 3, 481, DateTimeKind.Unspecified).AddTicks(8845), null, 20, 1, null, 100 },
                    { 24, "#127e4e", new DateTime(2022, 3, 1, 12, 7, 37, 226, DateTimeKind.Unspecified).AddTicks(7121), null, 9, 1, null, 38 },
                    { 25, "#2d576a", new DateTime(2022, 10, 30, 8, 43, 48, 102, DateTimeKind.Unspecified).AddTicks(5411), null, 69, 1, null, 196 },
                    { 26, "#394e68", new DateTime(2021, 12, 10, 8, 54, 42, 466, DateTimeKind.Unspecified).AddTicks(853), null, 190, 1, null, 82 },
                    { 27, "#1e781c", new DateTime(2022, 7, 16, 17, 1, 9, 373, DateTimeKind.Unspecified).AddTicks(6085), null, 138, 1, null, 177 },
                    { 28, "#6e203c", new DateTime(2021, 12, 4, 19, 9, 49, 290, DateTimeKind.Unspecified).AddTicks(5486), null, 137, 1, null, 114 },
                    { 29, "#77761b", new DateTime(2022, 11, 9, 2, 55, 16, 365, DateTimeKind.Unspecified).AddTicks(4053), null, 154, 1, null, 111 },
                    { 30, "#1e4705", new DateTime(2021, 5, 2, 20, 4, 44, 27, DateTimeKind.Unspecified).AddTicks(7195), null, 172, 1, null, 56 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsersLanguages_AppUserID",
                table: "AppUsersLanguages",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_CategoryId",
                table: "Urunler",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserProfile");

            migrationBuilder.DropTable(
                name: "AppUsersLanguages");

            migrationBuilder.DropTable(
                name: "UrunOzellikleri");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
