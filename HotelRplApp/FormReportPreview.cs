using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRplApp
{
    public partial class FormReportPreview : Form
    {
        DateTime from;
        DateTime to;
        public FormReportPreview(DateTime from, DateTime to)
        {
            InitializeComponent();
            this.from= from;
            this.to= to;
        }

        private void FormReportPreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_HOTEL_RPLDataSet.ViewReport' table. You can move, or remove it, as needed.
            this.viewReportTableAdapter.Fill(this.dB_HOTEL_RPLDataSet.ViewReport);

            reservationReportViewer
                .LocalReport.ReportEmbeddedResource = "HotelRplApp.ReservationCheckIn.rdlc";
            reservationReportViewer
                .LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Reservation", (DataTable) dB_HOTEL_RPLDataSet.ViewReport));
            reservationReportViewer.RefreshReport();
            this.reservationReportViewer.RefreshReport();
            this.reservationReportViewer.RefreshReport();
        }
    }
}
