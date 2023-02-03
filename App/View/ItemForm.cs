﻿using CourseProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.View
{

    public partial class ItemForm : Form
    {
        AppDbContext context = new AppDbContext();

        Model.Item current;

        public ItemForm(Model.Item item)
        {
            InitializeComponent();

            current = context.Items.FirstOrDefault(i => i.Id == item.Id);

            if (current == null)
                btDeleteItem.Enabled = false;
            else
            {
                UpdateForm();
                btAddItem.Text = "Update";
            }


            foreach(var i in context.Makers)
            {
                combMaker.Items.Add(i.Name);
            }
            combMaker.SelectedIndex = 0;

            foreach (var i in context.Types)
            {
                combType.Items.Add(i.Name);
            }
            combType.SelectedIndex = 0;
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
            if(current == null)
            {
                context.Items.Add(new Item
                {
                    Name = tbName.Text,
                    Model = tbModel.Text,
                    Maker = context.Makers.FirstOrDefault(m => m.Name == combMaker.Text),
                    Type = context.Types.FirstOrDefault(m => m.Name == combType.Text),
                    Release = RealeaseDate.Value,
                    Weight = (int)numWeight.Value,
                    Price = numPrice.Value
                });
                
            }
            else
            {
                context.Items.FirstOrDefault(m => m.Id == current.Id).Name = tbName.Text;
                context.Items.FirstOrDefault(m => m.Id == current.Id).Model = tbModel.Text;
                context.Items.FirstOrDefault(m => m.Id == current.Id).Maker = context.Makers.FirstOrDefault(m => m.Name == combMaker.Text);
                context.Items.FirstOrDefault(m => m.Id == current.Id).Type = context.Types.FirstOrDefault(m => m.Name == combType.Text);
                context.Items.FirstOrDefault(m => m.Id == current.Id).Release = RealeaseDate.Value;
                context.Items.FirstOrDefault(m => m.Id == current.Id).Weight = (int)numWeight.Value;
                context.Items.FirstOrDefault(m => m.Id == current.Id).Price = numPrice.Value;
            }
            context.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void btDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UpdateForm()
        {
            tbId.Text = current.Id.ToString();
            tbName.Text = current.Name;
            tbModel.Text = current.Model;
            combMaker.SelectedItem = current.Maker.Name;
            combType.SelectedItem = current.Type.Name;
            RealeaseDate.Value = current.Release;
            numWeight.Value = current.Weight;
            numPrice.Value = current.Price;
        }
    }
}