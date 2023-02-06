using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    public class ItemCountry
    {
        [Key, Column(Order = 0)]
        public int ItemId { get; set; }
        [Key, Column(Order = 1)]
        public int CountryId { get; set; }
        public int QuantityId { get; set; }
        public int FailId { get; set; }

        public virtual Country Country { get; set; }
        public virtual Fail Fail { get; set; }
        public virtual Item Item { get; set; }
        public virtual Quantity Quantity { get; set; }
    }
}
