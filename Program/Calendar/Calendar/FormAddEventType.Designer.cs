namespace Calendar
{
    partial class FormAddEventType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEventType));
            this.addButton = new System.Windows.Forms.Button();
            this.typeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tblEventTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEventTypes = new Calendar.DataSetEventTypes();
            this.label4 = new System.Windows.Forms.Label();
            this.tblEventTypesTableAdapter = new Calendar.DataSetEventTypesTableAdapters.tblEventTypesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.Location = new System.Drawing.Point(459, 354);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(156, 65);
            this.addButton.TabIndex = 73;
            this.addButton.Text = "הוסף";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // typeName
            // 
            this.typeName.Location = new System.Drawing.Point(481, 212);
            this.typeName.Margin = new System.Windows.Forms.Padding(4);
            this.typeName.Name = "typeName";
            this.typeName.Size = new System.Drawing.Size(132, 22);
            this.typeName.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(315, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 69;
            this.label1.Text = "הוספת סוג אירוע";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblEventTypesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(135, 155);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(213, 286);
            this.dataGridView2.TabIndex = 70;
            // 
            // tblEventTypesBindingSource
            // 
            this.tblEventTypesBindingSource.DataMember = "tblEventTypes";
            this.tblEventTypesBindingSource.DataSource = this.dataSetEventTypes;
            // 
            // dataSetEventTypes
            // 
            this.dataSetEventTypes.DataSetName = "DataSetEventTypes";
            this.dataSetEventTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "שם סוג אירוע";
            // 
            // tblEventTypesTableAdapter
            // 
            this.tblEventTypesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(167, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "טבלת סוגי אירוע";
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "typeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "סוג אירוע";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            // 
            // FormAddEventType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(832, 548);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.typeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddEventType";
            this.Text = "FormAddEventType";
            this.Load += new System.EventHandler(this.FormAddEventType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox typeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private DataSetEventTypes dataSetEventTypes;
        private System.Windows.Forms.BindingSource tblEventTypesBindingSource;
        private DataSetEventTypesTableAdapters.tblEventTypesTableAdapter tblEventTypesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
    }
}