using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace New_Project.Migrations
{
    /// <inheritdoc />
    public partial class mm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authers_AutherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authers",
                table: "Authers");

            migrationBuilder.RenameTable(
                name: "Authers",
                newName: "Authors");

            migrationBuilder.AddColumn<bool>(
                name: "ISDeleted",
                table: "Books",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "AutherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AutherId",
                table: "Books",
                column: "AutherId",
                principalTable: "Authors",
                principalColumn: "AutherId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AutherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "ISDeleted",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Authers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authers",
                table: "Authers",
                column: "AutherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authers_AutherId",
                table: "Books",
                column: "AutherId",
                principalTable: "Authers",
                principalColumn: "AutherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
