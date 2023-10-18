using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorCRUD.Data.Migrations
{
    /// <inheritdoc />
    public partial class init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "patients");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentOn",
                table: "patients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_patients_doctors_DoctorId",
                table: "patients");

            migrationBuilder.DropIndex(
                name: "IX_patients_DoctorId",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "AppointmentOn",
                table: "patients");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "patients");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
