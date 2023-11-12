using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class ModelAlmostCompletedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickup_required_data_drop_files_DropFile_Id",
                table: "clickup_required_data");

            migrationBuilder.RenameColumn(
                name: "DropFile_Id",
                table: "clickup_required_data",
                newName: "drop_file_id");

            migrationBuilder.RenameIndex(
                name: "IX_clickup_required_data_DropFile_Id",
                table: "clickup_required_data",
                newName: "IX_clickup_required_data_drop_file_id");

            migrationBuilder.AddColumn<string>(
                name: "additional_information",
                table: "clickup_required_data",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "expectation",
                table: "clickup_required_data",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_clickup_required_data_drop_files_drop_file_id",
                table: "clickup_required_data",
                column: "drop_file_id",
                principalTable: "drop_files",
                principalColumn: "FileID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickup_required_data_drop_files_drop_file_id",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "additional_information",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "expectation",
                table: "clickup_required_data");

            migrationBuilder.RenameColumn(
                name: "drop_file_id",
                table: "clickup_required_data",
                newName: "DropFile_Id");

            migrationBuilder.RenameIndex(
                name: "IX_clickup_required_data_drop_file_id",
                table: "clickup_required_data",
                newName: "IX_clickup_required_data_DropFile_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clickup_required_data_drop_files_DropFile_Id",
                table: "clickup_required_data",
                column: "DropFile_Id",
                principalTable: "drop_files",
                principalColumn: "FileID");
        }
    }
}
