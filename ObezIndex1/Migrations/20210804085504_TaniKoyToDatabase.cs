using Microsoft.EntityFrameworkCore.Migrations;

namespace ObezIndex1.Migrations
{
    public partial class TaniKoyToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaniKoyma",
                columns: table => new
                {
                    doc_ID = table.Column<int>(type: "int", nullable: false),
                    pat_ID = table.Column<int>(type: "int", nullable: false),
                    dgn_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaniKoyma");
        }
    }
}
