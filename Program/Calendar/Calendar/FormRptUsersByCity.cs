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
    public partial class FormRptUsersByCity : Form
    {
        private OleDbConnection dataConnection;
        private string userID;
        private string userFName;
        private string userLName;
        private string userBirthday;
        private string userAddress;
        private string userCity;
        private string userTel;
        private string userMobile;
        private string userMail;
        private string userPassword;
        private string userIsAdmin;
        private string userPicture;
        private string saveColor = "";
        private int lastRow = 0;
        private bool mainUserIsAdmin;
        public FormRptUsersByCity(OleDbConnection dataConnection,bool isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            RefreshDataGridView();
            mainUserIsAdmin = isAdmin;
        }

        private void FormRptUsersByCity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCities.tblCities' table. You can move, or remove it, as needed.
            this.tblCitiesTableAdapter.Fill(this.dataSetCities.tblCities);

        }

        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblCities " +
                                     "ORDER BY cityName";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView2.DataSource = tbl;
                dataGridView2.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblCities table failed \n" + err.Message, "Error",
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

        private void FillSelectedRow()
        {
            try
            {
                userCity = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                EnableButtons();
                GetUsers();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetUsers()
        {
            try
            {
                int counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   userID, userFirstName, userLastName, userEngDate, userAddress, userPhone, userMobile, userMail, userPassword, userIsAdmin, userPicture " +
                                         "FROM      tblUsers   " +
                                         "WHERE     userCity = \"" + userCity + "\" " +
                                         "ORDER BY  userID ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    userID = dataReader.GetInt32(0).ToString();
                    userFName = dataReader.GetString(1);
                    userLName = dataReader.GetString(2);
                    userBirthday = dataReader.GetDateTime(3).ToShortDateString();
                    userAddress = dataReader.GetString(4);
                    userTel = dataReader.GetString(5);
                    userMobile = dataReader.GetString(6);
                    userMail = dataReader.GetString(7);
                    userPassword = dataReader.GetString(8);
                    userIsAdmin = dataReader.GetBoolean(9).ToString();
                    userPicture = dataReader.GetString(10);
                    counter++;
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblUsers failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[12];
                if (counter == 1)
                {
                    arr[0] = userCity;
                }
                arr[1] = userID;
                arr[2] = userFName;
                arr[3] = userLName;
                arr[4] = userBirthday;
                arr[5] = userAddress;
                arr[6] = userTel;
                arr[7] = userMobile;
                arr[8] = userMail;
                if (mainUserIsAdmin)
                    arr[9] = userPassword;
                else
                    arr[9] = "";
                if (userIsAdmin == "True")
                    arr[10] = "כן";
                else
                    arr[10] = "לא";
                arr[11] = userPicture;
                ListViewItem item = new ListViewItem(arr);
                if (saveColor != "")
                    item.ForeColor = Color.FromArgb(int.Parse(saveColor));
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void ChooseColorButtonClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            chooseColorButton.BackColor = cd.Color;
            saveColor = chooseColorButton.BackColor.ToArgb().ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
                return;
            int selectedIndex = listView1.SelectedIndices[0];
            if (selectedIndex < 0)
                return;
            string city = "";
            int j = 0;
            while (city == "")
            {
                city = listView1.Items[selectedIndex - j].SubItems[0].Text;
                j++;
            }
            int i = 1;
            string id = listView1.Items[selectedIndex].SubItems[i++].Text;
            string firstName = listView1.Items[selectedIndex].SubItems[i++].Text;
            string lastName = listView1.Items[selectedIndex].SubItems[i++].Text;
            string date = listView1.Items[selectedIndex].SubItems[i++].Text;
            string address = listView1.Items[selectedIndex].SubItems[i++].Text;
            string tel = listView1.Items[selectedIndex].SubItems[i++].Text;
            string mobile = listView1.Items[selectedIndex].SubItems[i++].Text;
            string mail = listView1.Items[selectedIndex].SubItems[i++].Text;
            string password = listView1.Items[selectedIndex].SubItems[i++].Text;
            bool isAdmin = listView1.Items[selectedIndex].SubItems[i++].Text == "כן";
            string pic = listView1.Items[selectedIndex].SubItems[i].Text;
            FormRptShowPictureUser frm = new FormRptShowPictureUser(id, firstName, lastName, date, address, city, tel, mobile, mail, password, isAdmin, pic);
            this.Hide();
            frm.Show();
            frm.Disposed += frm_Disposed;
        }

        void frm_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

    }
}
