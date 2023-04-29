using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRPLApp3.Master
{
    public partial class FormRoom : Form
    {
        public FormRoom()
        {
            InitializeComponent();
        }

        void unlockComponents()
        {
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            inputRoomNumber.Enabled = true;
            inputRoomType.Enabled = true;
            inputRoomFloor.Enabled = true;
            inputDescription.Enabled = true;

            btnBack.Text = "Cancel";
            btnBack.Click += new EventHandler(CancelForm);
            btnBack.Click -= new EventHandler(CloseForm);
        }

        void lockComponents()
        {
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            inputRoomNumber.Enabled = false;
            inputRoomType.Enabled = false;
            inputRoomFloor.Enabled = false;
            inputDescription.Enabled = false;

            btnBack.Text = "Close";
            btnBack.Click += new EventHandler(CloseForm);
            btnBack.Click -= new EventHandler(CancelForm);
        }

        private void CancelForm(object sender, EventArgs e)
        {
            lockComponents();
            ResetInputs();
        }

        private void ResetInputs()
        {
            inputRoomNumber.Text = String.Empty;
            inputRoomType.Text = String.Empty;
            inputRoomFloor.Text = String.Empty;
            inputDescription.Text = String.Empty;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            loadRoomType();

            loadData();
            lockComponents();
        }

        private void loadRoomType()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM RoomType", conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    inputRoomType.DataSource = data;
                    inputRoomType.DisplayMember = "Name";
                    inputRoomType.ValueMember = "ID";
                }
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
                    updateData();
                    break;
                default:
                    break;
            }
        }

        private void updateData()
        {
            if (ValidateInputs())
            {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Room SET RoomNumber=@RoomNumber, RoomFloor=@RoomFloor, RoomTypeID=@RoomTypeID, Description=@Description WHERE ID=@ID", conn);
                    cmd.Parameters.AddWithValue("@RoomNumber", inputRoomNumber.Text);
                    cmd.Parameters.AddWithValue("@RoomFloor", inputRoomFloor.Text);
                    cmd.Parameters.AddWithValue("@RoomTypeID", inputRoomType.SelectedValue);
                    cmd.Parameters.AddWithValue("@Description", inputDescription.Text);
                    cmd.Parameters.AddWithValue("@ID", btnUpdate.Tag);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kamar telah diedit.");

                    loadData();
                }

                lockComponents();
            }
        }

        private void insertData()
        {
            if (ValidateInputs())
            {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Room VALUES (@RoomTypeID, @RoomNumber, @RoomFloor, @Description)", conn);
                    cmd.Parameters.AddWithValue("@RoomTypeID", inputRoomType.SelectedValue);
                    cmd.Parameters.AddWithValue("@RoomNumber", inputRoomNumber.Text);
                    cmd.Parameters.AddWithValue("@RoomFloor", inputRoomFloor.Text);
                    cmd.Parameters.AddWithValue("@Description", inputDescription.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tipe kamar baru ditambahkan.");

                    loadData();
                }
            }
        }

        private void loadData()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ViewRoom", conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridViewRoom.DataSource = data;
                    dataGridViewRoom.Columns["ID"].Visible = false;
                    dataGridViewRoom.Columns["RoomTypeID"].Visible = false;
                }
            }
        }

        private bool ValidateInputs()
        {
            if (inputRoomNumber.Text == "" || inputRoomFloor.Text == "" || inputRoomType.Text == "" || inputDescription.Text == "")
            {
                MessageBox.Show("Lengkapi data-data yang tersedia.");
                return false;
            }
            else if (!inputRoomFloor.Text.All(char.IsDigit))
            {
                MessageBox.Show("Input data lantai harus angka.");
                return false;
            }
            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            unlockComponents();
            btnSave.Tag = "insert";
            ResetInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Tag != null)
            {
                unlockComponents();
                btnSave.Tag = "update";
            }
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable data = dataGridViewRoom.DataSource as DataTable;
                DataRow row = data.Rows[e.RowIndex];

                inputRoomNumber.Text = row["RoomNumber"].ToString();
                inputRoomFloor.Text = row["RoomFloor"].ToString();
                inputRoomType.SelectedValue = row["RoomTypeID"].ToString();
                inputDescription.Text = row["Description"].ToString();

                btnUpdate.Tag = row["ID"].ToString();
                btnDelete.Tag = row["ID"].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Tag != null)
            {
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Room WHERE ID=@ID", conn);
                    cmd.Parameters.AddWithValue("@ID", btnDelete.Tag);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kamar telah dihapus.");

                    loadData();
                }
            }
        }
    }
}
