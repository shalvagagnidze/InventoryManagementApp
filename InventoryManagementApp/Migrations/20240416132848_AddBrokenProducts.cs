using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class AddBrokenProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrokenProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrokenProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrokenProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TotalBroken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalBroken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TotalBroken_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrokenProducts_ProductId",
                table: "BrokenProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TotalBroken_ProductId",
                table: "TotalBroken",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrokenProducts");

            migrationBuilder.DropTable(
                name: "TotalBroken");
        }
    }
}
