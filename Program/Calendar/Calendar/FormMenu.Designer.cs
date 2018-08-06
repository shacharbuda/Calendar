namespace Calendar
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annualsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parashotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventTypesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.annualsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parashotToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.annualsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.yearParashotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsByTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsByMemberIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsByDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annualsByDatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annualsByMonthsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annualsByDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annualsByTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersByCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parashotByYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsByTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsByMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annualsByTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.annualsByMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersByCityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helloLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablesToolStripMenuItem,
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.ChartsToolStripMenuItem,
            this.calendarToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainMenu.Size = new System.Drawing.Size(523, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.citiesToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.eventTypesToolStripMenuItem,
            this.annualsToolStripMenuItem,
            this.parashotToolStripMenuItem});
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.tablesToolStripMenuItem.Text = "&טבלאות";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.usersToolStripMenuItem.Text = "משתמשים";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.UserClick);
            // 
            // citiesToolStripMenuItem
            // 
            this.citiesToolStripMenuItem.Name = "citiesToolStripMenuItem";
            this.citiesToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.citiesToolStripMenuItem.Text = "ערים";
            this.citiesToolStripMenuItem.Click += new System.EventHandler(this.CityClick);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.eventsToolStripMenuItem.Text = "אירועים";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.EventClick);
            // 
            // eventTypesToolStripMenuItem
            // 
            this.eventTypesToolStripMenuItem.Name = "eventTypesToolStripMenuItem";
            this.eventTypesToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.eventTypesToolStripMenuItem.Text = "סוגי אירוע";
            this.eventTypesToolStripMenuItem.Click += new System.EventHandler(this.EventTypeClick);
            // 
            // annualsToolStripMenuItem
            // 
            this.annualsToolStripMenuItem.Name = "annualsToolStripMenuItem";
            this.annualsToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.annualsToolStripMenuItem.Text = "אירועים שנתיים";
            this.annualsToolStripMenuItem.Click += new System.EventHandler(this.AnnualClick);
            // 
            // parashotToolStripMenuItem
            // 
            this.parashotToolStripMenuItem.Name = "parashotToolStripMenuItem";
            this.parashotToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.parashotToolStripMenuItem.Text = "פרשות מחוברות (שנים עבריות)";
            this.parashotToolStripMenuItem.Click += new System.EventHandler(this.ParashotClick);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem1,
            this.citiesToolStripMenuItem1,
            this.eventsToolStripMenuItem1,
            this.eventTypesToolStripMenuItem1,
            this.annualsToolStripMenuItem1,
            this.parashotToolStripMenuItem1});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.addToolStripMenuItem.Text = "&הוספה";
            // 
            // usersToolStripMenuItem1
            // 
            this.usersToolStripMenuItem1.Name = "usersToolStripMenuItem1";
            this.usersToolStripMenuItem1.Size = new System.Drawing.Size(283, 26);
            this.usersToolStripMenuItem1.Text = "משתמשים";
            this.usersToolStripMenuItem1.Click += new System.EventHandler(this.AddUserClick);
            // 
            // citiesToolStripMenuItem1
            // 
            this.citiesToolStripMenuItem1.Name = "citiesToolStripMenuItem1";
            this.citiesToolStripMenuItem1.Size = new System.Drawing.Size(283, 26);
            this.citiesToolStripMenuItem1.Text = "ערים";
            this.citiesToolStripMenuItem1.Click += new System.EventHandler(this.AddCityClick);
            // 
            // eventsToolStripMenuItem1
            // 
            this.eventsToolStripMenuItem1.Name = "eventsToolStripMenuItem1";
            this.eventsToolStripMenuItem1.Size = new System.Drawing.Size(283, 26);
            this.eventsToolStripMenuItem1.Text = "אירועים";
            this.eventsToolStripMenuItem1.Click += new System.EventHandler(this.AddEventClick);
            // 
            // eventTypesToolStripMenuItem1
            // 
            this.eventTypesToolStripMenuItem1.Name = "eventTypesToolStripMenuItem1";
            this.eventTypesToolStripMenuItem1.Size = new System.Drawing.Size(283, 26);
            this.eventTypesToolStripMenuItem1.Text = "סוגי אירוע";
            this.eventTypesToolStripMenuItem1.Click += new System.EventHandler(this.AddEventTypeClick);
            // 
            // annualsToolStripMenuItem1
            // 
            this.annualsToolStripMenuItem1.Name = "annualsToolStripMenuItem1";
            this.annualsToolStripMenuItem1.Size = new System.Drawing.Size(283, 26);
            this.annualsToolStripMenuItem1.Text = "אירועים שנתיים";
            this.annualsToolStripMenuItem1.Click += new System.EventHandler(this.AddAnnualClick);
            // 
            // parashotToolStripMenuItem1
            // 
            this.parashotToolStripMenuItem1.Name = "parashotToolStripMenuItem1";
            this.parashotToolStripMenuItem1.Size = new System.Drawing.Size(283, 26);
            this.parashotToolStripMenuItem1.Text = "פרשות מחוברות (שנים עבריות)";
            this.parashotToolStripMenuItem1.Click += new System.EventHandler(this.AddYearParashotClick);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem2,
            this.eventsToolStripMenuItem2,
            this.annualsToolStripMenuItem2,
            this.yearParashotToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.updateToolStripMenuItem.Text = "&עדכון";
            // 
            // usersToolStripMenuItem2
            // 
            this.usersToolStripMenuItem2.Name = "usersToolStripMenuItem2";
            this.usersToolStripMenuItem2.Size = new System.Drawing.Size(283, 26);
            this.usersToolStripMenuItem2.Text = "משתמשים";
            this.usersToolStripMenuItem2.Click += new System.EventHandler(this.UpdateUserClick);
            // 
            // eventsToolStripMenuItem2
            // 
            this.eventsToolStripMenuItem2.Name = "eventsToolStripMenuItem2";
            this.eventsToolStripMenuItem2.Size = new System.Drawing.Size(283, 26);
            this.eventsToolStripMenuItem2.Text = "אירועים";
            this.eventsToolStripMenuItem2.Click += new System.EventHandler(this.UpdateEventClick);
            // 
            // annualsToolStripMenuItem2
            // 
            this.annualsToolStripMenuItem2.Name = "annualsToolStripMenuItem2";
            this.annualsToolStripMenuItem2.Size = new System.Drawing.Size(283, 26);
            this.annualsToolStripMenuItem2.Text = "אירועים שנתיים";
            this.annualsToolStripMenuItem2.Click += new System.EventHandler(this.UpdateAnnualClick);
            // 
            // yearParashotToolStripMenuItem
            // 
            this.yearParashotToolStripMenuItem.Name = "yearParashotToolStripMenuItem";
            this.yearParashotToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.yearParashotToolStripMenuItem.Text = "פרשות מחוברות (שנים עבריות)";
            this.yearParashotToolStripMenuItem.Click += new System.EventHandler(this.UpdateYearClick);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsByTypeToolStripMenuItem,
            this.eventsByMemberIDToolStripMenuItem,
            this.eventsByDatesToolStripMenuItem,
            this.annualsByDatesToolStripMenuItem,
            this.annualsByMonthsToolStripMenuItem,
            this.annualsByDaysToolStripMenuItem,
            this.annualsByTypeToolStripMenuItem,
            this.usersByCityToolStripMenuItem,
            this.parashotByYearToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.reportToolStripMenuItem.Text = "&דו\"חות";
            // 
            // eventsByTypeToolStripMenuItem
            // 
            this.eventsByTypeToolStripMenuItem.Name = "eventsByTypeToolStripMenuItem";
            this.eventsByTypeToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.eventsByTypeToolStripMenuItem.Text = "אירועים ע\"פ סוג אירוע";
            this.eventsByTypeToolStripMenuItem.Click += new System.EventHandler(this.ReportEventsByTypeClick);
            // 
            // eventsByMemberIDToolStripMenuItem
            // 
            this.eventsByMemberIDToolStripMenuItem.Name = "eventsByMemberIDToolStripMenuItem";
            this.eventsByMemberIDToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.eventsByMemberIDToolStripMenuItem.Text = "אירועים ע\"פ ת.ז. בעל האירוע";
            this.eventsByMemberIDToolStripMenuItem.Click += new System.EventHandler(this.ReportEventsByMemIDClick);
            // 
            // eventsByDatesToolStripMenuItem
            // 
            this.eventsByDatesToolStripMenuItem.Name = "eventsByDatesToolStripMenuItem";
            this.eventsByDatesToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.eventsByDatesToolStripMenuItem.Text = "אירועים ע\"פ טווח תאריכים";
            this.eventsByDatesToolStripMenuItem.Click += new System.EventHandler(this.ReportEventsByDatesClick);
            // 
            // annualsByDatesToolStripMenuItem
            // 
            this.annualsByDatesToolStripMenuItem.Name = "annualsByDatesToolStripMenuItem";
            this.annualsByDatesToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.annualsByDatesToolStripMenuItem.Text = "אירועים שנתיים ע\"פ טווח תאריכים";
            this.annualsByDatesToolStripMenuItem.Click += new System.EventHandler(this.ReportAnnualsByDatesClick);
            // 
            // annualsByMonthsToolStripMenuItem
            // 
            this.annualsByMonthsToolStripMenuItem.Name = "annualsByMonthsToolStripMenuItem";
            this.annualsByMonthsToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.annualsByMonthsToolStripMenuItem.Text = "אירועים שנתיים ע\"פ חודש";
            this.annualsByMonthsToolStripMenuItem.Click += new System.EventHandler(this.ReportAnnualsByMonthsClick);
            // 
            // annualsByDaysToolStripMenuItem
            // 
            this.annualsByDaysToolStripMenuItem.Name = "annualsByDaysToolStripMenuItem";
            this.annualsByDaysToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.annualsByDaysToolStripMenuItem.Text = "אירועים שנתיים ע\"פ יום בחודש";
            this.annualsByDaysToolStripMenuItem.Click += new System.EventHandler(this.ReportAnnualsByDaysClick);
            // 
            // annualsByTypeToolStripMenuItem
            // 
            this.annualsByTypeToolStripMenuItem.Name = "annualsByTypeToolStripMenuItem";
            this.annualsByTypeToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.annualsByTypeToolStripMenuItem.Text = "אירועים שנתיים ע\"פ סוג אירוע";
            this.annualsByTypeToolStripMenuItem.Click += new System.EventHandler(this.ReportAnnualsByTypeClick);
            // 
            // usersByCityToolStripMenuItem
            // 
            this.usersByCityToolStripMenuItem.Name = "usersByCityToolStripMenuItem";
            this.usersByCityToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.usersByCityToolStripMenuItem.Text = "משתמשים ע\"פ עיר (מגורים)";
            this.usersByCityToolStripMenuItem.Click += new System.EventHandler(this.ReportUsersByCityClick);
            // 
            // parashotByYearToolStripMenuItem
            // 
            this.parashotByYearToolStripMenuItem.Name = "parashotByYearToolStripMenuItem";
            this.parashotByYearToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.parashotByYearToolStripMenuItem.Text = "פרשות מחוברות ע\"פ שנה עברית";
            this.parashotByYearToolStripMenuItem.Click += new System.EventHandler(this.ReportParashotClick);
            // 
            // ChartsToolStripMenuItem
            // 
            this.ChartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsByTypeToolStripMenuItem1,
            this.eventsByMonthToolStripMenuItem,
            this.annualsByTypeToolStripMenuItem1,
            this.annualsByMonthToolStripMenuItem,
            this.usersByCityToolStripMenuItem1});
            this.ChartsToolStripMenuItem.Name = "ChartsToolStripMenuItem";
            this.ChartsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.ChartsToolStripMenuItem.Text = "&תרשימים";
            // 
            // eventsByTypeToolStripMenuItem1
            // 
            this.eventsByTypeToolStripMenuItem1.Name = "eventsByTypeToolStripMenuItem1";
            this.eventsByTypeToolStripMenuItem1.Size = new System.Drawing.Size(283, 26);
            this.eventsByTypeToolStripMenuItem1.Text = "אירועים ע\"פ סוג אירוע";
            this.eventsByTypeToolStripMenuItem1.Click += new System.EventHandler(this.ChartEventsByTypeClick);
            // 
            // eventsByMonthToolStripMenuItem
            // 
            this.eventsByMonthToolStripMenuItem.Name = "eventsByMonthToolStripMenuItem";
            this.eventsByMonthToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.eventsByMonthToolStripMenuItem.Text = "אירועים ע\"פ חודש";
            this.eventsByMonthToolStripMenuItem.Click += new System.EventHandler(this.ChartEventsByMonthClick);
            // 
            // annualsByTypeToolStripMenuItem1
            // 
            this.annualsByTypeToolStripMenuItem1.Name = "annualsByTypeToolStripMenuItem1";
            this.annualsByTypeToolStripMenuItem1.Size = new System.Drawing.Size(283, 26);
            this.annualsByTypeToolStripMenuItem1.Text = "אירועים שנתיים ע\"פ סוג אירוע";
            this.annualsByTypeToolStripMenuItem1.Click += new System.EventHandler(this.ChartAnnualsByTypeClick);
            // 
            // annualsByMonthToolStripMenuItem
            // 
            this.annualsByMonthToolStripMenuItem.Name = "annualsByMonthToolStripMenuItem";
            this.annualsByMonthToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.annualsByMonthToolStripMenuItem.Text = "אירועים שנתיים ע\"פ חודש לועזי";
            this.annualsByMonthToolStripMenuItem.Click += new System.EventHandler(this.ChartAnnualsByMonthClick);
            // 
            // usersByCityToolStripMenuItem1
            // 
            this.usersByCityToolStripMenuItem1.Name = "usersByCityToolStripMenuItem1";
            this.usersByCityToolStripMenuItem1.Size = new System.Drawing.Size(283, 26);
            this.usersByCityToolStripMenuItem1.Text = "משתמשים ע\"פ עיר";
            this.usersByCityToolStripMenuItem1.Click += new System.EventHandler(this.ChartUsersByCityClick);
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.calendarToolStripMenuItem.Text = "&לוח שנה";
            this.calendarToolStripMenuItem.Click += new System.EventHandler(this.CalendarButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // helloLabel
            // 
            this.helloLabel.Font = new System.Drawing.Font("Guttman Mantova", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.helloLabel.Location = new System.Drawing.Point(16, 62);
            this.helloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helloLabel.Size = new System.Drawing.Size(183, 169);
            this.helloLabel.TabIndex = 2;
            this.helloLabel.Text = "שלום ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(265, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "התפריט הראשי";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(375, 214);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 26);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "יציאה מהמערכת";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(523, 241);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annualsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parashotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eventTypesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem annualsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parashotToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem annualsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem yearParashotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsByTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsByMemberIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsByDatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annualsByDatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annualsByMonthsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annualsByDaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annualsByTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersByCityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parashotByYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsByTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eventsByMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annualsByTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem annualsByMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersByCityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
    }
}

