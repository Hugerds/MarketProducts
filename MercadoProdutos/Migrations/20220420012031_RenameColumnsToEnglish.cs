using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoProdutos.Migrations
{
    public partial class RenameColumnsToEnglish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "ProductMarket",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "ProductMarket",
                newName: "Quantity");

            migrationBuilder.AddColumn<decimal>(
                name: "Value",
                table: "Product",
                type: "numeric",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Value",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "ProductMarket",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "ProductMarket",
                newName: "Quantidade");
        }
    }
}
