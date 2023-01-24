namespace HotelRplApp
{
    partial class FormReportChart
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.inputYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_HOTEL_RPLDataSet = new HotelRplApp.DB_HOTEL_RPLDataSet();
            this.ViewReportTableAdapter = new HotelRplApp.DB_HOTEL_RPLDataSetTableAdapters.ViewReportTableAdapter();
            this.reservationGuestChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_HOTEL_RPLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationGuestChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.inputYear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Year to Preview Chart of Number Guests";
            // 
            // btnPreview
            // 
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreview.Location = new System.Drawing.Point(75, 62);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 38);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // inputYear
            // 
            this.inputYear.FormattingEnabled = true;
            this.inputYear.Items.AddRange(new object[] {
            "2023",
            "2024"});
            this.inputYear.Location = new System.Drawing.Point(75, 32);
            this.inputYear.Name = "inputYear";
            this.inputYear.Size = new System.Drawing.Size(192, 24);
            this.inputYear.TabIndex = 1;
            this.inputYear.Text = "2022";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year :";
            // 
            // ViewReportBindingSource
            // 
            this.ViewReportBindingSource.DataMember = "ViewReport";
            this.ViewReportBindingSource.DataSource = this.DB_HOTEL_RPLDataSet;
            // 
            // DB_HOTEL_RPLDataSet
            // 
            this.DB_HOTEL_RPLDataSet.DataSetName = "DB_HOTEL_RPLDataSet";
            this.DB_HOTEL_RPLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewReportTableAdapter
            // 
            this.ViewReportTableAdapter.ClearBeforeFill = true;
            // 
            // reservationGuestChart
            // 
            chartArea1.Name = "ChartArea1";
            this.reservationGuestChart.ChartAreas.Add(chartArea1);
            this.reservationGuestChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.reservationGuestChart.Legends.Add(legend1);
            this.reservationGuestChart.Location = new System.Drawing.Point(0, 145);
            this.reservationGuestChart.Name = "reservationGuestChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Guests";
            series1.YValuesPerPoint = 2;
            this.reservationGuestChart.Series.Add(series1);
            this.reservationGuestChart.Size = new System.Drawing.Size(800, 300);
            this.reservationGuestChart.TabIndex = 1;
            this.reservationGuestChart.Text = "chart1";
            // 
            // FormReportChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.reservationGuestChart);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReportChart";
            this.Text = "FormReportChart";
            this.Load += new System.EventHandler(this.FormReportChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_HOTEL_RPLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationGuestChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox inputYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.BindingSource ViewReportBindingSource;
        private DB_HOTEL_RPLDataSet DB_HOTEL_RPLDataSet;
        private DB_HOTEL_RPLDataSetTableAdapters.ViewReportTableAdapter ViewReportTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart reservationGuestChart;
    }
}