namespace HotelRPLApp3.Report
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewReportTableAdapter = new HotelRPLApp2.DataSetReportTableAdapters.TableAdapterManager();
            this.dB_HOTEL_RPLDataSet = new HotelRPLApp2.DataSetReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dB_HOTEL_RPLDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // viewReportTableAdapter
            // 
            this.viewReportTableAdapter.BackupDataSetBeforeUpdate = false;
            this.viewReportTableAdapter.Connection = null;
            this.viewReportTableAdapter.UpdateOrder = HotelRPLApp2.DataSetReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dB_HOTEL_RPLDataSet
            // 
            this.dB_HOTEL_RPLDataSet.DataSetName = "DataSetReport";
            this.dB_HOTEL_RPLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(801, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_HOTEL_RPLDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HotelRPLApp2.DataSetReportTableAdapters.TableAdapterManager viewReportTableAdapter;
        private HotelRPLApp2.DataSetReport dB_HOTEL_RPLDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}