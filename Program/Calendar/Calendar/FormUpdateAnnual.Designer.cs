namespace Calendar
{
    partial class FormUpdateAnnual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateAnnual));
            this.anType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataSetAnnuals = new Calendar.DataSetAnnuals();
            this.tblAnnualsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAnnualsTableAdapter = new Calendar.DataSetAnnualsTableAdapters.tblAnnualsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.annualIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualGregorianDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.annualPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUsersTableAdapter = new Calendar.DataSetUsersTableAdapters.tblUsersTableAdapter();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUsers = new Calendar.DataSetUsers();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.anPictureLocation = new System.Windows.Forms.TextBox();
            this.anGreg = new System.Windows.Forms.CheckBox();
            this.anDay = new System.Windows.Forms.TextBox();
            this.anMonth = new System.Windows.Forms.TextBox();
            this.anYear = new System.Windows.Forms.TextBox();
            this.anName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.firstButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.anID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnnuals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnnualsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // anType
            // 
            this.anType.FormattingEnabled = true;
            this.anType.Location = new System.Drawing.Point(1237, 116);
            this.anType.Margin = new System.Windows.Forms.Padding(4);
            this.anType.Name = "anType";
            this.anType.Size = new System.Drawing.Size(160, 24);
            this.anType.TabIndex = 82;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(541, 39);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 70;
            this.label13.Text = "תמונה";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1129, 204);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 69;
            this.label10.Text = "יום";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1132, 164);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 68;
            this.label9.Text = "חודש";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1120, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "שנה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1440, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 72;
            this.label5.Text = "סוג אירוע";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1424, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "שם אירוע";
            // 
            // dataSetAnnuals
            // 
            this.dataSetAnnuals.DataSetName = "DataSetAnnuals";
            this.dataSetAnnuals.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAnnualsBindingSource
            // 
            this.tblAnnualsBindingSource.DataMember = "tblAnnuals";
            this.tblAnnualsBindingSource.DataSource = this.dataSetAnnuals;
            // 
            // tblAnnualsTableAdapter
            // 
            this.tblAnnualsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.annualIDDataGridViewTextBoxColumn,
            this.annualTypeDataGridViewTextBoxColumn,
            this.annualNameDataGridViewTextBoxColumn,
            this.annualYearDataGridViewTextBoxColumn,
            this.annualMonthDataGridViewTextBoxColumn,
            this.annualDayDataGridViewTextBoxColumn,
            this.annualGregorianDataGridViewCheckBoxColumn,
            this.annualPictureDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblAnnualsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(168, 324);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1153, 185);
            this.dataGridView2.TabIndex = 66;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // annualIDDataGridViewTextBoxColumn
            // 
            this.annualIDDataGridViewTextBoxColumn.DataPropertyName = "annualID";
            this.annualIDDataGridViewTextBoxColumn.HeaderText = "ת.ז. אירוע";
            this.annualIDDataGridViewTextBoxColumn.Name = "annualIDDataGridViewTextBoxColumn";
            // 
            // annualTypeDataGridViewTextBoxColumn
            // 
            this.annualTypeDataGridViewTextBoxColumn.DataPropertyName = "annualType";
            this.annualTypeDataGridViewTextBoxColumn.HeaderText = "סוג אירוע";
            this.annualTypeDataGridViewTextBoxColumn.Name = "annualTypeDataGridViewTextBoxColumn";
            // 
            // annualNameDataGridViewTextBoxColumn
            // 
            this.annualNameDataGridViewTextBoxColumn.DataPropertyName = "annualName";
            this.annualNameDataGridViewTextBoxColumn.HeaderText = "שם אירוע";
            this.annualNameDataGridViewTextBoxColumn.Name = "annualNameDataGridViewTextBoxColumn";
            // 
            // annualYearDataGridViewTextBoxColumn
            // 
            this.annualYearDataGridViewTextBoxColumn.DataPropertyName = "annualYear";
            this.annualYearDataGridViewTextBoxColumn.HeaderText = "שנה";
            this.annualYearDataGridViewTextBoxColumn.Name = "annualYearDataGridViewTextBoxColumn";
            // 
            // annualMonthDataGridViewTextBoxColumn
            // 
            this.annualMonthDataGridViewTextBoxColumn.DataPropertyName = "annualMonth";
            this.annualMonthDataGridViewTextBoxColumn.HeaderText = "חודש";
            this.annualMonthDataGridViewTextBoxColumn.Name = "annualMonthDataGridViewTextBoxColumn";
            // 
            // annualDayDataGridViewTextBoxColumn
            // 
            this.annualDayDataGridViewTextBoxColumn.DataPropertyName = "annualDay";
            this.annualDayDataGridViewTextBoxColumn.HeaderText = "יום";
            this.annualDayDataGridViewTextBoxColumn.Name = "annualDayDataGridViewTextBoxColumn";
            // 
            // annualGregorianDataGridViewCheckBoxColumn
            // 
            this.annualGregorianDataGridViewCheckBoxColumn.DataPropertyName = "annualGregorian";
            this.annualGregorianDataGridViewCheckBoxColumn.HeaderText = "לועזי?";
            this.annualGregorianDataGridViewCheckBoxColumn.Name = "annualGregorianDataGridViewCheckBoxColumn";
            // 
            // annualPictureDataGridViewTextBoxColumn
            // 
            this.annualPictureDataGridViewTextBoxColumn.DataPropertyName = "annualPicture";
            this.annualPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.annualPictureDataGridViewTextBoxColumn.Name = "annualPictureDataGridViewTextBoxColumn";
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.dataSetUsers;
            // 
            // dataSetUsers
            // 
            this.dataSetUsers.DataSetName = "DataSetUsers";
            this.dataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(131, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(115, 32);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.browseButton.Size = new System.Drawing.Size(81, 28);
            this.browseButton.TabIndex = 79;
            this.browseButton.Text = "עיון...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // anPictureLocation
            // 
            this.anPictureLocation.Location = new System.Drawing.Point(204, 36);
            this.anPictureLocation.Margin = new System.Windows.Forms.Padding(4);
            this.anPictureLocation.Name = "anPictureLocation";
            this.anPictureLocation.Size = new System.Drawing.Size(316, 22);
            this.anPictureLocation.TabIndex = 78;
            // 
            // anGreg
            // 
            this.anGreg.AutoSize = true;
            this.anGreg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.anGreg.Location = new System.Drawing.Point(772, 121);
            this.anGreg.Margin = new System.Windows.Forms.Padding(4);
            this.anGreg.Name = "anGreg";
            this.anGreg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.anGreg.Size = new System.Drawing.Size(104, 21);
            this.anGreg.TabIndex = 77;
            this.anGreg.Text = "תאריך לועזי?";
            this.anGreg.UseVisualStyleBackColor = true;
            // 
            // anDay
            // 
            this.anDay.Location = new System.Drawing.Point(953, 204);
            this.anDay.Margin = new System.Windows.Forms.Padding(4);
            this.anDay.Name = "anDay";
            this.anDay.Size = new System.Drawing.Size(132, 22);
            this.anDay.TabIndex = 74;
            // 
            // anMonth
            // 
            this.anMonth.Location = new System.Drawing.Point(953, 160);
            this.anMonth.Margin = new System.Windows.Forms.Padding(4);
            this.anMonth.Name = "anMonth";
            this.anMonth.Size = new System.Drawing.Size(132, 22);
            this.anMonth.TabIndex = 76;
            // 
            // anYear
            // 
            this.anYear.Location = new System.Drawing.Point(953, 113);
            this.anYear.Margin = new System.Windows.Forms.Padding(4);
            this.anYear.Name = "anYear";
            this.anYear.Size = new System.Drawing.Size(132, 22);
            this.anYear.TabIndex = 75;
            // 
            // anName
            // 
            this.anName.Location = new System.Drawing.Point(1265, 159);
            this.anName.Margin = new System.Windows.Forms.Padding(4);
            this.anName.Name = "anName";
            this.anName.Size = new System.Drawing.Size(132, 22);
            this.anName.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(749, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "עדכון אירוע שנתי";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(1367, 254);
            this.firstButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(80, 41);
            this.firstButton.TabIndex = 101;
            this.firstButton.Text = "ראשון";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstButtonClick);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(1001, 254);
            this.lastButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(81, 41);
            this.lastButton.TabIndex = 100;
            this.lastButton.Text = "אחרון";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastButtonClick);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(1135, 254);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(83, 41);
            this.nextButton.TabIndex = 99;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(1239, 254);
            this.prevButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(83, 41);
            this.prevButton.TabIndex = 98;
            this.prevButton.Text = "הקודם";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButtonClick);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateButton.Location = new System.Drawing.Point(578, 196);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(156, 65);
            this.updateButton.TabIndex = 97;
            this.updateButton.Text = "עדכן";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // anID
            // 
            this.anID.Enabled = false;
            this.anID.Location = new System.Drawing.Point(1271, 64);
            this.anID.Margin = new System.Windows.Forms.Padding(4);
            this.anID.Name = "anID";
            this.anID.Size = new System.Drawing.Size(132, 22);
            this.anID.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1424, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 110;
            this.label3.Text = "מס\' סידורי של האירוע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(661, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 112;
            this.label2.Text = "טבלת אירועים שנתיים";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteButton.Location = new System.Drawing.Point(784, 196);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 64);
            this.deleteButton.TabIndex = 113;
            this.deleteButton.Text = "מחק רשומה";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // FormUpdateAnnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1632, 523);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.anID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.anType);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.anPictureLocation);
            this.Controls.Add(this.anGreg);
            this.Controls.Add(this.anDay);
            this.Controls.Add(this.anMonth);
            this.Controls.Add(this.anYear);
            this.Controls.Add(this.anName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUpdateAnnual";
            this.Text = "FormUpdateAnnual";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnnuals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnnualsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox anType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DataSetAnnuals dataSetAnnuals;
        private System.Windows.Forms.BindingSource tblAnnualsBindingSource;
        private DataSetAnnualsTableAdapters.tblAnnualsTableAdapter tblAnnualsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSetUsersTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private DataSetUsers dataSetUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox anPictureLocation;
        private System.Windows.Forms.CheckBox anGreg;
        private System.Windows.Forms.TextBox anDay;
        private System.Windows.Forms.TextBox anMonth;
        private System.Windows.Forms.TextBox anYear;
        private System.Windows.Forms.TextBox anName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox anID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn annualGregorianDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
    }
}