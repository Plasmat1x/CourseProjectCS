using CourseProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.View
{
    public partial class TypeForm : Form
    {
        AppDbContext context = new AppDbContext();
        public TypeForm()
        {
            InitializeComponent();

            var types = context.Types.ToList();
            ItemsGrid.DataSource = types;
            ItemsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void TypeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ItemsGrid_SelectionChanged(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbName.Text = "";
        }
    }
}
