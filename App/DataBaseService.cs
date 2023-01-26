using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFATestZone
{
    public enum Category
    {
        id,
        name,
        model,
        maker,
        type,
        price,
        weight,
        selldate,
        count,
    };

    public class DataBaseService
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet data;

        DataGridView target { get; set; }

        public Category Category { get; set; }

        public DataBaseService(SqlConnection connection, DataGridView target)
        {
            this.target = target;
            this.connection = connection;
            data = new DataSet();
        }

        public void ShowAll(bool desc = false)
        {
            data.Clear();

            string comstr = File.ReadAllText("../../Queries/SELECT_ALL.sql");

            comstr += " ORDER BY ";

            comstr += Category;

            if (desc)
                comstr += " DESC;";
            else
                comstr += " ASC;";

            this.command = new SqlCommand(comstr, connection);

            adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            target.DataSource = data.Tables[0];
        }
    }
}
