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
    public partial class FormRptParashot : Form
    {
        private OleDbConnection dataConnection;
        private string parashYear;
        private string parashConnected1;
        private string parashConnected2;
        private string parashConnected3;
        private string parashConnected4;
        private string parashConnected5;
        private string parashConnected6;
        private string saveColor = "";

        public FormRptParashot(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillCheckedListBox();
        }

        private void FillCheckedListBox()
        {
            try
            {
                yearsCheckedListBox.Items.Clear();
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT parashYear " +
                                        "FROM tblParashot " +
                                        "ORDER BY parashYear";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    yearsCheckedListBox.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("fill checked list box failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowButtonClick(object sender, EventArgs e)
        {
            try
            {
                string selectedYears = "";
                foreach (object item in yearsCheckedListBox.CheckedItems)
                {
                    if (selectedYears != "")
                        selectedYears += ",";
                    selectedYears += item.ToString();
                }
                if (selectedYears == "")
                { 
                    MessageBox.Show("nothing selected", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                        "FROM tblParashot " +
                                        "WHERE parashYear IN (" + selectedYears + ") " +
                                        "ORDER BY parashYear";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    parashYear = dataReader.GetInt32(0).ToString();
                    parashConnected1 = dataReader.GetBoolean(1).ToString();
                    parashConnected2 = dataReader.GetBoolean(2).ToString();
                    parashConnected3 = dataReader.GetBoolean(3).ToString();
                    parashConnected4 = dataReader.GetBoolean(4).ToString();
                    parashConnected5 = dataReader.GetBoolean(5).ToString();
                    parashConnected6 = dataReader.GetBoolean(6).ToString();
                    EditListView();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("select parashot failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView()
        {
            try
            {
                string[] arr = new string[8];
                int i = 0;
                arr[i++] = parashYear;
                arr[i++] = GetStringHebYear(int.Parse(parashYear));
                arr[i++] = parashConnected1;
                arr[i++] = parashConnected2;
                arr[i++] = parashConnected3;
                arr[i++] = parashConnected4;
                arr[i++] = parashConnected5;
                arr[i] = parashConnected6;
                for (i = 2; i < 8; i++)
                    if (arr[i] == "True")
                        arr[i] = "כן";
                    else
                        arr[i] = "";
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
            foreach (int i in yearsCheckedListBox.CheckedIndices)
                yearsCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            chooseAllButton.Text = "בחר הכל";
        }

        private void ChooseColorButtonClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            chooseColorButton.BackColor = cd.Color;
            saveColor = chooseColorButton.BackColor.ToArgb().ToString();
        }

        private string GetStringHebYear(int yearNum)
        {
            try
            {
                string year = "", str100s = "";
                char[] unitsAbc = "אבגדהוזחט".ToCharArray();
                char[] tensAbc = "יכלמנסעפצ".ToCharArray();
                char[] hundrendsAbc = "קרשת".ToCharArray();
                int thousands = 0, hundrends = 0, tens = 0, units = 0;
                while (yearNum > 999)
                {
                    thousands++;
                    yearNum -= 1000;
                }
                while (yearNum > 99)
                {
                    hundrends++;
                    yearNum -= 100;
                }
                while (yearNum > 9)
                {
                    tens++;
                    yearNum -= 10;
                }
                while (yearNum > 0)
                {
                    units++;
                    yearNum--;
                }
                while (hundrends >= 4)
                {
                    str100s += hundrendsAbc[3];
                    hundrends -= 4;
                }
                while (hundrends >= 3)
                {
                    str100s += hundrendsAbc[2];
                    hundrends -= 3;
                }
                while (hundrends >= 2)
                {
                    str100s += hundrendsAbc[1];
                    hundrends -= 2;
                }
                while (hundrends >= 1)
                {
                    str100s += hundrendsAbc[0];
                    hundrends--;
                }
                year += unitsAbc[thousands - 1] + "' ";
                year += str100s;
                if (tens != 0)
                    year += tensAbc[tens - 1];
                if (units != 0)
                    year += unitsAbc[units - 1];
                return year;
            }
            catch (Exception err)
            {
                MessageBox.Show("GetStringHebYear failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
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
            for (int i = 0; i < yearsCheckedListBox.Items.Count; i++) // loop to set all items checked (selected) or unchecked (!selected)
                yearsCheckedListBox.SetItemChecked(i, selected);
        }

    }
}
