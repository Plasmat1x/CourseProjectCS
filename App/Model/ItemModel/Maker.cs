using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class Maker
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Model.Item> items = new List<Model.Item>();

        public override string ToString()
        {
            return Name;
        }
    }
}
