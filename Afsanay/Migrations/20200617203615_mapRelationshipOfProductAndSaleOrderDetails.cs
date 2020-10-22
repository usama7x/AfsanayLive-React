using Microsoft.EntityFrameworkCore.Migrations;

namespace Afsanay.Migrations
{
    public partial class mapRelationshipOfProductAndSaleOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetails_ProductId",
                table: "SaleOrderDetails",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderDetails_Products_ProductId",
                table: "SaleOrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderDetails_Products_ProductId",
                table: "SaleOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrderDetails_ProductId",
                table: "SaleOrderDetails");
        }
    }
}
