using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalExam.Migrations
{
    /// <inheritdoc />
    public partial class RenamedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersInfo",
                table: "UsersInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "UsersInfo",
                newName: "UsersAccounts");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "UsersLogins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersAccounts",
                table: "UsersAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersLogins",
                table: "UsersLogins",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersLogins",
                table: "UsersLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersAccounts",
                table: "UsersAccounts");

            migrationBuilder.RenameTable(
                name: "UsersLogins",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "UsersAccounts",
                newName: "UsersInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersInfo",
                table: "UsersInfo",
                column: "Id");
        }
    }
}
