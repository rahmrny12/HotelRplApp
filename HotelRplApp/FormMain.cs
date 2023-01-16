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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMainAdmin_Load(object sender, EventArgs e)
        {
            labelDateAndTime.Text = DateTime.Now.ToString();

            if (LoggedInUser.JobID == "1")
            {
                labelJob.Text = "Admin";
                lockFrontOffice();
            }
            else
            {
                labelJob.Text = "Front Office";
                lockAdmin();
            }
        }

        void lockAdmin()
        {
            masterToolStripMenuItem.Visible = false;
            employeeToolStrip.Visible = false;
        }

        void lockFrontOffice()
        {
            transactionToolStripMenuItem.Visible = false;
            reportToolStripMenuItem.Visible = false;
            checkInToolStrip.Visible = false;
            reservationToolStrip.Visible = false;
            checkOutToolStrip.Visible = false;
        }

        private void logOut(object sender, EventArgs e)
        {
            LoggedInUser.Name = null;
            LoggedInUser.Username = null;
            LoggedInUser.JobID = null;

            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void exitToolStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoomType formRoomType = new FormRoomType();
            formRoomType.ShowDialog();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoom formRoom = new FormRoom();
            formRoom.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.ShowDialog();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItem formItem = new FormItem();
            formItem.ShowDialog();
        }

        private void foodAndDrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFoodAndDrink formFoodAndDrink = new FormFoodAndDrink();
            formFoodAndDrink.ShowDialog();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservation formReservation = new FormReservation();
            formReservation.Show();
        }
    }
}
