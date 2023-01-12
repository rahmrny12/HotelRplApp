using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelRplApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE username='" + inputUsername.Text + "' AND password='" + inputPassword.Text + "'", conn);
                SqlDataReader user = cmd.ExecuteReader();
                if (user.Read())
                {
                    LoggedInUser.Name = user["Name"].ToString();
                    LoggedInUser.Username = user["Username"].ToString();
                    LoggedInUser.JobID = user["JobID"].ToString();

                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User not found!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
