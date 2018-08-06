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
    public partial class FormRptAnnualsByDate : Form
    {
        private OleDbConnection dataConnection;
        private string annualType;
        private string annualID;
        private string annualName;
        private string annualYear;
        private string annualMonth;
        private string annualDay;
        private string annualPicture;
        DateTime fromDateDT, toDateDT;
        int fromYear , fromMonth , fromDay;
        int toYear , toMonth , toDay ;
        //used as fromDate value as string
        private string fromDateS;
        //used as toDate value as string
        private string toDateS;
        private string saveColor = "";
        public FormRptAnnualsByDate(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void ShowButtonClick(object sender, EventArgs e)
        {
            int counter = 0;
            try
            {
                fromDateDT=DateTime.Parse(fromDayTB.Text + "/" + fromMonthTB.Text + "/" + fromYearTB.Text);
                toDateDT=DateTime.Parse(toDayTB.Text + "/" + toMonthTB.Text + "/" + toYearTB.Text);
                fromYear = fromDateDT.Year;
                fromMonth = fromDateDT.Month;
                fromDay = fromDateDT.Day;
                toYear = toDateDT.Year;
                toMonth = toDateDT.Month;
                toDay = toDateDT.Day;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Get date from user failed. Check your date values and try again " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                        "FROM tblAnnuals " +
                                        "WHERE ((annualYear BETWEEN " + fromYear + " AND " + toYear + ") " +
                                        "OR ("+fromYear+"="+toYear+"= annualYear"+" AND (annualMonth BETWEEN " + fromMonth + " AND " + toMonth + ")) " +
                                        "OR ("+fromYear+"="+toYear+"= annualYear"+" AND "+fromMonth+"="+toMonth+"= annualMonth"+" AND (annualDay BETWEEN " + fromDay + " AND " + toDay + ")) " +
                                        "OR (" + fromYear + "=" + toYear +"= annualYear"+ " AND " + fromMonth + "=" + toMonth +"= annualMonth"+ " AND " + fromDay + "=" + toDay + "= annualDay"+")) " +
                                        "ORDER BY annualID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    annualID = dataReader.GetInt32(0).ToString();
                    annualType = dataReader.GetString(1);
                    annualName = dataReader.GetString(2);
                    annualYear = dataReader.GetInt32(3).ToString();
                    annualMonth = dataReader.GetInt32(4).ToString();
                    annualDay = dataReader.GetInt32(5).ToString();
                    if (GregDateRadioButton.Checked && !dataReader.GetBoolean(6))
                        continue;
                    else if (HebDateRadioButton.Checked && dataReader.GetBoolean(6))
                        continue;
                    annualPicture = dataReader.GetString(7);
                    counter++;
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ShowButtonClick failed. " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void EditListView(int counter)
        {
            try
            {
                fromDateS = fromDateDT.ToShortDateString();
                toDateS = toDateDT.ToShortDateString();
                string[] arr = new string[10];
                if (counter == 1)
                {
                    if(HebDateRadioButton.Checked)
                        arr[0]="עברי";
                    else
                        arr[0]="לועזי";
                    
                    arr[1] = fromDateS;
                    arr[2] = toDateS;
                }
                arr[3] = annualID;
                arr[4] = annualType;
                arr[5] = annualName;
                arr[6] = annualYear;
                arr[7] = annualMonth;
                arr[8] = annualDay;
                arr[9] = annualPicture;
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

        private void CheckedDateType(object sender, EventArgs e)
        {
            showButton.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
                return;
            int selectedIndex = listView1.SelectedIndices[0];
            if (selectedIndex < 0)
                return;
            string gregOrHebStr="";
            int j = 0;
            while (gregOrHebStr == "")
            {
                gregOrHebStr = listView1.Items[selectedIndex - j].SubItems[0].Text;
                j++;
            }
            bool isGreg=gregOrHebStr=="לועזי";
            int i = 3;                                                  
            string id = listView1.Items[selectedIndex].SubItems[i++].Text;
            string type = listView1.Items[selectedIndex].SubItems[i++].Text;
            string name = listView1.Items[selectedIndex].SubItems[i++].Text;
            string year = listView1.Items[selectedIndex].SubItems[i++].Text;
            string month = listView1.Items[selectedIndex].SubItems[i++].Text;
            string day = listView1.Items[selectedIndex].SubItems[i++].Text;
            string pic = listView1.Items[selectedIndex].SubItems[i].Text;
            FormRptShowPictureAnnual frm = new FormRptShowPictureAnnual(isGreg, id, type, name, year, month, day, pic);
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