using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class MultiFileUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickup_required_data_drop_files_drop_file_id",
                table: "clickup_required_data");

            migrationBuilder.DropIndex(
                name: "IX_clickup_required_data_drop_file_id",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "drop_file_id",
                table: "clickup_required_data");

            migrationBuilder.RenameColumn(
                name: "FileID",
                table: "drop_files",
                newName: "Id_File");

            migrationBuilder.AddColumn<long>(
                name: "ClickUp_Id",
                table: "drop_files",
                type: "BIGINT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_drop_files_ClickUp_Id",
                table: "drop_files",
                column: "ClickUp_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_drop_files_clickup_required_data_ClickUp_Id",
                table: "drop_files",
                column: "ClickUp_Id",
                principalTable: "clickup_required_data",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drop_files_clickup_required_data_ClickUp_Id",
                table: "drop_files");

            migrationBuilder.DropIndex(
                name: "IX_drop_files_ClickUp_Id",
                table: "drop_files");

            migrationBuilder.DropColumn(
                name: "ClickUp_Id",
                table: "drop_files");

            migrationBuilder.RenameColumn(
                name: "Id_File",
                table: "drop_files",
                newName: "FileID");

            migrationBuilder.AddColumn<long>(
                name: "drop_file_id",
                table: "clickup_required_data",
                type: "BIGINT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_clickup_required_data_drop_file_id",
                table: "clickup_required_data",
                column: "drop_file_id");

            migrationBuilder.AddForeignKey(
                name: "FK_clickup_required_data_drop_files_drop_file_id",
                table: "clickup_required_data",
                column: "drop_file_id",
                principalTable: "drop_files",
                principalColumn: "FileID");
        }
    }
}
