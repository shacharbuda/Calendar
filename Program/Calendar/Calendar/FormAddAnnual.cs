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
    public partial class FormAddAnnual : Form
    {
        private OleDbConnection dataConnection;
        System.Globalization.HebrewCalendar hebCal = new System.Globalization.HebrewCalendar();
        public FormAddAnnual(OleDbConnection dataConnection,bool isAdmin)
        {
            InitializeForm(dataConnection);
            if (!isAdmin)
                addButton.Enabled = false;
        }

        public FormAddAnnual(OleDbConnection dataConnection,DateTime date)
        {
            InitializeForm(dataConnection);
            string msg = "להוספת אירוע שנתי עברי, לחץ \"כן\"" + "\n" +
                       "להוספת אירוע שנתי לועזי, לחץ \"לא\"";
            DialogResult dialogResult = MessageBox.Show(msg, "הוספת אירוע שנתי", MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                                                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            if (dialogResult == DialogResult.No)
            {
                anYear.Text = date.Year.ToString();
                anMonth.Text = date.Month.ToString();
                anDay.Text = date.Day.ToString();
                anGreg.Checked = true;
            }
            else
            {
                anYear.Text = hebCal.GetYear(date).ToString();
                anMonth.Text = hebCal.GetMonth(date).ToString();
                anDay.Text = hebCal.GetDayOfMonth(date).ToString();
            }
            anYear.Enabled = false;
            anMonth.Enabled = false;
            anDay.Enabled = false;
            anGreg.Enabled = false;
        }

        private string GetStringHebDate(int day,int month,int year,bool leap)
        {
            string[] arrDays = { "א", "ב", "ג", "ד", "ה", "ו", "ז", "ח", "ט", "י", "יא", "יב", "יג", "יד", "טו", "טז", "יז", "יח", "יט", "כ", "כא", "כב", "כג", "כד", "כה", "כו", "כז", "כח", "כט", "ל" };
            string[] arrMonths12 = { "תשרי", "חשוון", "כסלו", "טבת", "שבט", "אדר", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" };
            string[] arrMonths13 = { "תשרי", "חשוון", "כסלו", "טבת", "שבט", "אדר א", "אדר ב", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" };
            string msg = arrDays[day - 1]+" ";
            if (leap)
                msg += arrMonths13[month - 1]+" ";
            else
                msg += arrMonths12[month - 1]+" ";
            msg += GetStringHebYear(year);
            return msg;
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

        private void InitializeForm(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            FillTypeCombo();
        }

        private void FillTypeCombo()                                   // Populate eventsType combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT typeName " +
                                          "FROM tblEventTypes " +
                                          "ORDER BY typeName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    anType.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill annualTypes combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                    ("INSERT INTO tblAnnuals " +
                    "(annualType, annualName, annualYear, annualMonth, annualDay, annualGregorian, annualPicture) " +
                    " VALUES ( \"{0}\", \"{1}\", {2}, {3}, {4}, {5}, \"{6}\")",
                    anType.Text, anName.Text, anYear.Text, anMonth.Text, anDay.Text, anGreg.Checked, anPictureLocation.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblAnnuals ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblAnnuals failed \n" + err.Message, "Error",
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
                                     "FROM     tblAnnuals " +
                                     "ORDER BY annualType";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView2.DataSource = tbl;
                dataGridView2.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BrowseButtonClick(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            anPictureLocation.Text = pictureFileName;
        }

        private void FormAddAnnual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAnnuals.tblAnnuals' table. You can move, or remove it, as needed.
            this.tblAnnualsTableAdapter.Fill(this.dataSetAnnuals.tblAnnuals);

        }

        private void anGreg_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (anYear.Text == "" || anMonth.Text == "" || anDay.Text == "")
                {
                    labelHebDate.ResetText();
                    return;
                }
                if (anGreg.Checked)
                {
                    labelHebDate.ResetText();
                    return;
                }
                int year = int.Parse(anYear.Text);
                int month = int.Parse(anMonth.Text);
                int day = int.Parse(anDay.Text);
                labelHebDate.Text = GetStringHebDate(day, month, year, hebCal.IsLeapYear(year));
            }
            catch
            {
                labelHebDate.ResetText();
            }
        }
    }
}