﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerfomanceBL.Models
{
    public class SchoolClass
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public List<Student> Students { get; set; }
    }
}
