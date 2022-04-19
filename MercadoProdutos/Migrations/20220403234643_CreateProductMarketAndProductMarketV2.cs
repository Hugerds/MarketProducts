using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoProdutos.Migrations
{
    public partial class CreateProductMarketAndProductMarketV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Market",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Document = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    QrCode = table.Column<string>(type: "text", nullable: false),
                    createdDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    excluded = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    createdDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    excluded = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductMarket",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FichaDescritivaBalanceamentoIdId = table.Column<Guid>(type: "uuid", nullable: false),
                    MarketId = table.Column<Guid>(type: "uuid", nullable: false),
                    createdDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    excluded = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMarket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMarket_Market_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Market",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMarket_Product_FichaDescritivaBalanceamentoIdId",
                        column: x => x.FichaDescritivaBalanceamentoIdId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductMarket_FichaDescritivaBalanceamentoIdId",
                table: "ProductMarket",
                column: "FichaDescritivaBalanceamentoIdId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMarket_MarketId",
                table: "ProductMarket",
                column: "MarketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductMarket");

            migrationBuilder.DropTable(
                name: "Market");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
