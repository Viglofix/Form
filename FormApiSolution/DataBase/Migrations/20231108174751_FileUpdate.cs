using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class FileUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DropFile_Id",
                table: "clickup_required_data",
                type: "BIGINT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "drop_files",
                columns: table => new
                {
                    FileID = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    file_name = table.Column<string>(type: "VARCHAR", maxLength: 256, nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    file_data = table.Column<byte[]>(type: "BYTEA", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drop_files", x => x.FileID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clickup_required_data_DropFile_Id",
                table: "clickup_required_data",
                column: "DropFile_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clickup_required_data_drop_files_DropFile_Id",
                table: "clickup_required_data",
                column: "DropFile_Id",
                principalTable: "drop_files",
                principalColumn: "FileID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickup_required_data_drop_files_DropFile_Id",
                table: "clickup_required_data");

            migrationBuilder.DropTable(
                name: "drop_files");

            migrationBuilder.DropIndex(
                name: "IX_clickup_required_data_DropFile_Id",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "DropFile_Id",
                table: "clickup_required_data");
        }
    }
}
