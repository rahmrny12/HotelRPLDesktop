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

namespace HotelRPLApp3.Report
{
    public partial class FormChartPreview : Form
    {
        public FormChartPreview()
        {
            InitializeComponent();
        }

        private void FormChartPreview_Load(object sender, EventArgs e)
        {
            loadYears();
            loadGuestsChart();
        }

        private void loadGuestsChart()
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC GetGuestsByYear", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                chart1.Series["Guests"].XValueMember = "Month";
                chart1.Series["Guests"].YValueMembers = "Guest";
                chart1.DataSource = dt;
            }
        }

        private void loadYears()
        {
            int currentYear = DateTime.Now.Year;
            for (int minYear = 2015; minYear < currentYear; minYear++)
            {
                inputYear.Items.Add(minYear);
            }
            inputYear.SelectedValue = currentYear;
        }
    }
}
