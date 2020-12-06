

namespace web_demo.Entities
{
    public class TeacherSubject
    {
        public int ID { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }

        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
    }
}
