using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoProdutos.Migrations
{
    public partial class EditModelBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updatedDate",
                table: "ProductMarket",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "excluded",
                table: "ProductMarket",
                newName: "Excluded");

            migrationBuilder.RenameColumn(
                name: "createdDate",
                table: "ProductMarket",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "updatedDate",
                table: "Product",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "excluded",
                table: "Product",
                newName: "Excluded");

            migrationBuilder.RenameColumn(
                name: "createdDate",
                table: "Product",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "updatedDate",
                table: "Market",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "excluded",
                table: "Market",
                newName: "Excluded");

            migrationBuilder.RenameColumn(
                name: "createdDate",
                table: "Market",
                newName: "CreatedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "ProductMarket",
                newName: "updatedDate");

            migrationBuilder.RenameColumn(
                name: "Excluded",
                table: "ProductMarket",
                newName: "excluded");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "ProductMarket",
                newName: "createdDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Product",
                newName: "updatedDate");

            migrationBuilder.RenameColumn(
                name: "Excluded",
                table: "Product",
                newName: "excluded");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Product",
                newName: "createdDate");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Market",
                newName: "updatedDate");

            migrationBuilder.RenameColumn(
                name: "Excluded",
                table: "Market",
                newName: "excluded");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Market",
                newName: "createdDate");
        }
    }
}
