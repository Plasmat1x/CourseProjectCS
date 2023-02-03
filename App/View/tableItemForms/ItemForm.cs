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
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void ToMakerForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MakerForm makerform = new MakerForm();
            makerform.ShowDialog();
        }

        private void ToTypeForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TypeForm typeform = new TypeForm();
            typeform.ShowDialog();
        }

        private void btAddItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
