namespace Calendar
{
    partial class FormChartAnnualsByType
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChartAnnualsByType));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetEvents = new Calendar.DataSetEvents();
            this.tblEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEventsTableAdapter = new Calendar.DataSetEventsTableAdapters.tblEventsTableAdapter();
            this.dataSetEventTypes = new Calendar.DataSetEventTypes();
            this.tblEventTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEventTypesTableAdapter = new Calendar.DataSetEventTypesTableAdapters.tblEventTypesTableAdapter();
            this.todayLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(615, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 32);
            this.label1.TabIndex = 115;
            this.label1.Text = "תרשים אירועים שנתיים ע\"פ סוג אירוע";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.Col2,
            this.col3,
            this.col4});
            this.dataGridView2.Location = new System.Drawing.Point(1175, 124);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(391, 508);
            this.dataGridView2.TabIndex = 114;
            // 
            // col1
            // 
            this.col1.HeaderText = "סוג אירוע";
            this.col1.Name = "col1";
            // 
            // Col2
            // 
            this.Col2.HeaderText = "סך אירועים";
            this.Col2.Name = "Col2";
            // 
            // col3
            // 
            this.col3.HeaderText = "אירועים שחלפו";
            this.col3.Name = "col3";
            // 
            // col4
            // 
            this.col4.HeaderText = "אירועים עתידיים";
            this.col4.Name = "col4";
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
            // tblEventsTableAdapter
            // 
            this.tblEventsTableAdapter.ClearBeforeFill = true;
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
            // tblEventTypesTableAdapter
            // 
            this.tblEventTypesTableAdapter.ClearBeforeFill = true;
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.todayLabel.Location = new System.Drawing.Point(431, 59);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.todayLabel.Size = new System.Drawing.Size(46, 17);
            this.todayLabel.TabIndex = 117;
            this.todayLabel.Text = "היום: ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(48, 130);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "סך אירועים";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "אירועים שחלפו";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "אירועים עתידיים";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1021, 502);
            this.chart1.TabIndex = 116;
            this.chart1.Text = "chart1";
            // 
            // FormChartAnnualsByType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1615, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChartAnnualsByType";
            this.Text = "FormChartAnnualsByType";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEventTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEventTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private DataSetEvents dataSetEvents;
        private System.Windows.Forms.BindingSource tblEventsBindingSource;
        private DataSetEventsTableAdapters.tblEventsTableAdapter tblEventsTableAdapter;
        private DataSetEventTypes dataSetEventTypes;
        private System.Windows.Forms.BindingSource tblEventTypesBindingSource;
        private DataSetEventTypesTableAdapters.tblEventTypesTableAdapter tblEventTypesTableAdapter;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}