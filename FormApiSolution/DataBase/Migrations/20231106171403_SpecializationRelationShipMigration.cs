using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class SpecializationRelationShipMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "clickUp_required_data",
                columns: table => new
                {
                    id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    full_name = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    phone_number = table.Column<string>(type: "TEXT", nullable: false),
                    date_of_birth = table.Column<DateTime>(type: "DATE", nullable: false),
                    specialization_id = table.Column<long>(type: "BIGINT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clickUp_required_data", x => x.id);
                    table.ForeignKey(
                        name: "FK_clickUp_required_data_specizalizations_specialization_id",
                        column: x => x.specialization_id,
                        principalTable: "specizalizations",
                        principalColumn: "Id_Specialization");
                });

            migrationBuilder.CreateIndex(
                name: "IX_clickUp_required_data_specialization_id",
                table: "clickUp_required_data",
                column: "specialization_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clickUp_required_data");

            migrationBuilder.DropTable(
                name: "specizalizations");
        }
    }
}
