using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class DeletedTotalBroken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BrokenProducts_TotalBroken_TotalBrokenId",
                table: "BrokenProducts");

            migrationBuilder.DropTable(
                name: "TotalBroken");

            migrationBuilder.DropIndex(
                name: "IX_BrokenProducts_TotalBrokenId",
                table: "BrokenProducts");

            migrationBuilder.DropColumn(
                name: "TotalBrokenId",
                table: "BrokenProducts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalBrokenId",
                table: "BrokenProducts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TotalBroken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalBroken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TotalBroken_Products_Id",
                        column: x => x.Id,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }
    }
}
