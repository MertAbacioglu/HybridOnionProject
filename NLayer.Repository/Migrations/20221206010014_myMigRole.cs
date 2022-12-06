using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class myMigRole : Migration
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
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 5, 10, 26, 25, 191, DateTimeKind.Unspecified).AddTicks(9492), null, "Movies", 1, null },
                    { 2, new DateTime(2022, 6, 22, 23, 46, 57, 58, DateTimeKind.Unspecified).AddTicks(1241), null, "Tools", 1, null },
                    { 3, new DateTime(2022, 8, 5, 6, 22, 24, 260, DateTimeKind.Unspecified).AddTicks(5649), null, "Health", 1, null },
                    { 4, new DateTime(2021, 7, 2, 14, 16, 30, 821, DateTimeKind.Unspecified).AddTicks(2681), null, "Baby", 1, null },
                    { 5, new DateTime(2022, 3, 8, 18, 30, 32, 584, DateTimeKind.Unspecified).AddTicks(5826), null, "Jewelery", 1, null },
                    { 6, new DateTime(2022, 1, 26, 7, 27, 6, 26, DateTimeKind.Unspecified).AddTicks(4823), null, "Jewelery", 1, null },
                    { 7, new DateTime(2021, 12, 5, 0, 25, 43, 124, DateTimeKind.Unspecified).AddTicks(9447), null, "Kids", 1, null },
                    { 8, new DateTime(2022, 9, 26, 18, 55, 43, 584, DateTimeKind.Unspecified).AddTicks(1615), null, "Shoes", 1, null },
                    { 9, new DateTime(2021, 5, 29, 18, 52, 4, 311, DateTimeKind.Unspecified).AddTicks(232), null, "Computers", 1, null },
                    { 10, new DateTime(2021, 8, 14, 21, 30, 0, 643, DateTimeKind.Unspecified).AddTicks(9860), null, "Electronics", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "LanguageName", "Level", "Status", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 6, 4, 0, 13, 662, DateTimeKind.Local).AddTicks(580), null, "Türkçe", 1, 1, null },
                    { 2, new DateTime(2022, 12, 6, 4, 0, 13, 663, DateTimeKind.Local).AddTicks(2634), null, "İngilizce", 1, 1, null },
                    { 3, new DateTime(2022, 12, 6, 4, 0, 13, 663, DateTimeKind.Local).AddTicks(2642), null, "Almanca", 1, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Name", "Price", "Status", "Stock", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2022, 1, 7, 9, 34, 5, 32, DateTimeKind.Unspecified).AddTicks(6345), null, "Rustic Wooden Gloves", 50m, 1, 159, null },
                    { 2, 5, new DateTime(2021, 11, 6, 5, 4, 53, 690, DateTimeKind.Unspecified).AddTicks(2976), null, "Practical Rubber Pizza", 56m, 1, 110, null },
                    { 3, 4, new DateTime(2022, 11, 9, 14, 3, 26, 436, DateTimeKind.Unspecified).AddTicks(7421), null, "Unbranded Cotton Salad", 51m, 1, 52, null },
                    { 4, 7, new DateTime(2021, 10, 15, 20, 58, 15, 648, DateTimeKind.Unspecified).AddTicks(7021), null, "Generic Rubber Table", 53m, 1, 163, null },
                    { 5, 5, new DateTime(2021, 7, 10, 10, 16, 1, 615, DateTimeKind.Unspecified).AddTicks(5152), null, "Handmade Steel Hat", 49m, 1, 15, null },
                    { 6, 10, new DateTime(2022, 8, 29, 1, 53, 25, 198, DateTimeKind.Unspecified).AddTicks(4888), null, "Generic Concrete Mouse", 52m, 1, 29, null },
                    { 7, 9, new DateTime(2022, 4, 4, 17, 23, 2, 604, DateTimeKind.Unspecified).AddTicks(1914), null, "Unbranded Cotton Keyboard", 49m, 1, 168, null },
                    { 8, 5, new DateTime(2021, 4, 20, 8, 1, 31, 949, DateTimeKind.Unspecified).AddTicks(8644), null, "Rustic Frozen Mouse", 51m, 1, 79, null },
                    { 9, 7, new DateTime(2022, 7, 25, 5, 13, 3, 965, DateTimeKind.Unspecified).AddTicks(8818), null, "Generic Concrete Tuna", 49m, 1, 129, null },
                    { 10, 5, new DateTime(2021, 12, 23, 16, 19, 25, 17, DateTimeKind.Unspecified).AddTicks(8567), null, "Unbranded Cotton Gloves", 52m, 1, 89, null },
                    { 11, 8, new DateTime(2021, 11, 25, 6, 13, 29, 508, DateTimeKind.Unspecified).AddTicks(1649), null, "Fantastic Fresh Computer", 53m, 1, 107, null },
                    { 12, 2, new DateTime(2022, 7, 21, 4, 36, 26, 79, DateTimeKind.Unspecified).AddTicks(8521), null, "Handmade Granite Hat", 52m, 1, 181, null },
                    { 13, 10, new DateTime(2022, 9, 13, 7, 55, 11, 784, DateTimeKind.Unspecified).AddTicks(6515), null, "Generic Fresh Chicken", 50m, 1, 89, null },
                    { 14, 10, new DateTime(2021, 7, 23, 21, 38, 10, 33, DateTimeKind.Unspecified).AddTicks(5609), null, "Refined Granite Bacon", 51m, 1, 49, null },
                    { 15, 9, new DateTime(2021, 6, 15, 23, 26, 11, 379, DateTimeKind.Unspecified).AddTicks(8189), null, "Practical Granite Salad", 54m, 1, 143, null },
                    { 16, 2, new DateTime(2022, 3, 23, 7, 37, 44, 485, DateTimeKind.Unspecified).AddTicks(2680), null, "Handcrafted Frozen Bacon", 52m, 1, 126, null },
                    { 17, 10, new DateTime(2021, 10, 19, 5, 29, 48, 222, DateTimeKind.Unspecified).AddTicks(2951), null, "Awesome Wooden Cheese", 51m, 1, 31, null },
                    { 18, 9, new DateTime(2021, 6, 20, 2, 24, 12, 678, DateTimeKind.Unspecified).AddTicks(6093), null, "Sleek Granite Fish", 55m, 1, 27, null },
                    { 19, 5, new DateTime(2021, 5, 8, 3, 15, 55, 959, DateTimeKind.Unspecified).AddTicks(955), null, "Incredible Soft Fish", 51m, 1, 130, null },
                    { 20, 6, new DateTime(2022, 7, 3, 5, 12, 38, 646, DateTimeKind.Unspecified).AddTicks(7262), null, "Awesome Wooden Soap", 49m, 1, 53, null },
                    { 21, 6, new DateTime(2021, 6, 12, 16, 34, 54, 813, DateTimeKind.Unspecified).AddTicks(3742), null, "Handmade Steel Computer", 49m, 1, 144, null },
                    { 22, 8, new DateTime(2021, 11, 12, 22, 27, 50, 737, DateTimeKind.Unspecified).AddTicks(632), null, "Gorgeous Rubber Shoes", 51m, 1, 149, null },
                    { 23, 6, new DateTime(2022, 10, 14, 23, 51, 12, 318, DateTimeKind.Unspecified).AddTicks(1970), null, "Awesome Steel Computer", 53m, 1, 70, null },
                    { 24, 10, new DateTime(2022, 1, 17, 18, 44, 58, 935, DateTimeKind.Unspecified).AddTicks(8082), null, "Rustic Cotton Chicken", 50m, 1, 18, null },
                    { 25, 9, new DateTime(2022, 4, 7, 3, 48, 32, 954, DateTimeKind.Unspecified).AddTicks(6865), null, "Generic Metal Shirt", 52m, 1, 51, null },
                    { 26, 8, new DateTime(2021, 9, 9, 17, 4, 37, 413, DateTimeKind.Unspecified).AddTicks(2147), null, "Fantastic Granite Chips", 57m, 1, 173, null },
                    { 27, 7, new DateTime(2022, 2, 12, 3, 4, 19, 768, DateTimeKind.Unspecified).AddTicks(3778), null, "Small Concrete Pizza", 55m, 1, 182, null },
                    { 28, 10, new DateTime(2022, 3, 20, 1, 18, 2, 100, DateTimeKind.Unspecified).AddTicks(3397), null, "Intelligent Rubber Mouse", 54m, 1, 172, null },
                    { 29, 8, new DateTime(2022, 5, 6, 1, 13, 18, 236, DateTimeKind.Unspecified).AddTicks(3121), null, "Refined Frozen Pants", 49m, 1, 9, null },
                    { 30, 10, new DateTime(2022, 7, 6, 23, 46, 21, 588, DateTimeKind.Unspecified).AddTicks(8050), null, "Licensed Fresh Shoes", 51m, 1, 33, null }
                });

            migrationBuilder.InsertData(
                table: "UrunOzellikleri",
                columns: new[] { "Id", "Color", "CreatedDate", "DeletedDate", "Height", "Status", "ModifiedDate", "Width" },
                values: new object[,]
                {
                    { 1, "#2c4461", new DateTime(2021, 11, 18, 4, 5, 29, 918, DateTimeKind.Unspecified).AddTicks(7856), null, 186, 1, null, 101 },
                    { 2, "#2a0956", new DateTime(2022, 2, 23, 16, 32, 21, 403, DateTimeKind.Unspecified).AddTicks(7800), null, 76, 1, null, 142 },
                    { 3, "#49175b", new DateTime(2021, 11, 22, 20, 47, 47, 383, DateTimeKind.Unspecified).AddTicks(483), null, 168, 1, null, 84 },
                    { 4, "#2f0051", new DateTime(2022, 3, 30, 13, 1, 41, 254, DateTimeKind.Unspecified).AddTicks(4241), null, 143, 1, null, 12 },
                    { 5, "#286e79", new DateTime(2021, 7, 8, 19, 22, 27, 977, DateTimeKind.Unspecified).AddTicks(1528), null, 161, 1, null, 94 },
                    { 6, "#7f301b", new DateTime(2022, 2, 21, 16, 6, 22, 826, DateTimeKind.Unspecified).AddTicks(6990), null, 93, 1, null, 109 },
                    { 7, "#321450", new DateTime(2021, 8, 21, 16, 21, 38, 162, DateTimeKind.Unspecified).AddTicks(4297), null, 97, 1, null, 101 },
                    { 8, "#1c5c0a", new DateTime(2021, 8, 10, 19, 43, 50, 194, DateTimeKind.Unspecified).AddTicks(4725), null, 100, 1, null, 76 },
                    { 9, "#791658", new DateTime(2022, 4, 4, 8, 32, 22, 677, DateTimeKind.Unspecified).AddTicks(7557), null, 112, 1, null, 27 },
                    { 10, "#054345", new DateTime(2021, 9, 13, 11, 41, 24, 719, DateTimeKind.Unspecified).AddTicks(5933), null, 59, 1, null, 80 },
                    { 11, "#511450", new DateTime(2022, 6, 6, 19, 49, 34, 92, DateTimeKind.Unspecified).AddTicks(8293), null, 37, 1, null, 104 },
                    { 12, "#1c140a", new DateTime(2022, 3, 11, 10, 34, 44, 788, DateTimeKind.Unspecified).AddTicks(2649), null, 164, 1, null, 183 },
                    { 13, "#4f5e54", new DateTime(2022, 7, 13, 3, 1, 12, 7, DateTimeKind.Unspecified).AddTicks(9456), null, 101, 1, null, 77 },
                    { 14, "#133776", new DateTime(2022, 1, 8, 10, 38, 3, 331, DateTimeKind.Unspecified).AddTicks(8886), null, 147, 1, null, 36 },
                    { 15, "#7c7a2e", new DateTime(2021, 6, 1, 14, 9, 13, 514, DateTimeKind.Unspecified).AddTicks(8575), null, 113, 1, null, 75 },
                    { 16, "#235e42", new DateTime(2022, 7, 26, 8, 39, 18, 257, DateTimeKind.Unspecified).AddTicks(418), null, 11, 1, null, 135 },
                    { 17, "#360a1f", new DateTime(2021, 6, 24, 16, 34, 30, 863, DateTimeKind.Unspecified).AddTicks(1080), null, 150, 1, null, 64 },
                    { 18, "#487b7b", new DateTime(2022, 3, 11, 15, 51, 14, 306, DateTimeKind.Unspecified).AddTicks(2922), null, 121, 1, null, 28 },
                    { 19, "#390e1f", new DateTime(2022, 1, 22, 8, 13, 44, 7, DateTimeKind.Unspecified).AddTicks(1083), null, 32, 1, null, 93 },
                    { 20, "#56003c", new DateTime(2022, 9, 18, 23, 53, 50, 492, DateTimeKind.Unspecified).AddTicks(3039), null, 138, 1, null, 42 },
                    { 21, "#7c7034", new DateTime(2022, 11, 2, 4, 1, 15, 459, DateTimeKind.Unspecified).AddTicks(5397), null, 25, 1, null, 111 },
                    { 22, "#5e5312", new DateTime(2022, 11, 28, 3, 12, 56, 725, DateTimeKind.Unspecified).AddTicks(4827), null, 199, 1, null, 128 },
                    { 23, "#4b1c3b", new DateTime(2022, 3, 17, 8, 56, 51, 430, DateTimeKind.Unspecified).AddTicks(1583), null, 119, 1, null, 93 },
                    { 24, "#735b13", new DateTime(2021, 3, 18, 18, 25, 18, 364, DateTimeKind.Unspecified).AddTicks(7328), null, 191, 1, null, 13 },
                    { 25, "#11512b", new DateTime(2021, 6, 21, 4, 27, 31, 580, DateTimeKind.Unspecified).AddTicks(7745), null, 177, 1, null, 169 },
                    { 26, "#274702", new DateTime(2022, 7, 5, 13, 16, 27, 931, DateTimeKind.Unspecified).AddTicks(3733), null, 21, 1, null, 92 },
                    { 27, "#7d513b", new DateTime(2022, 5, 14, 20, 43, 40, 38, DateTimeKind.Unspecified).AddTicks(6633), null, 5, 1, null, 66 },
                    { 28, "#16374f", new DateTime(2021, 12, 3, 13, 59, 2, 468, DateTimeKind.Unspecified).AddTicks(3474), null, 148, 1, null, 195 },
                    { 29, "#641732", new DateTime(2021, 9, 11, 6, 20, 46, 980, DateTimeKind.Unspecified).AddTicks(7463), null, 200, 1, null, 166 },
                    { 30, "#5e1f04", new DateTime(2021, 9, 6, 6, 30, 26, 474, DateTimeKind.Unspecified).AddTicks(9360), null, 196, 1, null, 13 }
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
