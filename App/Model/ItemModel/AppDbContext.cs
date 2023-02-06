using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Xml.Linq;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;

namespace CourseProject.Model
{
    /* //singleton
    internal class AppDbContext : DbContext
    {
        public static AppDbContext Instance { get => AppDbContextCreate.instance; }
        private AppDbContext() : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Fail> Fails { get; set; }
        public DbSet<Quantity> Quantities { get; set; }
        public DbSet<Selling> Sellings { get; set; }
        public DbSet<ItemCountry> ItemCountries { get; set; }

        private class AppDbContextCreate
        {
            static AppDbContextCreate() { }
            internal static readonly AppDbContext instance = new AppDbContext();
        }
    }
    //*/

    //* //classic
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Fail> Fails { get; set; }
        public DbSet<Quantity> Quantities { get; set; }
        public DbSet<Selling> Sellings { get; set; }
        public DbSet<ItemCountry> ItemCountries { get; set; }
    }
    //*/
}
