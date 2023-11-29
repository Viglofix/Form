using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class AdminPanel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin_panel",
                columns: table => new
                {
                    id_admin = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    login = table.Column<string>(type: "VARCHAR", maxLength: 32, nullable: false),
                    password = table.Column<string>(type: "VARCHAR", maxLength: 64, nullable: false),
                    note = table.Column<string>(type: "TEXT", nullable: false, defaultValue: "Note about this account")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin_panel", x => x.id_admin);
                });

            migrationBuilder.CreateTable(
                name: "schools",
                columns: table => new
                {
                    id_school = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    name = table.Column<string>(type: "VARCHAR", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schools", x => x.id_school);
                });

            migrationBuilder.CreateTable(
                name: "specializations",
                columns: table => new
                {
                    id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    domain = table.Column<string>(type: "VARCHAR", maxLength: 64, nullable: false),
                    role = table.Column<string>(type: "VARCHAR", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specializations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tests",
                columns: table => new
                {
                    id_test = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    question = table.Column<string>(type: "VARCHAR", maxLength: 64, nullable: false),
                    correct_answer = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tests", x => x.id_test);
                });

            migrationBuilder.CreateTable(
                name: "clickup_required_data",
                columns: table => new
                {
                    id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    full_name = table.Column<string>(type: "VARCHAR", maxLength: 64, nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    phone_number = table.Column<string>(type: "TEXT", nullable: false),
                    date_of_birth = table.Column<DateTime>(type: "DATE", nullable: false),
                    github_account = table.Column<string>(type: "TEXT", nullable: true),
                    NameOfUniversityOrOccupation = table.Column<string>(type: "text", nullable: true),
                    programming_languages = table.Column<string>(type: "VARCHAR", maxLength: 256, nullable: true),
                    graphic_inspiration = table.Column<string>(type: "TEXT", nullable: true),
                    proficient_graphic_tools = table.Column<string>(type: "TEXT", nullable: true),
                    experience = table.Column<string>(type: "TEXT", nullable: true),
                    finished_project = table.Column<string>(type: "TEXT", nullable: true),
                    english_level = table.Column<string>(type: "VARCHAR", maxLength: 5, nullable: false),
                    learning_goals = table.Column<string>(type: "TEXT", nullable: false),
                    goal_of_academy_participation = table.Column<string>(type: "VARCHAR", maxLength: 64, nullable: false),
                    practices_start = table.Column<DateTime>(type: "DATE", nullable: true),
                    practices_end = table.Column<DateTime>(type: "DATE", nullable: true),
                    additional_information = table.Column<string>(type: "TEXT", nullable: true),
                    column_id = table.Column<string>(type: "VARCHAR", maxLength: 16, nullable: true, defaultValue: "1"),
                    range = table.Column<long>(type: "bigint", nullable: true),
                    note = table.Column<string>(type: "text", nullable: true),
                    assigned_to_project_id = table.Column<long>(type: "bigint", nullable: true),
                    specialization_id = table.Column<long>(type: "BIGINT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clickup_required_data", x => x.id);
                    table.ForeignKey(
                        name: "FK_clickup_required_data_specializations_specialization_id",
                        column: x => x.specialization_id,
                        principalTable: "specializations",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "test_answers",
                columns: table => new
                {
                    id_test_answer = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    answer = table.Column<string>(type: "TEXT", nullable: false),
                    test_id = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_test_answers", x => x.id_test_answer);
                    table.ForeignKey(
                        name: "FK_test_answers_tests_test_id",
                        column: x => x.test_id,
                        principalTable: "tests",
                        principalColumn: "id_test",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "drop_files",
                columns: table => new
                {
                    id_file = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'1', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    file_name = table.Column<string>(type: "VARCHAR", maxLength: 256, nullable: false),
                    file_size = table.Column<string>(type: "TEXT", nullable: false),
                    file_data = table.Column<byte[]>(type: "BYTEA", nullable: false),
                    click_up_id = table.Column<long>(type: "BIGINT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drop_files", x => x.id_file);
                    table.ForeignKey(
                        name: "FK_drop_files_clickup_required_data_click_up_id",
                        column: x => x.click_up_id,
                        principalTable: "clickup_required_data",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_clickup_required_data_specialization_id",
                table: "clickup_required_data",
                column: "specialization_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_drop_files_click_up_id",
                table: "drop_files",
                column: "click_up_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_test_answers_test_id",
                table: "test_answers",
                column: "test_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin_panel");

            migrationBuilder.DropTable(
                name: "drop_files");

            migrationBuilder.DropTable(
                name: "schools");

            migrationBuilder.DropTable(
                name: "test_answers");

            migrationBuilder.DropTable(
                name: "clickup_required_data");

            migrationBuilder.DropTable(
                name: "tests");

            migrationBuilder.DropTable(
                name: "specializations");
        }
    }
}
