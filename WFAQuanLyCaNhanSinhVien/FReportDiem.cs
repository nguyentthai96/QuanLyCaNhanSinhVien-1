using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaNhanSinhVien_DTO;
using QuanLyCaNhanSinhVien_BLL;
using Microsoft.Reporting.WinForms;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FReportDiem : Form
    {
        private CSinhVien_DTO sv;
        private string strMaMon;
        public FReportDiem()
        {
            
        }

        public FReportDiem(CSinhVien_DTO sv)
        {
            this.sv = sv;
            strMaMon = "MaMon";
            InitializeComponent();
        }

        private void FReportDiem_Load(object sender, EventArgs e)
        {
            ReportParameter rparameter = new ReportParameter("HoTenSV", sv.StrHoTen);
            reportViewerDiem.LocalReport.SetParameters(rparameter);
            reportDataSource1 = new ReportDataSource();
            reportDataSource1.Name = "dsDiemSo";
            this.reportViewerDiem.LocalReport.DataSources.Add(reportDataSource1);
            reportDataSource1.Value = new CDiemSo_BLL().loadDSDiemMon(sv.StrMaSV);
            this.reportViewerDiem.RefreshReport();
        }

        private void FReportDiem_Resize(object sender, EventArgs e)
        {
            this.reportViewerDiem.Size = this.Size;
        }
    }
}
