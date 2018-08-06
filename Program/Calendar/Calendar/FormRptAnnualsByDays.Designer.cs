namespace Calendar
{
    partial class FormRptAnnualsByDays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRptAnnualsByDays));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.daysCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clearButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.chooseColorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chooseAllButton = new System.Windows.Forms.Button();
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
            // columnHeader9
            // 
            this.columnHeader9.Text = "לועזי?";
            this.columnHeader9.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1491, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 152;
            this.label2.Text = "ימים";
            // 
            // daysCheckedListBox
            // 
            this.daysCheckedListBox.FormattingEnabled = true;
            this.daysCheckedListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.daysCheckedListBox.Location = new System.Drawing.Point(1439, 113);
            this.daysCheckedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.daysCheckedListBox.Name = "daysCheckedListBox";
            this.daysCheckedListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.daysCheckedListBox.Size = new System.Drawing.Size(187, 191);
            this.daysCheckedListBox.TabIndex = 151;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Location = new System.Drawing.Point(25, 89);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(1307, 637);
            this.listView1.TabIndex = 150;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clearButton.Location = new System.Drawing.Point(1572, 421);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(161, 84);
            this.clearButton.TabIndex = 149;
            this.clearButton.Text = "נקה דו\"ח ובחירות";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.showButton.Location = new System.Drawing.Point(1471, 348);
            this.showButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(155, 50);
            this.showButton.TabIndex = 147;
            this.showButton.Text = "הצג דו\"ח";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowButtonClick);
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseColorButton.Location = new System.Drawing.Point(1368, 438);
            this.chooseColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(155, 50);
            this.chooseColorButton.TabIndex = 148;
            this.chooseColorButton.Text = "בחר צבע";
            this.chooseColorButton.UseVisualStyleBackColor = true;
            this.chooseColorButton.Click += new System.EventHandler(this.ChooseColorButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(644, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 32);
            this.label1.TabIndex = 146;
            this.label1.Text = "דו\"ח אירועים שנתיים ע\"פ ימים";
            // 
            // chooseAllButton
            // 
            this.chooseAllButton.Location = new System.Drawing.Point(1471, 311);
            this.chooseAllButton.Name = "chooseAllButton";
            this.chooseAllButton.Size = new System.Drawing.Size(155, 32);
            this.chooseAllButton.TabIndex = 153;
            this.chooseAllButton.Text = "בחר הכל";
            this.chooseAllButton.UseVisualStyleBackColor = true;
            this.chooseAllButton.Click += new System.EventHandler(this.ChooseAllButtonClick);
            // 
            // FormRptAnnualsByDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1757, 741);
            this.Controls.Add(this.chooseAllButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.daysCheckedListBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.chooseColorButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRptAnnualsByDays";
            this.Text = "FormRptAnnualsByDays";
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
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox daysCheckedListBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseAllButton;
    }
}