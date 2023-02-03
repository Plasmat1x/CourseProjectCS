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

namespace CourseProject
{ 
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            initElements();  
        }

        private void initElements()
        {
            testForm.Click += ToItemForm;
        }

        private void ToItemForm(object sender, EventArgs e)
        {
            ItemForm itemform = new ItemForm();
            itemform.ShowDialog();
        }
    }
}
