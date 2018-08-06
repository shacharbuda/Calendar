namespace Calendar
{
    partial class FormTblAnnuals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTblAnnuals));
            this.saveButton = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tblAnnualsTableAdapter = new Calendar.DataSetAnnualsTableAdapters.tblAnnualsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnnualsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnnuals)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.saveButton.Location = new System.Drawing.Point(597, 300);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 38);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
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
            this.dataGridView2.Location = new System.Drawing.Point(57, 84);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(1196, 185);
            this.dataGridView2.TabIndex = 2;
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
            this.annualTypeDataGridViewTextBoxColumn.HeaderText = "סוג האירוע";
            this.annualTypeDataGridViewTextBoxColumn.Name = "annualTypeDataGridViewTextBoxColumn";
            // 
            // annualNameDataGridViewTextBoxColumn
            // 
            this.annualNameDataGridViewTextBoxColumn.DataPropertyName = "annualName";
            this.annualNameDataGridViewTextBoxColumn.HeaderText = "שם האירוע";
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
            this.annualGregorianDataGridViewCheckBoxColumn.HeaderText = "לועזי";
            this.annualGregorianDataGridViewCheckBoxColumn.Name = "annualGregorianDataGridViewCheckBoxColumn";
            // 
            // annualPictureDataGridViewTextBoxColumn
            // 
            this.annualPictureDataGridViewTextBoxColumn.DataPropertyName = "annualPicture";
            this.annualPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.annualPictureDataGridViewTextBoxColumn.Name = "annualPictureDataGridViewTextBoxColumn";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(519, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "טבלת אירועים שנתיים";
            // 
            // tblAnnualsTableAdapter
            // 
            this.tblAnnualsTableAdapter.ClearBeforeFill = true;
            // 
            // FormTblAnnuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1309, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTblAnnuals";
            this.Text = "FormTblAnnuals";
            this.Load += new System.EventHandler(this.FormAnnuals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAnnualsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnnuals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private DataSetAnnuals dataSetAnnuals;
        private System.Windows.Forms.BindingSource tblAnnualsBindingSource;
        private DataSetAnnualsTableAdapters.tblAnnualsTableAdapter tblAnnualsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn annualGregorianDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn annualPictureDataGridViewTextBoxColumn;
    }
}