using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MercadoProdutos.Migrations
{
    public partial class MarketCodeQrCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Market");

            migrationBuilder.DropColumn(
                name: "QrCode",
                table: "Market");

            migrationBuilder.AddColumn<int>(
                name: "MarketCode",
                table: "Market",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarketCode",
                table: "Market");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Market",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QrCode",
                table: "Market",
                type: "text",
                nullable: true);
        }
    }
}
