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
    public partial class FormChartAnnualsByGregMonth : Form
    {
        
        private OleDbConnection dataConnection;
        private int counter=12;
        private string[] months;
        private int[] events;
        private int[] pastEvents;
        private int[] futEvents;
        public FormChartAnnualsByGregMonth(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            todayLabel.Text += DateTime.Today.ToShortDateString();
            events = new int[counter];
            pastEvents = new int[counter];
            futEvents = new int[counter];
            months = new string[counter];
            FillMonths();
            FillEvents();
            ShowChart();
            EditDataGridView();
        }

        private void FillMonths()
        {
            months = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthGenitiveNames;
        }

        private void FillEvents()
        {
            try
            {
                int month;
                DateTime eventDate, today = DateTime.Today;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  annualYear, annualMonth, annualDay, annualGregorian " +
                                          "FROM    tblAnnuals";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    //if isn't greg, skip to next event
                    if (!dataReader.GetBoolean(3))
                        continue;
                    eventDate = DateTime.Parse(dataReader.GetInt32(0).ToString() + " ," +
                                               dataReader.GetInt32(1).ToString() + " ," +
                                               dataReader.GetInt32(2).ToString());
                    month = eventDate.Month - 1;
                    if (DateTime.Compare(eventDate, today) < 0)
                        pastEvents[month]++;
                    else
                        futEvents[month]++;
                    events[month]++;
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill events failed\n" +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowChart()
        {
            try
            {
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                for (int i = 0; i < counter; i++)
                {
                    chart1.Series["סך אירועים"].Points.AddXY(months[i], events[i]);
                    chart1.Series["אירועים שחלפו"].Points.AddXY(months[i], pastEvents[i]);
                    chart1.Series["אירועים עתידיים"].Points.AddXY(months[i], futEvents[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Show chart failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditDataGridView()
        {
            try
            {
                for (int i = 0; i < counter; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                    row.Cells[0].Value = months[i];
                    row.Cells[1].Value = events[i].ToString();
                    row.Cells[2].Value = pastEvents[i].ToString();
                    row.Cells[3].Value = futEvents[i].ToString();
                    dataGridView2.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}