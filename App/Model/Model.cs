using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace CourseProject.Model
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=CourseProjectCSConnection")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Quantity> Quantities { get; set; }
        public DbSet<Selling> Sellings { get; set; }
        public DbSet<Fail> Fails { get; set; }
        public DbSet<ItemCountry> ItemCountries { get; set; }

    }
}
