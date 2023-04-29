using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRPLApp3.Reservation
{
    public partial class FormCheckOut : Form
    {
        DataTable tableCheckoutItem = new DataTable();
        int totalItem = 0;
        int totalFD = 0;
        private int totalCharge;

        public FormCheckOut()
        {
            InitializeComponent();
        }

        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            loadRoomsOccupied();
            loadItems();
            loadItemStatuses();

            tableCheckoutItem.Columns.Add("ReservationRoomID");
            tableCheckoutItem.Columns.Add("Item");
            tableCheckoutItem.Columns.Add("ItemID");
            tableCheckoutItem.Columns.Add("CompensationFee");
            tableCheckoutItem.Columns.Add("ItemStatusID");
            tableCheckoutItem.Columns.Add("Qty");
            tableCheckoutItem.Columns.Add("Subtotal");

            dataGridItem.DataSource = tableCheckoutItem;
            dataGridItem.Columns["ReservationRoomID"].Visible = false;
            dataGridItem.Columns["ItemID"].Visible = false;
            dataGridItem.Columns["ItemStatusID"].Visible = false;

            loadFDCheckOut();
        }

        private void loadFDCheckOut()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewFDCheckOut WHERE ReservationRoomID=@ID", conn);
                cmd.Parameters.AddWithValue("@ID", inputRoom.SelectedValue);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridFoodsAndDrinks.DataSource = dt;

                int total = 0;
                foreach (DataGridViewRow menu in dataGridFoodsAndDrinks.Rows)
                {
                    total += Convert.ToInt32(menu.Cells["TotalPrice"].Value);
                }
                totalFD = total;
                labelTotalFoodsAndDrinks.Text = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", totalFD);
                //labelTotalFoodsAndDrinks.Text = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {N:0}", totalFD);
                getTotalCharge();
            }
        }

        private void loadItems()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Item", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                inputItem.DisplayMember = "Name";
                inputItem.DataSource = dt;
            }
        }

        private void loadItemStatuses()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ItemStatus", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                inputItemStatus.DisplayMember = "Name";
                inputItemStatus.ValueMember = "ID";
                inputItemStatus.DataSource = dt;
            }
        }

        private void loadRoomsOccupied()
        {   
            using (SqlConnection conn = Helper.getConnected())
                {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetActiveRooms", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tableRooms = new DataTable();
                da.Fill(tableRooms);

                inputRoom.DisplayMember = "RoomNumber";
                inputRoom.ValueMember = "ReservationRoomID";
                inputRoom.DataSource = tableRooms;
            }
        }

        private void inputItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputCompensation.Text = ((DataRowView)inputItem.SelectedValue).Row.Field<int>("CompensationFee").ToString();
            getSubTotal();
        }

        private void getSubTotal()
        {
            if (inputItem.Text != "" && inputQuantity.Text != "" && inputQuantity.Text.All(char.IsDigit))
            {
                int price = Convert.ToInt32(((DataRowView)inputItem.SelectedValue).Row.Field<int>("RequestPrice"));
                int quantity = Convert.ToInt32(inputQuantity.Text);
                int subtotal = price * quantity;
                inputSubTotal.Text = subtotal.ToString();
            }
        }


        private void dataGridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                DataRowView selectedItem = (DataRowView)inputItem.SelectedValue;

                DataRow oldRow = tableCheckoutItem.AsEnumerable()
                            .SingleOrDefault(x => x.Field<string>("Item") == selectedItem.Row.Field<string>("Name"));

                if (oldRow == null)
                {
                    DataRow row = tableCheckoutItem.NewRow();
                    row["ReservationRoomID"] = inputRoom.SelectedValue;
                    row["Item"] = selectedItem.Row.Field<string>("Name");
                    row["ItemID"] = selectedItem.Row.Field<int>("ID");
                    row["CompensationFee"] = selectedItem.Row.Field<int>("CompensationFee");
                    row["ItemStatusID"] = inputItemStatus.SelectedValue;
                    row["Qty"] = inputQuantity.Text;
                    row["Subtotal"] = inputSubTotal.Text;
                    tableCheckoutItem.Rows.Add(row);
                    tableCheckoutItem.AcceptChanges();
                } else
                {
                    oldRow["Qty"] = Convert.ToInt32(oldRow["Qty"]) + Convert.ToInt32(inputQuantity.Text);

                    int price = Convert.ToInt32(((DataRowView)inputItem.SelectedValue).Row.Field<int>("RequestPrice"));
                    int quantity = Convert.ToInt32(oldRow["Qty"]);
                    int subtotal = price * quantity;
                    oldRow["Subtotal"] = subtotal;
                }

                int total = 0;
                foreach (DataGridViewRow item in dataGridItem.Rows)
                {
                    total += Convert.ToInt32(item.Cells["Subtotal"].Value);
                }
                totalItem = total;
                labelTotalItem.Text = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", totalItem);
                getTotalCharge();
            }
        }

        private void getTotalCharge()
        {
            totalCharge = totalItem + totalFD;
            string rupiah = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", totalCharge);
            labelTotalPrice.Text = rupiah;
        }

        private bool ValidateInputs()
        {
            if (inputItem.Text == "" || inputQuantity.Text == "" || inputSubTotal.Text == "" || inputItemStatus.Text == "")
            {
                MessageBox.Show("Lengkapi data item");
                return false;
            } else if (!inputQuantity.Text.All(char.IsDigit)) {
                MessageBox.Show("Lengkapi data item");
                return false;
            }
            return true;
        }

        private void inputQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            getSubTotal();
        }

        private void inputQuantity_ValueChanged(object sender, EventArgs e)
        {
            getSubTotal();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berhasil Checkout.");
            printNota.Print();
        }

        private void inputRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFDCheckOut();
        }

        private void printNota_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font headingFont = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            Font bodyFont = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            Font importantFont = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

            int currentHeight = 10;
            e.Graphics.DrawString("HOTEL RPL", headingFont, Brushes.Black, 5, currentHeight);
            e.Graphics.DrawString("Jalan Titik Koma Line No. 23", bodyFont, Brushes.Black, 5, currentHeight += 35);

            e.Graphics.DrawString("Item \t CompensationFee \t Qty \t Subtotal", bodyFont, Brushes.Black, 5, currentHeight += 40);
            e.Graphics.DrawString("---------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 20);

            foreach (DataGridViewRow item in dataGridItem.Rows)
            {
                e.Graphics.DrawString(item.Cells["Item"].Value + "\t" + item.Cells["CompensationFee"].Value + "\t\t\t" + item.Cells["Qty"].Value + "\t" + item.Cells["Subtotal"].Value + "\t", bodyFont, Brushes.Black, 5, currentHeight += 20);
                e.Graphics.DrawString("---------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 20);
            }

            e.Graphics.DrawString("Name \t\t\t Price \t Qty \t\t Subtotal", bodyFont, Brushes.Black, 5, currentHeight += 60);
            e.Graphics.DrawString("---------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 20);

            foreach (DataGridViewRow menu in dataGridFoodsAndDrinks.Rows)
            {
                e.Graphics.DrawString(menu.Cells["Name"].Value + "\t\t" + menu.Cells["Price"].Value + "\t" + menu.Cells["Qty"].Value + "\t\t" + menu.Cells["TotalPrice"].Value, bodyFont, Brushes.Black, 5, currentHeight += 20);
                e.Graphics.DrawString("---------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 20);
            }

            e.Graphics.DrawString("Kasir : " + LoggedInUser.Name, bodyFont, Brushes.Black, 5, currentHeight += 40);
            e.Graphics.DrawString("Total Biaya: " + string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", totalCharge), bodyFont, Brushes.Black, 5, currentHeight += 30);
            e.Graphics.DrawString("Terimakasih telah menggunakan layanan kami..!", importantFont, Brushes.Black, 5, currentHeight += 40);

            e.HasMorePages = false;
        }
    }
}
