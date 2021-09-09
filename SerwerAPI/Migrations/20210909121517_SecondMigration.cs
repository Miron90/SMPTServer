using Microsoft.EntityFrameworkCore.Migrations;

namespace SerwerAPI.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZoneLocation",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    longitude = table.Column<double>(type: "REAL", nullable: false),
                    latitude = table.Column<double>(type: "REAL", nullable: false),
                    shapeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZoneLocation", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZoneLocation");
        }
    }
}
