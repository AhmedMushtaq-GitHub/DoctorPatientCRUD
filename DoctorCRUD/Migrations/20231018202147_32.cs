using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorCRUD.WebUI.Migrations
{
    /// <inheritdoc />
    public partial class _32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patients_doctors_doctorId",
                table: "patients");

            migrationBuilder.DropIndex(
                name: "IX_patients_doctorId",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "doctorId",
                table: "patients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "doctorId",
                table: "patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_patients_doctorId",
                table: "patients",
                column: "doctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_patients_doctors_doctorId",
                table: "patients",
                column: "doctorId",
                principalTable: "doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
