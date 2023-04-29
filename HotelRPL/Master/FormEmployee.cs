using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;

namespace HotelRPLApp3.Master
{
    public partial class FormEmployee : Form
    {
        private string oldPassword;

        public FormEmployee()
        {
            InitializeComponent();
        }

        void unlockComponents()
        {
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            inputUsername.Enabled = true;
            inputPassword.Enabled = true;
            inputConfirmPass.Enabled = true;
            inputName.Enabled = true;
            inputEmail.Enabled = true;
            inputDateOfBirth.Enabled = true;
            inputJob.Enabled = true;
            inputAddress.Enabled = true;
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
            inputUsername.Enabled = false;
            inputPassword.Enabled = false;
            inputConfirmPass.Enabled = false;
            inputName.Enabled = false;
            inputEmail.Enabled = false;
            inputDateOfBirth.Enabled = false;
            inputJob.Enabled = false;
            inputAddress.Enabled = false;
            btnBrowse.Enabled = false;
            ResetInputs();

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
            inputUsername.Text = string.Empty;
            inputPassword.Text = string.Empty;
            inputConfirmPass.Text = string.Empty;
            inputName.Text = string.Empty;
            inputEmail.Text = string.Empty;
            inputDateOfBirth.Text = string.Empty;
            inputJob.Text = string.Empty;
            inputAddress.Text = string.Empty;
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

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            loadJobs();

            loadData();
            lockComponents();
        }

        private void loadJobs()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Job", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adapter.Fill(data);

                inputJob.DataSource = data;
                inputJob.ValueMember = "ID";
                inputJob.DisplayMember = "Name";
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
                byte[] uploadImage;
                try
                {
                    //cara update data bila gambar tidak berubah
                    MemoryStream stream = new MemoryStream();
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
                    SqlCommand cmd = new SqlCommand("UPDATE Employee SET " +
                        "Username=@Username, " +
                        "Name=@Name, " +
                        "Email=@Email, " +
                        "DateOfBirth=@DateOfBirth, " +
                        "JobID=@Job, " +
                        "Address=@Address, " +
                        "Photo=@Photo " +
                        "WHERE ID=@ID", conn);

                    cmd.Parameters.AddWithValue("@Username", inputUsername.Text);
                    if (inputPassword.Text == "")
                    {
                        cmd.Parameters.AddWithValue("@Password", oldPassword);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Password", Helper.hashPassToSHA256(inputPassword.Text));
                    }
                    cmd.Parameters.AddWithValue("@ConfirmPass", inputConfirmPass.Text);
                    cmd.Parameters.AddWithValue("@Name", inputName.Text);
                    cmd.Parameters.AddWithValue("@Email", inputEmail.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", inputDateOfBirth.Value);
                    cmd.Parameters.AddWithValue("@Job", inputJob.SelectedValue);
                    cmd.Parameters.AddWithValue("@Address", inputAddress.Text);
                    cmd.Parameters.AddWithValue("@Photo", uploadImage);
                    cmd.Parameters.AddWithValue("@ID", btnUpdate.Tag);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Karyawan telah diedit.");

                    loadData();
                }

                lockComponents();
            }
        }

        private void insertData()
        {
            if (ValidateInputs() && inputPassword.Text != "")
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES ('" + inputUsername.Text + "' , @Password, @Name, @Email, @Address, @DateOfBirth, @Job, '@Photo')", conn);
                    cmd.Parameters.AddWithValue("@Username", inputUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", Helper.hashPassToSHA256(inputPassword.Text));
                    cmd.Parameters.AddWithValue("@Name", inputName.Text);
                    cmd.Parameters.AddWithValue("@Email", inputEmail.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", inputDateOfBirth.Value);
                    cmd.Parameters.AddWithValue("@Job", inputJob.SelectedValue);
                    cmd.Parameters.AddWithValue("@Address", inputAddress.Text);
                    cmd.Parameters.AddWithValue("@Photo", uploadImage);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Karyawan baru ditambahkan.");

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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ViewEmployee", conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dataGridViewEmployee.DataSource = data;
                    dataGridViewEmployee.Columns["ID"].Visible = false;
                    dataGridViewEmployee.Columns["Password"].Visible = false;
                    dataGridViewEmployee.Columns["Photo"].Visible = false;
                }
            }
        }

        private bool ValidateInputs()
        {
            if (
                inputUsername.Text == "" ||
                inputName.Text == "" ||
                inputEmail.Text == "" ||
                inputDateOfBirth.Text == "" ||
                inputJob.Text == "" ||
                inputAddress.Text == "" ||
                pictureBoxPhoto.Image == null)
            {
                MessageBox.Show("Lengkapi data-data yang tersedia.");
                return false;
            }
            else if (inputPassword.Text != inputConfirmPass.Text)
            {
                MessageBox.Show("Konfirmasi password tidak cocok.");
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

        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable data = dataGridViewEmployee.DataSource as DataTable;
                DataRow row = data.Rows[e.RowIndex];

                inputName.Text = row["Name"].ToString();
                inputUsername.Text = row["Username"].ToString();
                inputName.Text = row["Name"].ToString();
                inputEmail.Text = row["Email"].ToString();
                inputDateOfBirth.Text = row["DateOfBirth"].ToString();
                inputJob.Text = row["Job"].ToString();
                inputAddress.Text = row["Address"].ToString();
                oldPassword = row["Password"].ToString();

                var imageBytes = row["Photo"] as byte[];

                if (imageBytes != null)
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream(imageBytes);
                        pictureBoxPhoto.Image = new Bitmap(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Gagal memuat gambar. Error : " + ex.Message);
                    }
                }

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
                    SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE ID=@ID", conn);
                    cmd.Parameters.AddWithValue("@ID", btnDelete.Tag);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Karyawan telah dihapus.");

                    loadData();
                }
            }
        }
    }
}
