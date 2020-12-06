

using System.Collections.Generic;

namespace web_demo.Entities
{
    public class School
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
              

        public int StateId { get; set; }
        public State State { get; set; }

        public List<User> Users { get; set; }
        public List<Student> Students { get; set; }


        public int InstitutionTypeId { get; set; }
        public InstitutionType InstitutionType { get; set; }

    }
}
