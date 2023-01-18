using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalExam.Migrations
{
    /// <inheritdoc />
    public partial class RedoForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersAccounts_UsersAddresses_UserAddressId",
                table: "UsersAccounts");

            migrationBuilder.DropIndex(
                name: "IX_UsersAccounts_UserAddressId",
                table: "UsersAccounts");

            migrationBuilder.DropIndex(
                name: "IX_UsersAccounts_UserLoginId",
                table: "UsersAccounts");

            migrationBuilder.DropColumn(
                name: "UserAddressId",
                table: "UsersAccounts");

            migrationBuilder.AddColumn<int>(
                name: "UserLoginId",
                table: "UsersAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UsersAddresses_UserLoginId",
                table: "UsersAddresses",
                column: "UserLoginId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsersAccounts_UserLoginId",
                table: "UsersAccounts",
                column: "UserLoginId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAddresses_UsersLogins_UserLoginId",
                table: "UsersAddresses",
                column: "UserLoginId",
                principalTable: "UsersLogins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersAddresses_UsersLogins_UserLoginId",
                table: "UsersAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UsersAddresses_UserLoginId",
                table: "UsersAddresses");

            migrationBuilder.DropIndex(
                name: "IX_UsersAccounts_UserLoginId",
                table: "UsersAccounts");

            migrationBuilder.DropColumn(
                name: "UserLoginId",
                table: "UsersAddresses");

            migrationBuilder.AddColumn<int>(
                name: "UserAddressId",
                table: "UsersAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UsersAccounts_UserAddressId",
                table: "UsersAccounts",
                column: "UserAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersAccounts_UserLoginId",
                table: "UsersAccounts",
                column: "UserLoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAccounts_UsersAddresses_UserAddressId",
                table: "UsersAccounts",
                column: "UserAddressId",
                principalTable: "UsersAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
