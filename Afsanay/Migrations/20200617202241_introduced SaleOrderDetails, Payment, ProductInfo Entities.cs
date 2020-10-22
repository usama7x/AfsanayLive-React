using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Afsanay.Migrations
{
    public partial class introducedSaleOrderDetailsPaymentProductInfoEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrders_Customers_CustomerId",
                table: "SaleOrders");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "SaleOrders",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "SaleOrders",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "SaleOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SaleOrderNo",
                table: "SaleOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PaymentType = table.Column<string>(nullable: true),
                    Allowed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "ProductInfo",
                columns: table => new
                {
                    ProductInfoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Size = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInfo", x => x.ProductInfoId);
                    table.ForeignKey(
                        name: "FK_ProductInfo_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrderDetails",
                columns: table => new
                {
                    SaleOrderDetailsId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SaleOrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<double>(nullable: false),
                    UnitCost = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Stamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrderDetails", x => x.SaleOrderDetailsId);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetails_SaleOrders_SaleOrderId",
                        column: x => x.SaleOrderId,
                        principalTable: "SaleOrders",
                        principalColumn: "SaleOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrders_PaymentId",
                table: "SaleOrders",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInfo_ProductId",
                table: "ProductInfo",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetails_SaleOrderId",
                table: "SaleOrderDetails",
                column: "SaleOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrders_Customers_CustomerId",
                table: "SaleOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrders_Payment_PaymentId",
                table: "SaleOrders",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "PaymentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrders_Customers_CustomerId",
                table: "SaleOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrders_Payment_PaymentId",
                table: "SaleOrders");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "ProductInfo");

            migrationBuilder.DropTable(
                name: "SaleOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrders_PaymentId",
                table: "SaleOrders");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "SaleOrders");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "SaleOrders");

            migrationBuilder.DropColumn(
                name: "SaleOrderNo",
                table: "SaleOrders");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "SaleOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrders_Customers_CustomerId",
                table: "SaleOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
