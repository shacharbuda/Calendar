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
        OleDbConnection dataConnection;
        public FormChooseEvent(string[] events, int[] ids, bool[] isAnnuals, OleDbConnection dataConnection, bool isAdmin)
        {
            this.dataConnection = dataConnection;
            this.ids = ids;
            this.isAnnuals = isAnnuals;
            InitializeComponent();
            foreach (string item in events)
                checkedListBox1.Items.Add(item);
            checkedListBox1.SetItemChecked(0, true);
            if(!isAdmin)
            {
                editButton.Enabled = false;
                if (ids.Length == 1)
                    ShowPicture(ids[0], 0);
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                    if (e.Index != ix)
                        checkedListBox1.SetItemChecked(ix, false);
        }      

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int indexOfEventToShow = checkedListBox1.CheckedIndices[0];
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
            int index = checkedListBox1.CheckedIndices[0];
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
    }
}
