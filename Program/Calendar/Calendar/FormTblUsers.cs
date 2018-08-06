using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class FormTblUsers : Form
    {
        public FormTblUsers(bool isAdmin)
        {
            InitializeComponent();
            try
            {
                if (!isAdmin)
                {
                    saveButton.Enabled = false;
                    dataGridView2.Columns.Remove("userPassword");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("handling authorization failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormUsers_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetUsers changes = (DataSetUsers)dataSetUsers.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblUsers.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                        foreach (DataColumn col in row.GetColumnsInError())
                            errorMsg += row.GetColumnsInError() + "\n";
                    MessageBox.Show("Errors in data: " + errorMsg, "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int numRows = tblUsersTableAdapter.Update(changes);
                MessageBox.Show("Updated" + numRows + " rows", "Success");
                dataSetUsers.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetUsers.RejectChanges();
            }                
        }
    }
}
