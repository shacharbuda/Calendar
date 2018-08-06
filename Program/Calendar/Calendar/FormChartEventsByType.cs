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
    public partial class FormChartEventsByType : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] types;
        private int[] events;
        private int[] pastEvents;
        private int[] futEvents;
        public FormChartEventsByType(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            todayLabel.Text += DateTime.Today.ToShortDateString();
            CountTypes();
            types=new string[counter];
            events = new int[counter];
            pastEvents = new int[counter];
            futEvents = new int[counter];
            FillTypes();
            FillEvents();
            ShowChart();
            EditDataGridView();
        }

        private void CountTypes()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblEventTypes  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Count tblEventTypes failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillTypes()
        {
            try
            {
                int k = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   typeName " +
                                          "FROM     tblEventTypes  " +
                                          "ORDER BY typeName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                    types[k++] = dataReader.GetString(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblEventTypes failed (Fill Types)" +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillEvents()
        {
            try
            {
                DateTime eventDate,today=DateTime.Today;
                for (int i = 0; i < types.Length;i++ )
                {
                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    datacommand.CommandText = "SELECT  eventDate " +
                                              "FROM    tblEvents  " +
                                              "WHERE   eventType = \"" + types[i] + "\"";
                    OleDbDataReader dataReader = datacommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        eventDate = dataReader.GetDateTime(0);
                        if (DateTime.Compare(eventDate, today) < 0)
                            pastEvents[i]++;
                        else
                            futEvents[i]++;
                        events[i]++;
                    }
                    dataReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblEventTypes failed (Fill Events)\n" +
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
                for (int i = 0; i < types.Length; i++)
                {
                    chart1.Series["סך אירועים"].Points.AddXY(types[i], events[i]);
                    chart1.Series["אירועים שחלפו"].Points.AddXY(types[i], pastEvents[i]);
                    chart1.Series["אירועים עתידיים"].Points.AddXY(types[i], futEvents[i]);
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
                for (int i = 0; i < types.Length; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                    row.Cells[0].Value = types[i];
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
