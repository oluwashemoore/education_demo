using Microsoft.EntityFrameworkCore.Migrations;

namespace web_demo.Migrations
{
    public partial class userupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Schools_SchoolID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "SchoolID",
                table: "Users",
                newName: "SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_SchoolID",
                table: "Users",
                newName: "IX_Users_SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Schools_SchoolId",
                table: "Users",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Schools_SchoolId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "SchoolId",
                table: "Users",
                newName: "SchoolID");

            migrationBuilder.RenameIndex(
                name: "IX_Users_SchoolId",
                table: "Users",
                newName: "IX_Users_SchoolID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Schools_SchoolID",
                table: "Users",
                column: "SchoolID",
                principalTable: "Schools",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
