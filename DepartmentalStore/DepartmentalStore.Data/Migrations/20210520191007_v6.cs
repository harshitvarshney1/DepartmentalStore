using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartmentalStore.Data.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_product_ProductId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_product_ProductId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrder_product_ProductId",
                table: "PurchaseOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierProduct_product_ProductId",
                table: "SupplierProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                table: "product");

            migrationBuilder.RenameTable(
                name: "product",
                newName: "Product");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrder_Product_ProductId",
                table: "PurchaseOrder",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierProduct_Product_ProductId",
                table: "SupplierProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Product_ProductId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrder_Product_ProductId",
                table: "PurchaseOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierProduct_Product_ProductId",
                table: "SupplierProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "product");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                table: "product",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_product_ProductId",
                table: "Inventory",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_product_ProductId",
                table: "ProductCategory",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrder_product_ProductId",
                table: "PurchaseOrder",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierProduct_product_ProductId",
                table: "SupplierProduct",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
