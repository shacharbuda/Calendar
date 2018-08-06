using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class FormRptShowPictureUser : Form
    {
        public FormRptShowPictureUser(string id, string firstName, string lastName, string date, string address, string city, string tel, string mobile, string mail, string password, bool isAdmin, string pic)
        {
            InitializeComponent();
            MakeAllReadOnly();
            userID.Text = id;
            userFirstName.Text = firstName;
            userLastName.Text = lastName;
            userBirthday.Text = date;
            userAddress.Text = address;
            comboBoxCities.Text = city;
            userTel.Text = tel;
            userMobile.Text = mobile;
            userMail.Text = mail;
            //notice that password will remain blank for non-admin users
            userPassword.Text = password;
            userIsManager.Checked = isAdmin;
            pictureBox1.ImageLocation = pic;
        }

        private void MakeAllReadOnly()
        {
            userID.ReadOnly = true;
            userFirstName.ReadOnly = true;
            userLastName.ReadOnly = true;
            userBirthday.Enabled = false;
            //make backColor normal
            userBirthday.BackColor = System.Drawing.SystemColors.Window;
            userAddress.ReadOnly = true;
            comboBoxCities.Enabled = false;
            //make backColor normal
            comboBoxCities.BackColor = System.Drawing.SystemColors.Window;
            userTel.ReadOnly = true;
            userMobile.ReadOnly = true;
            userMail.ReadOnly = true;
            userPassword.ReadOnly = true;
            userIsManager.Enabled = false;
            //make backColor normal
            userIsManager.BackColor = System.Drawing.SystemColors.Window;
        }  
    }
}
