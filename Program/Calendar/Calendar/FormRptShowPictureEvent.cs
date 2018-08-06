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
    public partial class FormRptShowPictureEvent : Form
    {

        public FormRptShowPictureEvent(string id, string type, string name, string memberID, string date, string time, string minutes, string pic)
        {
            Show(id, type, name, memberID, date, time, minutes, pic);
        }

        private void Show(string id, string type, string name, string memberID, string date, string time, string minutes, string pic)
        {
            InitializeComponent();
            MakeAllReadOnly();
            evID.Text = id;
            evType.Text = type;
            evName.Text = name;
            evMemberID.Text = memberID;
            evDate.Value = DateTime.Parse(date);
            evTime.Value = DateTime.Parse(time);
            evMinutes.Text = minutes;
            pictureBox1.ImageLocation = pic;
        }

        public FormRptShowPictureEvent(int idToShow,OleDbConnection dataConnection)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                        "FROM tblEvents " +
                                        "WHERE eventID = " + idToShow +" "+
                                        "ORDER BY eventID ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    int i = 1;
                    string type = dataReader.GetString(i++);
                    string name = dataReader.GetString(i++);
                    string memberID = dataReader.GetInt32(i++).ToString();
                    string date = dataReader.GetDateTime(i++).ToShortDateString();
                    string time = dataReader.GetDateTime(i++).ToShortTimeString();
                    string minutes = dataReader.GetInt32(i++).ToString();
                    string pic = dataReader.GetString(i);
                    Show(idToShow.ToString(),type,name,memberID,date,time,minutes,pic);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecting events failed (FormRptShowPictureEvent constructor)" + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MakeAllReadOnly()
        {
            evID.ReadOnly = true;
            evType.Enabled = false;
            //make backColor normal
            evType.BackColor = System.Drawing.SystemColors.Window;
            evName.ReadOnly = true;
            evMemberID.Enabled = false;
            evMemberID.BackColor = System.Drawing.SystemColors.Window;
            evDate.Enabled = false;
            evDate.BackColor = System.Drawing.SystemColors.Window;
            evTime.Enabled = false;
            evTime.BackColor = System.Drawing.SystemColors.Window;
            evMinutes.ReadOnly = true;
        }   
    }
}
