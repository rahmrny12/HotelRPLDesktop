using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelRPLApp3.Reservation
{
    public partial class FormReservation : Form
    {
        private string selectedCustomer;
        private string currentCustomerName;
        DataTable tableAvailableRooms = new DataTable();
        DataTable tableSelectedRooms = new DataTable();
        DataTable tableAdditionalItem = new DataTable();
        private bool alreadyCloned;
        private string currentBookingCode;

        public FormReservation()
        {
            InitializeComponent();
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            var genders = new[]
            {
                new { Gender = "Male", Value = "M" },
                new { Gender = "Female", Value = "F" }
            };

            inputGender.DataSource = genders;
            inputGender.DisplayMember = "Gender";
            inputGender.ValueMember = "Value";

            DataGridViewCheckBoxColumn chooseCustomer = new DataGridViewCheckBoxColumn();
            chooseCustomer.Name = "Choose";
            chooseCustomer.HeaderText = "Choose";
            dataGridViewCustomer.Columns.Insert(0, chooseCustomer);

            loadCustomers();
            loadRoomTypes();
            loadItems();

            tableAdditionalItem.Columns.Add("RoomID");
            tableAdditionalItem.Columns.Add("ItemID");
            tableAdditionalItem.Columns.Add("Item");
            tableAdditionalItem.Columns.Add("Quantity");
            tableAdditionalItem.Columns.Add("Price");
            tableAdditionalItem.Columns.Add("Subtotal");

            dataGridViewAdditionalItems.DataSource = tableAdditionalItem;
            dataGridViewAdditionalItems.Columns["RoomID"].Visible = false;
            dataGridViewAdditionalItems.Columns["ItemID"].Visible = false;
            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.Name = "btnRemove";
            btnRemove.Text = "Remove";
            btnRemove.UseColumnTextForButtonValue = true;
            dataGridViewAdditionalItems.Columns.Add(btnRemove);

            GetCheckOutDate();
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

        private void loadRoomTypes()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM RoomType", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                inputRoomType.DataSource = dt;
                inputRoomType.DisplayMember = "Name";
                inputRoomType.ValueMember = "ID";
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewAvailableRooms.CurrentRow;

            if (selectedRow != null)
            {
                DataRow row = tableSelectedRooms.NewRow();
                row["ID"] = selectedRow.Cells["ID"].Value.ToString();
                row["RoomNumber"] = selectedRow.Cells["RoomNumber"].Value.ToString();
                row["RoomFloor"] = selectedRow.Cells["RoomFloor"].Value.ToString();
                row["RoomPrice"] = selectedRow.Cells["RoomPrice"].Value.ToString();
                row["Description"] = selectedRow.Cells["Description"].Value.ToString();
                tableSelectedRooms.Rows.Add(row);
                tableSelectedRooms.AcceptChanges();

                dataGridViewAvailableRooms.Rows.Remove(selectedRow);
                getTotal();
            }
        }

        private void optionAddNew_CheckedChanged(object sender, EventArgs e)
        {
            if (optionAddNew.Checked)
            {
                dataGridViewCustomer.Visible = false;
                inputSearchCustomer.Visible = false;
            }
        }

        private void optionSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (optionSearch.Checked)
            {
                dataGridViewCustomer.Visible = true;
                inputSearchCustomer.Visible = true;
                loadCustomers();
            }
        }

        private void loadCustomers()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewCustomer.DataSource = dt;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                string customerID;
                if (optionAddNew.Checked)
                {
                    customerID = addNewCustomer();
                } else
                {
                    customerID = dataGridViewCustomer.CurrentRow.Cells["ID"].Value.ToString();
                }

                if (customerID != null)
                {
                    addReservation(customerID);
                }
            }
        }

        private void addReservation(string customerID)
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Reservation OUTPUT inserted.ID, inserted.BookingCode, inserted.CustomerID VALUES (" +
                    "@DateTime, " +
                    "@EmployeeID, " +
                    "@CustomerID, " +
                    "@BookingCode " +
                    ")", conn);
                cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
                cmd.Parameters.AddWithValue("@EmployeeID", LoggedInUser.UserID);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@BookingCode", Helper.getBookingCode());

                SqlDataReader insertedReservation = cmd.ExecuteReader();
                if (insertedReservation.Read())
                {
                    string insertedReservationID = insertedReservation["ID"].ToString();
                    currentBookingCode = insertedReservation["BookingCode"].ToString();
                    string insertedCustomerID = insertedReservation["CustomerID"].ToString();
                    insertedReservation.Close();

                    SqlCommand cmdCustomer = new SqlCommand("SELECT Name FROM Customer WHERE ID=" + insertedCustomerID, conn);
                    var customer = cmdCustomer.ExecuteScalar();
                    if (customer != null)
                    {
                        currentCustomerName = customer.ToString();
                    }


                    foreach (DataGridViewRow room in dataGridViewSelectedRooms.Rows)
                    {
                        SqlCommand cmdRoom = new SqlCommand("INSERT INTO ReservationRoom (ReservationID, RoomID, DurationNights, RoomPrice, CheckInDateTime, CheckOutDateTime) OUTPUT inserted.ID, inserted.RoomID VALUES (" +
                            "@ReservationID, " +
                            "@RoomID, " +
                            "@DurationNights, " +
                            "@RoomPrice, " +
                            "@CheckInDateTime, " +
                            "@CheckOutDateTime " +
                        ")", conn);
                        cmdRoom.Parameters.AddWithValue("@ReservationID", insertedReservationID);
                        cmdRoom.Parameters.AddWithValue("@RoomID", room.Cells["ID"].Value);
                        cmdRoom.Parameters.AddWithValue("@DurationNights", inputStaying.Value);
                        cmdRoom.Parameters.AddWithValue("@RoomPrice", room.Cells["RoomPrice"].Value);
                        cmdRoom.Parameters.AddWithValue("@CheckInDateTime", inputCheckIn.Value);
                        cmdRoom.Parameters.AddWithValue("@CheckOutDateTime", inputCheckOut.Value);

                        using (SqlDataReader insertedRoom = cmdRoom.ExecuteReader())
                        {
                            if (insertedRoom.Read())
                            {
                                string insertedRoomReservationID = insertedRoom["ID"].ToString();
                                string insertedRoomID = insertedRoom["RoomID"].ToString();
                                insertedRoom.Close();

                                foreach (DataGridViewRow item in dataGridViewAdditionalItems.Rows)
                                {
                                    if (item.Cells["RoomID"].Value.ToString() == insertedRoomID)
                                    {
                                        SqlCommand cmdItem = new SqlCommand("INSERT INTO ReservationRequestItem VALUES (" +
                                            "@ReservationRoomID, " +
                                            "@ItemID, " +
                                            "@Qty, " +
                                            "@TotalPrice " +
                                            ")", conn);
                                        cmdItem.Parameters.AddWithValue("@ReservationRoomID", insertedRoomReservationID);
                                        cmdItem.Parameters.AddWithValue("@ItemID", item.Cells["ItemID"].Value);
                                        cmdItem.Parameters.AddWithValue("@Qty", item.Cells["Quantity"].Value);
                                        cmdItem.Parameters.AddWithValue("@TotalPrice", item.Cells["Subtotal"].Value);

                                        cmdItem.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }

                    MessageBox.Show("Berhasil mencatat data reservasi");
                    using (PrintDialog pd = new PrintDialog())

                    {

                        if (pd.ShowDialog() == DialogResult.OK)
                        {

                            printDocumentNota.PrinterSettings = pd.PrinterSettings;

                            printDocumentNota.Print();



                        }

                    }
                }

                
            }
        }
        private string addNewCustomer()
        {
            var now = Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd"));
            var birthDay = Convert.ToInt32(inputDateOfBirth.Value.ToString("yyyyMMdd"));
            int age = (now - birthDay) / 10000;

            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Customer OUTPUT inserted.Name, inserted.ID VALUES (" +
                    "@Name, " +
                    "@NIK, " +
                    "@Email, " +
                    "@Gender, " +
                    "@PhoneNumber, " +
                    "@Age " +
                    ")", conn);
                cmd.Parameters.AddWithValue("@Name", inputName.Text);
                cmd.Parameters.AddWithValue("@NIK", inputNIK.Text);
                cmd.Parameters.AddWithValue("@Email", inputEmail.Text);
                cmd.Parameters.AddWithValue("@Gender", inputGender.SelectedValue);
                cmd.Parameters.AddWithValue("@PhoneNumber", inputPhone.Text);
                cmd.Parameters.AddWithValue("@Age", age.ToString());

                //cmd.ExecuteNonQuery();
                SqlDataReader customer = cmd.ExecuteReader();
                if (customer.Read())
                {
                    MessageBox.Show("Customer dengan nama " + customer["Name"].ToString() + " berhasil ditambahkan.");
                }
                return customer["ID"].ToString();
            }
        }

        private bool ValidateInputs()
        {
            if (optionAddNew.Checked)
            {
                if (
                    inputName.Text == "" ||
                    inputNIK.Text == "" ||
                    inputEmail.Text == "" ||
                    inputGender.Text == "" ||
                    inputPhone.Text == "" ||
                    inputDateOfBirth.Text == ""
                    )
                {
                    MessageBox.Show("Lengkapi data customer");
                    return false;
                }
            } else if (optionSearch.Checked)
            {
                if (selectedCustomer == null)
                {
                    MessageBox.Show("Pilih customer yang tersedia atau tambahkan yang baru.");
                    return false;
                }
            }
            
            if (
                inputCheckIn.Text == "" ||
                inputStaying.Text == "" ||
                inputCheckOut.Text == ""
                )
            {
                MessageBox.Show("Lengkapi data reservasi.");
                return false;
            } else if (dataGridViewSelectedRooms.Rows.Count == 0)
            {
                MessageBox.Show("Pilih setidaknya satu kamar.");
                return false;
            } else if (dataGridViewAdditionalItems.Rows.Count == 0)
            {
                if (MessageBox.Show("Yakin tidak ingin item tambahan?", "Information", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return false;
                }
            }
            return true;
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewCustomer.Rows[e.RowIndex];

            if (e.ColumnIndex == 0)
            {
                dataGridViewCustomer.EndEdit();

                var isChecked = (bool)selectedRow.Cells[e.ColumnIndex].Value;

                if (isChecked)
                {
                    selectedCustomer = selectedRow.Cells["ID"].Value.ToString();
                    foreach (DataGridViewRow row in dataGridViewCustomer.Rows)
                    {
                        if (row.Index != e.RowIndex)
                        {
                            row.Cells["Choose"].Value = !isChecked;
                        }
                    }
                }
            }

            //const int chkBoxColumnIndex = 0;

            //var dataGridView = (DataGridView)sender;

            //if (e.ColumnIndex == chkBoxColumnIndex)
            //{
            //    dataGridView.EndEdit();

            //    var isChecked = (bool)dataGridView[e.ColumnIndex, e.RowIndex].Value;

            //    if (isChecked)
            //    {
            //        foreach (DataGridViewRow row in dataGridView.Rows)
            //        {
            //            if (row.Index != e.RowIndex)
            //                row.Cells[chkBoxColumnIndex].Value = !isChecked;
            //        }
            //    }
            //}
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            if (inputRoomType.Text != "")
            {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("EXEC GetAvailableRooms @CheckInDate, @SelectedRoomType", conn);
                    cmd.Parameters.AddWithValue("@CheckInDate", inputCheckIn.Value);
                    cmd.Parameters.AddWithValue("@SelectedRoomType", inputRoomType.SelectedValue);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    tableAvailableRooms.Clear();
                    da.Fill(tableAvailableRooms);

                    // hapus data yang double di available room
                    List<DataRow> toDelete = new List<DataRow>();
                    foreach (DataRow avroomrow in tableAvailableRooms.Rows)
                    {
                        foreach (DataRow selroomrow in tableSelectedRooms.Rows)
                        {
                            if (avroomrow.Field<int>("ID") == selroomrow.Field<int>("ID"))
                            {
                                toDelete.Add(avroomrow);
                            }
                        }
                    }

                    foreach (DataRow row in toDelete)
                    {
                        tableAvailableRooms.Rows.Remove(row);
                    }
                    tableAvailableRooms.AcceptChanges();
                    tableSelectedRooms.AcceptChanges();

                    dataGridViewAvailableRooms.DataSource = tableAvailableRooms;
                    if (!alreadyCloned)
                    {
                        CloneRoomTable();
                        alreadyCloned = true;
                    }

                    dataGridViewAvailableRooms.Columns["ID"].Visible = false;
                    dataGridViewAvailableRooms.Columns["RoomType"].Visible = false;
                    dataGridViewAvailableRooms.Columns["RoomTypeID"].Visible = false;
                }
            } else
            {
                MessageBox.Show("Pilih tipe kamar dahulu.");
            }
        }

        private void CloneRoomTable()
        {
            tableSelectedRooms = tableAvailableRooms.Clone();
            dataGridViewSelectedRooms.DataSource = tableSelectedRooms;
            dataGridViewSelectedRooms.Columns["ID"].Visible = false;
            dataGridViewSelectedRooms.Columns["RoomType"].Visible = false;
            dataGridViewSelectedRooms.Columns["RoomTypeID"].Visible = false;
        }

        private void inputStaying_ValueChanged(object sender, EventArgs e)
        {
            GetCheckOutDate();
        }

        private void GetCheckOutDate()
        {
            var checkIn = inputCheckIn.Value;
            inputCheckOut.Value = checkIn.AddDays(Convert.ToInt32(inputStaying.Value));
        }

        private void inputSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (inputSearchCustomer.Text != null)
            {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE Name LIKE '%" + inputSearchCustomer.Text + "%'", conn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewCustomer.DataSource = dt;
                }
            }
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewSelectedRooms.CurrentRow;

            if (selectedRow != null)
            {
                DataRow row = tableAvailableRooms.NewRow();
                row["ID"] = selectedRow.Cells["ID"].Value.ToString();
                row["RoomNumber"] = selectedRow.Cells["RoomNumber"].Value.ToString();
                row["RoomFloor"] = selectedRow.Cells["RoomFloor"].Value.ToString();
                row["RoomPrice"] = selectedRow.Cells["RoomPrice"].Value.ToString();
                row["Description"] = selectedRow.Cells["Description"].Value.ToString();
                tableAvailableRooms.Rows.Add(row);
                tableAvailableRooms.AcceptChanges();

                dataGridViewSelectedRooms.Rows.Remove(selectedRow);
                getTotal();
            }
        }

        private void inputItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputItem.Text != "")
            {
                inputPrice.Text = ((DataRowView)inputItem.SelectedValue).Row.Field<int>("RequestPrice").ToString();
                getSubTotal();
            }
        }

        private void getSubTotal()
        {
            if (inputItem.Text != "" && inputQuantity.Text != "" && inputQuantity.Text.All(char.IsDigit))
            {
                int price = Convert.ToInt32(inputPrice.Text);
                int quantity = Convert.ToInt32(inputQuantity.Text);
                int subtotal = price * quantity;
                inputSubtotal.Text = subtotal.ToString();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (inputItem.SelectedText != "" ||
                inputQuantity.Text != "" ||
                inputPrice.Text != "" ||
                inputSubtotal.Text != ""
                )
            {
                if (dataGridViewSelectedRooms.CurrentRow != null)
                {
                    DataRow row = tableAdditionalItem.NewRow();
                    row["RoomID"] = dataGridViewSelectedRooms.CurrentRow.Cells["ID"].Value;
                    row["ItemID"] = ((DataRowView)inputItem.SelectedValue).Row.Field<int>("ID");
                    row["Item"] = inputItem.Text;
                    row["Quantity"] = Convert.ToInt32(inputQuantity.Text);
                    row["Price"] = Convert.ToInt32(inputPrice.Text);
                    row["Subtotal"] = Convert.ToInt32(inputSubtotal.Text);
                    tableAdditionalItem.Rows.Add(row);
                    tableAdditionalItem.AcceptChanges();

                    getTotal();
                } else
                {
                    MessageBox.Show("Klik di kamar mana item akan ditambahkan.");
                }
            }
        }

        private void inputQuantity_TextChanged(object sender, EventArgs e)
        {
            getSubTotal();
        }

        private void getTotal()
        {
            int total = 0;

            foreach (DataGridViewRow room in dataGridViewSelectedRooms.Rows)
            {
                int price = Convert.ToInt32(room.Cells["RoomPrice"].Value);
                int duration = Convert.ToInt32(inputStaying.Value);
                total += price * duration;
            }

            foreach (DataGridViewRow item in dataGridViewAdditionalItems.Rows)
            {
                int price = Convert.ToInt32(item.Cells["Price"].Value);
                int quantity = Convert.ToInt32(item.Cells["Quantity"].Value);
                total += price * quantity;
            }

            labelTotal.Text = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", total);
        }

        private void printDocumentNota_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font headingFont = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            Font bodyFont = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
            Font importantFont = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);

            int currentHeight = 10;
            e.Graphics.DrawString("HOTEL RPL", headingFont, Brushes.Black, 5, currentHeight);
            e.Graphics.DrawString("Jalan Titik Koma Line No. 23", bodyFont, Brushes.Black, 5, currentHeight += 35);
            e.Graphics.DrawString("Customer : " + currentCustomerName, bodyFont, Brushes.Black, 5, currentHeight += 30);
            e.Graphics.DrawString("Booking Code : " + currentBookingCode, importantFont, Brushes.Black, 5, currentHeight += 30);

            e.Graphics.DrawString("RoomNumber \t RoomFloor \t RoomPrice \t Description", bodyFont, Brushes.Black, 5, currentHeight += 40);
            e.Graphics.DrawString("---------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 20);

            foreach (DataGridViewRow room in dataGridViewSelectedRooms.Rows)
            {
                e.Graphics.DrawString(room.Cells["RoomNumber"].Value + "\t\t\t" + room.Cells["RoomFloor"].Value + "\t" + room.Cells["RoomPrice"].Value + "\t\t" + room.Cells["Description"].Value, bodyFont, Brushes.Black, 5, currentHeight += 20);
                e.Graphics.DrawString("---------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 20);
            }

            e.Graphics.DrawString("Item \t Quantity \t Price \t Subtotal", bodyFont, Brushes.Black, 5, currentHeight += 60);
            e.Graphics.DrawString("---------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 20);

            foreach (DataGridViewRow item in dataGridViewAdditionalItems.Rows)
            {
                e.Graphics.DrawString(item.Cells["Item"].Value + "\t\t" + item.Cells["Quantity"].Value + "\t" + item.Cells["Price"].Value + "\t\t" + item.Cells["Subtotal"].Value, bodyFont, Brushes.Black, 5, currentHeight += 20);
                e.Graphics.DrawString("---------------------------------------------------------------------------", bodyFont, Brushes.Black, 5, currentHeight += 20);
            }

            e.Graphics.DrawString("Kasir : " + LoggedInUser.Name, bodyFont, Brushes.Black, 5, currentHeight += 40);
            e.Graphics.DrawString("Total Biaya: " + labelTotal.Text, bodyFont, Brushes.Black, 5, currentHeight += 30);
            e.Graphics.DrawString("Terimakasih telah menggunakan layanan kami..!", importantFont, Brushes.Black, 5, currentHeight += 40);

            e.HasMorePages = false;
        }
    }
}
