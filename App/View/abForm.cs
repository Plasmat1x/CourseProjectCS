using CourseProject.Controll;
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
    public partial class abForm : Form
    {
        DBAnalyticQueryService dbserv = new DBAnalyticQueryService();
        public abForm()
        {
            InitializeComponent();

            buttonLow.Click += min;
            buttonAvg.Click += avg;
            buttonHigh.Click += max;
        }

        private void min(object s, EventArgs e)
        {
            dataGridView1.DataSource = dbserv.testQuery(qtty.min);
        }
        private void avg(object s, EventArgs e)
        {
            dataGridView1.DataSource = dbserv.testQuery(qtty.avg);
        }
        private void max(object s, EventArgs e)
        {
            dataGridView1.DataSource = dbserv.testQuery(qtty.max);
        }
    }
}
