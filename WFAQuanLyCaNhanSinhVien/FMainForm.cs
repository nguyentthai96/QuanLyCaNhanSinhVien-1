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
using QuanLyCaNhanSinhVien_DTO;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FMainForm : Form
    {
        CSinhVien_DTO sv;
        public FMainForm()
        {
            InitializeComponent();
        }

        private void ttxtTaiKhoan_Click(object sender, EventArgs e)
        {
            ttxtTaiKhoan.Focus();
            ttxtTaiKhoan.SelectAll();
        }

        private void ttxtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ttxtMatKhau.Focus();
                ttxtMatKhau.SelectAll();
            }
        }

        private void ttxtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            ttxtMatKhau.TextBox.PasswordChar = '*';
        }

        private void ttxtMatKhau_Click(object sender, EventArgs e)
        {
            ttxtMatKhau.Focus();
            ttxtMatKhau.SelectAll();
            ttxtMatKhau.TextBox.PasswordChar = '*';
        }

        private void ttxtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tmiDangNhap.Select();
            }
        }
       
        private void tmiDangNhap_Click(object sender, EventArgs e)
        {
           sv= new CAccountSinhVien_BLL().loadAccountSV(ttxtTaiKhoan.Text, ttxtMatKhau.Text);
            if (sv==null)
            {
                MessageBox.Show("Đăng nhập thất bại.");
                return;
            }
            frm.Dispose();
            lblTenSV.Text = sv.StrHoTen;
            lblTenSV.Location=new Point(this.Size.Width-75- lblTenSV.Width,lblTenSV.Location.Y);
            FTongQuan tq = new FTongQuan(sv.StrMaSV);
            tq.MdiParent = this;
            tq.Show();
            tmiDangNhap.Visible = false;
            ttxtMatKhau.Visible = false;
            ttxtTaiKhoan.Visible = false;
        }

        private void lblTenSV_Click(object sender, EventArgs e)
        {        
            cmsAccount.Show(this,lblTenSV.Location.X, lblTenSV.Location.Y+25);
        }

        private void tmiTongQuan_Click(object sender, EventArgs e)
        {
            ttxtTaiKhoan.Focus();
            ttxtTaiKhoan.SelectAll();
        }

        Form frm;
        Label lblChaoMung;
        private void FMainForm_Load(object sender, EventArgs e)
        {
            frm = new Form();
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();

            lblChaoMung = new Label();
            lblChaoMung.Text = "Bạn phải đăng nhập để thao tác với phần mềm.";
            lblChaoMung.Font = new Font("", 40, FontStyle.Bold, GraphicsUnit.Point);
            lblChaoMung.AutoSize = false;
            lblChaoMung.Size = frm.Size;
            lblChaoMung.ForeColor = Color.Green;
            lblChaoMung.TextAlign = ContentAlignment.MiddleCenter;
            frm.Controls.Add(lblChaoMung);

           // ttxtTaiKhoan.Text = "14110182";
           // ttxtMatKhau.Text = "ntt";
            tmiDangNhap_Click(this.tmiDangNhap, new EventArgs());
        }

        private void FMainForm_SizeChanged(object sender, EventArgs e)
        {
            lblTenSV.Location = new Point(this.Size.Width - 75 - lblTenSV.Width, lblTenSV.Location.Y);
            lblChaoMung.Size = frm.Size;
        }

        private void sửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new FThemSinhVien(sv).ShowDialog();
            sv = new CSinhVien_BLL().loadTTSV(sv.StrMaSV) ;
            lblTenSV.Text = sv.StrHoTen;
            FMainForm_SizeChanged(this, new EventArgs());
        }

        private void tmiDiemSoHT_Click(object sender, EventArgs e)
        {
            FXemDiem frmDiem = new FXemDiem(sv.StrMaSV);
            frmDiem.MdiParent = this;
            frmDiem.StartPosition = FormStartPosition.CenterParent;
            frmDiem.Show();
        }
    }
}
