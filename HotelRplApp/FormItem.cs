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
    public partial class FormItem : Form
    {
        public FormItem()
        {
            InitializeComponent();
        }

        private void FormItem_Load(object sender, EventArgs e)
        {
            refreshItems();
            lockComponents();
        }

        private void refreshItems()
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Item", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Item");

                dataGridItems.DataSource = ds;
                dataGridItems.DataMember = "Item";
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

        private void unlockComponents()
        {
            inputName.Enabled = true;
            inputRequestPrice.Enabled = true;
            inputCompensationFee.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void lockComponents()
        {
            inputName.Enabled = false;
            inputRequestPrice.Enabled = false;
            inputCompensationFee.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
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
                if (MessageBox.Show("Are you sure to delete this item?", "Delete room type", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection conn = Helper.getConnected();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM Item WHERE ID='" + btnDelete.Tag + "'", conn);
                        cmd.ExecuteNonQuery();
                        refreshItems();

                        MessageBox.Show("Item deleted successfully");
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
                MessageBox.Show("Click any data you want to delete.");
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
                    if (btnUpdate.Tag != null)
                    {
                        updateData();
                    }
                    else
                    {
                        MessageBox.Show("Click any item to update.");
                    }
                    break;
                default:
                    break;
            }
            lockComponents();
        }

        private void updateData()
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE INTO Item SET Name='" + inputName.Text + "', RequestPrice='" + inputRequestPrice.Text + "', CompensationFee='" + inputCompensationFee.Text + "' WHERE ID='" + btnUpdate.Tag + "'", conn);
                cmd.ExecuteNonQuery();
                refreshItems();

                MessageBox.Show("Item updated successfully");
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

        private void insertData()
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Item VALUES('" + inputName.Text + "', '" + inputRequestPrice.Text + "', '" + inputCompensationFee.Text + "')", conn);
                cmd.ExecuteNonQuery();
                refreshItems();
                MessageBox.Show("New item added successfully!");
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

        private void dataGridItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                inputName.Text = dataGridItems.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                inputRequestPrice.Text = dataGridItems.Rows[e.RowIndex].Cells["RequestPrice"].Value.ToString();
                inputCompensationFee.Text = dataGridItems.Rows[e.RowIndex].Cells["CompensationFee"].Value.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
