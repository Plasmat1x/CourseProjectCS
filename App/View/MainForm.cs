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

namespace CourseProject
{ 
    public partial class MainForm : Form
    {
        AppDbContext context;

        public MainForm()
        {
            InitializeComponent();
            initElements();  
        }

        private void initElements()
        {
            
            context = new AppDbContext();

            btAddItem.Click += addItem;

            var items = context.Items.ToList();

            ItemsGrid.DataSource = items;
        }

        private void addItem(object sender, EventArgs e)
        {
            ItemForm itemform = new ItemForm(formMode.ADD);
            itemform.ShowDialog();
        }

        private void btInspectItem_Click(object sender, EventArgs e)
        {
            ItemForm itemform = new ItemForm(formMode.INSPECT);
            itemform.ShowDialog();
        }
    }
}
