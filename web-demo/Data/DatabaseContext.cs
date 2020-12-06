

using Microsoft.EntityFrameworkCore;
using web_demo.Entities;

namespace web_demo.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }    
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<AcademicPeriod> AcademicPeriods { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
        public DbSet<StudentGuardian> StudentGuardians { get; set; }
        public DbSet<InstitutionType> InstitutionTypes { get; set; }
        public DbSet<AcademicAssessment> AcademicAssessments { get; set; }
        public DbSet<AcademicAssessmentType> AcademicAssessmentTypes { get; set; }
        public DbSet<AcademicAssessmentDetails> AcademicAssessmentDetails { get; set; }
        public DbSet<web_demo.Entities.AttendanceDetails> AttendanceDetails { get; set; }
    }
}
