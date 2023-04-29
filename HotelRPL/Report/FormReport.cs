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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = Helper.getConnected())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ViewReport", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetReservation", dt));
                //reportViewer1.LocalReport.ReportEmbeddedResource = "ReportingInDotNet.WinformsDotNet6.ReportDefinitions.ReportReservation.rdlc";
                //reportViewer1.LocalReport.ReportEmbeddedResource = "C:\\Users\\Laptop-RPL\\source\\repos\\HotelRPLApp2\\HotelRPLApp2\\ReportReservation.rdlc";
                reportViewer1.LocalReport.ReportPath = "ReportReservation.rdlc";

                reportViewer1.RefreshReport();

            }
        }
    }
}
