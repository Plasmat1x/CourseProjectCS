﻿using CourseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class Selling
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public DateTime Date { get; set; }
    }
}
