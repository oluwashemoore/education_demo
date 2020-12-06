
namespace web_demo.Entities
{
    public class AttendanceDetails
    {
        public int ID { get; set; }
        public bool Status { get; set; }
        public string Reason { get; set; }
        
        public int? StudentId { get; set; }
        public Student Student { get; set; }

        public Attendance Attendance { get; set; }
        public int? AttendanceDetailsId { get; set; }
    }
}
