namespace HotelRplApp
{
    partial class FormReportPreview
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_HOTEL_RPLDataSet = new HotelRplApp.DB_HOTEL_RPLDataSet();
            this.reservationReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewReportTableAdapter = new HotelRplApp.DB_HOTEL_RPLDataSetTableAdapters.ViewReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HOTEL_RPLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // viewReportBindingSource
            // 
            this.viewReportBindingSource.DataMember = "ViewReport";
            this.viewReportBindingSource.DataSource = this.dB_HOTEL_RPLDataSet;
            // 
            // dB_HOTEL_RPLDataSet
            // 
            this.dB_HOTEL_RPLDataSet.DataSetName = "DB_HOTEL_RPLDataSet";
            this.dB_HOTEL_RPLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationReportViewer
            // 
            this.reservationReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "ReservationDataSet";
            reportDataSource2.Value = this.viewReportBindingSource;
            this.reservationReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.reservationReportViewer.LocalReport.ReportEmbeddedResource = "HotelRplApp.ReservationCheckIn.rdlc";
            this.reservationReportViewer.Location = new System.Drawing.Point(0, 0);
            this.reservationReportViewer.Name = "reservationReportViewer";
            this.reservationReportViewer.ServerReport.BearerToken = null;
            this.reservationReportViewer.Size = new System.Drawing.Size(800, 450);
            this.reservationReportViewer.TabIndex = 3;
            // 
            // viewReportTableAdapter
            // 
            this.viewReportTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reservationReportViewer);
            this.Name = "FormReportPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportPreview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReportPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HOTEL_RPLDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reservationReportViewer;
        private DB_HOTEL_RPLDataSet dB_HOTEL_RPLDataSet;
        private System.Windows.Forms.BindingSource viewReportBindingSource;
        private DB_HOTEL_RPLDataSetTableAdapters.ViewReportTableAdapter viewReportTableAdapter;
    }
}