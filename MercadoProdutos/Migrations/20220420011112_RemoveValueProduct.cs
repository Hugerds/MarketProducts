using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoProdutos.Migrations
{
    public partial class RemoveValueProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Product",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Product",
                newName: "Descricao");

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Product",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
