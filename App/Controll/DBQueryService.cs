using CourseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Xml.Linq;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Mapping;

namespace CourseProject.Controll
{
    public enum ItemFields
    {
        Id, Name, Model, Maker, Type, Weight, Release, Price
    }

    internal class DBItemsQueryService
    {
        private AppDbContext context;
        private IEnumerable<Item> target;

        public IEnumerable<Model.Item> Target { get => target; private set => target = value; }
        internal AppDbContext Context { get => context; private set => context = value; }

        public DBItemsQueryService()
        {
            this.context = new AppDbContext();
        }

        public void UpdateContext(AppDbContext newContext)
        {
            this.context = newContext;
        }

        public void GetItemsAtRangeByPrice(decimal f, decimal t)
        {
            target = target.Where(x => x.Price >= f && x.Price <= t);
        }

        public void GetItemsAtRangeByDate(DateTime f, DateTime t)
        {
            target = target.Where(x => x.Release >= f && x.Release <= t);
        }

        public void GetItemsAtRangeByWeight(int f, int t)
        {
            target = target.Where(x => x.Weight >= f && x.Weight <= t);
        }

        public void GetItemsByMaker(CheckedListBox.CheckedItemCollection col)
        {
            List<Item> res = new List<Item>();
            List<Maker> makers = context.Makers.ToList();

            foreach(var item in col)
            {
                Maker maker = makers.Where(x => x.Name == item.ToString()).FirstOrDefault();

                foreach(var i in target)
                {
                    if (i.Maker.Id == maker.Id)
                        res.Add(i);
                }
            }

            target = res;
        }

        public void GetItemsByType(CheckedListBox.CheckedItemCollection col)
        {
            List<Item> res = new List<Item>();
            List<Model.Type> types = context.Types.ToList();

            foreach (var item in col)
            {
                Model.Type type = types.Where(x => x.Name == item.ToString()).FirstOrDefault();

                foreach (var i in target)
                {
                    if (i.Type.Id == type.Id)
                        res.Add(i);
                }
            }

            target = res;
        }

        public void GetItemsByName(string n)
        {
            target = target.Where(x => x.Name.Contains(n));
        }

        public void GetItems()
        {
            target = Context.Items.ToList();
        }

        public void GetItemsOrdered(ItemFields field, bool Descending)
        {
            switch (field)
            {
                case ItemFields.Id:
                    if (Descending) target = target.OrderByDescending(x => x.Id);
                    else target = target.OrderBy(x => x.Id);
                    break;

                case ItemFields.Name:
                    if (Descending) target = target.OrderByDescending(x => x.Name);
                    else target = target.OrderBy(x => x.Name);
                    break;

                case ItemFields.Model:
                    if (Descending) target = target.OrderByDescending(x => x.Model);
                    else target = target.OrderBy(x => x.Model);
                    break;

                case ItemFields.Maker:
                    if (Descending) target = target.OrderByDescending(x => x.Maker);
                    else target = target.OrderBy(x => x.Maker);
                    break;
                case ItemFields.Type:
                    if (Descending) target = target.OrderByDescending(x => x.Type);
                    else target = target.OrderBy(x => x.Type);
                    break;
                case ItemFields.Weight:
                    if (Descending) target = target.OrderByDescending(x => x.Weight);
                    else target = target.OrderBy(x => x.Weight);
                    break;
                case ItemFields.Release:
                    if (Descending) target = target.OrderByDescending(x => x.Release);
                    else target = target.OrderBy(x => x.Release);
                    break;
                case ItemFields.Price:
                    if (Descending) target = target.OrderByDescending(x => x.Price);
                    else target = target.OrderBy(x => x.Price);
                    break;
            }
        }
    }
}
