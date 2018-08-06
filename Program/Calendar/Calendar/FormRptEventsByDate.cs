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
    public partial class FormRptEventsByDate : Form
    {
        private OleDbConnection dataConnection;
        private string eventType;
        private string eventID;
        private string eventName;
        private string eventMemberID;
        private string eventDate;
        private string eventTime;
        private string eventMinutes;
        private string eventPicture;
        private string saveColor = "";
        //used as fromDate value as string
        private string fromDateS;
        //used as toDate value as string
        private string toDateS;
        public FormRptEventsByDate(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void ShowButtonClick(object sender, EventArgs e)
        {
            if (CheckDates())
                GetEvents();
            else
                MessageBox.Show("First event should be earlier than second.\nTry again.", "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckDates()
        {
            if (fromDate.Text == toDate.Text)
                return true;
            if (DateTime.Compare(fromDate.Value, toDate.Value) > 0)
                return false;
            return true;
        }

        private void GetEvents()
        {
            try
            {
                fromDateS = fromDate.Value.ToShortDateString();
                toDateS = toDate.Value.ToShortDateString();
                int counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                        "FROM tblEvents " +
                                        "WHERE eventDate BETWEEN #" + fromDateS + "# AND #" + toDateS + "# " +
                                        "ORDER BY eventID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    eventID = dataReader.GetInt32(0).ToString();
                    eventType = dataReader.GetString(1);
                    eventName = dataReader.GetString(2);
                    eventMemberID = dataReader.GetInt32(3).ToString();
                    eventDate = dataReader.GetDateTime(4).ToShortDateString();
                    eventTime = dataReader.GetDateTime(5).ToShortTimeString();
                    eventMinutes = dataReader.GetInt32(6).ToString();
                    eventPicture = dataReader.GetString(7);
                    counter++;
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecting events failed (GetEvents)" + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[10];
                if (counter == 1)
                {
                    arr[0] = fromDateS;
                    arr[1] = toDateS;
                }
                arr[2] = eventID;
                arr[3] = eventType;
                arr[4] = eventName;
                arr[5] = eventMemberID;
                arr[6] = eventDate;
                arr[7] = eventTime;
                arr[8] = eventMinutes;
                arr[9] = eventPicture;
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
            int i = 2;
            string id = listView1.Items[selectedIndex].SubItems[i++].Text;
            string type = listView1.Items[selectedIndex].SubItems[i++].Text;
            string name = listView1.Items[selectedIndex].SubItems[i++].Text;
            string memberID = listView1.Items[selectedIndex].SubItems[i++].Text;
            string date = listView1.Items[selectedIndex].SubItems[i++].Text;
            string time = listView1.Items[selectedIndex].SubItems[i++].Text;
            string minutes= listView1.Items[selectedIndex].SubItems[i++].Text;
            string pic = listView1.Items[selectedIndex].SubItems[i].Text;
            FormRptShowPictureEvent frm = new FormRptShowPictureEvent(id,type,name,memberID,date,time,minutes,pic);
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
