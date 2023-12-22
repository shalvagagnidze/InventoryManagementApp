using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class removeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_TotalSolds_TotalSoldId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_TotalSoldId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "TotalSoldId",
                table: "Sales");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalSoldId",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_TotalSoldId",
                table: "Sales",
                column: "TotalSoldId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_TotalSolds_TotalSoldId",
                table: "Sales",
                column: "TotalSoldId",
                principalTable: "TotalSolds",
                principalColumn: "Id");
        }
    }
}
