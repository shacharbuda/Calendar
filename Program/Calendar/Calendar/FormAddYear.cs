using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Calendar
{
    public partial class FormAddYear : Form
    {
        private OleDbConnection dataConnection;
        public FormAddYear(OleDbConnection dataConnection,bool isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            if (!isAdmin)
                addButton.Enabled = false;
        }


        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                    ("INSERT INTO tblParashot " +
                    "(parashYear, parashConnect1, parashConnect2, parashConnect3, parashConnect4, parashConnect5, parashConnect6) " +
                    " VALUES ( {0}, {1}, {2}, {3}, {4}, {5}, {6})",
                    parashYearNum.Text, parashConnect1.Checked, parashConnect2.Checked, parashConnect3.Checked, parashConnect4.Checked, parashConnect5.Checked, parashConnect6.Checked);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblYears ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblParashot failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblParashot " +
                                     "ORDER BY parashYear";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView2.DataSource = tbl;
                dataGridView2.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddYear_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetParashot.tblParashot' table. You can move, or remove it, as needed.
            this.tblParashotTableAdapter.Fill(this.dataSetParashot.tblParashot);

        }
    }
}