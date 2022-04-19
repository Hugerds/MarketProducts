using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoProdutos.Migrations
{
    public partial class ProductMarketProductId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMarket_Product_FichaDescritivaBalanceamentoIdId",
                table: "ProductMarket");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "ProductMarket",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "ProductMarket",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "FichaDescritivaBalanceamentoIdId",
                table: "ProductMarket",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductMarket_FichaDescritivaBalanceamentoIdId",
                table: "ProductMarket",
                newName: "IX_ProductMarket_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMarket_Product_ProductId",
                table: "ProductMarket",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMarket_Product_ProductId",
                table: "ProductMarket");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "ProductMarket",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "ProductMarket",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductMarket",
                newName: "FichaDescritivaBalanceamentoIdId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductMarket_ProductId",
                table: "ProductMarket",
                newName: "IX_ProductMarket_FichaDescritivaBalanceamentoIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMarket_Product_FichaDescritivaBalanceamentoIdId",
                table: "ProductMarket",
                column: "FichaDescritivaBalanceamentoIdId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
