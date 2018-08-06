namespace Calendar
{
    partial class FormChartUsersByCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChartUsersByCity));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetEvents = new Calendar.DataSetEvents();
            this.tblEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEventsTableAdapter = new Calendar.DataSetEventsTableAdapters.tblEventsTableAdapter();
            this.dataSetEventTypes = new Calendar.DataSetEventTypes();
            this.tblEventTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEventTypesTableAdapter = new Calendar.DataSetEventTypesTableAdapters.tblEventTypesTableAdapter();
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
            this.label1.Size = new System.Drawing.Size(330, 32);
            this.label1.TabIndex = 123;
            this.label1.Text = "תרשים משתמשים ע\"פ עיר";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView2.Location = new System.Drawing.Point(1175, 124);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(391, 508);
            this.dataGridView2.TabIndex = 122;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "עיר";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "סך משתמשים";
            this.Column2.Name = "Column2";
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
            series1.Name = "סך משתמשים";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1021, 502);
            this.chart1.TabIndex = 124;
            this.chart1.Text = "chart1";
            // 
            // FormChartUsersByCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1615, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChartUsersByCity";
            this.Text = "FormChartUsersByCity";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DataSetEvents dataSetEvents;
        private System.Windows.Forms.BindingSource tblEventsBindingSource;
        private DataSetEventsTableAdapters.tblEventsTableAdapter tblEventsTableAdapter;
        private DataSetEventTypes dataSetEventTypes;
        private System.Windows.Forms.BindingSource tblEventTypesBindingSource;
        private DataSetEventTypesTableAdapters.tblEventTypesTableAdapter tblEventTypesTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}