using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoProdutos.Migrations
{
    public partial class bytesMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MediaBinarized",
                table: "Media");

            migrationBuilder.AddColumn<byte[]>(
                name: "MediaBytes",
                table: "Media",
                type: "bytea",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MediaBytes",
                table: "Media");

            migrationBuilder.AddColumn<string>(
                name: "MediaBinarized",
                table: "Media",
                type: "text",
                nullable: true);
        }
    }
}
