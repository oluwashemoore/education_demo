
using System;
using System.Collections.Generic;

namespace web_demo.Entities
{
    public class Guardian
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }


        public string LastName { get; set; }
        public string FirstName { get; set; }      
        public string OtherNames { get; set; }
        
        public string EmailAdress { get; set; }

        public string StateOfOrigin { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string PermanentAddress { get; set; }

        public List<Student> Students { get; set; }
    }
}
