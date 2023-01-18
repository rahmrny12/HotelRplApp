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
    public partial class FormReservation : Form
    {
        DataTable tableAvailableRoom;
        DataTable tableSelectedRoom;
        DataTable tableAdditionalItems = new DataTable();

        public FormReservation()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void optionAddNew_CheckedChanged(object sender, EventArgs e)
        {
            dataGridCustomer.Visible = true;
            labelSearch.Visible = true;
            inputSearchCustomer.Visible = true;
        }

        private void optionSearch_CheckedChanged(object sender, EventArgs e)
        {
            dataGridCustomer.Visible = false;
            labelSearch.Visible = false;
            inputSearchCustomer.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID, RoomNumber, RoomFloor, RoomPrice, Description FROM ViewRoom WHERE RoomTypeID=" + inputRoomType.SelectedValue, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tableAvailableRoom = new DataTable();
                da.Fill(tableAvailableRoom);

                dataGridAvailableRooms.DataSource = tableAvailableRoom;
                dataGridAvailableRooms.Columns["ID"].Visible = false;

                tableSelectedRoom = tableAvailableRoom.Clone();
                dataGridSelectedRooms.DataSource = tableSelectedRoom;
                dataGridSelectedRooms.Columns["ID"].Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridAvailableRooms.CurrentRow;

            if (row != null)
            {
                DataRow newRow = tableSelectedRoom.NewRow();
                newRow["ID"] = row.Cells["ID"].Value;
                newRow["RoomNumber"] = row.Cells["RoomNumber"].Value;
                newRow["RoomFloor"] = row.Cells["RoomFloor"].Value;
                newRow["RoomPrice"] = row.Cells["RoomPrice"].Value;
                newRow["Description"] = row.Cells["Description"].Value;
                tableSelectedRoom.Rows.Add(newRow);
                tableSelectedRoom.AcceptChanges();

                dataGridAvailableRooms.Rows.Remove(row);
            }

            //var index = dataGridSelectedRooms.Rows.Add();
            //dataGridSelectedRooms.Rows[index].Cells["ID"].Value = row.Cells["ID"].Value;
            //dataGridSelectedRooms.Rows[index].Cells["RoomNumber"].Value = row.Cells["RoomNumber"].Value;
            //dataGridSelectedRooms.Rows[index].Cells["RoomFloor"].Value = row.Cells["RoomFloor"].Value;
            //dataGridSelectedRooms.Rows[index].Cells["RoomPrice"].Value = row.Cells["RoomPrice"].Value;
            //dataGridSelectedRooms.Rows[index].Cells["Description"].Value = row.Cells["Description"].Value;
            //dataGridAvailableRooms.Rows.Remove(row);

        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_HOTEL_RPLDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dB_HOTEL_RPLDataSet.Item);
            // TODO: This line of code loads data into the 'dB_HOTEL_RPLDataSet.RoomType' table. You can move, or remove it, as needed.
            this.roomTypeTableAdapter.Fill(this.dB_HOTEL_RPLDataSet.RoomType);

            refreshCustomer();

            tableAdditionalItems.Columns.Add("ItemID");
            tableAdditionalItems.Columns.Add("Item");
            tableAdditionalItems.Columns.Add("Quantity");
            tableAdditionalItems.Columns.Add("Price");
            tableAdditionalItems.Columns.Add("Sub Total");

            dataGridItem.DataSource = tableAdditionalItems;
            DataGridViewButtonColumn removeItemBtn = new DataGridViewButtonColumn();
            removeItemBtn.HeaderText = "Option";
            removeItemBtn.Text = "Remove";
            removeItemBtn.Name = "RemoveItem";
            removeItemBtn.UseColumnTextForButtonValue = true;
            dataGridItem.Columns.Insert(5, removeItemBtn);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridSelectedRooms.CurrentRow;

            if (row != null)
            {
                DataRow newRow = tableAvailableRoom.NewRow();
                newRow["ID"] = row.Cells["ID"].Value;
                newRow["RoomNumber"] = row.Cells["RoomNumber"].Value;
                newRow["RoomFloor"] = row.Cells["RoomFloor"].Value;
                newRow["RoomPrice"] = row.Cells["RoomPrice"].Value;
                newRow["Description"] = row.Cells["Description"].Value;
                tableAvailableRoom.Rows.Add(newRow);
                tableAvailableRoom.AcceptChanges();

                dataGridSelectedRooms.Rows.Remove(row);
            }

            //var index = dataGridAvailableRooms.Rows.Add();
            //dataGridAvailableRooms.Rows[index].Cells["ID"].Value = row.Cells["ID"].Value;
            //dataGridAvailableRooms.Rows[index].Cells["RoomNumber"].Value = row.Cells["RoomNumber"].Value;
            //dataGridAvailableRooms.Rows[index].Cells["RoomFloor"].Value = row.Cells["RoomFloor"].Value;
            //dataGridAvailableRooms.Rows[index].Cells["RoomPrice"].Value = row.Cells["RoomPrice"].Value;
            //dataGridAvailableRooms.Rows[index].Cells["Description"].Value = row.Cells["Description"].Value;
            //dataGridSelectedRooms.Rows.Remove(row);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputPrice_TextChanged(object sender, EventArgs e)
        {
            getSubtotal();
        }

        private void inputQuantity_ValueChanged(object sender, EventArgs e)
        {
            getSubtotal();
        }

        private void getSubtotal()
        {
            if (inputQuantity.Text != "" && inputPrice.Text != "")
            {
                int subtotal = int.Parse(inputQuantity.Value.ToString()) * int.Parse(inputPrice.Text);

                inputSubTotal.Text = subtotal.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            DataRow row = tableAdditionalItems.NewRow();
            row["ItemID"] = inputItem.SelectedValue;
            row["Item"] = inputItem.Text;
            row["Quantity"] = inputQuantity.Text;
            row["Price"] = inputPrice.Text;
            row["Sub Total"] = int.Parse(inputPrice.Text) * int.Parse(inputQuantity.Text);
            tableAdditionalItems.Rows.Add(row);
            tableAdditionalItems.AcceptChanges();
        }

        private void inputItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Item WHERE ID='" + inputItem.SelectedValue + "'", conn);
                SqlDataReader item = cmd.ExecuteReader();
                if (item.Read())
                {
                    inputPrice.Text = item["RequestPrice"].ToString();
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

        private void dataGridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridItem.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name == "RemoveItem")
                {
                    dataGridItem.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void inputStaying_ValueChanged(object sender, EventArgs e)
        {
            if (inputStaying.Text != "")
            {
                int durationNights = int.Parse(inputStaying.Text);
                inputCheckOut.Text = inputCheckIn.Value.AddDays(durationNights).ToLongDateString().ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String CustomerID;

            if (optionAddNew.Checked)
            {
                CustomerID = insertNewCustomer();
            }
            else
            {
                CustomerID = dataGridCustomer.CurrentRow.Cells["ID"].Value.ToString();
            }

            if (dataGridSelectedRooms.Rows.Count != 0)
            {
                insertNewReservation(CustomerID);
            }
            else
            {
                MessageBox.Show("Select at least one room.");
            }

        }

        private void insertNewReservation(string customerID)
        {
            //try
            //{
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                string bookingCode = Helper.generateBookingCode();
                SqlCommand cmdReservation = new SqlCommand("INSERT INTO Reservation OUTPUT inserted.ID VALUES('" + inputCheckIn.Text + "', '" + LoggedInUser.UserID + "', '" + customerID + "', '" + bookingCode + "')", conn);
                SqlDataReader reservation = cmdReservation.ExecuteReader();
                reservation.Read();
                string reservationID = reservation["ID"].ToString();
                reservation.Close();

                foreach (DataGridViewRow room
                    in dataGridSelectedRooms.Rows)
                {
                    SqlCommand cmdReservationRoom = new SqlCommand("INSERT INTO ReservationRoom OUTPUT inserted.ID VALUES('" + reservationID + "', '" + room.Cells["ID"].Value + "', '" + inputCheckIn.Text + "', '" + inputStaying.Text + "', '" + room.Cells["RoomPrice"].Value + "', '" + inputCheckIn.Text + "', '" + inputCheckOut.Text + "')", conn);
                    SqlDataReader reservationRoom = cmdReservationRoom.ExecuteReader();
                    reservationRoom.Read();
                    string reservationRoomID = reservationRoom["ID"].ToString();
                    reservationRoom.Close();

                    foreach (DataGridViewRow item in dataGridItem.Rows)
                    {
                        SqlCommand cmdAdditionalItem = new SqlCommand("INSERT INTO ReservationRequestItem VALUES('" + reservationRoomID + "', '" + item.Cells["ItemID"].Value + "', '" + item.Cells["Quantity"].Value + "', '" + item.Cells["Sub Total"].Value + "')", conn);
                        MessageBox.Show(cmdAdditionalItem.CommandText);
                        cmdAdditionalItem.ExecuteNonQuery();
                    }
                }

                //foreach (DataGridViewRow item in dataGridItem.Rows)
                //{
                //    SqlCommand cmdReservationItem = new SqlCommand("INSERT INTO ReservationRequestItem VALUES('" +  + "')", conn);
                //}

                MessageBox.Show("New reservation added successfully!");

            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //    throw;
            //}
        }

        private string insertNewCustomer()
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();

                int birthDate = int.Parse(inputDateOfBirth.Value.ToString("yyyyMMdd"));
                int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int age = (now - birthDate) / 10000;
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer VALUES('" + inputCustomerName.Text + "', '" + inputNIK.Text + "', '" + inputEmail.Text + "', '" + inputGender.Text + "', '" + inputPhoneNumber.Text + "', '" + age + "')", conn);
                cmd.ExecuteNonQuery();

                refreshCustomer();
                SqlCommand cmdCustomerID = new SqlCommand("SELECT ID FROM Customer WHERE NIK=" + inputNIK.Text, conn);
                SqlDataReader customer = cmdCustomerID.ExecuteReader();
                customer.Read();

                optionSearch.Checked = true;
                MessageBox.Show("New customer added successfully");

                return customer["ID"].ToString();

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

        private void refreshCustomer()
        {
            SqlConnection conn = Helper.getConnected();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridCustomer.DataSource = dt;
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

        private void inputCheckOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void inputCheckIn_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
