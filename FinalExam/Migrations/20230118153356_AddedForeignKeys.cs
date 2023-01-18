using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalExam.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAccountId",
                table: "UsersAddresses");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UsersAccounts_UsersLogins_UserLoginId",
                table: "UsersAccounts",
                column: "UserLoginId",
                principalTable: "UsersLogins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersAccounts_UsersAddresses_UserAddressId",
                table: "UsersAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersAccounts_UsersLogins_UserLoginId",
                table: "UsersAccounts");

            migrationBuilder.DropIndex(
                name: "IX_UsersAccounts_UserAddressId",
                table: "UsersAccounts");

            migrationBuilder.DropIndex(
                name: "IX_UsersAccounts_UserLoginId",
                table: "UsersAccounts");

            migrationBuilder.AddColumn<int>(
                name: "UserAccountId",
                table: "UsersAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
