

using System;
using System.Collections.Generic;

namespace web_demo.Entities
{
    public class Attendance
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }

        public int? SchoolId { get; set; }
        public virtual School School { get; set; }
        
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public List<AttendanceDetails> AttendanceDetails { get; set; }
    }
}
