using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class AddTotalBroken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TotalBroken_Products_ProductId",
                table: "TotalBroken");

            migrationBuilder.DropIndex(
                name: "IX_TotalBroken_ProductId",
                table: "TotalBroken");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "TotalBroken");

            migrationBuilder.AddColumn<int>(
                name: "TotalBrokenId",
                table: "BrokenProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BrokenProducts_TotalBrokenId",
                table: "BrokenProducts",
                column: "TotalBrokenId");

            migrationBuilder.AddForeignKey(
                name: "FK_BrokenProducts_TotalBroken_TotalBrokenId",
                table: "BrokenProducts",
                column: "TotalBrokenId",
                principalTable: "TotalBroken",
                principalColumn: "Id");

            // Add any additional operations...
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrokenProducts_TotalBroken_TotalBrokenId",
                table: "BrokenProducts");

            migrationBuilder.DropIndex(
                name: "IX_BrokenProducts_TotalBrokenId",
                table: "BrokenProducts");

            migrationBuilder.DropColumn(
                name: "TotalBrokenId",
                table: "BrokenProducts");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "TotalBroken",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TotalBroken_ProductId",
                table: "TotalBroken",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_TotalBroken_Products_ProductId",
                table: "TotalBroken",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

    }
}
