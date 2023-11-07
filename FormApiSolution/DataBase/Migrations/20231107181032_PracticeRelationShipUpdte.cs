using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class PracticeRelationShipUpdte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status_of_recruiter",
                table: "clickup_required_data");

            migrationBuilder.AddColumn<long>(
                name: "type_of_practice_id",
                table: "status_of_recruiter",
                type: "BIGINT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypeOfPracticeModel",
                columns: table => new
                {
                    id_type_of_practice = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    id_type_of_practice_name = table.Column<string>(type: "VARCHAR", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfPracticeModel", x => x.id_type_of_practice);
                });

            migrationBuilder.CreateIndex(
                name: "IX_status_of_recruiter_type_of_practice_id",
                table: "status_of_recruiter",
                column: "type_of_practice_id");

            migrationBuilder.AddForeignKey(
                name: "FK_status_of_recruiter_TypeOfPracticeModel_type_of_practice_id",
                table: "status_of_recruiter",
                column: "type_of_practice_id",
                principalTable: "TypeOfPracticeModel",
                principalColumn: "id_type_of_practice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_status_of_recruiter_TypeOfPracticeModel_type_of_practice_id",
                table: "status_of_recruiter");

            migrationBuilder.DropTable(
                name: "TypeOfPracticeModel");

            migrationBuilder.DropIndex(
                name: "IX_status_of_recruiter_type_of_practice_id",
                table: "status_of_recruiter");

            migrationBuilder.DropColumn(
                name: "type_of_practice_id",
                table: "status_of_recruiter");

            migrationBuilder.AddColumn<string>(
                name: "status_of_recruiter",
                table: "clickup_required_data",
                type: "VARCHAR",
                maxLength: 64,
                nullable: false,
                defaultValue: "");
        }
    }
}
