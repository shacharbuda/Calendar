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
    public partial class FormRptAnnualsByDays : Form
    {
        private OleDbConnection dataConnection;
        private string annualType;
        private string annualID;
        private string annualName;
        private string annualYear;
        private string prevDay;
        private string annualMonth;
        private string annualDay;
        private string annualGreg;
        private string annualPicture;
        private string saveColor = "";
        public FormRptAnnualsByDays(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void ShowButtonClick(object sender, EventArgs e)
        {
            string selectedDays = "";
            int counter = 0;
            foreach (int index in daysCheckedListBox.CheckedIndices)
            {
                if (selectedDays != "")
                    selectedDays += ",";
                selectedDays += index + 1;
            }
            if (selectedDays == "")
            {
                MessageBox.Show("nothing selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT * " +
                                    "FROM tblAnnuals " +
                                    "WHERE annualDay IN (" + selectedDays + ") " +
                                    "ORDER BY annualID";
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            prevDay = annualDay;
            while (dataReader.Read())
            {
                annualID = dataReader.GetInt32(0).ToString();
                annualType = dataReader.GetString(1);
                annualName = dataReader.GetString(2);
                annualYear = dataReader.GetInt32(3).ToString();
                annualMonth = dataReader.GetInt32(4).ToString();
                annualDay = dataReader.GetInt32(5).ToString();
                annualGreg = dataReader.GetBoolean(6).ToString();
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
                string[] arr = new string[8];
                if (annualDay != prevDay || counter == 1)
                {
                    arr[0] = annualDay;
                }
                arr[1] = annualID;
                arr[2] = annualType;
                arr[3] = annualName;
                arr[4] = annualYear;
                arr[5] = annualMonth;
                if (annualGreg == "True")
                    arr[6] = "כן";
                else
                    arr[6] = "לא";
                arr[7] = annualPicture;
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
            foreach (int i in daysCheckedListBox.CheckedIndices)
                daysCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            chooseAllButton.Text = "בחר הכל";

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
            string day = "";
            int j = 0;
            while (day== "")
            {
                day = listView1.Items[selectedIndex - j].SubItems[0].Text;
                j++;
            }
            int i = 1;
            string id = listView1.Items[selectedIndex].SubItems[i++].Text;
            string type = listView1.Items[selectedIndex].SubItems[i++].Text;
            string name = listView1.Items[selectedIndex].SubItems[i++].Text;
            string year = listView1.Items[selectedIndex].SubItems[i++].Text;
            string month = listView1.Items[selectedIndex].SubItems[i++].Text;
            bool isGreg = listView1.Items[selectedIndex].SubItems[i++].Text=="כן";
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

        private void ChooseAllButtonClick(object sender, EventArgs e)
        {
            if (chooseAllButton.Text == "בחר הכל")
            {
                ChooseUnChooseAll(true);
                chooseAllButton.Text = "בטל בחירת הכל";
            }
            else
            {
                ChooseUnChooseAll(false);
                chooseAllButton.Text = "בחר הכל";
            }
        }

        private void ChooseUnChooseAll(bool selected)
        {
            for (int i = 0; i < daysCheckedListBox.Items.Count; i++) // loop to set all items checked (selected) or unchecked (!selected)
                daysCheckedListBox.SetItemChecked(i, selected);
        }

    }
}