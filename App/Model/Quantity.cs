using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class Quantity
    {
        public int Id { get; set; }
        public int Amount { get; set; }

        public virtual ICollection<ItemCountry> ItemCountries { get; set; }
    }
}
