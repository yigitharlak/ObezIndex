using Microsoft.EntityFrameworkCore.Migrations;

namespace ObezIndex1.Migrations
{
    public partial class UzmanlikHasToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UzmanlikHas",
                columns: table => new
                {
                    doc_ID = table.Column<int>(type: "int", nullable: false),
                    pro_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UzmanlikHas");
        }
    }
}
