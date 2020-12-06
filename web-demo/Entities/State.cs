
using System.Collections.Generic;

namespace web_demo.Entities
{
    public class State
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<School> Schools { get; set; }
    }
}
