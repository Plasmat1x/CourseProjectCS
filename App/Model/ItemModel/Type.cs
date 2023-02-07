using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class Type : IComparable<Model.Type>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Model.Item> items = new List<Model.Item>();

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(Type other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
