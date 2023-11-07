using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class StatusOfRecruiterUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "id_specialization",
                table: "specializations",
                type: "BIGINT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "full_name",
                table: "clickup_required_data",
                type: "VARCHAR",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "StatusOfRecruiter",
                table: "clickup_required_data",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "Status_Id",
                table: "clickup_required_data",
                type: "BIGINT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "github_account",
                table: "clickup_required_data",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StatusOfRecruiterModel",
                columns: table => new
                {
                    id_status_of_recruiter = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name_of_the_university = table.Column<string>(type: "VARCHAR", maxLength: 128, nullable: false),
                    start_date_of_practice = table.Column<DateTime>(type: "DATE", nullable: false),
                    end_date_of_practice = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusOfRecruiterModel", x => x.id_status_of_recruiter);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clickup_required_data_Status_Id",
                table: "clickup_required_data",
                column: "Status_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clickup_required_data_StatusOfRecruiterModel_Status_Id",
                table: "clickup_required_data",
                column: "Status_Id",
                principalTable: "StatusOfRecruiterModel",
                principalColumn: "id_status_of_recruiter");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickup_required_data_StatusOfRecruiterModel_Status_Id",
                table: "clickup_required_data");

            migrationBuilder.DropTable(
                name: "StatusOfRecruiterModel");

            migrationBuilder.DropIndex(
                name: "IX_clickup_required_data_Status_Id",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "StatusOfRecruiter",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "Status_Id",
                table: "clickup_required_data");

            migrationBuilder.DropColumn(
                name: "github_account",
                table: "clickup_required_data");

            migrationBuilder.AlterColumn<long>(
                name: "id_specialization",
                table: "specializations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "BIGINT")
                .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "full_name",
                table: "clickup_required_data",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR",
                oldMaxLength: 64);
        }
    }
}
