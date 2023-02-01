using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public Maker Maker { get; set; }
        public Type Type { get; set; }
        public int Weight { get; set; }
        public DateTime Release { get; set; }
        public decimal Price { get; set; }

    }
}
