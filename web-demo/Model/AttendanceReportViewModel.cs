using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_demo.Model
{
    public class AttendanceReportViewModel
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int SchoolId { get; set; }
        public int SubjectId { get; set; }
    }
}
