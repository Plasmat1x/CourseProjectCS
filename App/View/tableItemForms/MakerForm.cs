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
        public MakerForm()
        {
            InitializeComponent();

            var makers = context.Makers.ToList();
            ItemsGrid.DataSource = makers;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {

        }

        private void MakerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ItemsGrid_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
