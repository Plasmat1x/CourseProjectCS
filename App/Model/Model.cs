using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WFATestZone.Model
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=CourseProjectCSConnection")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
