using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HeroAPI.Migrations
{
    public partial class fourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tier",
                table: "Character",
                newName: "Tier");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Character",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Character",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "playstyle",
                table: "Character",
                newName: "SecondaryPlaystyle");

            migrationBuilder.AlterColumn<string>(
                name: "Tier",
                table: "Character",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryPlaystyle",
                table: "Character",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "SwordUser",
                table: "Character",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrimaryPlaystyle",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "SwordUser",
                table: "Character");

            migrationBuilder.RenameColumn(
                name: "Tier",
                table: "Character",
                newName: "tier");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Character",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Character",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SecondaryPlaystyle",
                table: "Character",
                newName: "playstyle");

            migrationBuilder.AlterColumn<int>(
                name: "tier",
                table: "Character",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
