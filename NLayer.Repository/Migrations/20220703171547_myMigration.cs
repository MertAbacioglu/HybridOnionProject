using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class myMigration : Migration
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
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6313), null, "Laptop", 1, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[] { 2, new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6318), null, "Mobile Phone", 1, null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[] { 3, new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6320), null, "Vinly", 1, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "Name", "Price", "Status", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6462), null, "MSI CX-61", 100m, 1, 5, null },
                    { 2, 1, new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6465), null, "Lenov Z580", 100m, 1, 5, null },
                    { 3, 1, new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6467), null, "HP Probook", 100m, 1, 5, null },
                    { 4, 2, new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6469), null, "IPhone 11", 100m, 1, 5, null },
                    { 5, 2, new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6471), null, "Galaxy Core", 100m, 1, 5, null },
                    { 6, 3, new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6473), null, "Metallica Load", 100m, 1, 5, null },
                    { 7, 3, new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6475), null, "ELOY Down", 100m, 1, 5, null }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "Color", "CreatedDate", "DeletedDate", "Height", "Status", "UpdatedDate", "Width" },
                values: new object[,]
                {
                    { 1, "Blue", new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6495), null, 11, 1, null, 21 },
                    { 2, "Blue", new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6497), null, 12, 1, null, 22 },
                    { 3, "Blue", new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6499), null, 13, 1, null, 23 },
                    { 4, "Blue", new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6501), null, 14, 1, null, 24 },
                    { 5, "Blue", new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6503), null, 15, 1, null, 25 },
                    { 6, "Blue", new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6505), null, 16, 1, null, 26 },
                    { 7, "Blue", new DateTime(2022, 7, 3, 20, 15, 47, 263, DateTimeKind.Local).AddTicks(6507), null, 17, 1, null, 27 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
