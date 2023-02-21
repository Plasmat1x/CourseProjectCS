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
    public enum qtty
    {
        min,
        avg,
        max,
    }

    public class DBAnalyticQueryService
    {
        private Model.AppDbContext context = new Model.AppDbContext();

        public DBAnalyticQueryService()
        {

        }

        public void PopularTypeByPrice()
        {
        }

        public IEnumerable<Model.Item> testQuery(qtty t)
        {
            // item.price >= avg price
            var res = (from item in context.Items
                       join maker in context.Makers on item.Maker.Id equals maker.Id
                       join type in context.Types on item.Type.Id equals type.Id
                       select item);

            if (t == qtty.min)
                res = res.Where(x => x.Price <= context.Items.Min(y => y.Price));
            else if (t == qtty.avg)
                res = res.Where(x => x.Price <= context.Items.Average(y => y.Price));
            else if (t == qtty.max)
                res = res.Where(x => x.Price >= context.Items.Max(y => y.Price));

            return res.ToList();
        }
    }
}
