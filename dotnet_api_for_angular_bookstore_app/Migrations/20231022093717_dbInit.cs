using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_api_for_angular_bookstore_app.Migrations
{
    public partial class dbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PriceModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPages = table.Column<int>(type: "int", nullable: true),
                    PriceId = table.Column<int>(type: "int", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: true),
                    PublishedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookModel_PriceModel_PriceId",
                        column: x => x.PriceId,
                        principalTable: "PriceModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuthorModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorModel_BookModel_BookModelId",
                        column: x => x.BookModelId,
                        principalTable: "BookModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorModel_BookModelId",
                table: "AuthorModel",
                column: "BookModelId");

            migrationBuilder.CreateIndex(
                name: "IX_BookModel_PriceId",
                table: "BookModel",
                column: "PriceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorModel");

            migrationBuilder.DropTable(
                name: "BookModel");

            migrationBuilder.DropTable(
                name: "PriceModel");
        }
    }
}
