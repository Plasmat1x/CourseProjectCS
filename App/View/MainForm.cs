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
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Mapping;
using CourseProject.Controll;

namespace CourseProject
{
    public partial class MainForm : Form
    {
        Model.Item current = new Model.Item();
        DBItemsQueryService query;

        public MainForm()
        {
            InitializeComponent();     
            initElements();

            combFieldName.DataSource = current.GetType().GetProperties().ToList();
            combFieldName.ValueMember = "Name";
            combFieldName.SelectedIndex = 0;

            query = new DBItemsQueryService();
            query.GetItems();
            ItemsGrid.DataSource = query.Target.ToList();

            UpdateCbs();
            UpdateForm();
        }

        private void initElements()
        {
            checksMakers.Items.Clear();
            checksType.Items.Clear();

            buttonAddItem.Click += addItem;
            ItemsGrid.SelectionChanged += ItemsGrid_SelectionChanged;
            buttonShowResults.Click += Show;
        }

        private void addItem(object sender, EventArgs e)
        {
            ItemForm itemform = new ItemForm(null);
            if(itemform.ShowDialog() == DialogResult.OK)
                UpdateForm();
            UpdateCbs();
        }

        private void btInspectItem_Click(object sender, EventArgs e)
        {
            ItemForm itemform = new ItemForm(current);
            if (itemform.ShowDialog() == DialogResult.OK)
                UpdateForm();
            UpdateCbs();

        }

        private void ItemsGrid_SelectionChanged(object sender, EventArgs e)
        {
            current = ((Model.Item)ItemsGrid.CurrentRow.DataBoundItem);
        }

        private void UpdateForm()
        {
            if (nameTextBox.Text.Length != 0)
                query.GetItemsByName(nameTextBox.Text);
            else
                query.GetItems();

            if (checkMakersGroup.Checked == true)
               query.GetItemsByMaker(checksMakers.CheckedItems);
            if (checkTypesGroup.Checked == true)
                query.GetItemsByType(checksType.CheckedItems);
                

            if (checkPriceGroup.Checked == true)
                query.GetItemsAtRangeByPrice(priceFrom.Value, priceTo.Value);
            if (checkWeightGroup.Checked == true)
                query.GetItemsAtRangeByWeight((int)weightFrom.Value, (int)weightTo.Value);
            if (checkDateGroup.Checked == true)
                query.GetItemsAtRangeByDate(dateFrom.Value, dateTo.Value);
            query.GetItemsOrdered((ItemFields)combFieldName.SelectedIndex, radioDescening.Checked);

            ItemsGrid.DataSource = query.Target.ToList();
        }

        private void UpdateCbs()
        {
            checksType.Items.Clear();
            foreach (var i in query.Context.Types)
                checksType.Items.Add(i.Name);

            checksMakers.Items.Clear();
            foreach (var i in query.Context.Makers)
                checksMakers.Items.Add(i.Name);
        }

        private void Show(object sender, EventArgs e)
        {
            query.GetItems();
            UpdateForm();
        }
    }
}
