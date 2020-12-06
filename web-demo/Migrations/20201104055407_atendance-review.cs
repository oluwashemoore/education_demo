using Microsoft.EntityFrameworkCore.Migrations;

namespace web_demo.Migrations
{
    public partial class atendancereview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_Students_StudentId",
                table: "Attendance");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_StudentId",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Attendance");

            migrationBuilder.AddColumn<int>(
                name: "AttendanceDetailsId",
                table: "Attendance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AttendanceDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceDetails", x => x.ID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendance_AttendanceDetails_AttendanceDetailsId",
                table: "Attendance");

            migrationBuilder.DropTable(
                name: "AttendanceDetails");

            migrationBuilder.DropIndex(
                name: "IX_Attendance_AttendanceDetailsId",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "AttendanceDetailsId",
                table: "Attendance");

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Attendance",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Attendance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_StudentId",
                table: "Attendance",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendance_Students_StudentId",
                table: "Attendance",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
