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

    public partial class FormRptAnnualsByType : Form
    {
        private OleDbConnection dataConnection;
        private string annualType;
        private string annualID;
        private string annualName;
        private string annualYear;
        private string annualMonth;
        private string annualDay;
        private string annualGreg;
        private string annualPicture;
        private string saveColor = "";
        private int lastRow = 0;
        public FormRptAnnualsByType(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            RefreshDataGridView();
        }

        private void FormRptAnnualsByType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEventTypes.tblEventTypes' table. You can move, or remove it, as needed.
            this.tblEventTypesTableAdapter.Fill(this.dataSetEventTypes.tblEventTypes);
        }

        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblEventTypes " +
                                     "ORDER BY typeName";
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
                annualType = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                dataGridView2.CurrentCell = dataGridView2[0, lastRow];
                EnableButtons();
                GetAnnuals();
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

        private void GetAnnuals()
        {
            try
            {
                int counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   annualID, annualName, annualYear, annualMonth, annualDay, annualGregorian, annualPicture " +
                                         "FROM      tblAnnuals   " +
                                         "WHERE     annualType = \"" + annualType + "\" " +
                                         "ORDER BY  annualID ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    annualID = dataReader.GetInt32(0).ToString();
                    annualName = dataReader.GetString(1);
                    annualYear = dataReader.GetInt32(2).ToString();
                    annualMonth = dataReader.GetInt32(3).ToString();
                    annualDay = dataReader.GetInt32(4).ToString();
                    annualGreg = dataReader.GetBoolean(5).ToString();
                    annualPicture = dataReader.GetString(6);
                    counter++;
                    EditListView(counter);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblEvents failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView(int counter)
        {
            try
            {
                string[] arr = new string[8];
                if (counter == 1)
                {
                    arr[0] = annualType;
                }
                arr[1] = annualID;
                arr[2] = annualName;
                arr[3] = annualYear;
                arr[4] = annualMonth;
                arr[5] = annualDay;
                if (annualGreg == "True")
                    arr[6] = "כן";
                else
                    arr[6] = "לא";
                arr[7] = annualPicture;
                ListViewItem item = new ListViewItem(arr);
                if (saveColor != "")
                    item.ForeColor = Color.FromArgb(int.Parse(saveColor));
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void ChooseColorButtonClick(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            chooseColorButton.BackColor = cd.Color;
            saveColor = chooseColorButton.BackColor.ToArgb().ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
                return;
            int selectedIndex = listView1.SelectedIndices[0];
            if (selectedIndex < 0)
                return;
            string type="";
            int j = 0;
            while (type == "")
            {
                type = listView1.Items[selectedIndex - j].SubItems[0].Text;
                j++;
            }
            int i = 1;
            string id = listView1.Items[selectedIndex].SubItems[i++].Text;
            string name = listView1.Items[selectedIndex].SubItems[i++].Text;
            string year = listView1.Items[selectedIndex].SubItems[i++].Text;
            string month = listView1.Items[selectedIndex].SubItems[i++].Text;
            string day = listView1.Items[selectedIndex].SubItems[i++].Text;
            bool isGreg = listView1.Items[selectedIndex].SubItems[i++].Text=="כן";
            string pic = listView1.Items[selectedIndex].SubItems[i].Text;
            FormRptShowPictureAnnual frm = new FormRptShowPictureAnnual(isGreg, id, type, name, year, month, day, pic);
            this.Hide();
            frm.Show();
            frm.Disposed += frm_Disposed;
        }

        void frm_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

    }
}