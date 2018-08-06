namespace Calendar
{
    partial class FormRptShowPictureEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRptShowPictureEvent));
            this.evID = new System.Windows.Forms.TextBox();
            this.evMemberID = new System.Windows.Forms.ComboBox();
            this.evTime = new System.Windows.Forms.DateTimePicker();
            this.evDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.evType = new System.Windows.Forms.ComboBox();
            this.evMinutes = new System.Windows.Forms.TextBox();
            this.evName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // evID
            // 
            this.evID.Location = new System.Drawing.Point(356, 320);
            this.evID.Margin = new System.Windows.Forms.Padding(4);
            this.evID.Name = "evID";
            this.evID.Size = new System.Drawing.Size(132, 22);
            this.evID.TabIndex = 153;
            // 
            // evMemberID
            // 
            this.evMemberID.FormattingEnabled = true;
            this.evMemberID.Location = new System.Drawing.Point(328, 442);
            this.evMemberID.Margin = new System.Windows.Forms.Padding(4);
            this.evMemberID.Name = "evMemberID";
            this.evMemberID.Size = new System.Drawing.Size(160, 24);
            this.evMemberID.TabIndex = 152;
            // 
            // evTime
            // 
            this.evTime.CustomFormat = "HH:mm";
            this.evTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.evTime.Location = new System.Drawing.Point(107, 377);
            this.evTime.Margin = new System.Windows.Forms.Padding(4);
            this.evTime.Name = "evTime";
            this.evTime.ShowUpDown = true;
            this.evTime.Size = new System.Drawing.Size(103, 22);
            this.evTime.TabIndex = 150;
            // 
            // evDate
            // 
            this.evDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.evDate.Location = new System.Drawing.Point(79, 337);
            this.evDate.Margin = new System.Windows.Forms.Padding(4);
            this.evDate.Name = "evDate";
            this.evDate.Size = new System.Drawing.Size(131, 22);
            this.evDate.TabIndex = 149;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 424);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 142;
            this.label10.Text = "משך (בדקות)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 382);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 141;
            this.label9.Text = "שעה";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 140;
            this.label8.Text = "תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 145;
            this.label3.Text = "מס\' סידורי של האירוע";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 361);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 146;
            this.label5.Text = "סוג אירוע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 445);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 144;
            this.label2.Text = "ת.ז. בעל האירוע";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 143;
            this.label4.Text = "שם אירוע";
            // 
            // evType
            // 
            this.evType.FormattingEnabled = true;
            this.evType.Location = new System.Drawing.Point(328, 361);
            this.evType.Margin = new System.Windows.Forms.Padding(4);
            this.evType.Name = "evType";
            this.evType.Size = new System.Drawing.Size(160, 24);
            this.evType.TabIndex = 151;
            // 
            // evMinutes
            // 
            this.evMinutes.Location = new System.Drawing.Point(79, 424);
            this.evMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.evMinutes.Name = "evMinutes";
            this.evMinutes.Size = new System.Drawing.Size(132, 22);
            this.evMinutes.TabIndex = 148;
            // 
            // evName
            // 
            this.evName.Location = new System.Drawing.Point(356, 402);
            this.evName.Margin = new System.Windows.Forms.Padding(4);
            this.evName.Name = "evName";
            this.evName.Size = new System.Drawing.Size(132, 22);
            this.evName.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 154;
            this.label1.Text = "דו\"ח הצגת תמונת אירוע";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(79, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // FormRptShowPictureEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(657, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evID);
            this.Controls.Add(this.evMemberID);
            this.Controls.Add(this.evTime);
            this.Controls.Add(this.evDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.evType);
            this.Controls.Add(this.evMinutes);
            this.Controls.Add(this.evName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRptShowPictureEvent";
            this.Text = "FormRptShowPictureEvent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox evID;
        private System.Windows.Forms.ComboBox evMemberID;
        private System.Windows.Forms.DateTimePicker evTime;
        private System.Windows.Forms.DateTimePicker evDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox evType;
        private System.Windows.Forms.TextBox evMinutes;
        private System.Windows.Forms.TextBox evName;
        private System.Windows.Forms.Label label1;
    }
}