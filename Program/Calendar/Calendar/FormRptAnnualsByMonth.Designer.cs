namespace Calendar
{
    partial class FormRptAnnualsByMonth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRptAnnualsByMonth));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.chooseColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monthsCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.HebDateRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.GregDateRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBoxDateType = new System.Windows.Forms.GroupBox();
            this.chooseAllButton = new System.Windows.Forms.Button();
            this.groupBoxDateType.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "תמונה";
            this.columnHeader10.Width = 183;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "יום";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "חודש";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "שנה";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "שם אירוע";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "סוג אירוע";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "מספר מזהה";
            this.columnHeader3.Width = 100;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader10});
            this.listView1.Location = new System.Drawing.Point(33, 76);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(1307, 637);
            this.listView1.TabIndex = 143;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "עברי/לועזי";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "מעוברת?";
            this.columnHeader2.Width = 100;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clearButton.Location = new System.Drawing.Point(1583, 613);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(161, 84);
            this.clearButton.TabIndex = 142;
            this.clearButton.Text = "נקה דו\"ח ובחירות";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // showButton
            // 
            this.showButton.Enabled = false;
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.showButton.Location = new System.Drawing.Point(1475, 545);
            this.showButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(155, 50);
            this.showButton.TabIndex = 140;
            this.showButton.Text = "הצג דו\"ח";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowButtonClick);
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseColorButton.Location = new System.Drawing.Point(1366, 647);
            this.chooseColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(155, 50);
            this.chooseColorButton.TabIndex = 141;
            this.chooseColorButton.Text = "בחר צבע";
            this.chooseColorButton.UseVisualStyleBackColor = true;
            this.chooseColorButton.Click += new System.EventHandler(this.ChooseColorButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(652, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 32);
            this.label1.TabIndex = 135;
            this.label1.Text = "דו\"ח אירועים שנתיים ע\"פ חודשים";
            // 
            // monthsCheckListBox
            // 
            this.monthsCheckListBox.Enabled = false;
            this.monthsCheckListBox.FormattingEnabled = true;
            this.monthsCheckListBox.Items.AddRange(new object[] {
            "תשרי",
            "חשוון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר",
            "ניסן",
            "אייר",
            "סיוון",
            "תמוז",
            "אב",
            "אלול"});
            this.monthsCheckListBox.Location = new System.Drawing.Point(1471, 265);
            this.monthsCheckListBox.Margin = new System.Windows.Forms.Padding(4);
            this.monthsCheckListBox.Name = "monthsCheckListBox";
            this.monthsCheckListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthsCheckListBox.Size = new System.Drawing.Size(159, 225);
            this.monthsCheckListBox.TabIndex = 144;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1498, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 145;
            this.label2.Text = "חודשים";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(1393, 152);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(310, 51);
            this.label11.TabIndex = 147;
            this.label11.Text = "שים לב!\r\n בבחירת סוג תאריך מסויים\r\n יתקבלו רק אירועים שתאריכם מאותו סוג שסומן";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HebDateRadioButton
            // 
            this.HebDateRadioButton.AutoSize = true;
            this.HebDateRadioButton.Location = new System.Drawing.Point(101, 21);
            this.HebDateRadioButton.Name = "HebDateRadioButton";
            this.HebDateRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HebDateRadioButton.Size = new System.Drawing.Size(56, 21);
            this.HebDateRadioButton.TabIndex = 141;
            this.HebDateRadioButton.TabStop = true;
            this.HebDateRadioButton.Text = "עברי";
            this.HebDateRadioButton.UseVisualStyleBackColor = true;
            this.HebDateRadioButton.Click += new System.EventHandler(this.DateTypeClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(1625, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 146;
            this.label7.Text = "סוג תאריך:";
            // 
            // GregDateRadioButton
            // 
            this.GregDateRadioButton.AutoSize = true;
            this.GregDateRadioButton.Location = new System.Drawing.Point(23, 21);
            this.GregDateRadioButton.Name = "GregDateRadioButton";
            this.GregDateRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GregDateRadioButton.Size = new System.Drawing.Size(57, 21);
            this.GregDateRadioButton.TabIndex = 141;
            this.GregDateRadioButton.TabStop = true;
            this.GregDateRadioButton.Text = "לועזי";
            this.GregDateRadioButton.UseVisualStyleBackColor = true;
            this.GregDateRadioButton.Click += new System.EventHandler(this.DateTypeClick);
            // 
            // groupBoxDateType
            // 
            this.groupBoxDateType.Controls.Add(this.HebDateRadioButton);
            this.groupBoxDateType.Controls.Add(this.GregDateRadioButton);
            this.groupBoxDateType.Location = new System.Drawing.Point(1410, 94);
            this.groupBoxDateType.Name = "groupBoxDateType";
            this.groupBoxDateType.Size = new System.Drawing.Size(183, 55);
            this.groupBoxDateType.TabIndex = 148;
            this.groupBoxDateType.TabStop = false;
            // 
            // chooseAllButton
            // 
            this.chooseAllButton.Enabled = false;
            this.chooseAllButton.Location = new System.Drawing.Point(1475, 497);
            this.chooseAllButton.Name = "chooseAllButton";
            this.chooseAllButton.Size = new System.Drawing.Size(155, 32);
            this.chooseAllButton.TabIndex = 149;
            this.chooseAllButton.Text = "בחר הכל";
            this.chooseAllButton.UseVisualStyleBackColor = true;
            this.chooseAllButton.Click += new System.EventHandler(this.ChooseAllButtonClick);
            // 
            // FormRptAnnualsByMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1757, 741);
            this.Controls.Add(this.chooseAllButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBoxDateType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthsCheckListBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.chooseColorButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRptAnnualsByMonth";
            this.Text = "FormRptAnnualsByMonth";
            this.groupBoxDateType.ResumeLayout(false);
            this.groupBoxDateType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox monthsCheckListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton HebDateRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton GregDateRadioButton;
        private System.Windows.Forms.GroupBox groupBoxDateType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button chooseAllButton;
    }
}