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
    public partial class FormRptShowPictureAnnual : Form
    {
        public FormRptShowPictureAnnual(bool isGreg, string id, string type, string name, string year, string month, string day, string pic)
        {
            Show(isGreg,  id,  type,  name,  year,  month,  day,  pic);    
        }

        private void Show(bool isGreg, string id, string type, string name, string year, string month, string day, string pic)
        {
            InitializeComponent();
            MakeAllReadOnly();
            anGreg.Checked = isGreg;
            anID.Text = id;
            anType.Text = type;
            anName.Text = name;
            anYear.Text = year;
            anMonth.Text = month;
            anDay.Text = day;
            pictureBox1.ImageLocation = pic;
        }

        public FormRptShowPictureAnnual(int idToShow,OleDbConnection dataConnection)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT * " +
                                        "FROM tblAnnuals " +
                                        "WHERE annualID = " + idToShow + " " +
                                        "ORDER BY annualID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    int i=1;
                    string type=dataReader.GetString(i++);
                    string name=dataReader.GetString(i++);
                    string year=dataReader.GetInt32(i++).ToString();
                    string month = dataReader.GetInt32(i++).ToString();
                    string day = dataReader.GetInt32(i++).ToString();
                    bool isGreg=dataReader.GetBoolean(i++);
                    string pic = dataReader.GetString(i);
                    Show(isGreg, idToShow.ToString(), type, name, year, month, day, pic);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecting annuals failed (FormRptShowPictureAnnual constructor)" + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MakeAllReadOnly()
        {
            anGreg.Enabled=false;
            //make backColor normal
            anGreg.BackColor = System.Drawing.SystemColors.Window;
            anID.ReadOnly=true;
            anType.Enabled=false;
            anType.BackColor = System.Drawing.SystemColors.Window;
            anName.ReadOnly=true;
            anYear.ReadOnly=true;
            anMonth.ReadOnly=true;
            anDay.ReadOnly = true;     
        }   
    }       
}           
            