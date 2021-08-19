using Microsoft.EntityFrameworkCore.Migrations;

namespace ObezIndex1.Migrations
{
    public partial class addDoktorToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doktor",
                columns: table => new
                {
                    doc_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doc_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doc_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doc_profession = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doc_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doc_info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doc_username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doc_password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktor", x => x.doc_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doktor");
        }
    }
}
