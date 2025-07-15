using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Select2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Books" },
                    { 3, "Clothing" },
                    { 4, "Home & Kitchen" },
                    { 5, "Toys" },
                    { 6, "Health & Beauty" },
                    { 7, "Sports" },
                    { 8, "Automotive" },
                    { 9, "Garden" },
                    { 10, "Office Supplies" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 10, "Description for product 1", "Product 1", 438.05m },
                    { 2, 8, "Description for product 2", "Product 2", 142.39m },
                    { 3, 1, "Description for product 3", "Product 3", 149.84m },
                    { 4, 2, "Description for product 4", "Product 4", 131.24m },
                    { 5, 4, "Description for product 5", "Product 5", 378.87m },
                    { 6, 4, "Description for product 6", "Product 6", 480.91m },
                    { 7, 1, "Description for product 7", "Product 7", 14.33m },
                    { 8, 4, "Description for product 8", "Product 8", 173.04m },
                    { 9, 6, "Description for product 9", "Product 9", 48.94m },
                    { 10, 4, "Description for product 10", "Product 10", 498.16m },
                    { 11, 5, "Description for product 11", "Product 11", 100.90m },
                    { 12, 4, "Description for product 12", "Product 12", 498.57m },
                    { 13, 3, "Description for product 13", "Product 13", 418.30m },
                    { 14, 10, "Description for product 14", "Product 14", 94.88m },
                    { 15, 5, "Description for product 15", "Product 15", 58.24m },
                    { 16, 9, "Description for product 16", "Product 16", 331.84m },
                    { 17, 4, "Description for product 17", "Product 17", 491.91m },
                    { 18, 3, "Description for product 18", "Product 18", 396.50m },
                    { 19, 9, "Description for product 19", "Product 19", 40.00m },
                    { 20, 7, "Description for product 20", "Product 20", 357.12m },
                    { 21, 9, "Description for product 21", "Product 21", 372.93m },
                    { 22, 5, "Description for product 22", "Product 22", 106.03m },
                    { 23, 4, "Description for product 23", "Product 23", 344.89m },
                    { 24, 9, "Description for product 24", "Product 24", 177.95m },
                    { 25, 1, "Description for product 25", "Product 25", 72.62m },
                    { 26, 10, "Description for product 26", "Product 26", 158.07m },
                    { 27, 6, "Description for product 27", "Product 27", 74.93m },
                    { 28, 9, "Description for product 28", "Product 28", 130.90m },
                    { 29, 3, "Description for product 29", "Product 29", 41.56m },
                    { 30, 10, "Description for product 30", "Product 30", 442.51m },
                    { 31, 7, "Description for product 31", "Product 31", 170.10m },
                    { 32, 8, "Description for product 32", "Product 32", 225.36m },
                    { 33, 8, "Description for product 33", "Product 33", 157.66m },
                    { 34, 7, "Description for product 34", "Product 34", 19.14m },
                    { 35, 4, "Description for product 35", "Product 35", 297.50m },
                    { 36, 7, "Description for product 36", "Product 36", 92.16m },
                    { 37, 9, "Description for product 37", "Product 37", 497.74m },
                    { 38, 9, "Description for product 38", "Product 38", 473.84m },
                    { 39, 6, "Description for product 39", "Product 39", 292.12m },
                    { 40, 3, "Description for product 40", "Product 40", 215.44m },
                    { 41, 4, "Description for product 41", "Product 41", 404.58m },
                    { 42, 8, "Description for product 42", "Product 42", 227.57m },
                    { 43, 2, "Description for product 43", "Product 43", 116.82m },
                    { 44, 3, "Description for product 44", "Product 44", 382.91m },
                    { 45, 8, "Description for product 45", "Product 45", 14.67m },
                    { 46, 9, "Description for product 46", "Product 46", 98.47m },
                    { 47, 8, "Description for product 47", "Product 47", 413.63m },
                    { 48, 9, "Description for product 48", "Product 48", 54.44m },
                    { 49, 8, "Description for product 49", "Product 49", 290.03m },
                    { 50, 9, "Description for product 50", "Product 50", 249.30m },
                    { 51, 6, "Description for product 51", "Product 51", 245.98m },
                    { 52, 8, "Description for product 52", "Product 52", 449.41m },
                    { 53, 4, "Description for product 53", "Product 53", 23.30m },
                    { 54, 1, "Description for product 54", "Product 54", 396.58m },
                    { 55, 7, "Description for product 55", "Product 55", 134.65m },
                    { 56, 9, "Description for product 56", "Product 56", 164.07m },
                    { 57, 3, "Description for product 57", "Product 57", 247.69m },
                    { 58, 5, "Description for product 58", "Product 58", 475.55m },
                    { 59, 9, "Description for product 59", "Product 59", 57.99m },
                    { 60, 7, "Description for product 60", "Product 60", 102.34m },
                    { 61, 10, "Description for product 61", "Product 61", 45.18m },
                    { 62, 3, "Description for product 62", "Product 62", 357.63m },
                    { 63, 3, "Description for product 63", "Product 63", 342.93m },
                    { 64, 1, "Description for product 64", "Product 64", 330.37m },
                    { 65, 8, "Description for product 65", "Product 65", 418.75m },
                    { 66, 3, "Description for product 66", "Product 66", 14.42m },
                    { 67, 9, "Description for product 67", "Product 67", 143.72m },
                    { 68, 9, "Description for product 68", "Product 68", 156.73m },
                    { 69, 8, "Description for product 69", "Product 69", 230.51m },
                    { 70, 4, "Description for product 70", "Product 70", 452.49m },
                    { 71, 4, "Description for product 71", "Product 71", 65.43m },
                    { 72, 1, "Description for product 72", "Product 72", 113.36m },
                    { 73, 9, "Description for product 73", "Product 73", 25.93m },
                    { 74, 5, "Description for product 74", "Product 74", 92.12m },
                    { 75, 2, "Description for product 75", "Product 75", 263.28m },
                    { 76, 7, "Description for product 76", "Product 76", 101.19m },
                    { 77, 4, "Description for product 77", "Product 77", 345.38m },
                    { 78, 1, "Description for product 78", "Product 78", 296.14m },
                    { 79, 5, "Description for product 79", "Product 79", 441.54m },
                    { 80, 5, "Description for product 80", "Product 80", 115.81m },
                    { 81, 8, "Description for product 81", "Product 81", 327.01m },
                    { 82, 7, "Description for product 82", "Product 82", 242.11m },
                    { 83, 4, "Description for product 83", "Product 83", 481.51m },
                    { 84, 8, "Description for product 84", "Product 84", 449.93m },
                    { 85, 1, "Description for product 85", "Product 85", 218.52m },
                    { 86, 9, "Description for product 86", "Product 86", 308.76m },
                    { 87, 4, "Description for product 87", "Product 87", 90.85m },
                    { 88, 3, "Description for product 88", "Product 88", 215.28m },
                    { 89, 7, "Description for product 89", "Product 89", 400.44m },
                    { 90, 8, "Description for product 90", "Product 90", 454.71m },
                    { 91, 5, "Description for product 91", "Product 91", 61.04m },
                    { 92, 1, "Description for product 92", "Product 92", 491.80m },
                    { 93, 1, "Description for product 93", "Product 93", 223.55m },
                    { 94, 3, "Description for product 94", "Product 94", 126.44m },
                    { 95, 8, "Description for product 95", "Product 95", 57.91m },
                    { 96, 6, "Description for product 96", "Product 96", 4.02m },
                    { 97, 2, "Description for product 97", "Product 97", 419.43m },
                    { 98, 7, "Description for product 98", "Product 98", 119.65m },
                    { 99, 3, "Description for product 99", "Product 99", 178.97m },
                    { 100, 8, "Description for product 100", "Product 100", 157.92m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
