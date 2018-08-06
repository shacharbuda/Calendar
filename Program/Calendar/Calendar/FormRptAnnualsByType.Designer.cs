namespace Calendar
{
    partial class FormRptAnnualsByType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRptAnnualsByType));
            this.label1 = new System.Windows.Forms.Label();
            this.chooseColorButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.tblEventTypesTableAdapter = new Calendar.DataSetEventTypesTableAdapters.tblEventTypesTableAdapter();
            this.dataSetEventTypes = new Calendar.DataSetEventTypes();
            this.tblEventTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(413, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 32);
            this.label1.TabIndex = 118;
            this.label1.Text = "דו\"ח אירועים שנתיים ע\"פ סוג אירוע";
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseColorButton.Location = new System.Drawing.Point(643, 596);
            this.chooseColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(169, 68);
            this.chooseColorButton.TabIndex = 116;
            this.chooseColorButton.Text = "בחר צבע";
            this.chooseColorButton.UseVisualStyleBackColor = true;
            this.chooseColorButton.Click += new System.EventHandler(this.ChooseColorButtonClick);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(177, 577);
            this.firstButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(80, 41);
            this.firstButton.TabIndex = 115;
            this.firstButton.Text = "ראשון";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstButtonClick);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(76, 577);
            this.lastButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(81, 41);
            this.lastButton.TabIndex = 114;
            this.lastButton.Text = "אחרון";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastButtonClick);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(173, 639);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(83, 41);
            this.nextButton.TabIndex = 113;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(75, 639);
            this.prevButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(83, 41);
            this.prevButton.TabIndex = 111;
            this.prevButton.Text = "הקודם";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clearButton.Location = new System.Drawing.Point(851, 596);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(176, 68);
            this.clearButton.TabIndex = 117;
            this.clearButton.Text = "נקה דו\"ח";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // tblEventTypesTableAdapter
            // 
            this.tblEventTypesTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetEventTypes
            // 
            this.dataSetEventTypes.DataSetName = "DataSetEventTypes";
            this.dataSetEventTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEventTypesBindingSource
            // 
            this.tblEventTypesBindingSource.DataMember = "tblEventTypes";
            this.tblEventTypesBindingSource.DataSource = this.dataSetEventTypes;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "typeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "שם אירוע";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblEventTypesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(59, 54);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(243, 508);
            this.dataGridView2.TabIndex = 110;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Location = new System.Drawing.Point(336, 54);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(965, 507);
            this.listView1.TabIndex = 151;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // columnHeader5
            // 
            this.columnHeader5.Text = "שם אירוע";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "שנה";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "חודש";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "יום";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "לועזי?";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "תמונה";
            this.columnHeader10.Width = 183;
            // 
            // FormRptAnnualsByType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1363, 690);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseColorButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRptAnnualsByType";
            this.Text = "FormRptAnnualsByType";
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button clearButton;
        private DataSetEventTypesTableAdapters.tblEventTypesTableAdapter tblEventTypesTableAdapter;
        private DataSetEventTypes dataSetEventTypes;
        private System.Windows.Forms.BindingSource tblEventTypesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}