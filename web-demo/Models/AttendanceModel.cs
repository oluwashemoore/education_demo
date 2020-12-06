

using System.Collections.Generic;

namespace web_demo.Models
{
    public class AttendanceModel
    {

        public bool Status { get; set; }

        public int? SchoolId { get; set; }

        public int SubjectId { get; set; }

        public List<AttendanceDetailsModel> AttendanceDetails  { get; set; }

    }
}
