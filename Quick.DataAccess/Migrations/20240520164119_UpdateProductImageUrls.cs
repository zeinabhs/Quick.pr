using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quick.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/product/26058324-db82-48df-be01-f96f98d0a90b.PNG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "");
        }
    }
}
