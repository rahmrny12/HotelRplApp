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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DB_HOTEL_RPLDataSet.ViewReport' table. You can move, or remove it, as needed.
            this.ViewReportTableAdapter.Fill(this.DB_HOTEL_RPLDataSet.ViewReport);

            reportViewer1.LocalReport.ReportEmbeddedResource = "HotelRplApp.ReservationCheckIn.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ReservationDataSet", (DataTable) DB_HOTEL_RPLDataSet.ViewReport));
            reportViewer1.RefreshReport();

            inputCheckInToday.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }
    }
}
