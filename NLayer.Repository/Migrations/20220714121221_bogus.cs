using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class bogus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 1, new DateTime(2021, 11, 10, 14, 26, 4, 316, DateTimeKind.Unspecified).AddTicks(6606), null, "Games", 1, null },
                    { 2, new DateTime(2021, 12, 24, 10, 17, 14, 49, DateTimeKind.Unspecified).AddTicks(7397), null, "Toys", 1, null },
                    { 3, new DateTime(2022, 5, 14, 19, 37, 27, 558, DateTimeKind.Unspecified).AddTicks(3363), null, "Toys", 1, null },
                    { 4, new DateTime(2022, 5, 15, 9, 57, 45, 335, DateTimeKind.Unspecified).AddTicks(2357), null, "Movies", 1, null },
                    { 5, new DateTime(2022, 1, 30, 17, 59, 41, 342, DateTimeKind.Unspecified).AddTicks(1877), null, "Industrial", 1, null },
                    { 6, new DateTime(2022, 1, 2, 13, 14, 36, 683, DateTimeKind.Unspecified).AddTicks(9574), null, "Baby", 1, null },
                    { 7, new DateTime(2021, 4, 11, 1, 46, 15, 317, DateTimeKind.Unspecified).AddTicks(5726), null, "Health", 1, null },
                    { 8, new DateTime(2021, 3, 19, 18, 45, 11, 607, DateTimeKind.Unspecified).AddTicks(8330), null, "Jewelery", 1, null },
                    { 9, new DateTime(2021, 5, 24, 2, 47, 22, 129, DateTimeKind.Unspecified).AddTicks(4352), null, "Kids", 1, null },
                    { 10, new DateTime(2021, 8, 22, 9, 33, 36, 944, DateTimeKind.Unspecified).AddTicks(9464), null, "Outdoors", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Name", "Price", "Status", "Stock", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2021, 10, 29, 23, 24, 52, 530, DateTimeKind.Unspecified).AddTicks(3019), null, "Gorgeous Plastic Chicken", 53m, 1, 79, null },
                    { 2, 2, new DateTime(2021, 7, 29, 23, 2, 30, 324, DateTimeKind.Unspecified).AddTicks(4223), null, "Incredible Rubber Towels", 49m, 1, 146, null },
                    { 3, 4, new DateTime(2021, 9, 28, 0, 27, 21, 625, DateTimeKind.Unspecified).AddTicks(116), null, "Fantastic Frozen Keyboard", 52m, 1, 63, null },
                    { 4, 7, new DateTime(2021, 5, 26, 15, 22, 17, 672, DateTimeKind.Unspecified).AddTicks(7488), null, "Tasty Rubber Chair", 49m, 1, 54, null },
                    { 5, 3, new DateTime(2021, 9, 18, 6, 36, 3, 460, DateTimeKind.Unspecified).AddTicks(1850), null, "Refined Soft Table", 49m, 1, 9, null },
                    { 6, 1, new DateTime(2021, 8, 6, 8, 49, 34, 720, DateTimeKind.Unspecified).AddTicks(7373), null, "Incredible Fresh Keyboard", 56m, 1, 92, null },
                    { 7, 4, new DateTime(2022, 4, 20, 22, 12, 37, 266, DateTimeKind.Unspecified).AddTicks(4962), null, "Handmade Granite Sausages", 51m, 1, 190, null },
                    { 8, 10, new DateTime(2021, 6, 20, 7, 8, 30, 795, DateTimeKind.Unspecified).AddTicks(8450), null, "Fantastic Concrete Fish", 55m, 1, 190, null },
                    { 9, 6, new DateTime(2022, 5, 8, 11, 36, 39, 410, DateTimeKind.Unspecified).AddTicks(7116), null, "Generic Metal Bike", 57m, 1, 148, null },
                    { 10, 7, new DateTime(2022, 7, 3, 15, 31, 0, 610, DateTimeKind.Unspecified).AddTicks(6066), null, "Gorgeous Frozen Bacon", 51m, 1, 12, null },
                    { 11, 1, new DateTime(2022, 7, 10, 17, 35, 43, 233, DateTimeKind.Unspecified).AddTicks(2162), null, "Handcrafted Wooden Table", 57m, 1, 80, null },
                    { 12, 4, new DateTime(2022, 4, 11, 6, 47, 33, 989, DateTimeKind.Unspecified).AddTicks(7543), null, "Handmade Soft Pizza", 52m, 1, 51, null },
                    { 13, 8, new DateTime(2022, 5, 17, 0, 22, 14, 374, DateTimeKind.Unspecified).AddTicks(2691), null, "Tasty Granite Fish", 52m, 1, 58, null },
                    { 14, 9, new DateTime(2022, 4, 27, 16, 12, 39, 501, DateTimeKind.Unspecified).AddTicks(4406), null, "Practical Plastic Bacon", 56m, 1, 188, null },
                    { 15, 4, new DateTime(2021, 3, 29, 0, 20, 50, 413, DateTimeKind.Unspecified).AddTicks(9338), null, "Handcrafted Soft Pants", 50m, 1, 137, null },
                    { 16, 6, new DateTime(2022, 4, 9, 9, 39, 59, 461, DateTimeKind.Unspecified).AddTicks(1684), null, "Practical Wooden Fish", 51m, 1, 7, null },
                    { 17, 3, new DateTime(2021, 9, 10, 13, 58, 5, 23, DateTimeKind.Unspecified).AddTicks(5055), null, "Fantastic Metal Fish", 50m, 1, 84, null },
                    { 18, 9, new DateTime(2022, 3, 18, 23, 40, 52, 891, DateTimeKind.Unspecified).AddTicks(9957), null, "Fantastic Rubber Salad", 56m, 1, 179, null },
                    { 19, 7, new DateTime(2022, 5, 9, 19, 51, 5, 547, DateTimeKind.Unspecified).AddTicks(690), null, "Practical Metal Cheese", 53m, 1, 63, null },
                    { 20, 10, new DateTime(2021, 7, 18, 17, 10, 33, 272, DateTimeKind.Unspecified).AddTicks(7242), null, "Tasty Cotton Pizza", 57m, 1, 124, null },
                    { 21, 5, new DateTime(2021, 9, 15, 12, 30, 19, 721, DateTimeKind.Unspecified).AddTicks(5351), null, "Incredible Steel Keyboard", 49m, 1, 151, null },
                    { 22, 6, new DateTime(2022, 5, 6, 14, 36, 53, 348, DateTimeKind.Unspecified).AddTicks(4784), null, "Awesome Granite Bike", 55m, 1, 13, null },
                    { 23, 3, new DateTime(2021, 10, 2, 1, 47, 6, 87, DateTimeKind.Unspecified).AddTicks(1501), null, "Ergonomic Steel Bike", 49m, 1, 175, null },
                    { 24, 2, new DateTime(2021, 11, 25, 12, 36, 29, 127, DateTimeKind.Unspecified).AddTicks(8413), null, "Incredible Rubber Chicken", 54m, 1, 117, null },
                    { 25, 10, new DateTime(2022, 2, 27, 10, 32, 22, 740, DateTimeKind.Unspecified).AddTicks(3813), null, "Small Metal Gloves", 49m, 1, 141, null },
                    { 26, 3, new DateTime(2022, 6, 2, 0, 30, 57, 62, DateTimeKind.Unspecified).AddTicks(4022), null, "Rustic Frozen Chicken", 50m, 1, 95, null },
                    { 27, 1, new DateTime(2022, 5, 2, 22, 10, 57, 433, DateTimeKind.Unspecified).AddTicks(9974), null, "Small Wooden Chair", 54m, 1, 191, null },
                    { 28, 8, new DateTime(2021, 10, 11, 8, 40, 0, 959, DateTimeKind.Unspecified).AddTicks(9467), null, "Tasty Metal Pizza", 54m, 1, 182, null },
                    { 29, 1, new DateTime(2021, 7, 21, 4, 8, 52, 961, DateTimeKind.Unspecified).AddTicks(4833), null, "Practical Concrete Pants", 50m, 1, 86, null },
                    { 30, 7, new DateTime(2021, 10, 10, 7, 20, 41, 715, DateTimeKind.Unspecified).AddTicks(2841), null, "Small Steel Chips", 53m, 1, 139, null }
                });

            migrationBuilder.InsertData(
                table: "UrunOzellikleri",
                columns: new[] { "Id", "Color", "CreatedDate", "DeletedDate", "Height", "Status", "ModifiedDate", "Width" },
                values: new object[,]
                {
                    { 1, "#4b262d", new DateTime(2021, 4, 28, 8, 48, 6, 544, DateTimeKind.Unspecified).AddTicks(319), null, 139, 1, null, 154 },
                    { 2, "#732d23", new DateTime(2022, 1, 13, 20, 20, 58, 124, DateTimeKind.Unspecified).AddTicks(452), null, 162, 1, null, 103 },
                    { 3, "#3f4b7c", new DateTime(2021, 3, 22, 8, 27, 54, 619, DateTimeKind.Unspecified).AddTicks(7037), null, 77, 1, null, 97 },
                    { 4, "#5b6c2f", new DateTime(2022, 6, 25, 7, 31, 28, 96, DateTimeKind.Unspecified).AddTicks(3453), null, 190, 1, null, 109 },
                    { 5, "#767c59", new DateTime(2021, 5, 11, 12, 45, 0, 611, DateTimeKind.Unspecified).AddTicks(1016), null, 170, 1, null, 64 },
                    { 6, "#604a4f", new DateTime(2022, 1, 28, 23, 19, 47, 144, DateTimeKind.Unspecified).AddTicks(5366), null, 33, 1, null, 154 },
                    { 7, "#555308", new DateTime(2022, 6, 28, 9, 38, 16, 619, DateTimeKind.Unspecified).AddTicks(3029), null, 200, 1, null, 19 },
                    { 8, "#336d2a", new DateTime(2021, 10, 29, 5, 3, 32, 283, DateTimeKind.Unspecified).AddTicks(5048), null, 177, 1, null, 30 },
                    { 9, "#640f39", new DateTime(2021, 7, 3, 8, 42, 42, 393, DateTimeKind.Unspecified).AddTicks(6345), null, 68, 1, null, 44 },
                    { 10, "#5d144d", new DateTime(2021, 8, 7, 21, 13, 41, 15, DateTimeKind.Unspecified).AddTicks(3247), null, 19, 1, null, 167 },
                    { 11, "#5b707f", new DateTime(2022, 6, 14, 3, 30, 31, 161, DateTimeKind.Unspecified).AddTicks(9504), null, 158, 1, null, 35 },
                    { 12, "#42385b", new DateTime(2022, 3, 12, 6, 50, 41, 425, DateTimeKind.Unspecified).AddTicks(5957), null, 167, 1, null, 108 },
                    { 13, "#4c3f2e", new DateTime(2021, 8, 15, 18, 50, 10, 291, DateTimeKind.Unspecified).AddTicks(6225), null, 107, 1, null, 103 },
                    { 14, "#736a4b", new DateTime(2021, 12, 15, 8, 9, 17, 738, DateTimeKind.Unspecified).AddTicks(2522), null, 125, 1, null, 43 },
                    { 15, "#4f6502", new DateTime(2021, 7, 7, 21, 53, 0, 183, DateTimeKind.Unspecified).AddTicks(1238), null, 152, 1, null, 182 },
                    { 16, "#5a277e", new DateTime(2021, 11, 2, 18, 21, 42, 369, DateTimeKind.Unspecified).AddTicks(4324), null, 176, 1, null, 158 },
                    { 17, "#621576", new DateTime(2022, 2, 5, 9, 15, 18, 443, DateTimeKind.Unspecified).AddTicks(4449), null, 97, 1, null, 175 },
                    { 18, "#35686d", new DateTime(2022, 4, 6, 6, 12, 56, 277, DateTimeKind.Unspecified).AddTicks(9045), null, 177, 1, null, 143 },
                    { 19, "#4e6654", new DateTime(2022, 4, 22, 15, 10, 19, 471, DateTimeKind.Unspecified).AddTicks(336), null, 11, 1, null, 168 },
                    { 20, "#2c3964", new DateTime(2021, 4, 18, 0, 17, 36, 335, DateTimeKind.Unspecified).AddTicks(3375), null, 49, 1, null, 187 },
                    { 21, "#567226", new DateTime(2021, 10, 14, 6, 50, 3, 719, DateTimeKind.Unspecified).AddTicks(3243), null, 34, 1, null, 183 },
                    { 22, "#7f5a04", new DateTime(2021, 10, 1, 10, 26, 15, 514, DateTimeKind.Unspecified).AddTicks(4978), null, 58, 1, null, 184 },
                    { 23, "#80375d", new DateTime(2021, 10, 31, 2, 0, 27, 69, DateTimeKind.Unspecified).AddTicks(8704), null, 37, 1, null, 167 },
                    { 24, "#29787e", new DateTime(2021, 11, 10, 15, 2, 6, 411, DateTimeKind.Unspecified).AddTicks(8960), null, 128, 1, null, 17 },
                    { 25, "#3f6d75", new DateTime(2021, 9, 15, 8, 44, 30, 347, DateTimeKind.Unspecified).AddTicks(7104), null, 135, 1, null, 58 },
                    { 26, "#716258", new DateTime(2022, 6, 25, 20, 10, 32, 169, DateTimeKind.Unspecified).AddTicks(5184), null, 161, 1, null, 94 },
                    { 27, "#607748", new DateTime(2021, 7, 10, 20, 4, 57, 125, DateTimeKind.Unspecified).AddTicks(5432), null, 26, 1, null, 191 },
                    { 28, "#56110d", new DateTime(2021, 6, 23, 5, 48, 48, 184, DateTimeKind.Unspecified).AddTicks(8850), null, 197, 1, null, 37 },
                    { 29, "#6f0211", new DateTime(2021, 5, 27, 19, 20, 11, 533, DateTimeKind.Unspecified).AddTicks(1088), null, 137, 1, null, 167 },
                    { 30, "#543d72", new DateTime(2021, 9, 10, 22, 58, 49, 198, DateTimeKind.Unspecified).AddTicks(5394), null, 79, 1, null, 88 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_CategoryId",
                table: "Urunler",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UrunOzellikleri");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
