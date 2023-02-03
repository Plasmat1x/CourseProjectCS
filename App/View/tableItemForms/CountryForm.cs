using CourseProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.View
{
    public partial class CountryForm : Form
    {
        AppDbContext context = new AppDbContext();
        public CountryForm()
        {
            InitializeComponent();

            var countries = context.Countries.ToList();
            ItemsGrid.DataSource = countries;
            ItemsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void CountryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ItemsGrid_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
