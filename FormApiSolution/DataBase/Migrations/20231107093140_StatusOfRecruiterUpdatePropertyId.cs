using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class StatusOfRecruiterUpdatePropertyId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickup_required_data_StatusOfRecruiterModel_Status_Id",
                table: "clickup_required_data");

            migrationBuilder.RenameColumn(
                name: "Status_Id",
                table: "clickup_required_data",
                newName: "status_id");

            migrationBuilder.RenameIndex(
                name: "IX_clickup_required_data_Status_Id",
                table: "clickup_required_data",
                newName: "IX_clickup_required_data_status_id");

            migrationBuilder.AddForeignKey(
                name: "FK_clickup_required_data_StatusOfRecruiterModel_status_id",
                table: "clickup_required_data",
                column: "status_id",
                principalTable: "StatusOfRecruiterModel",
                principalColumn: "id_status_of_recruiter");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clickup_required_data_StatusOfRecruiterModel_status_id",
                table: "clickup_required_data");

            migrationBuilder.RenameColumn(
                name: "status_id",
                table: "clickup_required_data",
                newName: "Status_Id");

            migrationBuilder.RenameIndex(
                name: "IX_clickup_required_data_status_id",
                table: "clickup_required_data",
                newName: "IX_clickup_required_data_Status_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_clickup_required_data_StatusOfRecruiterModel_Status_Id",
                table: "clickup_required_data",
                column: "Status_Id",
                principalTable: "StatusOfRecruiterModel",
                principalColumn: "id_status_of_recruiter");
        }
    }
}
