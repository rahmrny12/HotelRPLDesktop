using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelRPLApp3
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();

                string hashedPass = Helper.hashPassToSHA256(inputPassword.Text);
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Username='" + inputUsername.Text + "' AND Password='" + hashedPass + "'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    LoggedInUser.UserID = dr["ID"].ToString();
                    LoggedInUser.Username = dr["Username"].ToString();
                    LoggedInUser.JobID = dr["JobID"].ToString();

                    FormMain formMain = new FormMain();
                    formMain.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("User tidak ditemukan, atau password salah.");
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}