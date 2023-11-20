using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class EnglishPropertyUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "english_Level",
                table: "clickup_required_data",
                newName: "english_level");

            migrationBuilder.AlterColumn<string>(
                name: "english_level",
                table: "clickup_required_data",
                type: "VARCHAR",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "english_level",
                table: "clickup_required_data",
                newName: "english_Level");

            migrationBuilder.AlterColumn<string>(
                name: "english_Level",
                table: "clickup_required_data",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 5);
        }
    }
}
