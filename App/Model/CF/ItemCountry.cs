using CourseProject.Model.DBF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class ItemCountry
    {
        public int ItemId { get; set; }
        public int CountryId { get; set; }
        public int QuantityId { get; set; }
        public int FailsId { get; set; }

        public virtual Countries Countries { get; set; }
        public virtual Fails Fails { get; set; }
        public virtual Items Items { get; set; }
        public virtual Quantities Quantities { get; set; }
    }
}
