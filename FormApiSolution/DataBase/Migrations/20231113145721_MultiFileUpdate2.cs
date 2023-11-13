using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class MultiFileUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drop_files_clickup_required_data_ClickUp_Id",
                table: "drop_files");

            migrationBuilder.RenameColumn(
                name: "Id_File",
                table: "drop_files",
                newName: "id_file");

            migrationBuilder.RenameColumn(
                name: "FileSize",
                table: "drop_files",
                newName: "file_size");

            migrationBuilder.RenameColumn(
                name: "ClickUp_Id",
                table: "drop_files",
                newName: "click_up_id");

            migrationBuilder.RenameIndex(
                name: "IX_drop_files_ClickUp_Id",
                table: "drop_files",
                newName: "IX_drop_files_click_up_id");

            migrationBuilder.AlterColumn<string>(
                name: "file_size",
                table: "drop_files",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_drop_files_clickup_required_data_click_up_id",
                table: "drop_files",
                column: "click_up_id",
                principalTable: "clickup_required_data",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drop_files_clickup_required_data_click_up_id",
                table: "drop_files");

            migrationBuilder.RenameColumn(
                name: "id_file",
                table: "drop_files",
                newName: "Id_File");

            migrationBuilder.RenameColumn(
                name: "file_size",
                table: "drop_files",
                newName: "FileSize");

            migrationBuilder.RenameColumn(
                name: "click_up_id",
                table: "drop_files",
                newName: "ClickUp_Id");

            migrationBuilder.RenameIndex(
                name: "IX_drop_files_click_up_id",
                table: "drop_files",
                newName: "IX_drop_files_ClickUp_Id");

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "drop_files",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_drop_files_clickup_required_data_ClickUp_Id",
                table: "drop_files",
                column: "ClickUp_Id",
                principalTable: "clickup_required_data",
                principalColumn: "id");
        }
    }
}
