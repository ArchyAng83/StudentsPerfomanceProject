using System.Collections.Generic;

namespace StudentsPerfomance.Logic.Models
{
    public class Guardian
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public List<Student> Students { get; set; }
    }
}