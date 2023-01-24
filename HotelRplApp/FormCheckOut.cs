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
    public partial class FormCheckOut : Form
    {
        private string reservationRoomID;
        private DataTable tableItems = new DataTable();
        private DataTable tableFoodsAndDrinks = new DataTable();
        int totalItems = 0;
        int totalMenu = 0;
        private int totalPrice;

        public FormCheckOut()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_HOTEL_RPLDataSet.ItemStatus' table. You can move, or remove it, as needed.
            this.itemStatusTableAdapter.Fill(this.dB_HOTEL_RPLDataSet.ItemStatus);
            // TODO: This line of code loads data into the 'dB_HOTEL_RPLDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dB_HOTEL_RPLDataSet.Item);
            // TODO: This line of code loads data into the 'dB_HOTEL_RPLDataSet.ReservationRoom' table. You can move, or remove it, as needed.
            this.reservationRoomTableAdapter.Fill(this.dB_HOTEL_RPLDataSet.ReservationRoom);
            // TODO: This line of code loads data into the 'dB_HOTEL_RPLDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.dB_HOTEL_RPLDataSet.Room);

            inputRoom.SelectedItem = null;
            inputItem.SelectedItem = null;

            tableItems.Columns.Add("ItemID");
            tableItems.Columns.Add("Item");
            tableItems.Columns.Add("ItemStatusID");
            tableItems.Columns.Add("Quantity");
            tableItems.Columns.Add("Compensation Fee");
            tableItems.Columns.Add("Sub Total");
            dataGridItem.DataSource = tableItems;
            DataGridViewButtonColumn removeBtn = new DataGridViewButtonColumn();
            removeBtn.HeaderText = "Option";
            removeBtn.Text = "Remove";
            removeBtn.UseColumnTextForButtonValue = true;
            dataGridItem.Columns.Add(removeBtn);
        }

        private void loadFoodsAndDrinks()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewFoodsAndDrinksCheckOut WHERE ReservationRoomID='" + reservationRoomID + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tableFoodsAndDrinks);

                dataGridFoodsAndDrinks.DataSource = tableFoodsAndDrinks;
                dataGridFoodsAndDrinks.Columns["ReservationRoomID"].Visible = false;
                dataGridFoodsAndDrinks.Columns["FDID"].Visible = false;
            }

            totalMenu = 0;
            foreach (DataGridViewRow menu in dataGridFoodsAndDrinks.Rows)
            {
                totalMenu += Convert.ToInt32(menu.Cells["Sub Total"].Value);
            }
            labelTotalFoodsAndDrinks.Text = "Total Price : Rp. " + totalMenu.ToString();
            getTotalPrice();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inputRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID FROM ReservationRoom WHERE RoomID='" + inputRoom.SelectedValue + "'", conn);
                SqlDataReader reservation = cmd.ExecuteReader();
                if (reservation.Read())
                {
                    reservationRoomID = reservation["ID"].ToString();
                    loadFoodsAndDrinks();
                }
            }
        }

        private void dataGridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            DataRow existItem = tableItems.AsEnumerable().SingleOrDefault(x => x.Field<string>("Item") == inputItem.Text);
            if (existItem != null)
            {
                int newQuantity = Convert.ToInt32(existItem["Quantity"]) + Convert.ToInt32(inputQuantity.Value);
                existItem["Quantity"] = newQuantity;
            }
            else
            {

                DataRow newItem = tableItems.NewRow();
                newItem["ItemID"] = inputItem.SelectedValue;
                newItem["Item"] = inputItem.Text;
                newItem["ItemStatusID"] = inputItemStatus.SelectedValue;
                newItem["Quantity"] = inputQuantity.Text;
                newItem["Compensation Fee"] = inputCompensation.Text;
                newItem["Sub Total"] = inputSubTotal.Text;
                tableItems.Rows.Add(newItem);
                tableItems.AcceptChanges();
            }

            totalItems = 0;
            foreach (DataRow row in tableItems.Rows)
            {
                totalItems += int.Parse(row["Sub Total"].ToString());
            }
            labelTotalItem.Text = "Total Price : Rp. " + totalItems.ToString();
            getTotalPrice();
        }

        private void getTotalPrice()
        {
            totalPrice = totalItems + totalMenu;
            labelTotalPrice.Text = "Total Charge : Rp. " + totalPrice.ToString();
        }

        private void inputItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Item WHERE ID='" + inputItem.SelectedValue + "'", conn);
                SqlDataReader item = cmd.ExecuteReader();
                if (item.Read())
                {
                    inputCompensation.Text = item["CompensationFee"].ToString();
                }
            }

            getSubtotal();
        }

        private void getSubtotal()
        {
            if (inputItem.Text != "" && inputQuantity.Value.ToString() != "")
            {
                int subtotal = int.Parse(inputCompensation.Text) * (int)inputQuantity.Value;
                inputSubTotal.Text = subtotal.ToString();
            }
        }

        private void inputQuantity_ValueChanged(object sender, EventArgs e)
        {
            getSubtotal();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                foreach (DataGridViewRow item in dataGridItem.Rows)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO ReservationCheckOut VALUES('" + reservationRoomID + "', '" + item.Cells["ItemID"].Value + "', '" + item.Cells["ItemStatusID"].Value + "', '" + item.Cells["Quantity"].Value + "', '" + item.Cells["Sub Total"].Value + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Checkout successful!");
            }
        }
    }
}
