using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class appUser : Migration
    {
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
                    Role = table.Column<int>(type: "int", nullable: false),
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
                    { 1, new DateTime(2021, 11, 5, 21, 2, 22, 964, DateTimeKind.Unspecified).AddTicks(1098), null, "Grocery", 1, null },
                    { 2, new DateTime(2022, 6, 13, 6, 27, 30, 92, DateTimeKind.Unspecified).AddTicks(5113), null, "Jewelery", 1, null },
                    { 3, new DateTime(2022, 6, 19, 3, 43, 59, 872, DateTimeKind.Unspecified).AddTicks(8155), null, "Electronics", 1, null },
                    { 4, new DateTime(2021, 12, 24, 2, 0, 8, 275, DateTimeKind.Unspecified).AddTicks(7508), null, "Baby", 1, null },
                    { 5, new DateTime(2022, 3, 19, 11, 4, 0, 395, DateTimeKind.Unspecified).AddTicks(9135), null, "Tools", 1, null },
                    { 6, new DateTime(2022, 1, 2, 6, 11, 24, 51, DateTimeKind.Unspecified).AddTicks(709), null, "Beauty", 1, null },
                    { 7, new DateTime(2021, 3, 27, 9, 43, 19, 142, DateTimeKind.Unspecified).AddTicks(8149), null, "Electronics", 1, null },
                    { 8, new DateTime(2022, 2, 22, 9, 59, 41, 599, DateTimeKind.Unspecified).AddTicks(8335), null, "Shoes", 1, null },
                    { 9, new DateTime(2022, 4, 28, 10, 34, 23, 671, DateTimeKind.Unspecified).AddTicks(5616), null, "Shoes", 1, null },
                    { 10, new DateTime(2022, 2, 18, 18, 50, 31, 652, DateTimeKind.Unspecified).AddTicks(6844), null, "Shoes", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Name", "Price", "Status", "Stock", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2022, 2, 13, 21, 15, 40, 368, DateTimeKind.Unspecified).AddTicks(1349), null, "Practical Rubber Car", 57m, 1, 24, null },
                    { 2, 2, new DateTime(2021, 6, 12, 22, 41, 10, 444, DateTimeKind.Unspecified).AddTicks(7620), null, "Licensed Soft Chips", 50m, 1, 68, null },
                    { 3, 3, new DateTime(2022, 2, 22, 18, 0, 5, 769, DateTimeKind.Unspecified).AddTicks(4086), null, "Awesome Plastic Pants", 57m, 1, 47, null },
                    { 4, 3, new DateTime(2021, 8, 9, 20, 30, 0, 861, DateTimeKind.Unspecified).AddTicks(678), null, "Gorgeous Rubber Keyboard", 54m, 1, 153, null },
                    { 5, 8, new DateTime(2021, 6, 27, 18, 48, 20, 908, DateTimeKind.Unspecified).AddTicks(4138), null, "Sleek Rubber Car", 52m, 1, 55, null },
                    { 6, 7, new DateTime(2022, 2, 18, 0, 30, 19, 984, DateTimeKind.Unspecified).AddTicks(6069), null, "Practical Plastic Towels", 55m, 1, 154, null },
                    { 7, 8, new DateTime(2021, 12, 27, 7, 30, 44, 651, DateTimeKind.Unspecified).AddTicks(2735), null, "Small Cotton Chair", 50m, 1, 199, null },
                    { 8, 1, new DateTime(2022, 3, 13, 1, 33, 5, 813, DateTimeKind.Unspecified).AddTicks(52), null, "Refined Metal Car", 49m, 1, 75, null },
                    { 9, 2, new DateTime(2022, 1, 28, 0, 42, 25, 916, DateTimeKind.Unspecified).AddTicks(9486), null, "Refined Plastic Mouse", 50m, 1, 103, null },
                    { 10, 10, new DateTime(2021, 5, 17, 15, 39, 56, 890, DateTimeKind.Unspecified).AddTicks(4064), null, "Sleek Cotton Chips", 57m, 1, 170, null },
                    { 11, 7, new DateTime(2022, 4, 2, 1, 11, 10, 462, DateTimeKind.Unspecified).AddTicks(3359), null, "Unbranded Concrete Chair", 54m, 1, 135, null },
                    { 12, 6, new DateTime(2021, 11, 7, 5, 49, 51, 272, DateTimeKind.Unspecified).AddTicks(4677), null, "Licensed Granite Salad", 55m, 1, 108, null },
                    { 13, 7, new DateTime(2021, 6, 29, 13, 31, 40, 81, DateTimeKind.Unspecified).AddTicks(1143), null, "Ergonomic Granite Fish", 56m, 1, 117, null },
                    { 14, 10, new DateTime(2021, 6, 4, 9, 37, 37, 699, DateTimeKind.Unspecified).AddTicks(8941), null, "Generic Wooden Chair", 53m, 1, 162, null },
                    { 15, 10, new DateTime(2021, 12, 20, 22, 5, 57, 152, DateTimeKind.Unspecified).AddTicks(3965), null, "Licensed Granite Bike", 55m, 1, 96, null },
                    { 16, 9, new DateTime(2021, 12, 14, 11, 14, 10, 186, DateTimeKind.Unspecified).AddTicks(6471), null, "Gorgeous Wooden Bacon", 55m, 1, 26, null },
                    { 17, 2, new DateTime(2021, 3, 31, 21, 19, 43, 654, DateTimeKind.Unspecified).AddTicks(4680), null, "Licensed Metal Chicken", 56m, 1, 3, null },
                    { 18, 8, new DateTime(2021, 7, 2, 7, 52, 23, 569, DateTimeKind.Unspecified).AddTicks(9588), null, "Licensed Granite Soap", 53m, 1, 54, null },
                    { 19, 8, new DateTime(2021, 12, 14, 4, 13, 52, 405, DateTimeKind.Unspecified).AddTicks(7666), null, "Generic Metal Tuna", 57m, 1, 5, null },
                    { 20, 1, new DateTime(2021, 9, 2, 12, 26, 6, 612, DateTimeKind.Unspecified).AddTicks(2277), null, "Ergonomic Wooden Towels", 53m, 1, 97, null },
                    { 21, 10, new DateTime(2021, 8, 5, 11, 6, 8, 342, DateTimeKind.Unspecified).AddTicks(5002), null, "Gorgeous Rubber Pants", 57m, 1, 101, null },
                    { 22, 9, new DateTime(2022, 1, 24, 17, 42, 32, 836, DateTimeKind.Unspecified).AddTicks(6543), null, "Awesome Rubber Towels", 51m, 1, 35, null },
                    { 23, 3, new DateTime(2022, 6, 3, 23, 35, 21, 224, DateTimeKind.Unspecified).AddTicks(7152), null, "Refined Fresh Pants", 49m, 1, 105, null },
                    { 24, 5, new DateTime(2021, 4, 26, 13, 25, 2, 755, DateTimeKind.Unspecified).AddTicks(4907), null, "Handmade Cotton Towels", 56m, 1, 61, null },
                    { 25, 7, new DateTime(2021, 6, 22, 4, 4, 35, 355, DateTimeKind.Unspecified).AddTicks(8102), null, "Generic Steel Bacon", 54m, 1, 48, null },
                    { 26, 1, new DateTime(2022, 7, 12, 2, 8, 27, 681, DateTimeKind.Unspecified).AddTicks(3366), null, "Fantastic Frozen Pants", 55m, 1, 146, null },
                    { 27, 4, new DateTime(2021, 7, 20, 14, 31, 27, 976, DateTimeKind.Unspecified).AddTicks(8896), null, "Unbranded Granite Car", 54m, 1, 97, null },
                    { 28, 8, new DateTime(2021, 5, 23, 17, 6, 25, 970, DateTimeKind.Unspecified).AddTicks(7120), null, "Intelligent Rubber Shoes", 54m, 1, 198, null },
                    { 29, 6, new DateTime(2021, 4, 3, 16, 55, 16, 353, DateTimeKind.Unspecified).AddTicks(8865), null, "Sleek Steel Soap", 57m, 1, 130, null },
                    { 30, 1, new DateTime(2021, 8, 10, 8, 41, 17, 933, DateTimeKind.Unspecified).AddTicks(9939), null, "Practical Metal Chicken", 55m, 1, 42, null }
                });

            migrationBuilder.InsertData(
                table: "UrunOzellikleri",
                columns: new[] { "Id", "Color", "CreatedDate", "DeletedDate", "Height", "Status", "ModifiedDate", "Width" },
                values: new object[,]
                {
                    { 1, "#63062b", new DateTime(2022, 2, 7, 4, 41, 21, 587, DateTimeKind.Unspecified).AddTicks(955), null, 65, 1, null, 145 },
                    { 2, "#251f29", new DateTime(2022, 4, 15, 21, 24, 59, 573, DateTimeKind.Unspecified).AddTicks(7298), null, 181, 1, null, 156 },
                    { 3, "#60024e", new DateTime(2021, 7, 6, 2, 1, 58, 705, DateTimeKind.Unspecified).AddTicks(6997), null, 71, 1, null, 156 },
                    { 4, "#4a402f", new DateTime(2021, 7, 29, 9, 37, 31, 482, DateTimeKind.Unspecified).AddTicks(2507), null, 115, 1, null, 10 },
                    { 5, "#3d6475", new DateTime(2021, 11, 14, 7, 39, 13, 909, DateTimeKind.Unspecified).AddTicks(7956), null, 40, 1, null, 127 },
                    { 6, "#3f397d", new DateTime(2021, 3, 31, 21, 17, 14, 605, DateTimeKind.Unspecified).AddTicks(816), null, 68, 1, null, 24 },
                    { 7, "#481560", new DateTime(2021, 4, 21, 21, 39, 47, 127, DateTimeKind.Unspecified).AddTicks(4378), null, 121, 1, null, 26 },
                    { 8, "#694a4d", new DateTime(2022, 3, 15, 17, 46, 18, 23, DateTimeKind.Unspecified).AddTicks(8612), null, 30, 1, null, 143 },
                    { 9, "#6b4a60", new DateTime(2021, 8, 3, 17, 57, 35, 718, DateTimeKind.Unspecified).AddTicks(1143), null, 140, 1, null, 147 },
                    { 10, "#044423", new DateTime(2021, 6, 15, 15, 32, 9, 310, DateTimeKind.Unspecified).AddTicks(3844), null, 87, 1, null, 81 },
                    { 11, "#4e277c", new DateTime(2021, 6, 19, 21, 37, 51, 808, DateTimeKind.Unspecified).AddTicks(1654), null, 22, 1, null, 165 },
                    { 12, "#546645", new DateTime(2022, 7, 1, 10, 40, 59, 665, DateTimeKind.Unspecified).AddTicks(2753), null, 178, 1, null, 161 },
                    { 13, "#6c7d1d", new DateTime(2022, 5, 14, 22, 37, 32, 276, DateTimeKind.Unspecified).AddTicks(7812), null, 107, 1, null, 9 },
                    { 14, "#1e4906", new DateTime(2021, 6, 8, 5, 16, 34, 900, DateTimeKind.Unspecified).AddTicks(8666), null, 79, 1, null, 131 },
                    { 15, "#6c045c", new DateTime(2022, 6, 29, 11, 17, 21, 855, DateTimeKind.Unspecified).AddTicks(2086), null, 13, 1, null, 89 },
                    { 16, "#0d0a09", new DateTime(2021, 5, 21, 11, 38, 31, 584, DateTimeKind.Unspecified).AddTicks(9626), null, 128, 1, null, 77 },
                    { 17, "#2a3e43", new DateTime(2022, 6, 8, 13, 50, 55, 691, DateTimeKind.Unspecified).AddTicks(5638), null, 139, 1, null, 28 },
                    { 18, "#653611", new DateTime(2022, 4, 14, 20, 56, 20, 991, DateTimeKind.Unspecified).AddTicks(7325), null, 129, 1, null, 86 },
                    { 19, "#4a3312", new DateTime(2021, 10, 18, 22, 45, 21, 621, DateTimeKind.Unspecified).AddTicks(3486), null, 114, 1, null, 56 },
                    { 20, "#787e73", new DateTime(2021, 9, 16, 17, 40, 27, 647, DateTimeKind.Unspecified).AddTicks(4855), null, 92, 1, null, 129 },
                    { 21, "#050e4e", new DateTime(2021, 12, 17, 15, 12, 32, 253, DateTimeKind.Unspecified).AddTicks(7853), null, 66, 1, null, 45 },
                    { 22, "#1c0a63", new DateTime(2021, 7, 31, 20, 57, 13, 923, DateTimeKind.Unspecified).AddTicks(8823), null, 142, 1, null, 123 },
                    { 23, "#1e201d", new DateTime(2021, 10, 3, 2, 24, 56, 549, DateTimeKind.Unspecified).AddTicks(3734), null, 11, 1, null, 163 },
                    { 24, "#3f3800", new DateTime(2021, 7, 12, 0, 59, 11, 318, DateTimeKind.Unspecified).AddTicks(2391), null, 55, 1, null, 134 },
                    { 25, "#6b6617", new DateTime(2021, 8, 6, 16, 18, 25, 956, DateTimeKind.Unspecified).AddTicks(9839), null, 14, 1, null, 109 },
                    { 26, "#2a0673", new DateTime(2022, 3, 16, 20, 51, 4, 884, DateTimeKind.Unspecified).AddTicks(2768), null, 144, 1, null, 182 },
                    { 27, "#1c1c38", new DateTime(2021, 5, 5, 11, 18, 19, 916, DateTimeKind.Unspecified).AddTicks(8469), null, 37, 1, null, 19 },
                    { 28, "#3e2928", new DateTime(2021, 4, 9, 6, 39, 42, 903, DateTimeKind.Unspecified).AddTicks(9620), null, 199, 1, null, 72 },
                    { 29, "#730948", new DateTime(2021, 5, 14, 10, 50, 30, 526, DateTimeKind.Unspecified).AddTicks(2240), null, 129, 1, null, 144 },
                    { 30, "#4f7c47", new DateTime(2022, 3, 7, 17, 21, 18, 138, DateTimeKind.Unspecified).AddTicks(8764), null, 53, 1, null, 54 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_CategoryId",
                table: "Urunler",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserProfile");

            migrationBuilder.DropTable(
                name: "UrunOzellikleri");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
