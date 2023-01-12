using System.Data.SqlClient;
using System.IO;
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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        void lockComponents()
        {
            inputUsername.Enabled = false;
            inputPassword.Enabled = false;
            inputConfirmPass.Enabled = false;
            inputName.Enabled = false;
            inputEmail.Enabled = false;
            inputDateOfBirth.Enabled = false;
            inputJob.Enabled = false;
            inputAddress.Enabled = false;
            btnBrowse.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }

        void unlockComponents()
        {
            inputUsername.Enabled = true;
            inputPassword.Enabled = true;
            inputConfirmPass.Enabled = true;
            inputName.Enabled = true;
            inputEmail.Enabled = true;
            inputDateOfBirth.Enabled = true;
            inputJob.Enabled = true;
            inputAddress.Enabled = true;
            btnBrowse.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        void refreshData()
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");
                dataGridEmployee.DataSource = ds;
                dataGridEmployee.DataMember = "Employee";
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            unlockComponents();
            btnSave.Tag = "insert";
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            lockComponents();
            refreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            unlockComponents();
            btnSave.Tag = "update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (btnSave.Tag)
            {
                case "insert":
                    if (pictureBoxPhoto.Image != null)
                    {
                        insertData();
                    } else
                    {
                        MessageBox.Show("Select a profile image first!");
                    }
                    break;
                case "update":
                    //updateData();
                    break;
                default:
                    break;
            }
        }

        void insertData()
        {
            MemoryStream stream = new MemoryStream();
            pictureBoxPhoto.Image.Save(stream, pictureBoxPhoto.Image.RawFormat);
            byte[] photo = stream.ToArray();

            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES('"
                    + inputUsername.Text + "', '"
                    + inputPassword.Text + "', '"
                    + inputName.Text + "', '"
                    + inputEmail.Text + "', '"
                    + inputAddress.Text + "', '"
                    + inputDateOfBirth.Text + "', '"
                    + inputJob.Text + "', '"
                    + photo + "')", conn);

                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                refreshData();
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
                pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
