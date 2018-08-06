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
    public partial class FormAddEventType : Form
    {
        private OleDbConnection dataConnection;
        public FormAddEventType(OleDbConnection dataConnection,bool isAdmin)
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
                    ("INSERT INTO tblEventTypes " +
                    "(typeName) " +
                    " VALUES ( \"{0}\")",
                    typeName.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblEventTypes ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblEventTypes failed \n" + err.Message, "Error",
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
                                     "FROM     tblEventTypes " +
                                     "ORDER BY typeName";
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

        private void FormAddEventType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEventTypes.tblEventTypes' table. You can move, or remove it, as needed.
            this.tblEventTypesTableAdapter.Fill(this.dataSetEventTypes.tblEventTypes);

        }
    }
}