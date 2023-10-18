using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorCRUD.WebUI.Migrations
{
    /// <inheritdoc />
    public partial class _321 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Number",
                table: "patients",
                newName: "doctorId");

            migrationBuilder.AddColumn<long>(
                name: "ContactNumber",
                table: "patients",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "ContactNumber",
                table: "doctors",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patients_doctors_doctorId",
                table: "patients");

            migrationBuilder.DropIndex(
                name: "IX_patients_doctorId",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "ContactNumber",
                table: "patients");

            migrationBuilder.RenameColumn(
                name: "doctorId",
                table: "patients",
                newName: "Number");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
