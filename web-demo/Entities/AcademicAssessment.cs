using System;
using System.Collections.Generic;

namespace web_demo.Entities
{
    public class AcademicAssessment
    {
        public int ID { get; set; }
        
        public int Weight { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }


        public int MaximumScore { get; set; }
        public DateTime AssessmentDate { get; set; }

        public int AcademicPeriodId { get; set; }
        public AcademicPeriod AcademicPeriod { get; set; }       

        public int AssessmentTypeId { get; set; }
        public AcademicAssessmentType AssessmentType { get; set; }


        public List<AcademicAssessmentDetails> AcademicAssessmentDetails { get; set; }

    }
}
