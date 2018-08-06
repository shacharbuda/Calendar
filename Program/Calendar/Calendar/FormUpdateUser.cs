using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Calendar
{
    public partial class FormUpdateUser : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        private bool isAdmin;
        public FormUpdateUser(OleDbConnection dataConnection,bool isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillCityCombo();
            RefreshDataGridView();
            this.isAdmin = isAdmin;
            try
            {
                if (!isAdmin)
                {
                    updateButton.Enabled = false;
                    deleteButton.Enabled = false;
                    dataGridView2.Columns.Remove("userPassword2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("handling authorization failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUpdateUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);
        }

        private void FillCityCombo()                   // fill cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   cityName " +
                                          "FROM     tblCities " +
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



        private void UpdateButtonClick(object sender, EventArgs e)          //Update users table
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblUsers  \n" +
                                          "SET    userFirstName    =  \"" + userFirstName.Text + "\" , \n" +
                                                  "userLastName    =  \"" + userLastName.Text + "\" , \n" +
                                                  "userEngDate   =  \"" + userBirthday.Text + "\" , \n" +
                                                  "userAddress     =  \"" + userAddress.Text + "\" , \n" +
                                                  "userCity    =  \"" + comboBoxCities.Text + "\" , \n" +
                                                  "userPhone       =  \"" + userTel.Text + "\" , \n" +
                                                  "userMobile      =  \"" + userMobile.Text + "\" , \n" +
                                                  "userMail        =   \"" + userMail.Text + "\", \n" +
                                                  "userPassword        =   \"" + userPassword.Text + "\", \n" +
                                                  "userIsAdmin =    " + userIsManager.Checked + "   , \n" +
                                                  "userPicture     =  \"" + userPictureLocation.Text + "\"  \n" +
                                          "WHERE  userID = " + userID.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                MessageBox.Show("Update tblUsers ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblUsers failed \n" + err.Message, "Error",
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
                MessageBox.Show("Refresh tblUsers table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("האם אתה בטוח?", "אישור מחיקה", MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                                                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (dialogResult == DialogResult.No)
                    return;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "DELETE FROM tblUsers " +
                                          "WHERE  userID = " + userID.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                MessageBox.Show("Update tblUsers ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblUsers failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView2.CurrentRow.Index;
            prevButton.Enabled = true;
            nextButton.Enabled = true;
            FillSelectedRow();
        }

        private void EnableButtons()
        {
            prevButton.Enabled = true;
            nextButton.Enabled = true;
            if (lastRow == 0)
                prevButton.Enabled = false;
            if (lastRow == dataGridView2.Rows.Count - 1)
                nextButton.Enabled = false;
        }

        private void FillSelectedRow()
        {
            try
            {
                int i = 0;
                userID.Text = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString();
                userFirstName.Text = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString();
                userLastName.Text = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString();
                userBirthday.Text = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString();
                userAddress.Text = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString();
                comboBoxCities.Text = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString();
                userTel.Text = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString();
                userMobile.Text = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString();
                userMail.Text = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString();
                if (isAdmin)
                {
                    labelPassword.Visible = true;
                    userPassword.Visible = true;
                    userPassword.Text = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString();
                }
                userIsManager.Checked = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString() == "True";
                userPictureLocation.Text = dataGridView2.SelectedRows[0].Cells[i++].Value.ToString();
                pictureBox1.ImageLocation = userPictureLocation.Text;
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrevButtonClick(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void NextButtonClick(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void FirstButtonClick(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void LastButtonClick(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow = dataGridView2.Rows.Count - 1;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();

        }

        private void BrowseButtonClick(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            userPictureLocation.Text = pictureFileName;
        }


    }
}