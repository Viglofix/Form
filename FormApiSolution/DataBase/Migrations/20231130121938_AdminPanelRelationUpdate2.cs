using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class AdminPanelRelationUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameOfUniversityOrOccupation",
                table: "clickup_required_data",
                newName: "name_of_university_or_occupation");

            migrationBuilder.AlterColumn<string>(
                name: "name_of_university_or_occupation",
                table: "clickup_required_data",
                type: "VARCHAR",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name_of_university_or_occupation",
                table: "clickup_required_data",
                newName: "NameOfUniversityOrOccupation");

            migrationBuilder.AlterColumn<string>(
                name: "NameOfUniversityOrOccupation",
                table: "clickup_required_data",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 64,
                oldNullable: true);
        }
    }
}
