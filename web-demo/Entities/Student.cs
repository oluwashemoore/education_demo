

using System;

namespace web_demo.Entities
{
    public class Student
    {
        public int ID { get; set; }        
        public string Image { get; set; }
        public string Title { get; set; }
        public string NERNId { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }


        public int SchoolId { get; set; }
        public School School { get; set; }


        public string LastName { get; set; }
        public string FirstName { get; set; }     
        public string OtherNames { get; set; }
        
        public string EmailAdress { get; set; }
        
      
        public string StateOfOrigin { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string PermanentAddress { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public string NationalIdentificationNumber { get; set; }      
        
    }
}
