using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    /// <inheritdoc />
    public partial class PracticeRelationShipTableNameUpdte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_status_of_recruiter_TypeOfPracticeModel_type_of_practice_id",
                table: "status_of_recruiter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeOfPracticeModel",
                table: "TypeOfPracticeModel");

            migrationBuilder.RenameTable(
                name: "TypeOfPracticeModel",
                newName: "type_of_practice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_type_of_practice",
                table: "type_of_practice",
                column: "id_type_of_practice");

            migrationBuilder.AddForeignKey(
                name: "FK_status_of_recruiter_type_of_practice_type_of_practice_id",
                table: "status_of_recruiter",
                column: "type_of_practice_id",
                principalTable: "type_of_practice",
                principalColumn: "id_type_of_practice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_status_of_recruiter_type_of_practice_type_of_practice_id",
                table: "status_of_recruiter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_type_of_practice",
                table: "type_of_practice");

            migrationBuilder.RenameTable(
                name: "type_of_practice",
                newName: "TypeOfPracticeModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeOfPracticeModel",
                table: "TypeOfPracticeModel",
                column: "id_type_of_practice");

            migrationBuilder.AddForeignKey(
                name: "FK_status_of_recruiter_TypeOfPracticeModel_type_of_practice_id",
                table: "status_of_recruiter",
                column: "type_of_practice_id",
                principalTable: "TypeOfPracticeModel",
                principalColumn: "id_type_of_practice");
        }
    }
}
