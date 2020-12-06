using Microsoft.EntityFrameworkCore.Migrations;

namespace web_demo.Migrations
{
    public partial class attendanceupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "AttendanceDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceDetails_StudentId",
                table: "AttendanceDetails",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceDetails_Students_StudentId",
                table: "AttendanceDetails",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceDetails_Students_StudentId",
                table: "AttendanceDetails");

            migrationBuilder.DropIndex(
                name: "IX_AttendanceDetails_StudentId",
                table: "AttendanceDetails");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "AttendanceDetails");
        }
    }
}
