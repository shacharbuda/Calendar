namespace Calendar
{
    partial class FormTblParashot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTblParashot));
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.parashYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parashConnect1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parashConnect2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parashConnect3DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parashConnect4DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parashConnect5DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parashConnect6DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblParashotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetParashot = new Calendar.DataSetParashot();
            this.tblParashotTableAdapter = new Calendar.DataSetParashotTableAdapters.tblParashotTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblParashotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetParashot)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.saveButton.Location = new System.Drawing.Point(509, 274);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 38);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parashYearDataGridViewTextBoxColumn,
            this.parashConnect1DataGridViewCheckBoxColumn,
            this.parashConnect2DataGridViewCheckBoxColumn,
            this.parashConnect3DataGridViewCheckBoxColumn,
            this.parashConnect4DataGridViewCheckBoxColumn,
            this.parashConnect5DataGridViewCheckBoxColumn,
            this.parashConnect6DataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.tblParashotBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(32, 52);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(1064, 185);
            this.dataGridView2.TabIndex = 3;
            // 
            // parashYearDataGridViewTextBoxColumn
            // 
            this.parashYearDataGridViewTextBoxColumn.DataPropertyName = "parashYear";
            this.parashYearDataGridViewTextBoxColumn.HeaderText = "שנה עברית";
            this.parashYearDataGridViewTextBoxColumn.Name = "parashYearDataGridViewTextBoxColumn";
            // 
            // parashConnect1DataGridViewCheckBoxColumn
            // 
            this.parashConnect1DataGridViewCheckBoxColumn.DataPropertyName = "parashConnect1";
            this.parashConnect1DataGridViewCheckBoxColumn.HeaderText = "ויקהל פקודי";
            this.parashConnect1DataGridViewCheckBoxColumn.Name = "parashConnect1DataGridViewCheckBoxColumn";
            // 
            // parashConnect2DataGridViewCheckBoxColumn
            // 
            this.parashConnect2DataGridViewCheckBoxColumn.DataPropertyName = "parashConnect2";
            this.parashConnect2DataGridViewCheckBoxColumn.HeaderText = "תזריע מצורע";
            this.parashConnect2DataGridViewCheckBoxColumn.Name = "parashConnect2DataGridViewCheckBoxColumn";
            // 
            // parashConnect3DataGridViewCheckBoxColumn
            // 
            this.parashConnect3DataGridViewCheckBoxColumn.DataPropertyName = "parashConnect3";
            this.parashConnect3DataGridViewCheckBoxColumn.HeaderText = "אחרי מות קדושים";
            this.parashConnect3DataGridViewCheckBoxColumn.Name = "parashConnect3DataGridViewCheckBoxColumn";
            // 
            // parashConnect4DataGridViewCheckBoxColumn
            // 
            this.parashConnect4DataGridViewCheckBoxColumn.DataPropertyName = "parashConnect4";
            this.parashConnect4DataGridViewCheckBoxColumn.HeaderText = "בהר בחוקותי";
            this.parashConnect4DataGridViewCheckBoxColumn.Name = "parashConnect4DataGridViewCheckBoxColumn";
            // 
            // parashConnect5DataGridViewCheckBoxColumn
            // 
            this.parashConnect5DataGridViewCheckBoxColumn.DataPropertyName = "parashConnect5";
            this.parashConnect5DataGridViewCheckBoxColumn.HeaderText = "מטות מסעי";
            this.parashConnect5DataGridViewCheckBoxColumn.Name = "parashConnect5DataGridViewCheckBoxColumn";
            // 
            // parashConnect6DataGridViewCheckBoxColumn
            // 
            this.parashConnect6DataGridViewCheckBoxColumn.DataPropertyName = "parashConnect6";
            this.parashConnect6DataGridViewCheckBoxColumn.HeaderText = "ניצבים וילך";
            this.parashConnect6DataGridViewCheckBoxColumn.Name = "parashConnect6DataGridViewCheckBoxColumn";
            // 
            // tblParashotBindingSource
            // 
            this.tblParashotBindingSource.DataMember = "tblParashot";
            this.tblParashotBindingSource.DataSource = this.dataSetParashot;
            // 
            // dataSetParashot
            // 
            this.dataSetParashot.DataSetName = "DataSetParashot";
            this.dataSetParashot.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblParashotTableAdapter
            // 
            this.tblParashotTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(513, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "טבלת פרשות";
            // 
            // FormTblParashot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1112, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTblParashot";
            this.Text = "FormTblParashot";
            this.Load += new System.EventHandler(this.FormParashot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblParashotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetParashot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSetParashot dataSetParashot;
        private System.Windows.Forms.BindingSource tblParashotBindingSource;
        private DataSetParashotTableAdapters.tblParashotTableAdapter tblParashotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn parashYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect3DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect4DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect5DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect6DataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}