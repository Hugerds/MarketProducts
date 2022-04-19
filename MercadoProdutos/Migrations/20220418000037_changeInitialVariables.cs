using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MercadoProdutos.Migrations
{
    public partial class changeInitialVariables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "updatedDate",
                table: "AspNetUsers",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "excluded",
                table: "AspNetUsers",
                newName: "Excluded");

            migrationBuilder.RenameColumn(
                name: "createdDate",
                table: "AspNetUsers",
                newName: "CreatedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "AspNetUsers",
                newName: "updatedDate");

            migrationBuilder.RenameColumn(
                name: "Excluded",
                table: "AspNetUsers",
                newName: "excluded");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "AspNetUsers",
                newName: "createdDate");

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "AspNetUsers",
                type: "text",
                nullable: true);
        }
    }
}
