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
    public partial class FormAddAnnual : Form
    {
        private OleDbConnection dataConnection;
        public FormAddAnnual(OleDbConnection dataConnection,bool isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillTypeCombo();
            if (!isAdmin)
                addButton.Enabled = false;
        }
        private void FillTypeCombo()                                   // Populate eventsType combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT typeName " +
                                          "FROM tblEventTypes " +
                                          "ORDER BY typeName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    anType.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill annualTypes combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                    ("INSERT INTO tblAnnuals " +
                    "(annualType, annualName, annualYear, annualMonth, annualDay, annualGregorian, annualPicture) " +
                    " VALUES ( \"{0}\", \"{1}\", {2}, {3}, {4}, {5}, \"{6}\")",
                    anType.Text, anName.Text, anYear.Text, anMonth.Text, anDay.Text, anGreg.Checked, anPictureLocation.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblAnnuals ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblAnnuals failed \n" + err.Message, "Error",
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
                                     "FROM     tblAnnuals " +
                                     "ORDER BY annualType";
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
        private void BrowseButtonClick(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            anPictureLocation.Text = pictureFileName;
        }

        private void FormAddAnnual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAnnuals.tblAnnuals' table. You can move, or remove it, as needed.
            this.tblAnnualsTableAdapter.Fill(this.dataSetAnnuals.tblAnnuals);

        }
    }
}