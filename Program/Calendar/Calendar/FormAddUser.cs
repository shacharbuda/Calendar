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
    public partial class FormAddUser : Form
    {
        private OleDbConnection dataConnection;
        public FormAddUser(OleDbConnection dataConnection,bool isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillCityCombo();
            try
            {
                if (!isAdmin)
                {
                    addButton.Enabled = false;
                    dataGridView2.Columns.Remove("userPassword1");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("handling authorization failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillCityCombo()                                   // Populate cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT cityName " +
                                          "FROM tblCities " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBoxCities.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str =string.Format
                    ("INSERT INTO tblUsers " +
                    "(userID, userFirstName, userLastName, userEngDate, userAddress, userCity, userPhone, userMobile, userMail, userPassword, userIsAdmin, userPicture) " +
                    " VALUES ( {0}, \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", \"{8}\", \"{9}\", {10}, \"{11}\")",
                    userID.Text, userFirstName.Text, userLastName.Text, userBirthday.Text, userAddress.Text, comboBoxCities.Text, userTel.Text, userMobile.Text, userMail.Text, userPassword.Text, userIsManager.Checked, userPictureLocation.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblUsers ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblUsers failed \n" + err.Message, "Error",
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
                                     "FROM     tblUsers " +
                                     "ORDER BY userID";
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
            userPictureLocation.Text = pictureFileName;
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

        }
    }
}
