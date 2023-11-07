using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class StatusOfRecruiterUpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickup_required_data_StatusOfRecruiterModel_status_id",
                table: "clickup_required_data");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusOfRecruiterModel",
                table: "StatusOfRecruiterModel");

            migrationBuilder.RenameTable(
                name: "StatusOfRecruiterModel",
                newName: "status_of_recruiter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_status_of_recruiter",
                table: "status_of_recruiter",
                column: "id_status_of_recruiter");

            migrationBuilder.AddForeignKey(
                name: "FK_clickup_required_data_status_of_recruiter_status_id",
                table: "clickup_required_data",
                column: "status_id",
                principalTable: "status_of_recruiter",
                principalColumn: "id_status_of_recruiter");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickup_required_data_status_of_recruiter_status_id",
                table: "clickup_required_data");

            migrationBuilder.DropPrimaryKey(
                name: "PK_status_of_recruiter",
                table: "status_of_recruiter");

            migrationBuilder.RenameTable(
                name: "status_of_recruiter",
                newName: "StatusOfRecruiterModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusOfRecruiterModel",
                table: "StatusOfRecruiterModel",
                column: "id_status_of_recruiter");

            migrationBuilder.AddForeignKey(
                name: "FK_clickup_required_data_StatusOfRecruiterModel_status_id",
                table: "clickup_required_data",
                column: "status_id",
                principalTable: "StatusOfRecruiterModel",
                principalColumn: "id_status_of_recruiter");
        }
    }
}
