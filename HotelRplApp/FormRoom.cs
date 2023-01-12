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
    public partial class FormRoom : Form
    {

        public FormRoom()
        {
            InitializeComponent();
        }

        void lockComponents()
        {
            inputRoomNumber.Enabled = false;
            inputRoomType.Enabled = false;
            inputRoomFloor.Enabled = false;
            inputDescription.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }

        void unlockComponents()
        {
            inputRoomNumber.Enabled = true;
            inputRoomType.Enabled = true;
            inputRoomFloor.Enabled = true;
            inputDescription.Enabled = true;

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
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewRoom", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Room");

                dataGridRoom.DataMember = "Room";
                dataGridRoom.DataSource = ds;
                dataGridRoom.Columns["ID"].Visible = false;
                dataGridRoom.Columns["RoomTypeID"].Visible = false;
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

        private void FormRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_HOTEL_RPLDataSet.RoomType' table. You can move, or remove it, as needed.
            this.roomTypeTableAdapter.Fill(this.dB_HOTEL_RPLDataSet.RoomType);
            refreshData();
            lockComponents();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            unlockComponents();
            btnSave.Tag = "insert";
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

        private void insertData()
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Room VALUES('" + inputRoomType.SelectedValue + "', '" + inputRoomNumber.Text + "' ,'" + inputRoomFloor.Text + "', '" + inputDescription.Text + "')", conn);

                cmd.ExecuteNonQuery();
                refreshData();

                MessageBox.Show("New room added successfully");
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

        private void updateData()
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Room SET RoomTypeID='" + inputRoomType.SelectedValue + "', RoomNumber='" + inputRoomNumber.Text + "', RoomFloor='" + inputRoomFloor.Text + "', Description='" + inputDescription.Text + "' WHERE ID='" + btnDelete.Tag + "'", conn);

                cmd.ExecuteNonQuery();
                refreshData();

                MessageBox.Show("Room updated successfully");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Tag != null)
            {
                if (MessageBox.Show("Are you sure to delete this room?", "Delete room", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection conn = Helper.getConnected();
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Room WHERE ID='" + btnDelete.Tag + "'", conn);

                        cmd.ExecuteNonQuery();
                        refreshData();

                        MessageBox.Show("Room deleted successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        throw;
                    }
                }
            } else
            {
                MessageBox.Show("Click any room you want to delete.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Tag != null)
            {
                unlockComponents();
                btnSave.Tag = "update";
            } else
            {
                MessageBox.Show("Click any room you want to update.");
            }
        }

        private void dataGridRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                inputRoomType.SelectedValue = dataGridRoom.Rows[e.RowIndex].Cells["RoomTypeID"].Value.ToString();
                inputRoomNumber.Text = dataGridRoom.Rows[e.RowIndex].Cells["RoomNumber"].Value.ToString();
                inputRoomFloor.Text = dataGridRoom.Rows[e.RowIndex].Cells["RoomFloor"].Value.ToString();
                inputDescription.Text = dataGridRoom.Rows[e.RowIndex].Cells["Description"].Value.ToString();

                btnUpdate.Tag = dataGridRoom.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                btnDelete.Tag = dataGridRoom.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            }
        }
    }
}