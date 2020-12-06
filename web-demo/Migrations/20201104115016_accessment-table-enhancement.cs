using Microsoft.EntityFrameworkCore.Migrations;

namespace web_demo.Migrations
{
    public partial class accessmenttableenhancement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicAssessments_AcademicPeriod_AcademicPeriodId",
                table: "AcademicAssessments");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicAssessments_Students_StudentId",
                table: "AcademicAssessments");

            migrationBuilder.DropIndex(
                name: "IX_AcademicAssessments_StudentId",
                table: "AcademicAssessments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcademicPeriod",
                table: "AcademicPeriod");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "AcademicAssessments");

            migrationBuilder.RenameTable(
                name: "AcademicPeriod",
                newName: "AcademicPeriods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcademicPeriods",
                table: "AcademicPeriods",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AcademicAssessmentDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: true),
                    AcademicAssessmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicAssessmentDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AcademicAssessmentDetails_AcademicAssessments_AcademicAssessmentId",
                        column: x => x.AcademicAssessmentId,
                        principalTable: "AcademicAssessments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcademicAssessmentDetails_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicAssessmentDetails_AcademicAssessmentId",
                table: "AcademicAssessmentDetails",
                column: "AcademicAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicAssessmentDetails_StudentId",
                table: "AcademicAssessmentDetails",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicAssessments_AcademicPeriods_AcademicPeriodId",
                table: "AcademicAssessments",
                column: "AcademicPeriodId",
                principalTable: "AcademicPeriods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicAssessments_AcademicPeriods_AcademicPeriodId",
                table: "AcademicAssessments");

            migrationBuilder.DropTable(
                name: "AcademicAssessmentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AcademicPeriods",
                table: "AcademicPeriods");

            migrationBuilder.RenameTable(
                name: "AcademicPeriods",
                newName: "AcademicPeriod");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "AcademicAssessments",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AcademicPeriod",
                table: "AcademicPeriod",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicAssessments_StudentId",
                table: "AcademicAssessments",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicAssessments_AcademicPeriod_AcademicPeriodId",
                table: "AcademicAssessments",
                column: "AcademicPeriodId",
                principalTable: "AcademicPeriod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicAssessments_Students_StudentId",
                table: "AcademicAssessments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
