using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp5.Migrations
{
    /// <inheritdoc />
    public partial class onetoone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_saleHistory_Products_ProductId",
                table: "saleHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_saleHistory",
                table: "saleHistory");

            migrationBuilder.RenameTable(
                name: "saleHistory",
                newName: "sales");

            migrationBuilder.RenameIndex(
                name: "IX_saleHistory_ProductId",
                table: "sales",
                newName: "IX_sales_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sales",
                table: "sales",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "productDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_productDetails_ProductId",
                table: "productDetails",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_sales_Products_ProductId",
                table: "sales",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sales_Products_ProductId",
                table: "sales");

            migrationBuilder.DropTable(
                name: "productDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sales",
                table: "sales");

            migrationBuilder.RenameTable(
                name: "sales",
                newName: "saleHistory");

            migrationBuilder.RenameIndex(
                name: "IX_sales_ProductId",
                table: "saleHistory",
                newName: "IX_saleHistory_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_saleHistory",
                table: "saleHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_saleHistory_Products_ProductId",
                table: "saleHistory",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
