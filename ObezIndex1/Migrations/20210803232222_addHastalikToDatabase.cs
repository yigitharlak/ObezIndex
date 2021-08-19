using Microsoft.EntityFrameworkCore.Migrations;

namespace ObezIndex1.Migrations
{
    public partial class addHastalikToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hastalik",
                columns: table => new
                {
                    ill_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ill_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ill_category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ill_description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastalik", x => x.ill_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hastalik");
        }
    }
}
