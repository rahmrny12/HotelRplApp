namespace HotelRplApp
{
    partial class FormReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ViewReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DB_HOTEL_RPLDataSet = new HotelRplApp.DB_HOTEL_RPLDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputCheckInTo = new System.Windows.Forms.DateTimePicker();
            this.inputCheckInFrom = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.inputCheckInToday = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ViewReportTableAdapter = new HotelRplApp.DB_HOTEL_RPLDataSetTableAdapters.ViewReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_HOTEL_RPLDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputCheckInTo);
            this.groupBox1.Controls.Add(this.inputCheckInFrom);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.inputCheckInToday);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose One Option to Print Preview";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(161, 138);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(103, 41);
            this.btnPreview.TabIndex = 1;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "To";
            // 
            // inputCheckInTo
            // 
            this.inputCheckInTo.CustomFormat = "dd-MMM-yyyy";
            this.inputCheckInTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputCheckInTo.Location = new System.Drawing.Point(387, 88);
            this.inputCheckInTo.Name = "inputCheckInTo";
            this.inputCheckInTo.Size = new System.Drawing.Size(160, 22);
            this.inputCheckInTo.TabIndex = 4;
            // 
            // inputCheckInFrom
            // 
            this.inputCheckInFrom.CustomFormat = "dd-MMM-yyyy";
            this.inputCheckInFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.inputCheckInFrom.Location = new System.Drawing.Point(161, 88);
            this.inputCheckInFrom.Name = "inputCheckInFrom";
            this.inputCheckInFrom.Size = new System.Drawing.Size(168, 22);
            this.inputCheckInFrom.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Check In From";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // inputCheckInToday
            // 
            this.inputCheckInToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputCheckInToday.Enabled = false;
            this.inputCheckInToday.Location = new System.Drawing.Point(161, 46);
            this.inputCheckInToday.Name = "inputCheckInToday";
            this.inputCheckInToday.Size = new System.Drawing.Size(386, 22);
            this.inputCheckInToday.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Check In Today";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "ReservationDataSet";
            reportDataSource1.Value = this.ViewReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelRplApp.ReservationCheckIn.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 212);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(592, 210);
            this.reportViewer1.TabIndex = 2;
            // 
            // ViewReportTableAdapter
            // 
            this.ViewReportTableAdapter.ClearBeforeFill = true;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 422);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DB_HOTEL_RPLDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputCheckInToday;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker inputCheckInFrom;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker inputCheckInTo;
        private System.Windows.Forms.Button btnPreview;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewReportBindingSource;
        private DB_HOTEL_RPLDataSet DB_HOTEL_RPLDataSet;
        private DB_HOTEL_RPLDataSetTableAdapters.ViewReportTableAdapter ViewReportTableAdapter;
    }
}