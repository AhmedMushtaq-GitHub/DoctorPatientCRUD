using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorCRUD.WebUI.Migrations
{
    /// <inheritdoc />
    public partial class init39 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patients_doctors_DoctorId",
                table: "patients");

            migrationBuilder.DropIndex(
                name: "IX_patients_DoctorId",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "patients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_patients_DoctorId",
                table: "patients",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_patients_doctors_DoctorId",
                table: "patients",
                column: "DoctorId",
                principalTable: "doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
