

using System.Collections.Generic;

namespace web_demo.Entities
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }       
        public string OtherNames { get; set; }       
        public string EmailAdress { get; set; }
        public string CoontactNumber { get; set; }
        
        public int CurrentSchoolId { get; set; }
        public School CurrentSchool { get; set; }

        public List<TeacherSubject> TeacherSubject { get; set; }
    }
}
