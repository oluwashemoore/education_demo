using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web_demo.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicAssessmentTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicAssessmentTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AcademicPeriod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicPeriod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Guardians",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    OtherNames = table.Column<string>(nullable: true),
                    EmailAdress = table.Column<string>(nullable: true),
                    StateOfOrigin = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: true),
                    PermanentAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guardians", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StudentGuardians",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    GuardianId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGuardians", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    StateId = table.Column<int>(nullable: false),
                    InstitutionTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Schools_InstitutionTypes_InstitutionTypeId",
                        column: x => x.InstitutionTypeId,
                        principalTable: "InstitutionTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schools_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    NERNId = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ClassId = table.Column<int>(nullable: false),
                    SchoolId = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    OtherNames = table.Column<string>(nullable: true),
                    EmailAdress = table.Column<string>(nullable: true),
                    StateOfOrigin = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    ContactNumber = table.Column<string>(nullable: true),
                    PermanentAddress = table.Column<string>(nullable: true),
                    EnrollmentDate = table.Column<DateTime>(nullable: false),
                    NationalIdentificationNumber = table.Column<string>(nullable: true),
                    GuardianID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Guardians_GuardianID",
                        column: x => x.GuardianID,
                        principalTable: "Guardians",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    OtherNames = table.Column<string>(nullable: true),
                    EmailAdress = table.Column<string>(nullable: true),
                    CoontactNumber = table.Column<string>(nullable: true),
                    CurrentSchoolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Teachers_Schools_CurrentSchoolId",
                        column: x => x.CurrentSchoolId,
                        principalTable: "Schools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserTypeId = table.Column<int>(nullable: false),
                    SchoolID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Schools_SchoolID",
                        column: x => x.SchoolID,
                        principalTable: "Schools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ClassID = table.Column<int>(nullable: true),
                    TeacherID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subjects_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AcademicAssessments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    SchoolId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: true),
                    SubjectId = table.Column<int>(nullable: false),
                    AssessmentDate = table.Column<DateTime>(nullable: false),
                    AcademicPeriodId = table.Column<int>(nullable: false),
                    AssessmentTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicAssessments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AcademicAssessments_AcademicPeriod_AcademicPeriodId",
                        column: x => x.AcademicPeriodId,
                        principalTable: "AcademicPeriod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademicAssessments_AcademicAssessmentTypes_AssessmentTypeId",
                        column: x => x.AssessmentTypeId,
                        principalTable: "AcademicAssessmentTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademicAssessments_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademicAssessments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcademicAssessments_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(nullable: false),
                    Reason = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    SchoolId = table.Column<int>(nullable: true),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Attendance_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attendance_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendance_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicAssessments_AcademicPeriodId",
                table: "AcademicAssessments",
                column: "AcademicPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicAssessments_AssessmentTypeId",
                table: "AcademicAssessments",
                column: "AssessmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicAssessments_SchoolId",
                table: "AcademicAssessments",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicAssessments_StudentId",
                table: "AcademicAssessments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicAssessments_SubjectId",
                table: "AcademicAssessments",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_SchoolId",
                table: "Attendance",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_StudentId",
                table: "Attendance",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_SubjectId",
                table: "Attendance",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_InstitutionTypeId",
                table: "Schools",
                column: "InstitutionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_StateId",
                table: "Schools",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GuardianID",
                table: "Students",
                column: "GuardianID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ClassID",
                table: "Subjects",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CurrentSchoolId",
                table: "Teachers",
                column: "CurrentSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SchoolID",
                table: "Users",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeId",
                table: "Users",
                column: "UserTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicAssessments");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "StudentGuardians");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AcademicPeriod");

            migrationBuilder.DropTable(
                name: "AcademicAssessmentTypes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Guardians");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "InstitutionTypes");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
