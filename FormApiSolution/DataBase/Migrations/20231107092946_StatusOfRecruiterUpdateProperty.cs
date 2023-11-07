using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class StatusOfRecruiterUpdateProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusOfRecruiter",
                table: "clickup_required_data",
                newName: "status_of_recruiter");

            migrationBuilder.AlterColumn<string>(
                name: "status_of_recruiter",
                table: "clickup_required_data",
                type: "VARCHAR",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "status_of_recruiter",
                table: "clickup_required_data",
                newName: "StatusOfRecruiter");

            migrationBuilder.AlterColumn<string>(
                name: "StatusOfRecruiter",
                table: "clickup_required_data",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 64);
        }
    }
}
