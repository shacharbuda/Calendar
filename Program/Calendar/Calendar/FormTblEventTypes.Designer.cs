namespace Calendar
{
    partial class FormTblEventTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTblEventTypes));
            this.dataSetEventTypes = new Calendar.DataSetEventTypes();
            this.dataSetEventTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCities = new Calendar.DataSetCities();
            this.tblCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCitiesTableAdapter = new Calendar.DataSetCitiesTableAdapters.tblCitiesTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEventTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEventTypesTableAdapter = new Calendar.DataSetEventTypesTableAdapters.tblEventTypesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetEventTypes
            // 
            this.dataSetEventTypes.DataSetName = "DataSetEventTypes";
            this.dataSetEventTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetEventTypesBindingSource
            // 
            this.dataSetEventTypesBindingSource.DataSource = this.dataSetEventTypes;
            this.dataSetEventTypesBindingSource.Position = 0;
            // 
            // dataSetCities
            // 
            this.dataSetCities.DataSetName = "DataSetCities";
            this.dataSetCities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCitiesBindingSource
            // 
            this.tblCitiesBindingSource.DataMember = "tblCities";
            this.tblCitiesBindingSource.DataSource = this.dataSetCities;
            // 
            // tblCitiesTableAdapter
            // 
            this.tblCitiesTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.saveButton.Location = new System.Drawing.Point(143, 246);
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
            this.typeNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblEventTypesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(43, 42);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(243, 185);
            this.dataGridView2.TabIndex = 2;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "typeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "שם סוג אירוע";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            // 
            // tblEventTypesBindingSource
            // 
            this.tblEventTypesBindingSource.DataMember = "tblEventTypes";
            this.tblEventTypesBindingSource.DataSource = this.dataSetEventTypes;
            // 
            // tblEventTypesTableAdapter
            // 
            this.tblEventTypesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "טבלת סוגי אירועים";
            // 
            // FormTblEventTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(361, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTblEventTypes";
            this.Text = "FormTblEventTypes";
            this.Load += new System.EventHandler(this.FormEventTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dataSetEventTypesBindingSource;
        private DataSetEventTypes dataSetEventTypes;
        private DataSetCities dataSetCities;
        private System.Windows.Forms.BindingSource tblCitiesBindingSource;
        private DataSetCitiesTableAdapters.tblCitiesTableAdapter tblCitiesTableAdapter;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tblEventTypesBindingSource;
        private DataSetEventTypesTableAdapters.tblEventTypesTableAdapter tblEventTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}