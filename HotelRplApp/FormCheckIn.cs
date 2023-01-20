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
        private string customerID;
        private string selectedRoomCustomerID;

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
                loadExistRooms();
            }
        }

        private void loadExistRooms()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewRoomCheckIn WHERE BookingCode='" + inputSearchBooking.Text + "' AND CheckInDateTime IS NULL", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridRoom.DataSource = dt;
                dataGridRoom.Columns["CustomerID"].Visible = false;
                dataGridRoom.Columns["BookingCode"].Visible = false;
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
                        customerID = customer["ID"].ToString();
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

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (selectedRoomCustomerID != null)
            {
                if (selectedRoomCustomerID == customerID)
                {

                    using (SqlConnection conn = Helper.getConnected())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE ReservationRoom SET CheckInDateTime='" + DateTime.Now.ToString("yyyyMMdd hh:mm:ss") + "' WHERE ID='" + dataGridRoom.CurrentRow.Cells[""].Value + "'", conn);
                        cmd.ExecuteNonQuery();

                        loadExistRooms();
                        selectedRoomCustomerID = null;

                        MessageBox.Show("Customer checked in successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Customer is not registered with this booking code!");
                }
            } else
            {
                MessageBox.Show("Click any room to check in.");
            }
        }

        private void dataGridRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRoomCustomerID = dataGridRoom.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
            }
        }
    }
}
