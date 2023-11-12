using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class FixedSpecializationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickUp_required_data_specizalizations_specialization_id",
                table: "clickUp_required_data");

            migrationBuilder.DropTable(
                name: "specizalizations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clickUp_required_data",
                table: "clickUp_required_data");

            migrationBuilder.RenameTable(
                name: "clickUp_required_data",
                newName: "clickup_required_data");

            migrationBuilder.RenameIndex(
                name: "IX_clickUp_required_data_specialization_id",
                table: "clickup_required_data",
                newName: "IX_clickup_required_data_specialization_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clickup_required_data",
                table: "clickup_required_data",
                column: "id");

            migrationBuilder.CreateTable(
                name: "specializations",
                columns: table => new
                {
                    Id_Specialization = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    specialization_name = table.Column<string>(type: "VARCHAR", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specializations", x => x.Id_Specialization);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_clickup_required_data_specializations_specialization_id",
                table: "clickup_required_data",
                column: "specialization_id",
                principalTable: "specializations",
                principalColumn: "Id_Specialization");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickup_required_data_specializations_specialization_id",
                table: "clickup_required_data");

            migrationBuilder.DropTable(
                name: "specializations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clickup_required_data",
                table: "clickup_required_data");

            migrationBuilder.RenameTable(
                name: "clickup_required_data",
                newName: "clickUp_required_data");

            migrationBuilder.RenameIndex(
                name: "IX_clickup_required_data_specialization_id",
                table: "clickUp_required_data",
                newName: "IX_clickUp_required_data_specialization_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clickUp_required_data",
                table: "clickUp_required_data",
                column: "id");

            migrationBuilder.CreateTable(
                name: "specizalizations",
                columns: table => new
                {
                    Id_Specialization = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    specialization_name = table.Column<string>(type: "VARCHAR", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specizalizations", x => x.Id_Specialization);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_clickUp_required_data_specizalizations_specialization_id",
                table: "clickUp_required_data",
                column: "specialization_id",
                principalTable: "specizalizations",
                principalColumn: "Id_Specialization");
        }
    }
}
