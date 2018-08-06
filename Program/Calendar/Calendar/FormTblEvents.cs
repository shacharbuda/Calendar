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
    public partial class FormTblEvents : Form
    {
        public FormTblEvents(bool isAdmin)
        {
            InitializeComponent();
            if (!isAdmin)
                saveButton.Enabled = false;
        }

        private void FormEvents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEvents.tblEvents' table. You can move, or remove it, as needed.
            this.tblEventsTableAdapter.Fill(this.dataSetEvents.tblEvents);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetEvents changes = (DataSetEvents)dataSetEvents.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblEvents.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                        foreach (DataColumn col in row.GetColumnsInError())
                            errorMsg += row.GetColumnsInError() + "\n";
                    return;
                }
                int numRows = tblEventsTableAdapter.Update(changes);
                MessageBox.Show("Updated" + numRows + " rows", "Success");
                dataSetEvents.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetEvents.RejectChanges();
            }
        }
    }
}
