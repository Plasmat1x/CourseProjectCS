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

        Model.Country current;

        public CountryForm()
        {
            InitializeComponent();

            UpdateForm();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            context.Countries.Add(new Model.Country { Name = tbName.Text });
            context.SaveChanges();
            UpdateForm();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            context.Countries.Remove(current);
            context.SaveChanges();
            UpdateForm();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ItemsGrid_SelectionChanged(object sender, EventArgs e)
        {
            current = ((Model.Country)ItemsGrid.CurrentRow.DataBoundItem);

            tbId.Text = current.Id.ToString();
            tbName.Text = current.Name;
        }

        private void UpdateForm()
        {
            var types = context.Countries.ToList();
            ItemsGrid.DataSource = types;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            context.Countries.FirstOrDefault(t => t.Id == current.Id).Name = tbName.Text;
            context.SaveChanges();
            UpdateForm();
        }
    }
}
