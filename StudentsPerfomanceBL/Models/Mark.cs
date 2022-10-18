using System;

namespace StudentsPerfomanceBL.Models
{
    public class Mark
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfIssue { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}