
using System;

namespace web_demo.Entities
{
    public class AcademicPeriod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        //public int ClassId { get; set; }
        //public Class Class { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public bool Status { get; set; }

    }
}
