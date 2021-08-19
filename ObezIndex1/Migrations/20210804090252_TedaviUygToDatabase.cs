using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ObezIndex1.Migrations
{
    public partial class TedaviUygToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TedaviUyg",
                columns: table => new
                {
                    doc_ID = table.Column<int>(type: "int", nullable: false),
                    pat_ID = table.Column<int>(type: "int", nullable: false),
                    ill_ID = table.Column<int>(type: "int", nullable: false),
                    tmt_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TedaviUyg");
        }
    }
}
