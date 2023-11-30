using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class AdminPanelRelationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_clickup_required_data_specialization_id",
                table: "clickup_required_data");

            migrationBuilder.CreateIndex(
                name: "IX_clickup_required_data_specialization_id",
                table: "clickup_required_data",
                column: "specialization_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_clickup_required_data_specialization_id",
                table: "clickup_required_data");

            migrationBuilder.CreateIndex(
                name: "IX_clickup_required_data_specialization_id",
                table: "clickup_required_data",
                column: "specialization_id",
                unique: true);
        }
    }
}
