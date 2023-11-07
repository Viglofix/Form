using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class EnglishRelationShipUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "english_level_id",
                table: "clickup_required_data",
                type: "BIGINT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "experience",
                table: "clickup_required_data",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "finished_project",
                table: "clickup_required_data",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "graphic_inspiration",
                table: "clickup_required_data",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "graphic_program",
                table: "clickup_required_data",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "programmin_knowledge",
                table: "clickup_required_data",
                type: "VARCHAR",
                maxLength: 256,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "english_level",
                columns: table => new
                {
                    id_english_level = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    engliah_level_property = table.Column<string>(type: "VARCHAR", maxLength: 2, nullable: false, defaultValue: "B1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_english_level", x => x.id_english_level);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clickup_required_data_english_level_id",
                table: "clickup_required_data",
                column: "english_level_id");

            migrationBuilder.AddForeignKey(
                name: "FK_clickup_required_data_english_level_english_level_id",
                table: "clickup_required_data",
                column: "english_level_id",
                principalTable: "english_level",
                principalColumn: "id_english_level");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickup_required_data_english_level_english_level_id",
                table: "clickup_required_data");

            migrationBuilder.DropTable(
                name: "english_level");

            migrationBuilder.DropIndex(
                name: "IX_clickup_required_data_english_level_id",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "english_level_id",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "experience",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "finished_project",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "graphic_inspiration",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "graphic_program",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "programmin_knowledge",
                table: "clickup_required_data");
        }
    }
}
