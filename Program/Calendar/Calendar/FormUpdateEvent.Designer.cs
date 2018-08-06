namespace Calendar
{
    partial class FormUpdateEvent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateEvent));
            this.evMemberID = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tblEventsTableAdapter = new Calendar.DataSetEventsTableAdapters.tblEventsTableAdapter();
            this.evTime = new System.Windows.Forms.DateTimePicker();
            this.evDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataSetEvents = new Calendar.DataSetEvents();
            this.tblEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.evPictureLocation = new System.Windows.Forms.TextBox();
            this.evMinutes = new System.Windows.Forms.TextBox();
            this.evName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventMemberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.evID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // evMemberID
            // 
            this.evMemberID.FormattingEnabled = true;
            this.evMemberID.Location = new System.Drawing.Point(1133, 209);
            this.evMemberID.Margin = new System.Windows.Forms.Padding(4);
            this.evMemberID.Name = "evMemberID";
            this.evMemberID.Size = new System.Drawing.Size(160, 24);
            this.evMemberID.TabIndex = 103;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tblEventsTableAdapter
            // 
            this.tblEventsTableAdapter.ClearBeforeFill = true;
            // 
            // evTime
            // 
            this.evTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.evTime.Location = new System.Drawing.Point(879, 159);
            this.evTime.Margin = new System.Windows.Forms.Padding(4);
            this.evTime.Name = "evTime";
            this.evTime.Size = new System.Drawing.Size(103, 22);
            this.evTime.TabIndex = 101;
            // 
            // evDate
            // 
            this.evDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.evDate.Location = new System.Drawing.Point(849, 112);
            this.evDate.Margin = new System.Windows.Forms.Padding(4);
            this.evDate.Name = "evDate";
            this.evDate.Size = new System.Drawing.Size(131, 22);
            this.evDate.TabIndex = 100;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(557, 52);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 90;
            this.label13.Text = "תמונה";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1025, 209);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 89;
            this.label10.Text = "משך (בדקות)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1028, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 88;
            this.label9.Text = "שעה";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1016, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 87;
            this.label8.Text = "תאריך";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1336, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 93;
            this.label5.Text = "סוג אירוע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1320, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 92;
            this.label2.Text = "ת.ז. בעל האירוע";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1320, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 91;
            this.label4.Text = "שם אירוע";
            // 
            // dataSetEvents
            // 
            this.dataSetEvents.DataSetName = "DataSetEvents";
            this.dataSetEvents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEventsBindingSource
            // 
            this.tblEventsBindingSource.DataMember = "tblEvents";
            this.tblEventsBindingSource.DataSource = this.dataSetEvents;
            // 
            // evType
            // 
            this.evType.FormattingEnabled = true;
            this.evType.Location = new System.Drawing.Point(1133, 122);
            this.evType.Margin = new System.Windows.Forms.Padding(4);
            this.evType.Name = "evType";
            this.evType.Size = new System.Drawing.Size(160, 24);
            this.evType.TabIndex = 102;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(147, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(131, 44);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.browseButton.Size = new System.Drawing.Size(81, 28);
            this.browseButton.TabIndex = 97;
            this.browseButton.Text = "עיון...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // evPictureLocation
            // 
            this.evPictureLocation.Location = new System.Drawing.Point(220, 48);
            this.evPictureLocation.Margin = new System.Windows.Forms.Padding(4);
            this.evPictureLocation.Name = "evPictureLocation";
            this.evPictureLocation.Size = new System.Drawing.Size(316, 22);
            this.evPictureLocation.TabIndex = 96;
            // 
            // evMinutes
            // 
            this.evMinutes.Location = new System.Drawing.Point(849, 209);
            this.evMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.evMinutes.Name = "evMinutes";
            this.evMinutes.Size = new System.Drawing.Size(132, 22);
            this.evMinutes.TabIndex = 95;
            // 
            // evName
            // 
            this.evName.Location = new System.Drawing.Point(1161, 164);
            this.evName.Margin = new System.Windows.Forms.Padding(4);
            this.evName.Name = "evName";
            this.evName.Size = new System.Drawing.Size(132, 22);
            this.evName.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(645, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 85;
            this.label1.Text = "עדכון אירוע";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIDDataGridViewTextBoxColumn,
            this.eventTypeDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.eventMemberIDDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.eventTimeDataGridViewTextBoxColumn,
            this.eventMinutesDataGridViewTextBoxColumn,
            this.eventPictureDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblEventsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(147, 314);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1153, 185);
            this.dataGridView2.TabIndex = 86;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "eventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "ת.ז. אירוע";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            // 
            // eventTypeDataGridViewTextBoxColumn
            // 
            this.eventTypeDataGridViewTextBoxColumn.DataPropertyName = "eventType";
            this.eventTypeDataGridViewTextBoxColumn.HeaderText = "סוג אירוע";
            this.eventTypeDataGridViewTextBoxColumn.Name = "eventTypeDataGridViewTextBoxColumn";
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "eventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "שם אירוע";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            // 
            // eventMemberIDDataGridViewTextBoxColumn
            // 
            this.eventMemberIDDataGridViewTextBoxColumn.DataPropertyName = "eventMemberID";
            this.eventMemberIDDataGridViewTextBoxColumn.HeaderText = "ת.ז. בעל אירוע";
            this.eventMemberIDDataGridViewTextBoxColumn.Name = "eventMemberIDDataGridViewTextBoxColumn";
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "eventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            // 
            // eventTimeDataGridViewTextBoxColumn
            // 
            this.eventTimeDataGridViewTextBoxColumn.DataPropertyName = "eventTime";
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.eventTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.eventTimeDataGridViewTextBoxColumn.HeaderText = "שעה";
            this.eventTimeDataGridViewTextBoxColumn.Name = "eventTimeDataGridViewTextBoxColumn";
            // 
            // eventMinutesDataGridViewTextBoxColumn
            // 
            this.eventMinutesDataGridViewTextBoxColumn.DataPropertyName = "eventMinutes";
            this.eventMinutesDataGridViewTextBoxColumn.HeaderText = "משך בדקות";
            this.eventMinutesDataGridViewTextBoxColumn.Name = "eventMinutesDataGridViewTextBoxColumn";
            // 
            // eventPictureDataGridViewTextBoxColumn
            // 
            this.eventPictureDataGridViewTextBoxColumn.DataPropertyName = "eventPicture";
            this.eventPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.eventPictureDataGridViewTextBoxColumn.Name = "eventPictureDataGridViewTextBoxColumn";
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(1243, 251);
            this.firstButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(80, 41);
            this.firstButton.TabIndex = 108;
            this.firstButton.Text = "ראשון";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstButtonClick);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(879, 251);
            this.lastButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(81, 41);
            this.lastButton.TabIndex = 107;
            this.lastButton.Text = "אחרון";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastButtonClick);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(1012, 251);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(83, 41);
            this.nextButton.TabIndex = 106;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(1116, 251);
            this.prevButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(83, 41);
            this.prevButton.TabIndex = 105;
            this.prevButton.Text = "הקודם";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateButton.Location = new System.Drawing.Point(587, 209);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(95, 64);
            this.updateButton.TabIndex = 104;
            this.updateButton.Text = "עדכן";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // evID
            // 
            this.evID.Enabled = false;
            this.evID.Location = new System.Drawing.Point(1167, 80);
            this.evID.Margin = new System.Windows.Forms.Padding(4);
            this.evID.Name = "evID";
            this.evID.Size = new System.Drawing.Size(132, 22);
            this.evID.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1320, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 93;
            this.label3.Text = "מס\' סידורי של האירוע";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(635, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 110;
            this.label6.Text = "טבלת אירועים";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteButton.Location = new System.Drawing.Point(706, 209);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 64);
            this.deleteButton.TabIndex = 114;
            this.deleteButton.Text = "מחק רשומה";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // FormUpdateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1520, 532);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.evID);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.evMemberID);
            this.Controls.Add(this.evTime);
            this.Controls.Add(this.evDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.evType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.evPictureLocation);
            this.Controls.Add(this.evMinutes);
            this.Controls.Add(this.evName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUpdateEvent";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormUpdateEvent";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox evMemberID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DataSetEventsTableAdapters.tblEventsTableAdapter tblEventsTableAdapter;
        private System.Windows.Forms.DateTimePicker evTime;
        private System.Windows.Forms.DateTimePicker evDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DataSetEvents dataSetEvents;
        private System.Windows.Forms.BindingSource tblEventsBindingSource;
        private System.Windows.Forms.ComboBox evType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox evPictureLocation;
        private System.Windows.Forms.TextBox evMinutes;
        private System.Windows.Forms.TextBox evName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox evID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventMemberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
    }
}