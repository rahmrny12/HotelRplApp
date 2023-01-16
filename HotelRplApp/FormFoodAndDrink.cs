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
    public partial class FormFoodAndDrink : Form
    {
        private string projectDir = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

        public FormFoodAndDrink()
        {
            InitializeComponent();
        }

        private void FormFoodAndDrink_Load(object sender, EventArgs e)
        {
            refreshFoodsAndDrinks();
            lockComponents();

            openMenuPhotoDialog.FileName = "";
        }

        private void refreshFoodsAndDrinks()
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM FoodsAndDrinks", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "FoodAndDrink");

                dataGridFoodsAndDrinks.DataSource = ds;
                dataGridFoodsAndDrinks.DataMember = "FoodAndDrink";
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
            inputType.Enabled = true;
            inputPrice.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Tag = "cancel";
        }

        private void lockComponents()
        {
            clearInputs();
            inputName.Enabled = false;
            inputType.Enabled = false;
            inputPrice.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Tag = "close";
        }

        private void clearInputs()
        {
            inputName.Text = "";
            inputType.Text = "";
            inputPrice.Text = "";
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
                if (MessageBox.Show("Are you sure to delete this food and drink?", "Delete room type", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string oldImage = dataGridFoodsAndDrinks.CurrentRow.Cells["Photo"].Value.ToString();
                    System.IO.File.Delete(projectDir + oldImage);

                    SqlConnection conn = Helper.getConnected();
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM FoodsAndDrinks WHERE ID='" + btnDelete.Tag + "'", conn);
                        cmd.ExecuteNonQuery();
                        refreshFoodsAndDrinks();

                        MessageBox.Show("Menu deleted successfully");
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
                        MessageBox.Show("Click any Menu to update.");
                    }
                    break;
                default:
                    break;
            }
            lockComponents();
        }

        private void updateData()
        {
            string oldImage = dataGridFoodsAndDrinks.CurrentRow.Cells["Photo"].Value.ToString();
            string uploadDir = oldImage;

            MessageBox.Show((openMenuPhotoDialog.FileName != null).ToString());
            if (openMenuPhotoDialog.FileName != "")
            {
                if (System.IO.File.Exists(projectDir + oldImage))
                {
                    System.IO.File.Delete(projectDir + oldImage);
                }
                string extension = System.IO.Path.GetExtension(openMenuPhotoDialog.FileName);
                string newFileName = Guid.NewGuid() + extension;
                uploadDir = "\\Image\\FoodsAndDrinks\\" + newFileName;

                System.IO.File.Copy(openMenuPhotoDialog.FileName, projectDir + uploadDir);
            }

            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE FoodsAndDrinks SET Name='" + inputName.Text + "', Type='" + inputType.Text + "', Price='" + inputPrice.Text + "', Photo='" + uploadDir + "' WHERE ID='" + btnUpdate.Tag + "'", conn);
                cmd.ExecuteNonQuery();
                refreshFoodsAndDrinks();

                MessageBox.Show("Menu updated successfully");
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
            if (openMenuPhotoDialog.FileName != "")
            {
                string extension = System.IO.Path.GetExtension(openMenuPhotoDialog.FileName);
                string newFileName = "\\Image\\FoodsAndDrinks\\" + Guid.NewGuid() + extension;
                System.IO.File.Copy(openMenuPhotoDialog.FileName, projectDir + newFileName);


                SqlConnection conn = Helper.getConnected();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO FoodsAndDrinks VALUES('" + inputName.Text + "', '" + inputType.Text + "', '" + inputPrice.Text + "', '" + newFileName + "')", conn);

                    cmd.ExecuteNonQuery();
                    refreshFoodsAndDrinks();
                    MessageBox.Show("New Menu added successfully!");
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
                MessageBox.Show("Choose menu's photo first!");
            }
        }

        private void dataGridFoodsAndDrinks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridFoodsAndDrinks.Rows[e.RowIndex];
                inputName.Text = row.Cells["Name"].Value.ToString();
                inputType.Text = row.Cells["Type"].Value.ToString();
                inputPrice.Text = row.Cells["Price"].Value.ToString();
                pictureBoxMenu.ImageLocation = projectDir + row.Cells["Photo"].Value.ToString();
                System.Diagnostics.Debug.WriteLine(projectDir + row.Cells["Photo"].Value.ToString());

                btnUpdate.Tag = row.Cells["ID"].Value.ToString();
                btnDelete.Tag = row.Cells["ID"].Value.ToString();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openMenuPhotoDialog.Filter = "Image Only(*.jpg, *.png, *.jpeg)|*.jpg; *.png; *.jpeg";
            if (openMenuPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                if (openMenuPhotoDialog.CheckFileExists)
                {
                    pictureBoxMenu.ImageLocation = openMenuPhotoDialog.FileName;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancel.Tag.ToString() == "cancel")
            {
                lockComponents();
            }
            else
            {
                this.Close();
            }
        }
    }
}
