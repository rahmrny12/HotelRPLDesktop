using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRPLApp3.Master
{
    public partial class FormFoodsAndDrinks : Form
    {
        private string selectedDataID;

        public FormFoodsAndDrinks()
        {
            InitializeComponent();
        }

        private void FormFoodsAndDrinks_Load(object sender, EventArgs e)
        {
            lockComponents();
            loadData();
        }

        private void loadData()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM FoodsAndDrinks", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);

                dataGridViewFoodsAndDrinks.DataSource = data;
                dataGridViewFoodsAndDrinks.Columns["Photo"].Visible = false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Only|*.jpg;*.jpeg;*.png;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = new Bitmap(ofd.FileName);
            }
        }

        void unlockComponents()
        {
            inputName.Enabled = true;
            inputType.Enabled = true;
            inputPrice.Enabled = true;

            btnBrowse.Enabled = true;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;

            btnBack.Click += new EventHandler(CancelChange);
            btnBack.Click -= new EventHandler(CloseForm);
        }

        private void ResetInputs()
        {
            selectedDataID = null;
            inputName.Text = String.Empty;
            inputType.Text = String.Empty;
            inputPrice.Text = String.Empty;
            pictureBoxPhoto.Image = null;
        }

        void lockComponents()
        {
            inputName.Enabled = false;
            inputType.Enabled = false;
            inputPrice.Enabled = false;

            btnBrowse.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            btnSave.Enabled = false;

            btnBack.Click += new EventHandler(CloseForm);
            btnBack.Click -= new EventHandler(CancelChange);
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelChange(object sender, EventArgs e)
        {
            lockComponents();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            unlockComponents();
            btnSave.Tag = "insert";
            ResetInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            unlockComponents();
            btnSave.Tag = "update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDataID != null)
            {
                if (MessageBox.Show("Yakin ingin menghapus data?", "Hapus menu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = Helper.getConnected())
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM FoodsAndDrinks WHERE ID=@ID", conn);
                            cmd.Parameters.AddWithValue("@ID", selectedDataID);

                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Berhasil menghapus menu.");
                        loadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan : " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Klik menu yang ingin dihapus.");
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
            loadData();
            ResetInputs();
        }

        private void updateData()
        {
            if (ValidateInputs())
            {
                byte[] uploadImage;
                MemoryStream sm = new MemoryStream();
                pictureBoxPhoto.Image.Save(sm, ImageFormat.Jpeg);
                uploadImage = sm.ToArray();

                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE FoodsAndDrinks SET " +
                        "Name=@Name, " +
                        "Type=@Type, " +
                        "Price=@Price, " +
                        "Photo=@Photo " +
                        "WHERE ID=@ID", conn);
                    cmd.Parameters.AddWithValue("@Name", inputName.Text);
                    cmd.Parameters.AddWithValue("@Type", inputType.Text);
                    cmd.Parameters.AddWithValue("@Price", inputPrice.Text);
                    cmd.Parameters.AddWithValue("@Photo", uploadImage);
                    cmd.Parameters.AddWithValue("@ID", selectedDataID);

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Berhasil menambah menu.");
                lockComponents();
            }
        }

        private void insertData()
        {
            if (ValidateInputs())
            {
                byte[] uploadImage;
                MemoryStream sm = new MemoryStream();
                pictureBoxPhoto.Image.Save(sm, ImageFormat.Jpeg);
                uploadImage = sm.ToArray();

                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO FoodsAndDrinks VALUES(" +
                        "@Name, " +
                        "@Type, " +
                        "@Price, " +
                        "@Photo" +
                        ")", conn);
                    cmd.Parameters.AddWithValue("@Name", inputName.Text);
                    cmd.Parameters.AddWithValue("@Type", inputType.Text);
                    cmd.Parameters.AddWithValue("@Price", inputPrice.Text);
                    cmd.Parameters.AddWithValue("@Photo", uploadImage);

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Berhasil menambah menu.");
                lockComponents();
            }
        }

        private bool ValidateInputs()
        {
            if (inputName.Text == "" ||
                inputType.Text == "" ||
                inputPrice.Text == ""
            )
            {
                MessageBox.Show("Lengkapi data yang ada!");
                return false;
            }
            else if (pictureBoxPhoto.Image == null)
            {
                MessageBox.Show("Pilih foto terlebih dahulu!");
                return false;
            }
            return true;
        }

        private void dataGridViewFoodsAndDrinks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable data = (DataTable)dataGridViewFoodsAndDrinks.DataSource;
                try
                {
                    DataRow row = data.Rows[e.RowIndex];

                    selectedDataID = row["ID"].ToString();
                    inputName.Text = row["Name"].ToString();
                    inputType.Text = row["Type"].ToString();
                    inputPrice.Text = row["Price"].ToString();

                    try
                    {
                        byte[] imageBytes = (byte[])row["Photo"];

                        MemoryStream ms = new MemoryStream(imageBytes);
                        pictureBoxPhoto.Image = new Bitmap(ms);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal memuat gambar : " + ex.Message);
                    }
                }
                catch
                {
                    MessageBox.Show("Terjadi Kesalahan.");
                }
            }
        }
    }
}
