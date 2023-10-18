using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorCRUD.WebUI.Migrations
{
    /// <inheritdoc />
    public partial class init9 : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "patients");

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
