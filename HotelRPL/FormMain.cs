using HotelRPLApp3.Master;
using HotelRPLApp3.Report;
using HotelRPLApp3.Reservation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRPLApp3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            currentTimer.Start();

            if (LoggedInUser.JobID == "1")
            {
                transactionToolStripMenuItem.Visible = false;
                reportToolStripMenuItem.Visible = false;
                checkInToolStrip.Visible = false;
                reservationToolStrip.Visible = false;
                checkoutToolStrip.Visible = false;
                labelJob.Text = "Admin";
            }
            else
            {
                masterToolStripMenuItem.Visible = false;
                employeeToolStrip.Visible = false;
                labelJob.Text = "Front Office";
            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.MdiParent = this;
            formEmployee.Show();
        }

        private void foodAndDrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFoodsAndDrinks formFD = new FormFoodsAndDrinks();
            formFD.MdiParent = this;
            formFD.Show();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItem formItem = new FormItem();
            formItem.MdiParent = this;
            formItem.Show();
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoomType formRoomType = new FormRoomType();
            formRoomType.MdiParent = this;
            formRoomType.Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoom formRoom = new FormRoom();
            formRoom.MdiParent = this;
            formRoom.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStrip_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeeToolStrip_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.MdiParent = this;
            formEmployee.Show();
        }

        private void currentTimer_Tick(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToString();
        }

        private void reservationToolStrip_Click(object sender, EventArgs e)
        {
            FormReservation formReservation = new FormReservation();
            formReservation.MdiParent = this;
            formReservation.Show();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservation formReservation = new FormReservation();
            formReservation.MdiParent = this;
            formReservation.Show();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCheckIn formCheckIn = new FormCheckIn();
            formCheckIn.MdiParent = this;
            formCheckIn.Show();
        }

        private void checkInToolStrip_Click(object sender, EventArgs e)
        {
            FormCheckIn formCheckIn = new FormCheckIn();
            formCheckIn.MdiParent = this;
            formCheckIn.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCheckOut formCheckOut = new FormCheckOut();
            formCheckOut.MdiParent = this;
            formCheckOut.Show();
        }

        private void checkoutToolStrip_Click(object sender, EventArgs e)
        {
            FormCheckOut formCheckOut = new FormCheckOut();
            formCheckOut.MdiParent = this;
            formCheckOut.Show();
        }

        private void checkInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.MdiParent = this;
            formReport.Show();
        }

        private void guestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChartPreview formChartPreview = new FormChartPreview();
            formChartPreview.MdiParent = this;
            formChartPreview.Show();
        }
    }
}
