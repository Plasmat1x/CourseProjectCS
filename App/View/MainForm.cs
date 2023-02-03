using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using CourseProject.Model;
using CourseProject.View;
using System.Data.Entity;
using System.Xml.Linq;

namespace CourseProject
{ 
    public partial class MainForm : Form
    {
        AppDbContext context = new AppDbContext();
        Model.Item current;

        List<Model.Item> list;

        public MainForm()
        {
            InitializeComponent();     
            initElements();
            UpdateForm();
            UpdateCbs();
        }

        private void initElements()
        {
            btAddItem.Click += addItem;
            ItemsGrid.SelectionChanged += ItemsGrid_SelectionChanged;

            //test
            test.Click += (object s, EventArgs e) => {
                //ItemsGrid.DataSource = context.Items.Include("Makers").Include("Makers.Types").ToList();
            };
        }

        private void addItem(object sender, EventArgs e)
        {
            ItemForm itemform = new ItemForm(null);
            if(itemform.ShowDialog() == DialogResult.OK)
                UpdateForm();
            UpdateCbs();
        }

        private void btInspectItem_Click(object sender, EventArgs e)
        {
            ItemForm itemform = new ItemForm(current);
            if (itemform.ShowDialog() == DialogResult.OK)
                UpdateForm();
            UpdateCbs();

        }

        private void ItemsGrid_SelectionChanged(object sender, EventArgs e)
        {
            current = ((Model.Item)ItemsGrid.CurrentRow.DataBoundItem);
        }

        private void UpdateForm()
        {
            context = new AppDbContext();
            list = (from item in context.Items
                    join maker in context.Makers on item.Maker.Id equals maker.Id
                    join type in context.Types on item.Type.Id equals type.Id
                    select item
                ).ToList();
            ItemsGrid.DataSource = list;
        }

        private void UpdateCbs()
        {
            cbType.Items.Clear();
            foreach (var i in context.Types)
                cbType.Items.Add(i.Name);

            cbMakers.Items.Clear();
            foreach (var i in context.Makers)
                cbMakers.Items.Add(i.Name);
        }
    }
}
