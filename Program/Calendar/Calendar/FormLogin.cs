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
    public partial class FormLogin : Form
    {
        private OleDbConnection dataConnection;
        string name;
        bool isAdmin;
        int userID;
        public FormLogin()
        {
            InitializeComponent();
            OpenDb();
        }

        private void OpenDb()
        {
            dataConnection = new OleDbConnection();
            try
            {
                dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Projects_2017\\Project_ShacharBuda\\Access\\dbCalendar.accdb";
                dataConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error accessing the database " + e.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckButtonClick(object sender, EventArgs e)
        {
            string line, password;
            try
            {
                OleDbCommand dataCommand = new OleDbCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT userID,userPassword,userFirstName,userIsAdmin,userPicture " + "FROM tblUsers " + "WHERE userID =" + this.idNumber.Text;
                OleDbDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                userID = dataReader.GetInt32(0);
                password = dataReader.GetString(1);
                if (password == this.password.Text)
                {
                    name=dataReader.GetString(2);
                    isAdmin = dataReader.GetBoolean(3);
                    Welcome(dataReader.GetString(4));
                }
                else
                {
                    line = "Invalid password: " + this.password.Text;
                    MessageBox.Show(line, "Error");
                }
            }
            catch (Exception err)
            {
                line = "Invalid id: " + this.idNumber.Text + err.Message;
                MessageBox.Show(line, "Error");
            }
        }

        private void Welcome(string picLocation)
        {
            HideOthers();
            welcomeButton.Text = "ברוך הבא למערכת\n"+
                                 "Boogle Calendar\n" + name + " !" +
                                 "\n\nלחץ כאן להמשך";
            welcomeButton.Visible = true;
            userPicture.Visible = true;
            userPicture.ImageLocation = picLocation;
        }

        private void HideOthers()
        {
            password.Visible = false;
            label1.Visible = false;
            idNumber.Visible = false;
            label2.Visible = false;
            checkButton.Visible = false;
            logoPicture.Visible = false;
        }

        private void WelcomeButtonClick(object sender,EventArgs e)
        {
            this.Hide();
            FormMenu frMenu = new FormMenu(dataConnection,name,isAdmin,userID);
            frMenu.Show();
            frMenu.Disposed += frMenu_Disposed;
        }

        void frMenu_Disposed(object sender, EventArgs e)
        {
            InitializeItems();
            this.Show();
            this.Activate();
        }

        //used for returning to form after exiting mainMenu.
        private void InitializeItems()
        {
            this.idNumber.Text = "";
            this.password.Text = "";
            password.Visible = true;
            label1.Visible = true;
            idNumber.Visible = true;
            label2.Visible = true;
            checkButton.Visible = true;
            logoPicture.Visible = true;
            welcomeButton.Visible = false;
            userPicture.Visible = false;
        }

    }
}
