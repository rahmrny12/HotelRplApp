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
    public partial class FormRoomType : Form
    {
        // path folder project ini
        string uploadDir = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

        public FormRoomType()
        {
            InitializeComponent();
        }

        void lockComponents()
        {
            btnSave.Enabled = false;
            inputName.Enabled = false;
            inputCapacity.Enabled = false;
            inputRoomPrice.Enabled = false;
            btnBrowse.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }

        void unlockComponents()
        {
            btnSave.Enabled = true;
            inputName.Enabled = true;
            inputCapacity.Enabled = true;
            inputRoomPrice.Enabled = true;
            btnBrowse.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void refreshData()
        {
            SqlConnection conn = Helper.getConnected();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM RoomType", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "RoomType");

                dataGridRoomType.DataMember = "RoomType";
                dataGridRoomType.DataSource = ds;
                dataGridRoomType.Columns["ID"].Visible = false;
                dataGridRoomType.Columns["Photo"].Visible = false;
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
            openPhotoDialog.InitialDirectory = "C://Desktop";
            openPhotoDialog.Title = "Select a room type photo";
            openPhotoDialog.Filter = "Image Only(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            openPhotoDialog.FilterIndex = 1;
            try
            {
                if (openPhotoDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openPhotoDialog.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openPhotoDialog.FileName);
                        labelPath.Visible = true;
                        labelPath.Text = path;
                        pictureBoxPhoto.Image = new Bitmap(openPhotoDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            unlockComponents();
            btnSave.Tag = "insert";
        }

        private void FormRoomType_Load(object sender, EventArgs e)
        {
            refreshData();
            lockComponents();
        }

        private void dataGridViewRoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                inputName.Text = dataGridRoomType.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                inputCapacity.Text = dataGridRoomType.Rows[e.RowIndex].Cells["Capacity"].Value.ToString();
                inputRoomPrice.Text = dataGridRoomType.Rows[e.RowIndex].Cells["RoomPrice"].Value.ToString();
                btnUpdate.Tag = dataGridRoomType.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                btnDelete.Tag = dataGridRoomType.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                pictureBoxPhoto.ImageLocation = uploadDir + dataGridRoomType.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Tag != null)
            {
                unlockComponents();
                btnSave.Tag = "update";
            }
            else
            {
                MessageBox.Show("Click any data you want to update.");
            }
        }

        public void insertData()
        {
            SqlConnection conn = Helper.getConnected();
            // ambil nama file
            string filename = System.IO.Path.GetFileName(openPhotoDialog.FileName);
            // copy gambar ke folder image
            System.IO.File.Copy(openPhotoDialog.FileName, uploadDir + "\\Image\\RoomType\\" + filename);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO RoomType " +
                    "VALUES ('" + inputName.Text + "', '" + inputCapacity.Text + "', '" + inputRoomPrice.Text + "', '\\Image\\RoomType\\" + filename + "')", conn);

                cmd.ExecuteNonQuery();

                refreshData();

                MessageBox.Show("New room type added successfully!");
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

        public void updateData()
        {
            SqlConnection conn = Helper.getConnected();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE RoomType SET Name='" + inputName.Text + "', Capacity='" + inputCapacity.Text + "', RoomPrice='" + inputRoomPrice.Text + "' WHERE ID='" + btnUpdate.Tag + "'", conn);
                cmd.ExecuteNonQuery();

                refreshData();

                MessageBox.Show("Room type updated successfully!");
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

        public void deleteData()
        {
            SqlConnection conn = Helper.getConnected();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM RoomType WHERE ID='" + btnDelete.Tag + "'", conn);

                cmd.ExecuteNonQuery();
                refreshData();

                MessageBox.Show("Room type deleted successfully!");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (btnSave.Tag)
            {
                case "insert":
                    insertData();
                    break;
                case "update":
                    updateData();
                    break;
                default:
                    break;
            }
            lockComponents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Tag != null)
            {
                if (MessageBox.Show("Are you sure to delete this room type?", "Delete room type", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    deleteData();
                }
            }
            else
            {
                MessageBox.Show("Click any data you want to delete.");
            }
        }

        private void dataGridRoomType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
