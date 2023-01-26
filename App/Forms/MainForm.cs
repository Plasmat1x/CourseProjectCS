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
using WFATestZone;

namespace CourseProject
{ 
    public partial class MainForm : Form
    {
        string sqlConnectionString;
        string sqlServer = @"PLASMAT1X\SQLEXPRESS";
        string sqlDatabase = @"CourseProjectCS";

        SqlConnection connection;
        DataBaseService dbservice;

        public MainForm()
        {
            InitializeComponent();
            initElements();
        }

        private void initElements()
        {
            sqlConnectionString = $@"data source = {sqlServer}; initial catalog = {sqlDatabase}; integrated security = true";
            connection = new SqlConnection(sqlConnectionString);
            dbservice = new DataBaseService(connection, tablegrid);

            for(int i = 0; i < (int)Category.count; i++)
            {
                categoryCB.Items.Add((Category)i);
            }

            categoryCB.SelectedIndex = 0;

            showBT.Click += search;

            dbservice.ShowAll(rbDescening.Checked);
        }

        private void search(object sender, EventArgs e)
        {
            dbservice.Category = (Category)categoryCB.SelectedItem;
            dbservice.ShowAll(rbDescening.Checked);
        }
    }
}
