using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Calendar
{
    public partial class FormUpdateYear : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateYear(OleDbConnection dataConnection,bool isAdmin)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            RefreshDataGridView();
            if (!isAdmin)
            {
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void FormUpdateYear_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetParashot.tblParashot' table. You can move, or remove it, as needed.
            this.tblParashotTableAdapter.Fill(this.dataSetParashot.tblParashot);
        }

        private void UpdateButtonClick(object sender, EventArgs e)          //Update events table
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE  tblParashot  \n" +
                                          "SET     parashConnect1        =  " + parashConnect1.Checked + " , \n" +
                                                  "parashConnect2        =  " + parashConnect2.Checked + " , \n" +
                                                  "parashConnect3        =  " + parashConnect3.Checked + " , \n" +
                                                  "parashConnect4        =  " + parashConnect4.Checked + " , \n" +
                                                  "parashConnect5        =  " + parashConnect5.Checked + " , \n" +
                                                  "parashConnect6        =  " + parashConnect6.Checked + "   \n" +
                                          "WHERE  parashYear = " + parashYearNum.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                MessageBox.Show("Update tblParashot ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblParashot failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("האם אתה בטוח?", "אישור מחיקה", MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                                                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                if (dialogResult == DialogResult.No)
                    return;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "DELETE FROM tblParashot " +
                                          "WHERE  parashYear = " + parashYearNum.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                MessageBox.Show("Update tblParashot ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblParashot failed \n" + err.Message, "Error",
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
                                     "FROM     tblParashot " +
                                     "ORDER BY parashYear";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView2.DataSource = tbl;
                dataGridView2.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblParashot table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView2.CurrentRow.Index;
            prevButton.Enabled = true;
            nextButton.Enabled = true;
            FillSelectedRow();
        }

        private void EnableButtons()
        {
            prevButton.Enabled = true;
            nextButton.Enabled = true;
            if (lastRow == 0)
                prevButton.Enabled = false;
            if (lastRow == dataGridView2.Rows.Count - 1)
                nextButton.Enabled = false;
        }

        private void FillSelectedRow()
        {
            try
            {
                parashYearNum.Text     = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                parashConnect1.Checked = dataGridView2.SelectedRows[0].Cells[1].Value.ToString()=="True";
                parashConnect2.Checked = dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "True";
                parashConnect3.Checked = dataGridView2.SelectedRows[0].Cells[3].Value.ToString() == "True";
                parashConnect4.Checked = dataGridView2.SelectedRows[0].Cells[4].Value.ToString() == "True";
                parashConnect5.Checked = dataGridView2.SelectedRows[0].Cells[5].Value.ToString() == "True";
                parashConnect6.Checked = dataGridView2.SelectedRows[0].Cells[6].Value.ToString() == "True";
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrevButtonClick(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void NextButtonClick(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void FirstButtonClick(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void LastButtonClick(object sender, EventArgs e)
        {
            dataGridView2.Rows[lastRow].Selected = false;
            lastRow = dataGridView2.Rows.Count - 1;
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();

        }

    }
}