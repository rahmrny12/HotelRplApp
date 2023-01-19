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
    public partial class FormCheckIn : Form
    {
        public FormCheckIn()
        {
            InitializeComponent();
        }

        private void FormCheckIn_Load(object sender, EventArgs e)
        {

        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            if (inputSearchBooking.Text != "")
            {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM ViewRoomCheckIn WHERE BookingCode='" + inputSearchBooking.Text + "'", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridRoom.DataSource = dt;
                    dataGridRoom.Columns["BookingCode"].Visible = false;
                }

            }
        }

        private void inputGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (inputPhoneNumber.Text != "")
            {
                SqlConnection conn = Helper.getConnected();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE PhoneNumber='" + inputPhoneNumber.Text + "'", conn);
                    SqlDataReader customer = cmd.ExecuteReader();
                    if (customer.Read())
                    {
                        inputName.Text = customer["Name"].ToString();
                        inputEmail.Text = customer["Email"].ToString();
                        if (customer["Gender"].ToString() == "Male")
                        {
                            optionMale.Checked = true;
                        } else
                        {
                            optionFemale.Checked = true;
                        }
                        //inputGender.Text = customer["Gender"].ToString();
                        inputAge.Text = customer["Age"].ToString();
                        inputNIK.Text = customer["NIK"].ToString();
                    }
                }
                finally
                {
                    conn.Close();
                }



            }
        }
    }
}
