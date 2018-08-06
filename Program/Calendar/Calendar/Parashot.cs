using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Globalization;
using System.Windows.Forms;

namespace Calendar
{
    class Parashot
    {
        int hebYear;
        int weeksTillSimchatTorah;
        HebrewCalendar hebCal = new HebrewCalendar();
        string[] arrShabbatot;
        bool connected1, connected2, connected3, connected4, connected5, connected6;
        OleDbConnection dataConnection;

        public Parashot(int hebYear, OleDbConnection dataConnection, DateTime date)
        {
            //if didn't get to simchat torah, set arrShabbatot as last year's arr
            if (DateTime.Compare(date, GetDateTimeHebDate(hebYear, 1, 22)) < 0)
                this.hebYear = hebYear - 1;
            else
                this.hebYear = hebYear;
            this.dataConnection = dataConnection;
            SetArrShabbatot();
            SetWeeksTillSimchatTorah();
        }

        public string GetCurrentShabbatText(DateTime currentDate)
        {
            return arrShabbatot[GetWeekCountFromSimchatTorah(currentDate) - 1];
        }

        private int GetWeekCountFromSimchatTorah(DateTime currentDate)
        {
            int weekCountFromSimchat;
            weekCountFromSimchat = GetWeekOfHebYear(currentDate) - weeksTillSimchatTorah;
            //if true, currentDate is before simchat torah of its year.
            if (weekCountFromSimchat <= 0)
            {
                int lastMonth = hebCal.GetMonthsInYear(hebYear);
                int lastDay = hebCal.GetDaysInMonth(hebYear, lastMonth);
                DateTime lastDayOfPrevYear = GetDateTimeHebDate(hebYear, lastMonth, lastDay);
                return GetWeekOfHebYear(currentDate) + GetWeekCountFromSimchatTorah(lastDayOfPrevYear) - 1;
            }
            return weekCountFromSimchat;
        }

        private void SetConnectedBools()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT parashConnect1, parashConnect2, parashConnect3, parashConnect4, parashConnect5, parashConnect6 " +
                                        "FROM tblParashot " +
                                        "WHERE parashYear = " + hebYear + " " +
                                        "ORDER BY parashYear";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    connected1 = dataReader.GetBoolean(0);
                    connected2 = dataReader.GetBoolean(1);
                    connected3 = dataReader.GetBoolean(2);
                    connected4 = dataReader.GetBoolean(3);
                    connected5 = dataReader.GetBoolean(4);
                    connected6 = dataReader.GetBoolean(5);
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("SetConnectedBools failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetArrShabbatot()
        {
            try
            {
                SetConnectedBools();
                arrShabbatot = new string[]{"בראשית","נח","לך לך","וירא","חיי שרה","תולדות","ויצא","וישלח","וישב","מקץ","ויגש","ויחי",
                                     "שמות","וארא","בא","בשלח","יתרו","משפטים","תרומה","תצוה","כי תשא","ויקהל","פקודי",
                                     "ויקרא","צו","שמיני","תזריע","מצורע","אחרי מות","קדושים","אמור","בהר","בחוקותי",
                                     "במדבר","נשא","בהעלותך","שלח","קרח","חוקת","בלק","פנחס","מטות","מסעי",
                                     "דברים","ואתחנן","עקב","ראה","שופטים","כי תצא","כי תבוא","נצבים","וילך","האזינו"};
                if (connected1)
                    SetConnectedParash("ויקהל");
                if (connected2)
                    SetConnectedParash("תזריע");
                if (connected3)
                    SetConnectedParash("אחרי מות");
                if (connected4)
                    SetConnectedParash("בהר");
                if (connected5)
                    SetConnectedParash("מטות");
                if (connected6)
                    SetConnectedParash("נצבים");
                AddHolidays();
            }
            catch (Exception err)
            {
                MessageBox.Show("SetArrShabbatot failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddHolidays()
        {
            try
            {
                int index = 0;
                //first shabbat after simchat torah
                DateTime currentShabbat = GetDateTimeHebDate(hebYear, 1, 22);
                while (currentShabbat.DayOfWeek != DayOfWeek.Saturday)
                    currentShabbat = currentShabbat.AddDays(1);
                bool leap = hebCal.IsLeapYear(hebYear);
                int month, day;
                //loop till passes next simchat torah
                while (DateTime.Compare(currentShabbat, GetDateTimeHebDate(hebYear + 1, 1, 22)) <= 0)
                {
                    month = hebCal.GetMonth(currentShabbat);
                    day = hebCal.GetDayOfMonth(currentShabbat);
                    //rosh hasana
                    if (month == 1 && (day == 1 || day == 2))
                        AddInIndex("ראש השנה", index);
                    //kipur
                    else if (month == 1 && day == 10)
                        AddInIndex("יום כיפור", index);
                    //succot
                    else if (month == 1 && (day <= 21 && day >= 15))
                        AddInIndex("סוכות", index);
                    else if (month == 1 && day == 22)
                        AddInIndex("שמחת תורה", index);
                    //passover and shavout for leap year
                    else if (leap)
                    {
                        if (month == 8 && day >= 15 && day <= 21)
                            AddInIndex("פסח", index);
                        if (month == 10 && day == 6)
                            AddInIndex("שבועות", index);
                    }
                    //passover and shavout for nonleap year
                    else
                        if (month == 7 && day >= 15 && day <= 21)
                            AddInIndex("פסח", index);
                        else if (month == 9 && day == 6)
                            AddInIndex("שבועות", index);
                    currentShabbat = currentShabbat.AddDays(7);
                    index++;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("AddHolidays failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddInIndex(string str, int index)
        {
            try
            {
                Array.Resize<string>(ref arrShabbatot, arrShabbatot.Length + 1);
                for (int i = arrShabbatot.Length - 1; i > index; i--)
                    arrShabbatot[i] = arrShabbatot[i - 1];
                arrShabbatot[index] = str;
            }
            catch (Exception err)
            {
                MessageBox.Show("AddInIndex (AddHolidays) failed\n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetConnectedParash(string parash)
        {
            int index = FindIndex(parash);
            arrShabbatot[index] += " " + arrShabbatot[index + 1];
            arrShabbatot[index + 1] = null;
            arrShabbatot = arrShabbatot.Where(val => val != null).ToArray();

        }

        private int FindIndex(string str)
        {
            int index;
            for (index = 0; index < arrShabbatot.Length; index++)
                if (arrShabbatot[index] == str)
                    return index;
            return -1;
        }

        private void SetWeeksTillSimchatTorah()
        {

            DateTime simchatTorah = GetDateTimeHebDate(hebYear, 1, 22);
            DateTime firstDay = GetDateTimeHebDate(hebYear, 1, 1);
            int currentWeekOfYear = GetWeekOfHebYear(firstDay);
            int simchatTorahWeekOfYear = GetWeekOfHebYear(simchatTorah);
            while (currentWeekOfYear != simchatTorahWeekOfYear)
            {
                firstDay = hebCal.AddWeeks(firstDay, 1);
                weeksTillSimchatTorah++;
                currentWeekOfYear = GetWeekOfHebYear(firstDay);
            }
        }

        private DateTime GetDateTimeHebDate(int year, int month, int day)
        {
            return hebCal.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        private int GetWeekOfHebYear(DateTime date)
        {
            return hebCal.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
        }
    }
}
