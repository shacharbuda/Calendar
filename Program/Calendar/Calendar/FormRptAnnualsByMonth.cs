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
    public partial class FormRptAnnualsByMonth : Form
    {
        private OleDbConnection dataConnection;
        private string annualType;
        private string annualID;
        private string annualName;
        private string annualYear;
        private string prevMonth;
        private string annualMonth;
        private string annualDay;
        private bool annualGreg;
        private string annualPicture;
        private string saveColor = "";
        private bool isGreg;
        public FormRptAnnualsByMonth(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void ShowButtonClick(object sender, EventArgs e)
        {
            string selectedMonths = "";
            int counter = 0;
            foreach (int index in monthsCheckListBox.CheckedIndices)
            {
                if (selectedMonths != "")
                    selectedMonths += ",";
                selectedMonths += index + 1;
            }
            if (selectedMonths == "")
            {
                MessageBox.Show("Nothing selected!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT * " +
                                    "FROM tblAnnuals " +
                                    "WHERE annualMonth IN (" + selectedMonths + ") " +
                                    "ORDER BY annualID";
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            while (dataReader.Read())
            {
                prevMonth = annualMonth;
                annualGreg = dataReader.GetBoolean(6);
                if (annualGreg && !isGreg)
                    continue;
                if (!annualGreg && isGreg)
                    continue;
                annualID = dataReader.GetInt32(0).ToString();
                annualType = dataReader.GetString(1);
                annualName = dataReader.GetString(2);
                annualYear = dataReader.GetInt32(3).ToString();
                annualMonth = dataReader.GetInt32(4).ToString();
                annualDay = dataReader.GetInt32(5).ToString();
                annualPicture = dataReader.GetString(7);
                counter++;
                EditListView(counter);
            }
            dataReader.Close();
        }

        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[9];
                if (counter == 1)
                {
                    if (!isGreg)
                        arr[0] = "עברי";
                    else
                        arr[0] = "לועזי";
                }
                if (counter == 1 || prevMonth != annualMonth)
                    arr[1] = annualMonth;
                int i = 2;
                arr[i++] = annualID;
                arr[i++] = annualType;
                arr[i++] = annualName;
                arr[i++] = annualYear;
                arr[i++] = IsLeapYear(int.Parse(annualYear));
                arr[i++] = annualDay;
                arr[i] = annualPicture;
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

        private string IsLeapYear(int year)
        {
            if (isGreg)
                return "";
            int remainder = year % 19;
            switch (remainder)
            {
                case 0:
                case 3:
                case 6:
                case 8:
                case 11:
                case 14:
                case 17:
                    return "כן";
                default:
                    return "לא";
            }
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (int i in monthsCheckListBox.CheckedIndices)
                monthsCheckListBox.SetItemCheckState(i, CheckState.Unchecked);
            chooseAllButton.Text = "בחר הכל";
        }

        private void ChooseColorButtonClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            chooseColorButton.BackColor = cd.Color;
            saveColor = chooseColorButton.BackColor.ToArgb().ToString();
        }

        private void DateTypeClick(object sender, EventArgs e)
        {
            showButton.Enabled = true;
            monthsCheckListBox.Enabled = true;
            chooseAllButton.Enabled = true;
            chooseAllButton.Text = "בחר הכל";
            RadioButton dateTypeSelected = (RadioButton)sender;
            string[] hebMonths = { "תשרי", "חשוון", "כסלו", "טבת", "שבט", "אדר", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" };
            string[] gregMonths = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames;
            monthsCheckListBox.Items.Clear();
            if (dateTypeSelected.Text == "לועזי")
            {
                for (int i = 0; i < 12; i++)
                    monthsCheckListBox.Items.Add(gregMonths[i]);
                isGreg = true;
            }
            else
            {
                for (int i = 0; i < 12; i++)
                    monthsCheckListBox.Items.Add(hebMonths[i]);
                isGreg = false;
            }
        }

        private void ChooseAllButtonClick(object sender, EventArgs e)
        {
            if(chooseAllButton.Text=="בחר הכל")
            {
                ChooseUnChooseAll(true);
                chooseAllButton.Text="בטל בחירת הכל";
            }
            else
            {
                ChooseUnChooseAll(false);
                chooseAllButton.Text = "בחר הכל";
            }
        }

        private void ChooseUnChooseAll(bool selected)
        {
            for (int i = 0; i < monthsCheckListBox.Items.Count; i++) // loop to set all items checked (selected) or unchecked (!selected)
                monthsCheckListBox.SetItemChecked(i, selected);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
                return;
            int selectedIndex = listView1.SelectedIndices[0];
            if (selectedIndex < 0)
                return;
            string month = "",gregOrHebStr="";
            int j = 0;
            while (gregOrHebStr == "")
            {
                gregOrHebStr = listView1.Items[selectedIndex - j].SubItems[0].Text;
                j++;
            }
            bool isGreg = gregOrHebStr == "לועזי";
            j = 0;
            while (month == "")
            {
                month = listView1.Items[selectedIndex - j].SubItems[1].Text;
                j++;
            }
            int i = 2;
            string id = listView1.Items[selectedIndex].SubItems[i++].Text;
            string type = listView1.Items[selectedIndex].SubItems[i++].Text;
            string name = listView1.Items[selectedIndex].SubItems[i++].Text;
            string year = listView1.Items[selectedIndex].SubItems[i++].Text;
            i++;
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