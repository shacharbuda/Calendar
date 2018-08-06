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
    public partial class FormChooseEvent : Form
    {
        int[] ids;
        bool[] isAnnuals;
        int lastRow=0;
        OleDbConnection dataConnection;
        public FormChooseEvent(int[] ids, bool[] isAnnuals, OleDbConnection dataConnection,MouseButtons bt)
        {
            this.dataConnection = dataConnection;
            this.ids = ids;
            this.isAnnuals = isAnnuals;
            InitializeComponent();
            FillEventsDataGridView();
            dataGridView1.Rows[lastRow].Selected = true;
            EnableButtons();
            if (bt == MouseButtons.Left)
            {
                editButton.Visible = false;
                label1.Text += "הצג";
            }
            else
            {
                showButton.Visible = false;
                label1.Text += "ערוך";
            }
            label1.Text += " אותו";
        }

        private void FillEventsDataGridView()
        {
            try
            {
                for(int i = 0;i<ids.Length;i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    dataGridView1.AllowUserToAddRows = false;
                    if (isAnnuals[i] == true)
                    {
                        OleDbCommand datacommand = new OleDbCommand();
                        datacommand.Connection = dataConnection;
                        datacommand.CommandText = "SELECT annualID, annualName, annualType " +
                                                  "FROM tblAnnuals " +
                                                  "WHERE annualID = " + ids[i] + " " +
                                                  "ORDER BY annualID";
                        OleDbDataReader dataReader = datacommand.ExecuteReader();
                        dataReader.Read();
                        row.Cells[0].Value = "שנתי";
                        row.Cells[1].Value=dataReader.GetInt32(0);
                        row.Cells[2].Value= dataReader.GetString(2);
                        row.Cells[3].Value = dataReader.GetString(1);
                        dataReader.Close();
                    }
                    else
                    {
                        OleDbCommand datacommand = new OleDbCommand();
                        datacommand.Connection = dataConnection;
                        datacommand.CommandText = "SELECT eventID, eventName, eventType " +
                                                  "FROM tblEvents " +
                                                  "WHERE eventID = " + ids[i] + " " +
                                                  "ORDER BY eventID";
                        OleDbDataReader dataReader = datacommand.ExecuteReader();
                        dataReader.Read();
                        row.Cells[0].Value = "רגיל";
                        row.Cells[1].Value = dataReader.GetInt32(0);
                        row.Cells[2].Value = dataReader.GetString(2);
                        row.Cells[3].Value = dataReader.GetString(1);
                        dataReader.Close();
                    }
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill FillEventsDataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int indexOfEventToShow = dataGridView1.SelectedRows[0].Index;
            int idToShow = ids[indexOfEventToShow];
            ShowPicture(idToShow, indexOfEventToShow);
        }

        private void ShowPicture(int idToShow,int index)
        {
            if (isAnnuals[index])
            {
                FormRptShowPictureAnnual fr = new FormRptShowPictureAnnual(idToShow, dataConnection);
                this.Hide();
                fr.Show();
                fr.Disposed += fr_Disposed;
            }
            else
            {
                FormRptShowPictureEvent fr = new FormRptShowPictureEvent(idToShow, dataConnection);
                this.Hide();
                fr.Show();
                fr.Disposed += fr_Disposed;
            }
        }

        void fr_Disposed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;
            int idToShow = ids[index];
            bool isAnnual = isAnnuals[index];
            this.Hide();
            if(isAnnual)
            {
                FormUpdateAnnual fr = new FormUpdateAnnual(dataConnection, idToShow);
                fr.Show();
                fr.Disposed+=fr_Disposed;
            }
            else
            {
                FormUpdateEvent fr = new FormUpdateEvent(dataConnection, idToShow);
                fr.Show();
                fr.Disposed+=fr_Disposed;
            }
        }

        private void PrevButtonClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            EnableButtons();
        }

        private void NextButtonClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            EnableButtons();
        }

        private void FirstButtonClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            EnableButtons();
        }

        private void LastButtonClick(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            EnableButtons();
        }

        private void EnableButtons()
        {
            prevButton.Enabled = true;
            nextButton.Enabled = true;
            if (lastRow == 0)
                prevButton.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                nextButton.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[lastRow].Selected = true;
            EnableButtons();
        }
    }
}
