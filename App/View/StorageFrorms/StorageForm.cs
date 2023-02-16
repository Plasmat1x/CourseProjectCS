using CourseProject.Controll;
using CourseProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject.View.StorageFrorms
{
    public partial class StorageForm : Form
    {
        DBStorageService storageService = new DBStorageService();

        public StorageForm()
        {
            InitializeComponent();

            this.Load += Update;
        }

        private void Update(object s, EventArgs e)
        {
            dataGridView1.DataSource = storageService.GetItems();
        }
    }
}
