using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartmentalStore.Data.Migrations
{
    public partial class addeddbsetofproductcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Category_CategoryId",
                table: "ProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "Productcategory");

            migrationBuilder.RenameIndex(
                name: "IX_ProductCategory_CategoryId",
                table: "Productcategory",
                newName: "IX_Productcategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productcategory",
                table: "Productcategory",
                columns: new[] { "ProductId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Productcategory_Category_CategoryId",
                table: "Productcategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productcategory_Product_ProductId",
                table: "Productcategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productcategory_Category_CategoryId",
                table: "Productcategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Productcategory_Product_ProductId",
                table: "Productcategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productcategory",
                table: "Productcategory");

            migrationBuilder.RenameTable(
                name: "Productcategory",
                newName: "ProductCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Productcategory_CategoryId",
                table: "ProductCategory",
                newName: "IX_ProductCategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                columns: new[] { "ProductId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Category_CategoryId",
                table: "ProductCategory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductCategory_Product_ProductId",
                table: "ProductCategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
