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
    public partial class FormAddEvent : Form
    {
        private OleDbConnection dataConnection;
        public FormAddEvent(OleDbConnection dataConnection,bool isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillMemIDCombo();
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
                    evType.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill eventTypes combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillMemIDCombo()                                   // Populate MemberID combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT userID " +
                                          "FROM tblUsers " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    evMemberID.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill eventMemberID combobox failed \n" + err.Message, "Error",
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
                    ("INSERT INTO tblEvents " +
                    "(eventType, eventName, eventMemberID, eventDate, eventTime, eventMinutes, eventPicture) " +
                    " VALUES ( \"{0}\", \"{1}\", {2}, \"{3}\", \"{4}\", {5}, \"{6}\")",
                    evType.Text, evName.Text, evMemberID.Text, evDate.Text, evTime.Text, evMinutes.Text, evPictureLocation.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblEvents ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblEvents failed \n" + err.Message, "Error",
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
                                     "FROM     tblEvents " +
                                     "ORDER BY eventID";
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
            evPictureLocation.Text = pictureFileName;
        }

        private void FormAddEvent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEvents.tblEvents' table. You can move, or remove it, as needed.
            this.tblEventsTableAdapter.Fill(this.dataSetEvents.tblEvents);

        }
    }
}