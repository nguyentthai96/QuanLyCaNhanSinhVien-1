using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaNhanSinhVien_BLL;
using Microsoft.Reporting.WinForms;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FReportDiem : Form
    {        
        private string strMaMon;
        private string strMaSV;
        private string strMaHK;
        public FReportDiem(string strMaSV)
        {
            this.strMaSV = strMaSV;
            InitializeComponent();
        }

        private void FReportDiem_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = CHocKy_BLL.loaDSHocKy();
            comboBox2.DisplayMember = "TenHK";
            comboBox2.ValueMember = "MaHK";
            try
            {
            comboBox2_SelectedIndexChanged(this.comboBox2, new EventArgs());
            comboBox1_SelectedIndexChanged(this.comboBox1, new EventArgs());
            }
            catch (Exception)
            {
            }
        }

        private void FReportDiem_Resize(object sender, EventArgs e)
        {
            this.reportViewerDiem.Size = this.Size;
        }

        //MonHoc
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            strMaMon = comboBox1.SelectedValue.ToString();
            ReportParameter rparameter = new ReportParameter("HoTenSV", CSinhVien_BLL.loadTenSinhVien(strMaSV));
            reportViewerDiem.LocalReport.SetParameters(rparameter);
            //  = new ReportDataSource("dsDiem", CDiemSo_BLL.loadDSDiemMon(strMaSV, strMaMon, strMaHK));
            reportDiemBindingSource.DataSource = CDiemSo_BLL.loadDSDiemMon(strMaSV, strMaMon, strMaHK);
            //this.reportViewerDiem.LocalReport.DataSources.Add(reportDiemBindingSource);
            this.reportViewerDiem.RefreshReport();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
             strMaHK=comboBox2.SelectedValue.ToString();
            comboBox1.DataSource = CMonHoc_BLL.loadDSMonHK(strMaSV, strMaHK);
            comboBox1.DisplayMember = "TenMon";
            comboBox1.ValueMember = "MaMon";
        }
    }
}
