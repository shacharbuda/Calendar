namespace Calendar
{
    partial class FormRptAnnualsByDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRptAnnualsByDate));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.chooseColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDayTB = new System.Windows.Forms.TextBox();
            this.fromMonthTB = new System.Windows.Forms.TextBox();
            this.fromYearTB = new System.Windows.Forms.TextBox();
            this.toYearTB = new System.Windows.Forms.TextBox();
            this.toMonthTB = new System.Windows.Forms.TextBox();
            this.toDayTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HebDateRadioButton = new System.Windows.Forms.RadioButton();
            this.GregDateRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBoxDateType = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxDateType.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10});
            this.listView1.Location = new System.Drawing.Point(52, 101);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(1307, 637);
            this.listView1.TabIndex = 134;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "לועזי/עברי";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "מתאריך";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "עד תאריך";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "מספר מזהה";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "סוג אירוע";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "שם אירוע";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "שנה";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "חודש";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "יום";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "תמונה";
            this.columnHeader10.Width = 183;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clearButton.Location = new System.Drawing.Point(1577, 479);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(161, 59);
            this.clearButton.TabIndex = 133;
            this.clearButton.Text = "נקה דו\"ח";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // showButton
            // 
            this.showButton.Enabled = false;
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.showButton.Location = new System.Drawing.Point(1477, 391);
            this.showButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(155, 50);
            this.showButton.TabIndex = 131;
            this.showButton.Text = "הצג דו\"ח";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowButtonClick);
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseColorButton.Location = new System.Drawing.Point(1366, 484);
            this.chooseColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(155, 50);
            this.chooseColorButton.TabIndex = 132;
            this.chooseColorButton.Text = "בחר צבע";
            this.chooseColorButton.UseVisualStyleBackColor = true;
            this.chooseColorButton.Click += new System.EventHandler(this.ChooseColorButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1609, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 129;
            this.label2.Text = "עד תאריך:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(1609, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 130;
            this.label8.Text = "מתאריך:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(652, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 32);
            this.label1.TabIndex = 126;
            this.label1.Text = "דו\"ח אירועים שנתיים ע\"פ טווח תאריכים";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1571, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 137;
            this.label10.Text = "יום";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1563, 77);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 136;
            this.label9.Text = "חודש";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1571, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 135;
            this.label3.Text = "שנה";
            // 
            // fromDayTB
            // 
            this.fromDayTB.Location = new System.Drawing.Point(1463, 101);
            this.fromDayTB.Margin = new System.Windows.Forms.Padding(4);
            this.fromDayTB.Name = "fromDayTB";
            this.fromDayTB.Size = new System.Drawing.Size(73, 22);
            this.fromDayTB.TabIndex = 138;
            // 
            // fromMonthTB
            // 
            this.fromMonthTB.Location = new System.Drawing.Point(1463, 74);
            this.fromMonthTB.Margin = new System.Windows.Forms.Padding(4);
            this.fromMonthTB.Name = "fromMonthTB";
            this.fromMonthTB.Size = new System.Drawing.Size(73, 22);
            this.fromMonthTB.TabIndex = 140;
            // 
            // fromYearTB
            // 
            this.fromYearTB.Location = new System.Drawing.Point(1463, 47);
            this.fromYearTB.Margin = new System.Windows.Forms.Padding(4);
            this.fromYearTB.Name = "fromYearTB";
            this.fromYearTB.Size = new System.Drawing.Size(73, 22);
            this.fromYearTB.TabIndex = 139;
            // 
            // toYearTB
            // 
            this.toYearTB.Location = new System.Drawing.Point(1467, 150);
            this.toYearTB.Margin = new System.Windows.Forms.Padding(4);
            this.toYearTB.Name = "toYearTB";
            this.toYearTB.Size = new System.Drawing.Size(73, 22);
            this.toYearTB.TabIndex = 139;
            // 
            // toMonthTB
            // 
            this.toMonthTB.Location = new System.Drawing.Point(1467, 177);
            this.toMonthTB.Margin = new System.Windows.Forms.Padding(4);
            this.toMonthTB.Name = "toMonthTB";
            this.toMonthTB.Size = new System.Drawing.Size(73, 22);
            this.toMonthTB.TabIndex = 140;
            // 
            // toDayTB
            // 
            this.toDayTB.Location = new System.Drawing.Point(1467, 204);
            this.toDayTB.Margin = new System.Windows.Forms.Padding(4);
            this.toDayTB.Name = "toDayTB";
            this.toDayTB.Size = new System.Drawing.Size(73, 22);
            this.toDayTB.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1575, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 135;
            this.label4.Text = "שנה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1571, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 136;
            this.label5.Text = "חודש";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1575, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 137;
            this.label6.Text = "יום";
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
            this.HebDateRadioButton.CheckedChanged += new System.EventHandler(this.CheckedDateType);
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
            this.GregDateRadioButton.CheckedChanged += new System.EventHandler(this.CheckedDateType);
            // 
            // groupBoxDateType
            // 
            this.groupBoxDateType.Controls.Add(this.HebDateRadioButton);
            this.groupBoxDateType.Controls.Add(this.GregDateRadioButton);
            this.groupBoxDateType.Location = new System.Drawing.Point(1432, 249);
            this.groupBoxDateType.Name = "groupBoxDateType";
            this.groupBoxDateType.Size = new System.Drawing.Size(183, 55);
            this.groupBoxDateType.TabIndex = 142;
            this.groupBoxDateType.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(1636, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 129;
            this.label7.Text = "סוג תאריך:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(1373, 325);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(310, 51);
            this.label11.TabIndex = 135;
            this.label11.Text = "שים לב!\r\n בבחירת סוג תאריך מסויים\r\n יתקבלו רק אירועים שתאריכם מאותו סוג שסומן";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRptAnnualsByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1735, 741);
            this.Controls.Add(this.groupBoxDateType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toDayTB);
            this.Controls.Add(this.fromDayTB);
            this.Controls.Add(this.toMonthTB);
            this.Controls.Add(this.fromMonthTB);
            this.Controls.Add(this.toYearTB);
            this.Controls.Add(this.fromYearTB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.chooseColorButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRptAnnualsByDate";
            this.Text = "FormRptAnnualsByDate";
            this.groupBoxDateType.ResumeLayout(false);
            this.groupBoxDateType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fromDayTB;
        private System.Windows.Forms.TextBox fromMonthTB;
        private System.Windows.Forms.TextBox fromYearTB;
        private System.Windows.Forms.TextBox toYearTB;
        private System.Windows.Forms.TextBox toMonthTB;
        private System.Windows.Forms.TextBox toDayTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton HebDateRadioButton;
        private System.Windows.Forms.RadioButton GregDateRadioButton;
        private System.Windows.Forms.GroupBox groupBoxDateType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}