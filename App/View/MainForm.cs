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
        AppDbContext context;
        Model.Item current;
        public MainForm()
        {
            InitializeComponent();
            initElements();

            UpdateForm();
        }

        private void initElements()
        {
            btAddItem.Click += addItem;
            ItemsGrid.SelectionChanged += ItemsGrid_SelectionChanged;
        }

        private void addItem(object sender, EventArgs e)
        {
            ItemForm itemform = new ItemForm(null);
            if(itemform.ShowDialog() == DialogResult.OK)
                UpdateForm();
        }

        private void btInspectItem_Click(object sender, EventArgs e)
        {
            ItemForm itemform = new ItemForm(current);
            if (itemform.ShowDialog() == DialogResult.OK)
                UpdateForm();

        }

        private void ItemsGrid_SelectionChanged(object sender, EventArgs e)
        {
            current = ((Model.Item)ItemsGrid.CurrentRow.DataBoundItem);
        }

        private void UpdateForm()
        {
            context = new AppDbContext();
            var items = context.Items.ToList();
            ItemsGrid.DataSource = items;
        }
    }
}
