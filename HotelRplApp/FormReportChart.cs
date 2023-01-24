using System.Data.SqlClient;
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
    public partial class FormReportChart : Form
    {
        public FormReportChart()
        {
            InitializeComponent();
        }

        private void FormReportChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DB_HOTEL_RPLDataSet.ViewReport' table. You can move, or remove it, as needed.
            this.ViewReportTableAdapter.Fill(this.DB_HOTEL_RPLDataSet.ViewReport);

            int currentYear = DateTime.Now.Year;
            for (int i = 2005; i < currentYear; i++)
            {
                inputYear.Items.Add(i);
            }
            inputYear.Text = currentYear.ToString();

            loadGuests();
        }

        private void loadGuests()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetGuestsByYear " + inputYear.Text, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable report = new DataTable();
                da.Fill(report);

                reservationGuestChart.DataSource = report;
            }

            reservationGuestChart.Series["Guests"].XValueMember = "Month";
            reservationGuestChart.Series["Guests"].YValueMembers = "Guest";
            reservationGuestChart.Titles.Add("Monthly Guests in a Year");
        }
    }
}
