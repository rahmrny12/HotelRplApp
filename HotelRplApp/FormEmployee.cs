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
        private string projectDir = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

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

        void refreshEmployee()
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
            // TODO: This line of code loads data into the 'dB_HOTEL_RPLDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.dB_HOTEL_RPLDataSet.Job);
            lockComponents();
            refreshEmployee();

            openFileDialog.FileName = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            unlockComponents();
            btnSave.Tag = "update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Tag != null)
            {
                if (MessageBox.Show("Are you sure to delete this employee?", "Delete employee", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string oldImage = dataGridEmployee.CurrentRow.Cells["Photo"].Value.ToString();
                    System.IO.File.Delete(oldImage);

                    SqlConnection conn = Helper.getConnected();
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE ID='" + btnDelete.Tag + "'", conn);

                        cmd.ExecuteNonQuery();
                        refreshEmployee();

                        MessageBox.Show("Employee deleted successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("Click any room you want to delete.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (btnSave.Tag)
            {
                case "insert":
                    if (pictureBoxPhoto.Image != null)
                    {
                        insertData();
                    }
                    else
                    {
                        MessageBox.Show("Select a profile image first!");
                    }
                    break;
                case "update":
                    updateData();
                    break;
                default:
                    break;
            }
            lockComponents();
        }

        void insertData()
        {
            if (inputPassword.Text == inputConfirmPass.Text)
            {
                string extension = System.IO.Path.GetExtension(openFileDialog.FileName);
                string newFileName = Guid.NewGuid() + extension;
                string uploadDir = "\\Image\\Employee\\" + newFileName;
                System.IO.File.Copy(openFileDialog.FileName, projectDir + uploadDir);

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
                        + inputDateOfBirth.Value + "', '"
                        + inputJob.SelectedValue + "', '"
                        + uploadDir + "')", conn);

                    cmd.ExecuteNonQuery();
                    refreshEmployee();

                    MessageBox.Show("New employee added successfully!");
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
            else
            {
                MessageBox.Show("Password confirmation not valid!");
            }
        }

        void updateData()
        {
            string oldImage = dataGridEmployee.CurrentRow.Cells["Photo"].Value.ToString();
            string uploadDir = oldImage;

            if (openFileDialog.FileName != "")
            {
                if (File.Exists(uploadDir))
                {
                    System.IO.File.Delete(uploadDir);
                }

                string extension = System.IO.Path.GetExtension(openFileDialog.FileName);
                string newFileName = Guid.NewGuid() + extension;
                uploadDir = "\\Image\\Employee\\" + newFileName;
                System.IO.File.Copy(openFileDialog.FileName, projectDir + uploadDir);
            }

            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Employee SET Username='"
                    + inputUsername.Text + "', Password='"
                    + inputPassword.Text + "', Name='"
                    + inputName.Text + "', Email='"
                    + inputEmail.Text + "', Address='"
                    + inputAddress.Text + "', DateOfBirth='"
                    + inputDateOfBirth.Value + "', JobID='"
                    + inputJob.Text + "', Photo='"
                    + uploadDir + "' WHERE ID='" + btnUpdate.Tag + "'", conn);

                cmd.ExecuteNonQuery();
                refreshEmployee();

                MessageBox.Show("Employee updated successfully!");
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
                pictureBoxPhoto.Image = new Bitmap(openFileDialog.FileName);
                pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                inputUsername.Text = dataGridEmployee.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                inputPassword.Text = dataGridEmployee.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                inputName.Text = dataGridEmployee.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                inputEmail.Text = dataGridEmployee.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                inputAddress.Text = dataGridEmployee.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                inputDateOfBirth.Text = dataGridEmployee.Rows[e.RowIndex].Cells["DateOfBirth"].Value.ToString();
                inputJob.SelectedValue = dataGridEmployee.Rows[e.RowIndex].Cells["JobID"].Value.ToString();
                pictureBoxPhoto.ImageLocation = projectDir + dataGridEmployee.Rows[e.RowIndex].Cells["Photo"].Value.ToString();

                btnUpdate.Tag = dataGridEmployee.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                btnDelete.Tag = dataGridEmployee.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            }
        }

        private void inputUsername_Validating(object sender, CancelEventArgs e)
        {
            if (inputUsername.Text == "")
            {
                e.Cancel = true;
            }
        }

        private void inputJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
