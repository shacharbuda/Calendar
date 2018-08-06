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
    public partial class FormTblEventTypes : Form
    {
        public FormTblEventTypes(bool isAdmin)
        {
            InitializeComponent();
            if (!isAdmin)
                saveButton.Enabled = false;
        }

        private void FormEventTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetEventTypes.tblEventTypes' table. You can move, or remove it, as needed.
            this.tblEventTypesTableAdapter.Fill(this.dataSetEventTypes.tblEventTypes);
            // TODO: This line of code loads data into the 'dataSetCities.tblCities' table. You can move, or remove it, as needed.
            this.tblCitiesTableAdapter.Fill(this.dataSetCities.tblCities);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                DataSetEventTypes changes = (DataSetEventTypes)dataSetEventTypes.GetChanges();
                if (changes == null)
                    return;
                DataTable dt = changes.tblEventTypes.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                        foreach (DataColumn col in row.GetColumnsInError())
                            errorMsg += row.GetColumnsInError() + "\n";
                    return;
                }
                int numRows = tblEventTypesTableAdapter.Update(changes);
                MessageBox.Show("Updated" + numRows + " rows", "Success");
                dataSetEventTypes.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetEventTypes.RejectChanges();
            }
        }
    }
}
