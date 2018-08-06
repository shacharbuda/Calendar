namespace Calendar
{
    partial class FormAddYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddYear));
            this.addButton = new System.Windows.Forms.Button();
            this.parashYearNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tblParashotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetParashot = new Calendar.DataSetParashot();
            this.label4 = new System.Windows.Forms.Label();
            this.parashConnect1 = new System.Windows.Forms.CheckBox();
            this.parashConnect2 = new System.Windows.Forms.CheckBox();
            this.parashConnect3 = new System.Windows.Forms.CheckBox();
            this.parashConnect4 = new System.Windows.Forms.CheckBox();
            this.parashConnect5 = new System.Windows.Forms.CheckBox();
            this.parashConnect6 = new System.Windows.Forms.CheckBox();
            this.tblParashotTableAdapter = new Calendar.DataSetParashotTableAdapters.tblParashotTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.parashYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parashConnect1DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parashConnect2DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parashConnect3DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parashConnect4DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parashConnect5DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.parashConnect6DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblParashotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetParashot)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.Location = new System.Drawing.Point(521, 197);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(156, 65);
            this.addButton.TabIndex = 73;
            this.addButton.Text = "הוסף";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // parashYearNum
            // 
            this.parashYearNum.Location = new System.Drawing.Point(812, 112);
            this.parashYearNum.Margin = new System.Windows.Forms.Padding(4);
            this.parashYearNum.Name = "parashYearNum";
            this.parashYearNum.Size = new System.Drawing.Size(132, 22);
            this.parashYearNum.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(516, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 69;
            this.label1.Text = "הוספת שנה";
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
            this.dataGridView2.Location = new System.Drawing.Point(76, 306);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(1019, 130);
            this.dataGridView2.TabIndex = 70;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(953, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "שנה עברית (במספר)";
            // 
            // parashConnect1
            // 
            this.parashConnect1.AutoSize = true;
            this.parashConnect1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parashConnect1.Location = new System.Drawing.Point(973, 160);
            this.parashConnect1.Margin = new System.Windows.Forms.Padding(4);
            this.parashConnect1.Name = "parashConnect1";
            this.parashConnect1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parashConnect1.Size = new System.Drawing.Size(96, 21);
            this.parashConnect1.TabIndex = 74;
            this.parashConnect1.Text = "ויקהל פקודי";
            this.parashConnect1.UseVisualStyleBackColor = true;
            // 
            // parashConnect2
            // 
            this.parashConnect2.AutoSize = true;
            this.parashConnect2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parashConnect2.Location = new System.Drawing.Point(800, 160);
            this.parashConnect2.Margin = new System.Windows.Forms.Padding(4);
            this.parashConnect2.Name = "parashConnect2";
            this.parashConnect2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parashConnect2.Size = new System.Drawing.Size(101, 21);
            this.parashConnect2.TabIndex = 74;
            this.parashConnect2.Text = "תזריע מצורע";
            this.parashConnect2.UseVisualStyleBackColor = true;
            // 
            // parashConnect3
            // 
            this.parashConnect3.AutoSize = true;
            this.parashConnect3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parashConnect3.Location = new System.Drawing.Point(657, 151);
            this.parashConnect3.Margin = new System.Windows.Forms.Padding(4);
            this.parashConnect3.Name = "parashConnect3";
            this.parashConnect3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parashConnect3.Size = new System.Drawing.Size(81, 38);
            this.parashConnect3.TabIndex = 74;
            this.parashConnect3.Text = "אחרי מות\r\nקדושים";
            this.parashConnect3.UseVisualStyleBackColor = true;
            // 
            // parashConnect4
            // 
            this.parashConnect4.AutoSize = true;
            this.parashConnect4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parashConnect4.Location = new System.Drawing.Point(488, 160);
            this.parashConnect4.Margin = new System.Windows.Forms.Padding(4);
            this.parashConnect4.Name = "parashConnect4";
            this.parashConnect4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parashConnect4.Size = new System.Drawing.Size(101, 21);
            this.parashConnect4.TabIndex = 74;
            this.parashConnect4.Text = "בהר בחוקותי";
            this.parashConnect4.UseVisualStyleBackColor = true;
            // 
            // parashConnect5
            // 
            this.parashConnect5.AutoSize = true;
            this.parashConnect5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parashConnect5.Location = new System.Drawing.Point(327, 160);
            this.parashConnect5.Margin = new System.Windows.Forms.Padding(4);
            this.parashConnect5.Name = "parashConnect5";
            this.parashConnect5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parashConnect5.Size = new System.Drawing.Size(90, 21);
            this.parashConnect5.TabIndex = 74;
            this.parashConnect5.Text = "מטות מסעי";
            this.parashConnect5.UseVisualStyleBackColor = true;
            // 
            // parashConnect6
            // 
            this.parashConnect6.AutoSize = true;
            this.parashConnect6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.parashConnect6.Location = new System.Drawing.Point(117, 160);
            this.parashConnect6.Margin = new System.Windows.Forms.Padding(4);
            this.parashConnect6.Name = "parashConnect6";
            this.parashConnect6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parashConnect6.Size = new System.Drawing.Size(93, 21);
            this.parashConnect6.TabIndex = 74;
            this.parashConnect6.Text = "ניצבים וילך";
            this.parashConnect6.UseVisualStyleBackColor = true;
            // 
            // tblParashotTableAdapter
            // 
            this.tblParashotTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(501, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "טבלת פרשות מחוברות (שנים עבריות)";
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
            // FormAddYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1183, 465);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parashConnect6);
            this.Controls.Add(this.parashConnect5);
            this.Controls.Add(this.parashConnect4);
            this.Controls.Add(this.parashConnect3);
            this.Controls.Add(this.parashConnect2);
            this.Controls.Add(this.parashConnect1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.parashYearNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddYear";
            this.Text = "FormAddYear";
            this.Load += new System.EventHandler(this.FormAddYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblParashotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetParashot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox parashYearNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox parashConnect1;
        private System.Windows.Forms.CheckBox parashConnect2;
        private System.Windows.Forms.CheckBox parashConnect3;
        private System.Windows.Forms.CheckBox parashConnect4;
        private System.Windows.Forms.CheckBox parashConnect5;
        private System.Windows.Forms.CheckBox parashConnect6;
        private DataSetParashot dataSetParashot;
        private System.Windows.Forms.BindingSource tblParashotBindingSource;
        private DataSetParashotTableAdapters.tblParashotTableAdapter tblParashotTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parashYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect1DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect2DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect3DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect4DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect5DataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn parashConnect6DataGridViewCheckBoxColumn;
    }
}