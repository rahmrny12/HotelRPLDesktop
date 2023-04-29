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

namespace HotelRPLApp3.Master
{
    public partial class FormItem : Form
    {
        private string selectedDataID;

        public FormItem()
        {
            InitializeComponent();
        }

        private void FormItem_Load(object sender, EventArgs e)
        {
            lockComponents();
            loadData();
        }

        private void loadData()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Item", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);

                dataGridViewItem.DataSource = data;
            }
        }

        void unlockComponents()
        {
            inputName.Enabled = true;
            inputRequestPrice.Enabled = true;
            inputCompensationFee.Enabled = true;

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
            inputRequestPrice.Text = String.Empty;
            inputCompensationFee.Text = String.Empty;
        }

        void lockComponents()
        {
            inputName.Enabled = false;
            inputRequestPrice.Enabled = false;
            inputCompensationFee.Enabled = false;

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
                if (MessageBox.Show("Yakin ingin menghapus data?", "Hapus item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = Helper.getConnected())
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM Item WHERE ID=@ID", conn);
                            cmd.Parameters.AddWithValue("@ID", selectedDataID);

                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Berhasil menghapus item.");
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
                MessageBox.Show("Klik item yang ingin dihapus.");
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
                using (SqlConnection conn = Helper.getConnected())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Item SET " +
                        "Name=@Name, " +
                        "RequestPrice=@RequestPrice, " +
                        "CompensationFee=@CompensationFee " +
                        "WHERE ID=@ID", conn);
                    cmd.Parameters.AddWithValue("@Name", inputName.Text);
                    cmd.Parameters.AddWithValue("@RequestPrice", inputRequestPrice.Text);
                    cmd.Parameters.AddWithValue("@CompensationFee", inputCompensationFee.Text);
                    cmd.Parameters.AddWithValue("@ID", selectedDataID);

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Berhasil menambah item.");
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO Item VALUES(" +
                        "@Name, " +
                        "@RequestPrice, " +
                        "@CompensationFee " +
                        ")", conn);
                    cmd.Parameters.AddWithValue("@Name", inputName.Text);
                    cmd.Parameters.AddWithValue("@RequestPrice", inputRequestPrice.Text);
                    cmd.Parameters.AddWithValue("@CompensationFee", inputCompensationFee.Text);

                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Berhasil menambah item.");
                lockComponents();
            }
        }

        private bool ValidateInputs()
        {
            if (inputName.Text == "" ||
                inputRequestPrice.Text == "" ||
                inputCompensationFee.Text == ""
            )
            {
                MessageBox.Show("Lengkapi data yang ada!");
                return false;
            }
            return true;
        }

        private void dataGridViewItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable data = (DataTable)dataGridViewItem.DataSource;
                try
                {
                    DataRow row = data.Rows[e.RowIndex];

                    selectedDataID = row["ID"].ToString();
                    inputName.Text = row["Name"].ToString();
                    inputRequestPrice.Text = row["RequestPrice"].ToString();
                    inputCompensationFee.Text = row["CompensationFee"].ToString();
                }
                catch
                {
                    MessageBox.Show("Terjadi Kesalahan.");
                }
            }
        }
    }
}
