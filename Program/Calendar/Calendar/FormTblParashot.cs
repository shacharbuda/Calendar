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
    public partial class FormTblParashot : Form
    {
        public FormTblParashot(bool isAdmin)
        {
            InitializeComponent();
            if (!isAdmin)
                saveButton.Enabled = false;
        }

        private void FormParashot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetParashot.tblParashot' table. You can move, or remove it, as needed.
            this.tblParashotTableAdapter.Fill(this.dataSetParashot.tblParashot);

        }
        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetParashot changes = (DataSetParashot)dataSetParashot.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblParashot.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                        foreach (DataColumn col in row.GetColumnsInError())
                            errorMsg += row.GetColumnsInError() + "\n";
                    return;
                }
                int numRows = tblParashotTableAdapter.Update(changes);
                MessageBox.Show("Updated" + numRows + " rows", "Success");
                dataSetParashot.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetParashot.RejectChanges();
            }
        }
    }
}
