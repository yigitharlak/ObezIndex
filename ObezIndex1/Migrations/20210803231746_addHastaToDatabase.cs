using Microsoft.EntityFrameworkCore.Migrations;

namespace ObezIndex1.Migrations
{
    public partial class addHastaToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hasta",
                columns: table => new
                {
                    pat_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pat_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pat_username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pat_password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pat_height = table.Column<int>(type: "int", nullable: false),
                    pat_weight = table.Column<int>(type: "int", nullable: false),
                    pat_age = table.Column<int>(type: "int", nullable: false),
                    pat_gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pat_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pat_info = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hasta", x => x.pat_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hasta");
        }
    }
}
