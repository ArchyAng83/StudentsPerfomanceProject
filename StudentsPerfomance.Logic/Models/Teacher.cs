using System.Collections.Generic;

namespace StudentsPerfomance.Logic.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Subject Subject { get; set; }
    }
}