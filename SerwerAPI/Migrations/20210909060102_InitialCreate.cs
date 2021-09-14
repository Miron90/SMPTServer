using Microsoft.EntityFrameworkCore.Migrations;

namespace SerwerAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersLocation",
                columns: table => new
                {
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    latitude = table.Column<double>(type: "REAL", nullable: false),
                    longtitude = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersLocation", x => x.name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersLocation");
        }
    }
}
