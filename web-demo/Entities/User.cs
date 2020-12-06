

namespace web_demo.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public School School { get; set; }
        public int? SchoolId { get; set; }


        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
    }
}
