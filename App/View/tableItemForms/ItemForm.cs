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
    public enum formMode
    { 
        INSPECT,
        ADD,
    }

    public partial class ItemForm : Form
    {
        public ItemForm(formMode mode, Model.Item item = null)
        {
            InitializeComponent();

            if(mode == formMode.ADD)
            {
                btDeleteItem.Enabled = false;
            }
            else if(mode == formMode.INSPECT)
            {
                btAddItem.Text = "Update";
                btDeleteItem.Enabled = true;

                tbId.Text = item.Id.ToString();
                tbName.Text = item.Name;
                tbModel.Text = item.Model;
                combMaker.SelectedItem = item.Maker.Name; 
                combType.SelectedItem = item.Type.Name;
                RealeaseDate.Value = item.Release;
                numWeight.Value = item.Weight;
                numPrice.Value = item.Price;

            }
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

        private void btDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
