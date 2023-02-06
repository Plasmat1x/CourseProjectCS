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
        Model.Item current;
        DBItemsQueryService query;

        public MainForm()
        {
            InitializeComponent();     
            initElements();

            query = new DBItemsQueryService();
            query.GetItems();
            ItemsGrid.DataSource = query.Target.ToList();

            for (int i = 0; i < ItemsGrid.ColumnCount; i++)
                categoryCB.Items.Add(ItemsGrid.Columns[i].Name);
            categoryCB.SelectedIndex = 0;

            UpdateCbs();
            UpdateForm();
        }

        private void initElements()
        {
            btAddItem.Click += addItem;
            ItemsGrid.SelectionChanged += ItemsGrid_SelectionChanged;
            showBT.Click += Show;
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
            if (SearchField.Text.Length != 0)
                query.GetItemsByName(SearchField.Text);
            else
                query.GetItems();

            if (cbPriceGroup.Checked == true)
                query.GetItemsAtRangeByPrice(priceFrom.Value, priceTo.Value);
            if (cbWeightGroup.Checked == true)
                query.GetItemsAtRangeByWeight((int)weightFrom.Value, (int)weightTo.Value);
            if (cbDateGroup.Checked == true)
                query.GetItemsAtRangeByDate(dateFrom.Value, dateTo.Value);
            query.GetItemsOrdered((ItemFields)categoryCB.SelectedIndex, rbDescening.Checked);

            ItemsGrid.DataSource = query.Target.ToList();
        }

        private void UpdateCbs()
        {
            cbType.Items.Clear();
            foreach (var i in query.Context.Types)
                cbType.Items.Add(i.Name);

            cbMakers.Items.Clear();
            foreach (var i in query.Context.Makers)
                cbMakers.Items.Add(i.Name);
        }

        private void Show(object sender, EventArgs e)
        {
            UpdateForm();
        }
    }
}
