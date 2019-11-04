using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuotesApp.API.Migrations
{
    public partial class Quote_MaterialClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Region = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    Period = table.Column<string>(nullable: true),
                    QuoteNeededBy = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotes_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quotes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    QuoteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_QuoteId",
                table: "Materials",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_CustomerId",
                table: "Quotes",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_UserId",
                table: "Quotes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
