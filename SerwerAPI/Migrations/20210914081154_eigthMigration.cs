using Microsoft.EntityFrameworkCore.Migrations;

namespace SerwerAPI.Migrations
{
    public partial class eigthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OldUsersData",
                table: "OldUsersData");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "OldUsersData",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "OldUsersData",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OldUsersData",
                table: "OldUsersData",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OldUsersData",
                table: "OldUsersData");

            migrationBuilder.DropColumn(
                name: "id",
                table: "OldUsersData");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "OldUsersData",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OldUsersData",
                table: "OldUsersData",
                column: "name");
        }
    }
}
