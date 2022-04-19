using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoProdutos.Migrations
{
    public partial class MediaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MediaBinarized",
                table: "Media",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MediaCode",
                table: "Media",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MediaDescription",
                table: "Media",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MediaBinarized",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "MediaCode",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "MediaDescription",
                table: "Media");
        }
    }
}
