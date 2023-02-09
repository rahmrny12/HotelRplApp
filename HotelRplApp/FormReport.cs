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
            inputToday.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void btnGoPreview_Click(object sender, EventArgs e)
        {
            FormReportPreview formReportPreview;

            if (btnCheckInToday.Checked)
            {
                formReportPreview = new FormReportPreview(DateTime.Parse(inputToday.Text), DateTime.Parse(inputToday.Text));
            } else
            {
                formReportPreview = new FormReportPreview(inputDateFrom.Value, inputDateTo.Value);
            }
            formReportPreview.ShowDialog();
            this.Close();
        }
    }
}
