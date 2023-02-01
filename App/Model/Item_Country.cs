using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class ItemCountry
    {
        public int ItemCountryId { get; set; }
        public Item Item { get; set; }
        public Country Country { get; set; }
    }
}
