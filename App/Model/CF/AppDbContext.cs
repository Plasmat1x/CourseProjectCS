using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model.CF
{
    internal class AppDbContext : DbContext
    {
        public static AppDbContext Instance { get => AppDbContextCreate.instance; }

        private AppDbContext() : base("DefaultConnection") { }

        private class AppDbContextCreate
        {
            static AppDbContextCreate() { }
            internal static readonly AppDbContext instance = new AppDbContext();
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Fail> Fails { get; set; }
        public DbSet<Quantity> Quantities { get; set; }
        public DbSet<Selling> Sellings { get; set; }
    }
}
