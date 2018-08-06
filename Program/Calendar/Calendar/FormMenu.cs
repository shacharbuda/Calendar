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
    public partial class FormMenu : Form
    {
        private OleDbConnection dataConnection;
        string name;
        bool isAdmin;
        int userID;
        public FormMenu(OleDbConnection dataConnection,string firstName,bool isAdmin,int id)
        {
            this.name = firstName;
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isAdmin = isAdmin;
            userID = id;
            AddInstr();
        }

        private void AddInstr()
        {
            helloLabel.Text += name+"\n\nבחר/י באחד מן התפריטים להמשך";
        }

        private void UserClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblUsers frUser = new FormTblUsers(isAdmin);
            frUser.Show();
            frUser.Disposed += fr_Disposed;
        }

        private void EventTypeClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblEventTypes frEventType = new FormTblEventTypes(isAdmin);
            frEventType.Show();
            frEventType.Disposed += fr_Disposed;
        }

        private void CityClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblCities frCity = new FormTblCities(isAdmin);
            frCity.Show();
            frCity.Disposed += fr_Disposed;
        }

        private void EventClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblEvents frEvent = new FormTblEvents(isAdmin);
            frEvent.Show();
            frEvent.Disposed += fr_Disposed;
        }

        private void AnnualClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblAnnuals frAnnual = new FormTblAnnuals(isAdmin);
            frAnnual.Show();
            frAnnual.Disposed += fr_Disposed;
        }

        private void ParashotClick(object sender, EventArgs e)
        {
            this.Hide();
            FormTblParashot frParash = new FormTblParashot(isAdmin);
            frParash.Show();
            frParash.Disposed += fr_Disposed;
        }

        private void AddUserClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddUser frAdUs = new FormAddUser(dataConnection, isAdmin);
            frAdUs.Show();
            frAdUs.Disposed += fr_Disposed;
        }

        private void AddAnnualClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddAnnual frAdAn = new FormAddAnnual(dataConnection, isAdmin);
            frAdAn.Show();
            frAdAn.Disposed += fr_Disposed;
        }

        private void AddCityClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCity frAdCT = new FormAddCity(dataConnection, isAdmin);
            frAdCT.Show();
            frAdCT.Disposed += fr_Disposed;
        }

        private void AddEventClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddEvent frAdEve = new FormAddEvent(dataConnection, isAdmin);
            frAdEve.Show();
            frAdEve.Disposed += fr_Disposed;

        }

        private void AddEventTypeClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddEventType frAdEveTy = new FormAddEventType(dataConnection, isAdmin);
            frAdEveTy.Show();
            frAdEveTy.Disposed += fr_Disposed;
        }

        private void AddYearParashotClick(object sender, EventArgs e)
        {
            this.Hide();
            FormAddYear frAdYea = new FormAddYear(dataConnection, isAdmin);
            frAdYea.Show();
            frAdYea.Disposed += fr_Disposed;
        }

        private void UpdateUserClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateUser frUpUs = new FormUpdateUser(dataConnection, isAdmin);
            frUpUs.Show();
            frUpUs.Disposed += fr_Disposed;
        }

        private void UpdateEventClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateEvent frUpEv = new FormUpdateEvent(dataConnection, isAdmin);
            frUpEv.Show();
            frUpEv.Disposed += fr_Disposed;
        }

        private void UpdateAnnualClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateAnnual frUpAn = new FormUpdateAnnual(dataConnection, isAdmin);
            frUpAn.Show();
            frUpAn.Disposed += fr_Disposed;
        }

        private void UpdateYearClick(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateYear frUpYear = new FormUpdateYear(dataConnection, isAdmin);
            frUpYear.Show();
            frUpYear.Disposed += fr_Disposed;
        }

        private void ReportEventsByTypeClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptEventsByType frRptEvByTy=new FormRptEventsByType(dataConnection);
            frRptEvByTy.Show();
            frRptEvByTy.Disposed+= fr_Disposed;
        }

        private void ReportEventsByMemIDClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptEventsByMember frRptEvByMemID = new FormRptEventsByMember(dataConnection,isAdmin);
            frRptEvByMemID.Show();
            frRptEvByMemID.Disposed += fr_Disposed;
        }

        private void ReportEventsByDatesClick(object sender,EventArgs e)
        {
            this.Hide();
            FormRptEventsByDate frRptEvByDa = new FormRptEventsByDate(dataConnection);
            frRptEvByDa.Show();
            frRptEvByDa.Disposed+=fr_Disposed;
        }

        private void ReportAnnualsByDatesClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptAnnualsByDate frRptAnByDa = new FormRptAnnualsByDate(dataConnection);
            frRptAnByDa.Show();
            frRptAnByDa.Disposed += fr_Disposed;
        }

        private void ReportAnnualsByMonthsClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptAnnualsByMonth frRptAnByMo = new FormRptAnnualsByMonth(dataConnection);
            frRptAnByMo.Show();
            frRptAnByMo.Disposed += fr_Disposed;
        }

        private void ReportAnnualsByDaysClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptAnnualsByDays frRptAnByDa = new FormRptAnnualsByDays(dataConnection);
            frRptAnByDa.Show();
            frRptAnByDa.Disposed += fr_Disposed;
        }

        private void ReportAnnualsByTypeClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptAnnualsByType frRptAnByType = new FormRptAnnualsByType(dataConnection);
            frRptAnByType.Show();
            frRptAnByType.Disposed += fr_Disposed;
        }

        private void ReportUsersByCityClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptUsersByCity frRptUsByCT = new FormRptUsersByCity(dataConnection,isAdmin);
            frRptUsByCT.Show();
            frRptUsByCT.Disposed += fr_Disposed;
        }

        private void ReportParashotClick(object sender, EventArgs e)
        {
            this.Hide();
            FormRptParashot frRptParashot = new FormRptParashot(dataConnection);
            frRptParashot.Show();
            frRptParashot.Disposed += fr_Disposed;
        }

        private void ChartEventsByTypeClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartEventsByType frChaEvByTy = new FormChartEventsByType(dataConnection);
            frChaEvByTy.Show();
            frChaEvByTy.Disposed += fr_Disposed;
        }

        private void ChartEventsByMonthClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartEventsByMonth frChaEvByMo = new FormChartEventsByMonth(dataConnection);
            frChaEvByMo.Show();
            frChaEvByMo.Disposed += fr_Disposed;
        }

        private void ChartAnnualsByMonthClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartAnnualsByGregMonth frChaAnByMo = new FormChartAnnualsByGregMonth(dataConnection);
            frChaAnByMo.Show();
            frChaAnByMo.Disposed += fr_Disposed;
        }

        private void ChartAnnualsByTypeClick(object sender, EventArgs e)
        {
            this.Hide();
            FormChartAnnualsByType frChaAnByTy = new FormChartAnnualsByType(dataConnection);
            frChaAnByTy.Show();
            frChaAnByTy.Disposed += fr_Disposed;
        }

        private void ChartUsersByCityClick(object sender,EventArgs e)
        {
            this.Hide();
            FormChartUsersByCity frChaUsByCT = new FormChartUsersByCity(dataConnection);
            frChaUsByCT.Show();
            frChaUsByCT.Disposed+= fr_Disposed;
        }

        private void CalendarButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            FormCalendar frCal = new FormCalendar(dataConnection,isAdmin,userID);
            frCal.Show();
            frCal.Disposed += fr_Disposed;
        }

        void fr_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }


    }
}
