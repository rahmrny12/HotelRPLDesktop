using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HotelRPLApp3.Master
{
    public partial class FormRoomType : Form
    {
        public FormRoomType()
        {
            InitializeComponent();
        }

        void unlockComponents()
        {
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            inputName.Enabled = true;
            inputCapacity.Enabled = true;
            inputRoomPrice.Enabled = true;
            btnBrowse.Enabled = true;

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
            inputName.Enabled = false;
            inputCapacity.Enabled = false;
            inputRoomPrice.Enabled = false;
            btnBrowse.Enabled = false;

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
            pictureBoxPhoto.Image = null;
            inputName.Text = string.Empty;
            inputCapacity.Text = string.Empty;
            inputRoomPrice.Text = string.Empty;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Only|*.jpg;*.png;*.jpeg;";

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (openFileDialog.CheckFileExists)
                {
                    pictureBoxPhoto.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void FormRoomType_Load(object sender, EventArgs e)
        {
            loadData();
            lockComponents();
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
                byte[] uploadImage;
                MemoryStream stream = new MemoryStream();
                try
                {
                    //cara update data bila gambar tidak berubah
                    pictureBoxPhoto.Image.Save(stream, ImageFormat.Png);
                    uploadImage = stream.ToArray();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan gambar. Error : " + ex.Message);
                    throw;
                }

                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE RoomType SET Name=@Name, Capacity=@Capacity, RoomPrice=@RoomPrice, Photo=@Photo WHERE ID=@ID", conn);
                    cmd.Parameters.AddWithValue("@Name", inputName.Text);
                    cmd.Parameters.AddWithValue("@Capacity", inputCapacity.Value);
                    cmd.Parameters.AddWithValue("@RoomPrice", inputRoomPrice.Text);
                    cmd.Parameters.AddWithValue("@Photo", uploadImage);
                    cmd.Parameters.AddWithValue("@ID", btnUpdate.Tag);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tipe kamar telah diedit.");

                    loadData();
                }

                lockComponents();
            }
        }

        private void insertData()
        {
            if (ValidateInputs())
            {
                byte[] uploadImage;
                MemoryStream stream = new MemoryStream();
                try
                {
                    //cara update data bila gambar tidak berubah
                    pictureBoxPhoto.Image.Save(stream, ImageFormat.Png);
                    uploadImage = stream.ToArray();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan gambar. Error : " + ex.Message);
                    throw;
                }


                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO RoomType VALUES (@Name, @Capacity, @RoomPrice, @Photo)", conn);
                    cmd.Parameters.AddWithValue("@Name", inputName.Text);
                    cmd.Parameters.AddWithValue("@Capacity", inputCapacity.Value);
                    cmd.Parameters.AddWithValue("@RoomPrice", inputRoomPrice.Text);
                    cmd.Parameters.AddWithValue("@Photo", uploadImage);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tipe kamar baru ditambahkan.");

                    loadData();
                }

                lockComponents();
            }
        }

        private void loadData()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM RoomType", conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridViewRoomType.DataSource = data;
                    dataGridViewRoomType.Columns["Photo"].Visible = false;
                }
            }
        }

        private bool ValidateInputs()
        {
            if (inputName.Text == "" || inputCapacity.Text == "" || inputRoomPrice.Text == "")
            {
                MessageBox.Show("Lengkapi data-data yang tersedia.");
                return false;
            }
            else if (!inputRoomPrice.Text.All(char.IsDigit))
            {
                MessageBox.Show("Input data harga harus angka.");
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

        private void dataGridViewRoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable data = dataGridViewRoomType.DataSource as DataTable;
                DataRow row = data.Rows[e.RowIndex];

                inputName.Text = row["Name"].ToString();
                inputCapacity.Text = row["Capacity"].ToString();
                inputRoomPrice.Text = row["RoomPrice"].ToString();

                var imageBytes = row["Photo"] as byte[];

                if (imageBytes != null)
                {
                    MemoryStream ms = new MemoryStream(imageBytes);
                    pictureBoxPhoto.Image = System.Drawing.Image.FromStream(ms);
                }

                btnUpdate.Tag = row["ID"].ToString();
                btnDelete.Tag = row["ID"].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Tag != null)
            {
                try
                {
                    using (SqlConnection conn = Helper.getConnected())
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM RoomType WHERE ID=@ID", conn);
                        cmd.Parameters.AddWithValue("@ID", btnDelete.Tag);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tipe kamar telah dihapus.");

                        loadData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Tipe kamar ini tidak dapat dihapus karena datanya berelasi dengan kamar tertentu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
