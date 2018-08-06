namespace Calendar
{
    partial class FormAddEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEvent));
            this.addButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.evPictureLocation = new System.Windows.Forms.TextBox();
            this.evMinutes = new System.Windows.Forms.TextBox();
            this.evName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tblEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEvents = new Calendar.DataSetEvents();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.evDate = new System.Windows.Forms.DateTimePicker();
            this.evTime = new System.Windows.Forms.DateTimePicker();
            this.tblEventsTableAdapter = new Calendar.DataSetEventsTableAdapters.tblEventsTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.evType = new System.Windows.Forms.ComboBox();
            this.evMemberID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventMemberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.Location = new System.Drawing.Point(698, 213);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(156, 65);
            this.addButton.TabIndex = 81;
            this.addButton.Text = "הוסף";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(195, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(179, 44);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.browseButton.Size = new System.Drawing.Size(81, 28);
            this.browseButton.TabIndex = 79;
            this.browseButton.Text = "עיון...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // evPictureLocation
            // 
            this.evPictureLocation.Location = new System.Drawing.Point(268, 48);
            this.evPictureLocation.Margin = new System.Windows.Forms.Padding(4);
            this.evPictureLocation.Name = "evPictureLocation";
            this.evPictureLocation.Size = new System.Drawing.Size(316, 22);
            this.evPictureLocation.TabIndex = 78;
            // 
            // evMinutes
            // 
            this.evMinutes.Location = new System.Drawing.Point(897, 209);
            this.evMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.evMinutes.Name = "evMinutes";
            this.evMinutes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.evMinutes.Size = new System.Drawing.Size(132, 22);
            this.evMinutes.TabIndex = 73;
            // 
            // evName
            // 
            this.evName.Location = new System.Drawing.Point(1209, 164);
            this.evName.Margin = new System.Windows.Forms.Padding(4);
            this.evName.Name = "evName";
            this.evName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.evName.Size = new System.Drawing.Size(132, 22);
            this.evName.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(693, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 64;
            this.label1.Text = "הוספת אירוע";
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
            this.dataGridView2.Location = new System.Drawing.Point(129, 322);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(1153, 185);
            this.dataGridView2.TabIndex = 65;
            // 
            // tblEventsBindingSource
            // 
            this.tblEventsBindingSource.DataMember = "tblEvents";
            this.tblEventsBindingSource.DataSource = this.dataSetEvents;
            // 
            // dataSetEvents
            // 
            this.dataSetEvents.DataSetName = "DataSetEvents";
            this.dataSetEvents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(605, 52);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 69;
            this.label13.Text = "תמונה";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1073, 209);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 68;
            this.label10.Text = "משך (בדקות)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1076, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 67;
            this.label9.Text = "שעה";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1064, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 66;
            this.label8.Text = "תאריך";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1384, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "סוג אירוע";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1368, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "שם אירוע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1368, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "ת.ז. בעל האירוע";
            // 
            // evDate
            // 
            this.evDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.evDate.Location = new System.Drawing.Point(897, 112);
            this.evDate.Margin = new System.Windows.Forms.Padding(4);
            this.evDate.Name = "evDate";
            this.evDate.Size = new System.Drawing.Size(131, 22);
            this.evDate.TabIndex = 82;
            // 
            // evTime
            // 
            this.evTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.evTime.Location = new System.Drawing.Point(927, 159);
            this.evTime.Margin = new System.Windows.Forms.Padding(4);
            this.evTime.Name = "evTime";
            this.evTime.Size = new System.Drawing.Size(103, 22);
            this.evTime.TabIndex = 82;
            // 
            // tblEventsTableAdapter
            // 
            this.tblEventsTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // evType
            // 
            this.evType.FormattingEnabled = true;
            this.evType.Location = new System.Drawing.Point(1181, 122);
            this.evType.Margin = new System.Windows.Forms.Padding(4);
            this.evType.Name = "evType";
            this.evType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.evType.Size = new System.Drawing.Size(160, 24);
            this.evType.TabIndex = 83;
            // 
            // evMemberID
            // 
            this.evMemberID.FormattingEnabled = true;
            this.evMemberID.Location = new System.Drawing.Point(1181, 209);
            this.evMemberID.Margin = new System.Windows.Forms.Padding(4);
            this.evMemberID.Name = "evMemberID";
            this.evMemberID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.evMemberID.Size = new System.Drawing.Size(160, 24);
            this.evMemberID.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(683, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "טבלת אירועים";
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
            this.eventMemberIDDataGridViewTextBoxColumn.HeaderText = "ת.ז. בעל האירוע";
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
            dataGridViewCellStyle1.Format = "T";
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
            // FormAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1520, 532);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.evMemberID);
            this.Controls.Add(this.evType);
            this.Controls.Add(this.evTime);
            this.Controls.Add(this.evDate);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.evPictureLocation);
            this.Controls.Add(this.evMinutes);
            this.Controls.Add(this.evName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddEvent";
            this.Text = "FormAddEvent";
            this.Load += new System.EventHandler(this.FormAddEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox evPictureLocation;
        private System.Windows.Forms.TextBox evMinutes;
        private System.Windows.Forms.TextBox evName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker evDate;
        private System.Windows.Forms.DateTimePicker evTime;
        private DataSetEvents dataSetEvents;
        private System.Windows.Forms.BindingSource tblEventsBindingSource;
        private DataSetEventsTableAdapters.tblEventsTableAdapter tblEventsTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox evType;
        private System.Windows.Forms.ComboBox evMemberID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventMemberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventPictureDataGridViewTextBoxColumn;
    }
}