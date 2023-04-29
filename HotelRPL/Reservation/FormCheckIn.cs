using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRPLApp3.Reservation
{

    public partial class FormCheckIn : Form
    {
        DataTable tableRooms = new DataTable();

        public FormCheckIn()
        {
            InitializeComponent();
        }

        private void FormCheckIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            if (inputSearchBooking.Text != "")
            {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM ViewReservationRoom WHERE BookingCode=@BookingCode AND StartDateTime IS NULL", conn);
                    cmd.Parameters.AddWithValue("@BookingCode", inputSearchBooking.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    tableRooms = new DataTable();
                    da.Fill(tableRooms);

                    dataGridViewRoom.DataSource = tableRooms;
                    dataGridViewRoom.Columns["ID"].Visible = false;
                    dataGridViewRoom.Columns["BookingCode"].Visible = false;
                    dataGridViewRoom.Columns["StartDateTime"].Visible = false;
                    dataGridViewRoom.Columns["CheckInDateTime"].Visible = false;
                    dataGridViewRoom.Columns["CheckOutDateTime"].Visible = false;
                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                if (inputName.Text != "")
                {
                    foreach (DataGridViewRow room in dataGridViewRoom.Rows)
                    {
                        using (SqlConnection conn = Helper.getConnected())
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE ReservationRoom SET StartDateTime=@StartDateTime WHERE ID=@ID", conn);
                            cmd.Parameters.AddWithValue("StartDateTime", DateTime.Now);
                            cmd.Parameters.AddWithValue("ID", room.Cells["ID"].Value.ToString());

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("CheckIn Berhasil");
                            tableRooms.Rows.Clear();
                            inputSearchBooking.Text = "";
                            inputPhoneNumber.Text = "";
                            inputName.Text = "";
                            inputEmail.Text = "";
                            optionMale.Checked = false;
                            optionFemale.Checked = false;
                            inputAge.Text = "";
                            inputNIK.Text = "";
                        }
                    }
                }
            }
        }

        private bool ValidateInputs()
        {
            if (inputPhoneNumber.Text == "")
            {
                MessageBox.Show("Masukkan nomor telepon customer, atau isikan data customer baru!");
                return false;
            } else if (dataGridViewRoom.Rows.Count == 0)
            {
                MessageBox.Show("Masukkan kode booking kamar!");
                return false;
            }
            return true;
        }

        private void inputPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE PhoneNumber=@PhoneNumber", conn);
                cmd.Parameters.AddWithValue("@PhoneNumber", inputPhoneNumber.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    inputName.Text = reader["Name"].ToString(); 
                    inputEmail.Text = reader["Email"].ToString(); 
                    if (reader["Gender"].ToString() == "M")
                    {
                        optionMale.Checked = true;
                    } else
                    {
                        optionFemale.Checked = false;
                    }
                    inputAge.Text = reader["Age"].ToString();
                    inputNIK.Text = reader["NIK"].ToString(); 
                }
            }
        }

        private void btmClose_Click(object sender, EventArgs e)
        {

        }
    }
}
