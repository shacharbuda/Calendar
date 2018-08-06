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
    public partial class FormChartUsersByCity : Form
    {
        OleDbConnection dataConnection;
        private int[] users;
        private string[] cities;
        int counter;
        public FormChartUsersByCity(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountCities();
            users = new int[counter];
            cities = new string[counter];
            FillCities();
            FillUsers();
            ShowChart();
            EditDataGridView();
        }

        private void CountCities()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblCities  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblCities failed\n" +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillCities()
        {
            try
            {
                int k = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   cityName " +
                                          "FROM     tblCities  " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                    cities[k++] = dataReader.GetString(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill cities failed\n" +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FillUsers()
        {
            try
            {
                for (int i = 0; i < cities.Length; i++)
                {
                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    datacommand.CommandText = "SELECT  userID " +
                                              "FROM    tblUsers  " +
                                              "WHERE   userCity = \"" + cities[i] + "\"";
                    OleDbDataReader dataReader = datacommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        users[i]++;
                    }
                    dataReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill users failed\n" +
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
                for (int i = 0; i < cities.Length; i++)
                {
                    chart1.Series["סך משתמשים"].Points.AddXY(cities[i], users[i]);
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
                for (int i = 0; i < cities.Length; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                    row.Cells[0].Value = cities[i];
                    row.Cells[1].Value = users[i].ToString();
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
