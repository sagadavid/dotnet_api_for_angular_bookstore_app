using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_api_for_angular_bookstore_app.Migrations
{
    public partial class modelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Authory",
                table: "BookModel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Authory",
                table: "BookModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
