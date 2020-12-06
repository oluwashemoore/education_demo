using Microsoft.EntityFrameworkCore.Migrations;

namespace web_demo.Migrations
{
    public partial class attendancedetailsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_AttendanceDetails_AttendanceDetailsId",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_AttendanceDetailsId",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "AttendanceDetailsId",
                table: "Attendance");

            migrationBuilder.AddColumn<int>(
                name: "AttendanceDetailsId",
                table: "AttendanceDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttendanceID",
                table: "AttendanceDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceDetails_AttendanceID",
                table: "AttendanceDetails",
                column: "AttendanceID");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceDetails_Attendance_AttendanceID",
                table: "AttendanceDetails",
                column: "AttendanceID",
                principalTable: "Attendance",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttendanceDetails_Attendance_AttendanceID",
                table: "AttendanceDetails");

            migrationBuilder.DropIndex(
                name: "IX_AttendanceDetails_AttendanceID",
                table: "AttendanceDetails");

            migrationBuilder.DropColumn(
                name: "AttendanceDetailsId",
                table: "AttendanceDetails");

            migrationBuilder.DropColumn(
                name: "AttendanceID",
                table: "AttendanceDetails");

            migrationBuilder.AddColumn<int>(
                name: "AttendanceDetailsId",
                table: "Attendance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_AttendanceDetailsId",
                table: "Attendance",
                column: "AttendanceDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_AttendanceDetails_AttendanceDetailsId",
                table: "Attendance",
                column: "AttendanceDetailsId",
                principalTable: "AttendanceDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
