namespace Calendar
{
    partial class FormAddAnnual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAnnual));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.anPictureLocation = new System.Windows.Forms.TextBox();
            this.anGreg = new System.Windows.Forms.CheckBox();
            this.anDay = new System.Windows.Forms.TextBox();
            this.anMonth = new System.Windows.Forms.TextBox();
            this.anYear = new System.Windows.Forms.TextBox();
            this.anName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetUsers = new Calendar.DataSetUsers();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new Calendar.DataSetUsersTableAdapters.tblUsersTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.annualIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annualGregorianDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.annualPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAnnualsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAnnuals = new Calendar.DataSetAnnuals();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tblAnnualsTableAdapter = new Calendar.DataSetAnnualsTableAdapters.tblAnnualsTableAdapter();
            this.anType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHebDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnnualsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnnuals)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.Location = new System.Drawing.Point(749, 228);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(156, 65);
            this.addButton.TabIndex = 63;
            this.addButton.Text = "הוסף";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(125, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(109, 38);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.browseButton.Size = new System.Drawing.Size(81, 28);
            this.browseButton.TabIndex = 61;
            this.browseButton.Text = "עיון...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // anPictureLocation
            // 
            this.anPictureLocation.Location = new System.Drawing.Point(199, 42);
            this.anPictureLocation.Margin = new System.Windows.Forms.Padding(4);
            this.anPictureLocation.Name = "anPictureLocation";
            this.anPictureLocation.Size = new System.Drawing.Size(316, 22);
            this.anPictureLocation.TabIndex = 60;
            // 
            // anGreg
            // 
            this.anGreg.AutoSize = true;
            this.anGreg.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.anGreg.Location = new System.Drawing.Point(767, 127);
            this.anGreg.Margin = new System.Windows.Forms.Padding(4);
            this.anGreg.Name = "anGreg";
            this.anGreg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.anGreg.Size = new System.Drawing.Size(104, 21);
            this.anGreg.TabIndex = 59;
            this.anGreg.Text = "תאריך לועזי?";
            this.anGreg.UseVisualStyleBackColor = true;
            this.anGreg.CheckedChanged += new System.EventHandler(this.anGreg_CheckedChanged);
            // 
            // anDay
            // 
            this.anDay.Location = new System.Drawing.Point(948, 210);
            this.anDay.Margin = new System.Windows.Forms.Padding(4);
            this.anDay.Name = "anDay";
            this.anDay.Size = new System.Drawing.Size(132, 22);
            this.anDay.TabIndex = 52;
            this.anDay.TextChanged += new System.EventHandler(this.anGreg_CheckedChanged);
            // 
            // anMonth
            // 
            this.anMonth.Location = new System.Drawing.Point(948, 166);
            this.anMonth.Margin = new System.Windows.Forms.Padding(4);
            this.anMonth.Name = "anMonth";
            this.anMonth.Size = new System.Drawing.Size(132, 22);
            this.anMonth.TabIndex = 57;
            this.anMonth.TextChanged += new System.EventHandler(this.anGreg_CheckedChanged);
            // 
            // anYear
            // 
            this.anYear.Location = new System.Drawing.Point(948, 119);
            this.anYear.Margin = new System.Windows.Forms.Padding(4);
            this.anYear.Name = "anYear";
            this.anYear.Size = new System.Drawing.Size(132, 22);
            this.anYear.TabIndex = 54;
            this.anYear.TextChanged += new System.EventHandler(this.anGreg_CheckedChanged);
            // 
            // anName
            // 
            this.anName.Location = new System.Drawing.Point(1260, 165);
            this.anName.Margin = new System.Windows.Forms.Padding(4);
            this.anName.Name = "anName";
            this.anName.Size = new System.Drawing.Size(132, 22);
            this.anName.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(744, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "הוספת אירוע שנתי";
            // 
            // dataSetUsers
            // 
            this.dataSetUsers.DataSetName = "DataSetUsers";
            this.dataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.dataSetUsers;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView2.Location = new System.Drawing.Point(180, 324);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(1153, 185);
            this.dataGridView2.TabIndex = 38;
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
            this.annualPictureDataGridViewTextBoxColumn.Width = 200;
            // 
            // tblAnnualsBindingSource
            // 
            this.tblAnnualsBindingSource.DataMember = "tblAnnuals";
            this.tblAnnualsBindingSource.DataSource = this.dataSetAnnuals;
            // 
            // dataSetAnnuals
            // 
            this.dataSetAnnuals.DataSetName = "DataSetAnnuals";
            this.dataSetAnnuals.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(536, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "תמונה";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1124, 210);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "יום";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1127, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "חודש";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1115, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "שנה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1435, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "סוג אירוע";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1419, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "שם אירוע";
            // 
            // tblAnnualsTableAdapter
            // 
            this.tblAnnualsTableAdapter.ClearBeforeFill = true;
            // 
            // anType
            // 
            this.anType.FormattingEnabled = true;
            this.anType.Location = new System.Drawing.Point(1232, 122);
            this.anType.Margin = new System.Windows.Forms.Padding(4);
            this.anType.Name = "anType";
            this.anType.Size = new System.Drawing.Size(160, 24);
            this.anType.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(731, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "טבלת אירועים שנתיים";
            // 
            // labelHebDate
            // 
            this.labelHebDate.AutoSize = true;
            this.labelHebDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHebDate.Location = new System.Drawing.Point(1065, 74);
            this.labelHebDate.Name = "labelHebDate";
            this.labelHebDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelHebDate.Size = new System.Drawing.Size(0, 25);
            this.labelHebDate.TabIndex = 66;
            // 
            // FormAddAnnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1632, 523);
            this.Controls.Add(this.labelHebDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.anType);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.anPictureLocation);
            this.Controls.Add(this.anGreg);
            this.Controls.Add(this.anDay);
            this.Controls.Add(this.anMonth);
            this.Controls.Add(this.anYear);
            this.Controls.Add(this.anName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddAnnual";
            this.Text = "FormAddAnnual";
            this.Load += new System.EventHandler(this.FormAddAnnual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnnualsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnnuals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox anPictureLocation;
        private System.Windows.Forms.CheckBox anGreg;
        private System.Windows.Forms.TextBox anDay;
        private System.Windows.Forms.TextBox anMonth;
        private System.Windows.Forms.TextBox anYear;
        private System.Windows.Forms.TextBox anName;
        private System.Windows.Forms.Label label1;
        private DataSetUsers dataSetUsers;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private DataSetUsersTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DataSetAnnuals dataSetAnnuals;
        private System.Windows.Forms.BindingSource tblAnnualsBindingSource;
        private DataSetAnnualsTableAdapters.tblAnnualsTableAdapter tblAnnualsTableAdapter;
        private System.Windows.Forms.ComboBox anType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn annualGregorianDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelHebDate;
    }
}