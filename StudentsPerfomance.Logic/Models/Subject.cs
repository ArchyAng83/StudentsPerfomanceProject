﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsPerfomance.Logic.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Mark> Marks { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
