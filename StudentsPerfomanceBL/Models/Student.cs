using System;
using System.Collections.Generic;

namespace StudentsPerfomanceBL.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Adress { get; set; }        
        public SchoolClass SchoolClass { get; set; }
        public List<Mark> Marks { get; set; }
        public List<Guardian> Guardians { get; set; }
    }
}