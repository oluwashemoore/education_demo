

using System.Collections.Generic;

namespace web_demo.Entities
{
    public class Class
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
