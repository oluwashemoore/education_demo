using Microsoft.EntityFrameworkCore.Migrations;

namespace web_demo.Migrations
{
    public partial class teachersubjectmappingupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "TeacherID",
                table: "Subjects");

            migrationBuilder.CreateTable(
                name: "TeacherSubjects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSubjects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjects_SubjectId",
                table: "TeacherSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjects_TeacherId",
                table: "TeacherSubjects",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherSubjects");

            migrationBuilder.AddColumn<int>(
                name: "TeacherID",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
