using CourseProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.View
{
    public partial class MakerForm : Form
    {
        AppDbContext context = new AppDbContext();

        Model.Maker current;

        public MakerForm()
        {
            InitializeComponent();

            UpdateForm();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            context.Makers.Add(new Model.Maker { Name = tbName.Text });
            context.SaveChanges();
            UpdateForm();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            context.Makers.Remove(current);
            context.SaveChanges();
            UpdateForm();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ItemsGrid_SelectionChanged(object sender, EventArgs e)
        {
            current = ((Model.Maker)ItemsGrid.CurrentRow.DataBoundItem);

            tbId.Text = current.Id.ToString();
            tbName.Text = current.Name;
        }

        private void UpdateForm()
        {
            var types = context.Makers.ToList();
            ItemsGrid.DataSource = types;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            context.Makers.FirstOrDefault(t => t.Id == current.Id).Name = tbName.Text;
            context.SaveChanges();
            UpdateForm();
        }
    }
}
