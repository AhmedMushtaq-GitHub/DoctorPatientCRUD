using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorCRUD.Data.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_userRoles_UserRoleId",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "UserRoleId",
                table: "users",
                newName: "UserRolesId");

            migrationBuilder.RenameIndex(
                name: "IX_users_UserRoleId",
                table: "users",
                newName: "IX_users_UserRolesId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_userRoles_UserRolesId",
                table: "users",
                column: "UserRolesId",
                principalTable: "userRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_userRoles_UserRolesId",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "UserRolesId",
                table: "users",
                newName: "UserRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_users_UserRolesId",
                table: "users",
                newName: "IX_users_UserRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_userRoles_UserRoleId",
                table: "users",
                column: "UserRoleId",
                principalTable: "userRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
