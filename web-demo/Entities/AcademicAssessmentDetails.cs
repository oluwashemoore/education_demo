
namespace web_demo.Entities
{
    public class AcademicAssessmentDetails
    {
        public int ID { get; set; }

        public int Score { get; set; }

        public int? StudentId { get; set; }
        public Student Student { get; set; }

        public int? AcademicAssessmentId { get; set; }
        public AcademicAssessment AcademicAssessment { get; set; }
    }
}
