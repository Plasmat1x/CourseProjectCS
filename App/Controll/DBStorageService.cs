using CourseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.Controll
{
    internal class DBStorageService
    {
        AppDbContext context = new AppDbContext();

        public DBStorageService()
        {
            
        }

        public IEnumerable<Model.ItemCountry> GetItems()
        {
            var res = (from ic in context.ItemCountries
                       join item in context.Items on ic.ItemId equals item.Id
                       join county in context.Countries on ic.CountryId equals county.Id
                       join quantity in context.Quantities on ic.QuantityId equals quantity.Id
                       join fail in context.Fails on ic.FailId equals fail.Id
                       select ic).ToList();

            return res;
        }
    }
}
