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
using System.Globalization;

namespace Calendar
{
    public partial class FormCalendar : Form
    {
        OleDbConnection dataConnection;
        //used by many functions
        HebrewCalendar hebCal = new HebrewCalendar();
        bool isAdmin;
        int userID;
        int index = 0;
        string[] gregMonths = { "ינואר", "פברואר", "מרץ", "אפריל", "מאי", "יוני", "יולי", "אוגוסט", "ספטמבר", "אוקטובר", "נובמבר", "דצמבר" };
        public FormCalendar(OleDbConnection dataConnection, bool isAdmin, int id)
        {
            this.dataConnection = dataConnection;
            InitializeComponent();
            SetInitialDate();
            MakeTBReadOnly();
            this.isAdmin = isAdmin;
            allUsersCheckBox.Visible = isAdmin;
            userID = id;
        }

        private void SetInitialDate()
        {
            SetInputText(DateTime.Today);
        }

        private void MakeTBReadOnly()
        {
            RichTextBox month_x_y;
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 7; j++)
                {
                    month_x_y = GetMonth_x_y(i, j);
                    if (month_x_y == null)
                        return;
                    month_x_y.ReadOnly = true;
                    //make backColor normal again
                    month_x_y.BackColor = System.Drawing.SystemColors.Window;
                }
        }

        private void SetInputText(DateTime date)
        {
            try
            {
                yearTextBox.Text = date.Year.ToString();
                monthsComboBox.SelectedIndex = monthsComboBox.FindString(date.Month.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show("SetInputText failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowInputError(Exception err, string current)
        {
            string missing = "Missing:";
            if (monthsComboBox.SelectedIndex == -1)
            {
                missing += " Month";
            }
            if (yearTextBox.Text == "")
            {
                missing += " Year";
            }
            string message = "Getting " + current + " date failed. \nInvalid date\n\n";
            if (missing != "Missing:")
                message += missing;
            message += "\n\n" + err.Message;
            MessageBox.Show(message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        //used by many functions
        private RichTextBox GetMonth_x_y(int x, int y)
        {
            try
            {
                return (RichTextBox)(this.Controls.Find("month_" + x + "_" + y, true))[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void ShowTodayButtonClick(object sender, EventArgs e)
        {
            try
            {
                DateTime today = DateTime.Today;
                string date = 1 + "/" + today.Month + "/" + today.Year;
                SetInputText(today);
                ShowCalendar(DateTime.Parse(date));
            }
            catch (Exception err)
            {
                MessageBox.Show("Getting today date failed.\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowButtonClick(object sender, EventArgs e)
        {
            try
            {
                DateTime pickedDate = DateTime.Parse("1/" + monthsComboBox.Text + "/" + yearTextBox.Text);
                ShowCalendar(pickedDate);
            }
            catch (Exception err)
            {
                ShowInputError(err, "picked");
            }
        }

        private void NextButtonClick(object sender, EventArgs e)
        {
            try
            {
                DateTime newDate;
                int currentMonth = GetCurrentMonth(), currentYear = int.Parse(yearTextBox.Text);
                int newMonth, newYear = currentYear;
                if (currentMonth == 12)
                {
                    newMonth = 1;
                    newYear += 1;
                }
                else
                    newMonth = currentMonth + 1;
                newDate = DateTime.Parse("1/" + newMonth + "/" + newYear);
                SetInputText(newDate);
                ShowCalendar(newDate);

            }
            catch (Exception err)
            {
                ShowInputError(err, "next");
            }
        }

        private void prevButtonClick(object sender, EventArgs e)
        {
            try
            {
                DateTime newDate;
                int currentMonth = GetCurrentMonth(), currentYear = int.Parse(yearTextBox.Text);
                int newMonth, newYear = currentYear;
                if (currentMonth == 1)
                {
                    newMonth = 12;
                    newYear -= 1;
                }
                else
                    newMonth = currentMonth - 1;
                newDate = DateTime.Parse("1/" + newMonth + "/" + newYear);
                SetInputText(newDate);
                ShowCalendar(newDate);
            }
            catch (Exception err)
            {
                ShowInputError(err, "previous");
            }
        }

        private int GetCurrentMonth()
        {
            int month;
            for (month = 0; month < 12; month++)
                if (monthLabel.Text == gregMonths[month])
                    return month + 1;
            return -1;

        }

        //MAIN FUNCTION FOR SHOWING CALENDAR(without events info)
        private void ShowCalendar(DateTime date)
        {
            try
            {
                ClearTable();
                SetLabels(date);
                SetTableDates(date);
                EnableNePre();
                AddParashot();
                AddHolidays();
                AddEventSignsToTable();
                EnableDisableShowTodayButton();
            }
            catch (Exception err)
            {
                MessageBox.Show("ShowCalendar failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTable()
        {
            RichTextBox month_x_y;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 7; j++)
                {
                    month_x_y = GetMonth_x_y(i, j);
                    month_x_y.Enabled = true;
                    month_x_y.Text = "";
                    month_x_y.Font = new Font(month_x_y.Font, FontStyle.Regular);
                }
            for (int j = 0; j < 2; j++)
            {
                month_x_y = GetMonth_x_y(5, j);
                month_x_y.Visible = false;
                month_x_y.Text = "";
                month_x_y.Font = new Font(month_x_y.Font, FontStyle.Regular);
            }
        }

        private void SetLabels(DateTime date)
        {
            try
            {
                yearLabel.Text = date.Year.ToString();
                monthLabel.Text = gregMonths[date.Month - 1];
                monthsComboBox.Text = date.Month.ToString();
                yearTextBox.Text = date.Year.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("SetLabels failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetTableDates(DateTime date)
        {
            try
            {
                int daysInGregMonth = DateTime.DaysInMonth(date.Year, date.Month);
                SetGregTableUnableOtherDays((int)date.DayOfWeek + 1, daysInGregMonth);
                SetHebTableAddToday(date, daysInGregMonth);
                FillBlanked(date);
            }
            catch (Exception err)
            {
                MessageBox.Show("SetTable failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetGregTableUnableOtherDays(int firstDay, int daysInMonth)
        {
            try
            {
                RichTextBox month_x_y;
                int skipIterations = firstDay - 1, dayInMonth = 1;
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 7; j++)
                    {
                        month_x_y = GetMonth_x_y(i, j);
                        if (skipIterations > 0)
                        {
                            month_x_y.Enabled = false;
                            skipIterations--;
                            continue;
                        }
                        month_x_y.Text = dayInMonth.ToString();
                        dayInMonth++;
                        if (dayInMonth > daysInMonth)
                        {
                            //true only for non leap feburuary month that its first is on sunday
                            if (i == 3)
                                UnableOthers(4, 0);
                            else
                                UnableOthers(i, j + 1);
                            return;
                        }
                    }
                //if got here counter is less than daysInMonth
                //set extra days (row 6)
                for (int j = 0; j < 2; j++)
                {
                    month_x_y = GetMonth_x_y(5, j);
                    month_x_y.Visible = true;
                    month_x_y.Text = dayInMonth.ToString();
                    dayInMonth++;
                    if (dayInMonth > daysInMonth)
                        return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("SetGregTable failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnableOthers(int i, int j)
        {
            RichTextBox month_x_y;
            for (; i < 5; i++)
                for (; j < 7; j++)
                {
                    month_x_y = GetMonth_x_y(i, j);
                    month_x_y.Enabled = false;
                }
        }

        private void SetHebTableAddToday(DateTime date, int numOfDaysToShow)
        {
            bool isFirstGregFound = false, firstTime = true;
            int counter = 0;
            RichTextBox month_x_y;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 7; j++)
                {
                    month_x_y = GetMonth_x_y(i, j);
                    if (!isFirstGregFound)
                        if (month_x_y.Text == "1")
                            isFirstGregFound = true;
                        else
                            continue;
                    counter++;
                    AddHebDate(month_x_y, date, firstTime);
                    if (DateTime.Compare(date, DateTime.Today) == 0)
                        AddToday(month_x_y);
                    date = date.AddDays(1);
                    if (counter == numOfDaysToShow)
                        return;
                    if (firstTime)
                        firstTime = false;
                }
            //if got here counter is less than numOfDaysToShow
            //set extra days (row 6)
            for (int j = 0; j < 2; j++)
            {
                month_x_y = GetMonth_x_y(5, j);
                month_x_y.Visible = true;
                counter++;
                AddHebDate(month_x_y, date, false);
                if (DateTime.Compare(date, DateTime.Today) == 0)
                    AddToday(month_x_y);
                date = date.AddDays(1);
                if (counter == numOfDaysToShow)
                    return;
            }
        }

        private void AddHebDate(RichTextBox month_x_y, DateTime gregDate, bool showYear)
        {
            try
            {
                string textMonth, textDate;
                int year = hebCal.GetYear(gregDate);
                int month = hebCal.GetMonth(gregDate);
                int day = hebCal.GetDayOfMonth(gregDate);
                int monthsInYear = hebCal.GetMonthsInYear(year);
                string[] arrDays = { "א", "ב", "ג", "ד", "ה", "ו", "ז", "ח", "ט", "י", "יא", "יב", "יג", "יד", "טו", "טז", "יז", "יח", "יט", "כ", "כא", "כב", "כג", "כד", "כה", "כו", "כז", "כח", "כט", "ל" };
                string[] arrMonths12 = { "תשרי", "חשוון", "כסלו", "טבת", "שבט", "אדר", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" };
                string[] arrMonths13 = { "תשרי", "חשוון", "כסלו", "טבת", "שבט", "אדר א", "אדר ב", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" };
                if (monthsInYear == 13)
                    textMonth = arrMonths13[month - 1];
                else
                    textMonth = arrMonths12[month - 1];
                textDate = arrDays[day - 1] +
                           " " + textMonth;
                month_x_y.AppendText(Environment.NewLine + textDate);
                month_x_y.SelectionAlignment = HorizontalAlignment.Right;
                if (day == 1 || showYear)
                {
                    month_x_y.AppendText(Environment.NewLine + GetStringHebYear(year));
                    month_x_y.SelectionAlignment = HorizontalAlignment.Right;
                    //Check for hebYear is in db. if not, let the user know that info might be incorrect.
                    CheckHebYearInDB(year);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("AddHebDate failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void CheckHebYearInDB(int year)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT parashYear " +
                                        "FROM tblParashot " +
                                        "WHERE parashYear = " + year + " " +
                                        "ORDER BY parashYear";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                bool isYearInDB = dataReader.Read();
                dataReader.Close();
                if (isYearInDB)
                    //got here means there's a matching year in DB. return.
                    return;
                //got here means - no match.
                string yearStr = GetStringHebYear(year);
                string msg = "שים לב! השנה העברית המוצגת כעת אינה נכנסה למאגר הנתונים.\n" +
                             "לפיכך המערכת לא יכולה לזהות האם קיימות בשנה זו " +
                             " " + year + " " + yearStr + " " +
                             "פרשות מחוברות.\n" +
                             " הנתונים המוצגים עלולים להיות שגויים עד שהמשתמש יכניס ידנית את ערכי השנה הנוכחית" +
                             " " + year + " " + yearStr + " " +
                             " למאגר הנתונים בטבלת פרשות מחוברות." + "\n" +
                             "ניתן להשתמש באפשרות \"הוספה\" שבתפריט הראשי בכדי להוסיף את השנה הנוכחית למאגר." +
                             "\n\n" +
                             "הודעה זו תמשיך להופיע בכל חודש בשנה הנוכחית עד שהמשתמש יוסיף אותה למאגר הנתונים.";
                MessageBox.Show(msg, "שים לב!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            catch (Exception err)
            {
                MessageBox.Show("CheckHebYearInDB failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToday(RichTextBox todayBox)
        {
            todayBox.AppendText(Environment.NewLine + "!!!היום");
            todayBox.Font = new Font(todayBox.Font, FontStyle.Bold);
            todayBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void FillBlanked(DateTime currentMonth)
        {
            try
            {
                RichTextBox month_x_y;
                DateTime prevMonth = currentMonth;
                //fill before currentMonth
                for (int j = 6; j >= 0; j--)
                {
                    month_x_y = GetMonth_x_y(0, j);
                    if (month_x_y.Enabled == false)
                    {
                        prevMonth = prevMonth.AddDays(-1);
                        month_x_y.Text = prevMonth.Day.ToString();
                        AddHebDate(month_x_y, prevMonth, false);
                    }
                }
                //set nextMonth as last day of month
                DateTime nextMonth = DateTime.Parse(DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month) + "/" + currentMonth.Month + "/" + currentMonth.Year);
                //fill after currentMonth
                for (int j = 0; j < 7; j++)
                {
                    month_x_y = GetMonth_x_y(4, j);
                    if (month_x_y.Enabled == false)
                    {
                        nextMonth = nextMonth.AddDays(1);
                        month_x_y.Text = nextMonth.Day.ToString();
                        AddHebDate(month_x_y, nextMonth, false);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("FillBlanks failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnableNePre()
        {
            prevMonthButton.Enabled = true;
            nextMonthButton.Enabled = true;
        }

        private void AddParashot()
        {
            try
            {
                RichTextBox shabbat_x;
                int hebYear;
                DateTime shabbat_x_Date;
                Parashot yearParashot;
                string shabbatText;
                for (int i = 0; i < 5; i++)
                {
                    shabbat_x = GetMonth_x_y(i, 6);
                    shabbat_x_Date = GetDate(shabbat_x);
                    hebYear = hebCal.GetYear(shabbat_x_Date);
                    yearParashot = new Parashot(hebYear, dataConnection, shabbat_x_Date);
                    shabbatText = yearParashot.GetCurrentShabbatText(shabbat_x_Date);
                    //append text in orange color
                    shabbat_x.SelectionColor = Color.Orange;
                    shabbat_x.AppendText(Environment.NewLine + shabbatText);
                    shabbat_x.SelectionAlignment = HorizontalAlignment.Center;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("AddParashot failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEventSignsToTable()
        {
            RichTextBox month_x_y;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 7; j++)
                {
                    month_x_y = GetMonth_x_y(i, j);
                    if (month_x_y.Enabled == true)
                        CheckHasEvents(month_x_y);
                }
            for (int j = 0; j < 2; j++)
            {
                month_x_y = GetMonth_x_y(5, j);
                if (month_x_y.Visible == false)
                    return;
                CheckHasEvents(month_x_y);
            }
        }

        private void CheckHasEvents(RichTextBox month_x_y)
        {
            DateTime date = GetDate(month_x_y);
            string events, annuals;
            events = GetEvents(month_x_y);
            annuals = GetAnnuals(month_x_y);
            if (!(events == "" && annuals == ""))
                SetHasEvent(month_x_y);
        }

        private void SetHasEvent(RichTextBox month_x_y)
        {
            try
            {
                month_x_y.AppendText(Environment.NewLine + "@");
                month_x_y.SelectionAlignment = HorizontalAlignment.Center;
            }
            catch (Exception err)
            {
                MessageBox.Show("SetHasEvent failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddHolidays()
        {
            RichTextBox month_x_y;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 6; j++)
                {
                    month_x_y = GetMonth_x_y(i, j);
                    AddHolidayToDay(month_x_y);
                }
        }

        private void AddHolidayToDay(RichTextBox month_x_y)
        {
            DateTime date = GetDate(month_x_y);
            int month = hebCal.GetMonth(date);
            int day = hebCal.GetDayOfMonth(date);
            if (hebCal.IsLeapYear(hebCal.GetYear(date)) && month >= 6)
                month--;
            string holidayText = null;
            //rosh hasana
            if (month == 1 && (day == 1 || day == 2))
                holidayText = "ראש השנה";
            //kipur
            else if (month == 1 && day == 10)
                holidayText = "יום כיפור";
            //succot
            else if (month == 1 && (day <= 21 && day >= 15))
                holidayText = "סוכות";
            else if (month == 1 && day == 22)
                holidayText = "שמחת תורה";
            else if ((month == 3 && day >= 25) || (month == 4 && day <= 3))
                holidayText = "חנוכה";
            else if (month == 6 && day == 14)
                holidayText = "פורים";
            else if (month == 7 && day >= 15 && day <= 21)
                holidayText = "פסח";
            else if (month == 9 && day == 6)
                holidayText = "שבועות";
            //no holiday-> return
            if (String.IsNullOrEmpty(holidayText))
                return;
            //append text in blue color
            month_x_y.SelectionColor = Color.Blue;
            month_x_y.AppendText(Environment.NewLine + holidayText);
            month_x_y.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void EnableDisableShowTodayButton()
        {
            if (GetCurrentMonth() == DateTime.Today.Month && yearTextBox.Text == DateTime.Today.Year.ToString())
                showTodayButton.Enabled = false;
            else
                showTodayButton.Enabled = true;
        }

        //SHOWING EVENTS INFO
        private void month_x_y_MouseHover(object sender, EventArgs e)
        {
            //check if table is clear(show buttons wasn't clicked)
            if (month_2_3.Text == "")
                return;
            RichTextBox month_x_y = (RichTextBox)sender;
            string events, annuals, msg = "";
            events = GetEvents(month_x_y);
            annuals = GetAnnuals(month_x_y);
            if (events == "" && annuals == "")
                msg = "אין אירועים ביום זה";
            if (events != "")
                msg += "אירועים:\n\n" + events;
            if (annuals != "")
            {
                if (events != "")
                    msg += "\n";
                msg += "אירועים שנתיים:\n\n" + annuals;
            }
            eventsToolTip.SetToolTip(month_x_y, msg);
        }

        private string GetAnnuals(RichTextBox month_x_y)
        {
            try
            {
                if (!displayAnnualsCheckBox.Checked)
                    return "";
                string annuals = "";
                DateTime date = GetDate(month_x_y);
                int year = date.Year, month = date.Month, day = date.Day;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                        "FROM tblAnnuals " +
                                        "WHERE annualYear= " + year + " AND annualMonth= " + month + " AND annualDay = " + day + " AND annualGregorian = true " +
                                        "ORDER BY annualID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string annualID = dataReader.GetInt32(0).ToString();
                    string annualType = dataReader.GetString(1);
                    string annualName = dataReader.GetString(2);
                    string annualPicture = dataReader.GetString(7);
                    annuals += GetEventString(annualID, annualType, annualName, annualPicture);
                    annuals += Environment.NewLine + Environment.NewLine;
                }
                dataReader.Close();
                annuals += GetHebDateAnnuals(date);
                return annuals;
            }
            catch (Exception err)
            {
                MessageBox.Show("GetAnnuals (mouse hover) failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Failed";
            }
        }

        private string GetHebDateAnnuals(DateTime date)
        {
            string hebDateAnnuals = "";
            try
            {
                HebrewCalendar hebDate = new HebrewCalendar();
                int year = hebDate.GetYear(date), month = hebDate.GetMonth(date), day = hebDate.GetDayOfMonth(date);
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                        "FROM tblAnnuals " +
                                        "ORDER BY annualID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string annualID = dataReader.GetInt32(0).ToString();
                    string annualType = dataReader.GetString(1);
                    string annualName = dataReader.GetString(2);
                    int annualMonth = dataReader.GetInt32(4);
                    int annualDay = dataReader.GetInt32(5);
                    bool annualGreg = dataReader.GetBoolean(6);
                    string annualPicture = dataReader.GetString(7);
                    if (annualGreg)
                        continue;
                    if (annualMonth == month && annualDay == day)
                    {
                        hebDateAnnuals += GetEventString(annualID, annualType, annualName, annualPicture);
                        hebDateAnnuals += Environment.NewLine + Environment.NewLine;
                    }
                }
                dataReader.Close();
                return hebDateAnnuals;
            }
            catch (Exception err)
            {
                MessageBox.Show("GetHebDateAnnuals (mouse hover) failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Failed";
            }

        }

        private string GetEventString(string id, string type, string name, string picture)
        {
            string event1 = "";
            event1 += "ת.ז. האירוע השנתי: " + id + Environment.NewLine;
            event1 += "סוג האירוע השנתי: " + type + Environment.NewLine;
            event1 += "שם האירוע השנתי: " + name + Environment.NewLine;
            event1 += "Picture location: " + picture + Environment.NewLine;
            return event1;
        }

        private string GetEvents(RichTextBox month_x_y)
        {
            try
            {
                string events = "";
                DateTime date = GetDate(month_x_y);
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                         "FROM tblEvents " +
                                         "ORDER BY eventID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    //if not month_x_y's date, continue
                    if (dataReader.GetDateTime(4).CompareTo(date) != 0)
                        continue;
                    //skip if not user's event and allUsersCheckBox isn't checked
                    if (!allUsersCheckBox.Checked && dataReader.GetInt32(3) != userID)
                        continue;
                    string eventID = dataReader.GetInt32(0).ToString();
                    string eventType = dataReader.GetString(1);
                    string eventName = dataReader.GetString(2);
                    string eventMemberID = dataReader.GetInt32(3).ToString();
                    string eventTime = dataReader.GetDateTime(5).ToShortTimeString();
                    string eventMinutes = dataReader.GetInt32(6).ToString();
                    string eventPicture = dataReader.GetString(7);
                    events += GetEventString(eventID, eventType, eventName, eventMemberID, eventTime, eventMinutes, eventPicture);
                    events += Environment.NewLine + Environment.NewLine;
                }
                dataReader.Close();
                return events;
            }
            catch (Exception err)
            {
                MessageBox.Show("GetEvents (mouse hover) failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Failed";
            }
        }

        private string GetEventString(string id, string type, string name, string memberID, string time, string minutes, string picture)
        {
            string event1 = "";
            event1 += "ת.ז. האירוע: " + id + Environment.NewLine;
            event1 += "סוג האירוע: " + type + Environment.NewLine;
            event1 += "שם האירוע: " + name + Environment.NewLine;
            event1 += "ת.ז. בעל האירוע: " + memberID + Environment.NewLine;
            event1 += "שעת האירוע: " + time + Environment.NewLine;
            event1 += "אורך (בדקות): " + minutes + Environment.NewLine;
            event1 += "Picture location: " + picture + Environment.NewLine;
            return event1;
        }

        //to be used only after adding greg date.
        //function used for both GetAnnuals and GetEvents
        private DateTime GetDate(RichTextBox month_x_y)
        {
            try
            {
                DateTime date;
                int day, month, year;
                day = int.Parse(new string(month_x_y.Text.ToCharArray(0, 2)));
                month = int.Parse(monthsComboBox.Text);
                year = int.Parse(yearTextBox.Text);
                if (month_x_y.Enabled)
                    date = new DateTime(year, month, day);
                else
                {
                    //prev month
                    if (day > 20)
                        if (month == 1)
                        {
                            month = 12;
                            year--;
                        }
                        else
                            month--;
                    //next month
                    else
                        if (month == 12)
                        {
                            month = 1;
                            year++;
                        }
                        else
                            month++;
                    date = new DateTime(year, month, day);
                }
                return date;
            }
            catch (Exception err)
            {
                MessageBox.Show("GetDate (from RichTextBox.Text) failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DateTime(1800, 1, 1);
            }

        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            //calendar isn't shown
            if (GetCurrentMonth() == -1)
                return;
            ShowCalendar(DateTime.Parse("1/" + GetCurrentMonth() + "/" + yearLabel.Text));
        }

        private void SetEventsAnnualsOnDate(DateTime date,ref int[] ids, ref bool[] isAnnuals)
        {
            try
            {
                SetEventsOnDate(date, ref ids, ref isAnnuals);
                SetAnnualsOnDate(date, ref ids, ref isAnnuals);
            }
            catch (Exception err)
            {
                MessageBox.Show("SetEventsAnnualsOnDate failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SetAnnualsOnDate(DateTime date, ref int[] ids, ref bool[] isAnnuals)
        {
            try
            {
                if (!displayAnnualsCheckBox.Checked)
                    return;
                int year = date.Year, month = date.Month, day = date.Day;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT annualID " +
                                        "FROM tblAnnuals " +
                                        "WHERE annualYear= " + year + " AND annualMonth= " + month + " AND annualDay = " + day + " AND annualGregorian = true " +
                                        "ORDER BY annualID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    if (index == ids.Length)
                        ResizeArrays(ref ids, ref isAnnuals, ids.Length + 1);
                    isAnnuals[index] = true;
                    ids[index++] = dataReader.GetInt32(0);
                }
                dataReader.Close();
                SetHebAnnualsOnDate(date, ref ids, ref isAnnuals);
            }
            catch (Exception err)
            {
                MessageBox.Show("SetAnnualsOnDate failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SetHebAnnualsOnDate(DateTime date, ref int[] ids, ref bool[] isAnnuals)
        {
            try
            {
                HebrewCalendar hebDate = new HebrewCalendar();
                int month = hebDate.GetMonth(date), day = hebDate.GetDayOfMonth(date);
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT annualID " +
                                        "FROM tblAnnuals " +
                                        "WHERE annualGregorian = false AND annualMonth= " + month + " AND annualDay = " + day + " " +
                                        "ORDER BY annualID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    int annualID = dataReader.GetInt32(0);
                    if (index == ids.Length)
                        ResizeArrays(ref ids, ref isAnnuals, ids.Length + 1);
                    ids[index] = annualID;
                    isAnnuals[index++] = true;
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("SetHebAnnualsOnDate failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SetEventsOnDate(DateTime date, ref int[] ids, ref bool[] isAnnuals)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT eventID, eventDate, eventMemberID " +
                                         "FROM tblEvents " +
                                         "ORDER BY eventID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    //if not month_x_y's date, continue
                    if (dataReader.GetDateTime(1).CompareTo(date) != 0)
                        continue;
                    //skip if not user's event and allUsersCheckBox isn't checked
                    if (!allUsersCheckBox.Checked && dataReader.GetInt32(2) != userID)
                        continue;
                    if (index == ids.Length)
                        ResizeArrays(ref ids, ref isAnnuals, ids.Length + 1);
                    isAnnuals[index] = false;
                    ids[index++] = dataReader.GetInt32(0);
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("SetEventsOnDate failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ResizeArrays(ref int[] ids,ref bool[] isAnnuals, int newLength)
        {
            Array.Resize<int>(ref ids, newLength);
            Array.Resize<bool>(ref isAnnuals, newLength);  
        }

        void fr_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
            //refresh calendar
            ShowCalendar(DateTime.Parse("1/" + GetCurrentMonth() + "/" + yearLabel.Text));
        }

        private void ExitButtonClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("האם אתה בטוח?", "אישור יציאה", MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                                                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            if (dialogResult == DialogResult.No)
                return;
            Application.Exit();
        }

        private void Month_x_y_MouseClick(object sender, MouseEventArgs mouseEvent)
        {
            try
            {
                //check if table is clear(show buttons wasn't clicked)
                if (month_2_3.Text == "")
                    return;
                RichTextBox month_x_y = (RichTextBox)sender;
                //if not mouse *click* return
                if (mouseEvent.Button != MouseButtons.Right && mouseEvent.Button != MouseButtons.Left)
                {
                    if (mouseEvent.Button == MouseButtons.Middle)
                        Month_x_y_MouseMiddleButtonClick(month_x_y);
                    return;
                }
                //non-admin can't edit
                if (mouseEvent.Button == MouseButtons.Right && !isAdmin)
                    return;
                //checks if has events
                if (!month_x_y.Text.Contains('@'))
                    return;
                int[] ids = new int[1];
                bool[] isAnnuals = new bool[1];
                DateTime date = GetDate(month_x_y);
                index = 0;
                SetEventsAnnualsOnDate(date, ref ids, ref isAnnuals);
                FormChooseEvent fr = new FormChooseEvent(ids, isAnnuals, dataConnection, mouseEvent.Button);
                this.Hide();
                fr.Show();
                fr.Disposed += fr_Disposed;
            }
            catch (Exception err)
            {
                MessageBox.Show("Show & Edit Pictures on click failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Month_x_y_MouseMiddleButtonClick(RichTextBox month_x_y)
        {
            //for admins only!
            if (!isAdmin)
                return;
            DateTime date = GetDate(month_x_y);
            string msg = "להוספת אירוע שנתי, לחץ \"כן\"" + "\n" +
                       "להוספת אירוע רגיל, לחץ \"לא\""+"\n"+
                       "לביטול, לחץ \"ביטול\"";
            DialogResult dialogResult = MessageBox.Show(msg, "הוספת אירוע", MessageBoxButtons.YesNoCancel,
                                                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                                                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            if (dialogResult == DialogResult.No)
            {
                FormAddEvent fr = new FormAddEvent(dataConnection, date);
                this.Hide();
                fr.Show();
                fr.Disposed += fr_Disposed;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                FormAddAnnual fr = new FormAddAnnual(dataConnection, date);
                this.Hide();
                fr.Show();
                fr.Disposed += fr_Disposed;
            }
            else
                return;
        }

        private void showInstrButton_Click(object sender, EventArgs e)
        {
            string msg = "בלחיצה על הלחצן השמאלי בעכבר על יום עם אירוע, תוכל להציג את האירוע בצורה מפורטת, בטופס נפרד" + "\n" +
                         "למנהלים בלבד: בלחיצה על הלחצן הימני בעכבר, תוכל לערוך/למחוק את האירוע." + "\n" +
                         "למנהלים בלבד: בלחיצה על הלחצן האמצעי בעכבר (לחיצה על הגלגלת), על כל יום בחודש (יום המציג תאריך ואינו ריק), גם אם אין בו אירוע, תוכל להוסיף אירוע לאותו יום , בטופס נפרד.";
            MessageBox.Show(msg, "חידושי הגרסה האחרונה", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                                                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void showTodayButton_MouseHover(object sender, EventArgs e)
        {
            string msg;
            msg = "בלחיצה על \"הצג תאריך נוכחי\" תועבר לחודש הנוכחי, חודש " + gregMonths[DateTime.Today.Month - 1]+" בשנת "+DateTime.Today.Year;
            eventsToolTip.SetToolTip(showTodayButton, msg);
        }

        private void prevMonthButton_MouseHover(object sender, EventArgs e)
        {
            string msg;
            int year=int.Parse(yearTextBox.Text);
            msg = "בלחיצה על \"החודש הקודם\" תועבר לחודש הקודם, חודש ";
            if (GetCurrentMonth() == 1)
            {
                msg += gregMonths[11];
                year--;
            }
            else
                msg += gregMonths[GetCurrentMonth() - 2];//-2 for prevMonth(-1-1)
            msg += " בשנת " + year;
            eventsToolTip.SetToolTip(prevMonthButton, msg);
        }

        private void NextMonthButton_MouseHover(object sender, EventArgs e)
        {
            string msg;
            int year=int.Parse(yearTextBox.Text);
            msg = "בלחיצה על \"החודש הבא\" תועבר לחודש הבא, חודש ";
            if (GetCurrentMonth() == 12)
            {
                msg += gregMonths[0];
                year++;
            }
            else
                msg += gregMonths[GetCurrentMonth()];// for nextMonth(-1+1)
            msg += " בשנת " + year;
            eventsToolTip.SetToolTip(nextMonthButton, msg);
        }

        private void showButton_MouseHover(object sender, EventArgs e)
        {
            if (yearTextBox.Text == ""  || monthsComboBox.SelectedIndex == -1)
            {
                eventsToolTip.SetToolTip(showButton, "לא נבחר חודש או שהנתונים לא מתאימים לבחירת חודש. נסה שנית");
                return;
            }
            string msg = "בלחיצה על \"הצג חודש נבחר\", תועבר לחודש הנבחר, חודש " + gregMonths[monthsComboBox.SelectedIndex] + " בשנת " + yearTextBox.Text;
            eventsToolTip.SetToolTip(showButton, msg);
        }

        private void monthsComboBox_TextChanged(object sender, EventArgs e)
        {
            if (!monthsComboBox.Items.Contains(monthsComboBox.Text) && monthsComboBox.Text!="")
            {
                MessageBox.Show("הטקסט שהקשת בתיבת ה\"חודש\" אינו מתאים לאחד מן החודשים (1-12).\n אנא הקש מספר מתאים", "שגיאה",
                MessageBoxButtons.OK, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                monthsComboBox.ResetText();
            }
        }

        private RichTextBox GetMonth_x_y(int day)
        {
            DateTime date = new DateTime(int.Parse(yearLabel.Text), GetCurrentMonth(), day);
            for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 7; j++)
                        if(GetDate(GetMonth_x_y(i,j)).CompareTo(date)==0)
                            return GetMonth_x_y(i,j);
            for (int j = 0; j < 2; j++)
                    if(GetDate(GetMonth_x_y(5,j)).CompareTo(date)==0)
                            return GetMonth_x_y(5,j);
            return null;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchEvent();
            eventNameTextBox.Text="";
        }

        private void SearchEvent()
        {
            try
            {
                string eventName = eventNameTextBox.Text;
                DateTime eventDate = new DateTime(1, 1, 1);
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT eventDate FROM tblEvents WHERE eventName = \"" + eventName + "\" ORDER BY eventName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                if (dataReader.Read())
                    eventDate = dataReader.GetDateTime(0);
                dataReader.Close();
                if (eventDate.CompareTo(new DateTime(1, 1, 1)) == 0)
                {
                    MessageBox.Show("No event found.\n", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ShowCalendar(new DateTime(eventDate.Year,eventDate.Month,1));
                RichTextBox theDay = GetMonth_x_y(eventDate.Day);
                theDay.AppendText(Environment.NewLine + "יום האירוע המבוקש");
                theDay.Font = new Font(theDay.Font, FontStyle.Bold);
                theDay.SelectionAlignment = HorizontalAlignment.Center;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AllUsersCheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged(sender, e);
            if (allUsersCheckBox.Checked)
            {
                searchButton.Enabled = true;
                eventNameTextBox.ResetText();
            }
            else
            {
                searchButton.Enabled = false;
                eventNameTextBox.Text = "כדי לחפש אירוע, \nיש לבחור ב\"הצג את אירועי כל המשתמשים\"";
            }
        }



        //TODO:
        //      Search option
        //      week presentation
        //      print option
    }
}
