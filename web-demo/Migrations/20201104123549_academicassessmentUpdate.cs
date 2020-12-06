using Microsoft.EntityFrameworkCore.Migrations;

namespace web_demo.Migrations
{
    public partial class academicassessmentUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "AcademicAssessments");

            migrationBuilder.AddColumn<int>(
                name: "MaximumScore",
                table: "AcademicAssessments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaximumScore",
                table: "AcademicAssessments");

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "AcademicAssessments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
