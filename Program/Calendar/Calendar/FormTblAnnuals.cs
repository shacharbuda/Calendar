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
    public partial class FormTblAnnuals : Form
    {
        public FormTblAnnuals(bool isAdmin)
        {
            InitializeComponent();
            if (!isAdmin)
                saveButton.Enabled = false;
        }

        private void FormAnnuals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAnnuals.tblAnnuals' table. You can move, or remove it, as needed.
            this.tblAnnualsTableAdapter.Fill(this.dataSetAnnuals.tblAnnuals);
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetAnnuals changes = (DataSetAnnuals)dataSetAnnuals.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblAnnuals.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                        foreach (DataColumn col in row.GetColumnsInError())
                            errorMsg += row.GetColumnsInError() + "\n";
                    return;
                }
                int numRows = tblAnnualsTableAdapter.Update(changes);
                MessageBox.Show("Updated" + numRows + " rows", "Success");
                dataSetAnnuals.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetAnnuals.RejectChanges();
            }
        }
    }
}
