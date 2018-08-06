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
    public partial class FormUpdateEvent : Form
    {
        private OleDbConnection dataConnection;
        private int lastRow = 0;
        public FormUpdateEvent(OleDbConnection dataConnection,bool isAdmin)
        {
            this.dataConnection = dataConnection;
            InitializeForm();
            if (!isAdmin)
            {
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        public FormUpdateEvent(OleDbConnection dataConnection,int id)
        {
            this.dataConnection = dataConnection;
            InitializeForm();
            foreach (DataGridViewRow row in dataGridView2.Rows)
                if (row.Cells[0].Value.ToString().Equals(id.ToString()))
                {
                    lastRow = row.Index;
                    break;
                }
            dataGridView2.Rows[lastRow].Selected = true;
            FillSelectedRow();
            firstButton.Enabled = false;
            lastButton.Enabled = false;
            prevButton.Enabled = false;
            nextButton.Enabled = false;
            dataGridView2.Enabled = false;
        }

        private void InitializeForm()
        {
            InitializeComponent();
            FillTypeCombo();
            FillMemIDCombo();
            RefreshDataGridView();
        }

        private void FormUpdateEvent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEvents.tblEvents' table. You can move, or remove it, as needed.
            this.tblEventsTableAdapter.Fill(this.dataSetEvents.tblEvents);
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
                    evType.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill eventTypes combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillMemIDCombo()                                   // Populate MemberID combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT userID " +
                                          "FROM tblUsers " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    evMemberID.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill eventMemberID combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateButtonClick(object sender, EventArgs e)          //Update events table
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE  tblEvents  \n" +
                                          "SET     eventType      =  \"" + evType.Text            + "\" , \n" +
                                                  "eventName      =  \"" + evName.Text            + "\" , \n" +
                                                  "eventMemberID  =  \"" + evMemberID.Text        + "\" , \n" +
                                                  "eventDate      =  \"" + evDate.Text            + "\" , \n" +
                                                  "eventTime      =  \"" + evTime.Text            + "\" , \n" +
                                                  "eventMinutes   =  \"" + evMinutes.Text         + "\" , \n" +
                                                  "eventPicture   =  \"" + evPictureLocation.Text + "\"   \n" +
                                          "WHERE  eventID = "   +  evID.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                MessageBox.Show("Update tblEvents ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblEvents failed \n" + err.Message, "Error",
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
                datacommand.CommandText = "DELETE FROM tblEvents " +
                                          "WHERE  eventID = " + evID.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                MessageBox.Show("Update tblEvents ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblEvents failed \n" + err.Message, "Error",
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
                                     "FROM     tblEvents " +
                                     "ORDER BY eventID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView2.DataSource = tbl;
                dataGridView2.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblEvents table failed \n" + err.Message, "Error",
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
                evID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                evType.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                evName.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                evMemberID.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                evDate.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                evTime.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                evMinutes.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                evPictureLocation.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
                pictureBox1.ImageLocation = evPictureLocation.Text;
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

        private void BrowseButtonClick(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            evPictureLocation.Text = pictureFileName;
        }


    }
}