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

        FTongQuan frmTongQuan;
        private void tmiDangNhap_Click(object sender, EventArgs e)
        {
           sv= new CAccountSinhVien_BLL().loadAccountSV(ttxtTaiKhoan.Text, ttxtMatKhau.Text);
            if (sv==null)
            {
                MessageBox.Show("Đăng nhập thất bại.");
                return;
            }
            frmEmpty.Dispose();
            frmEmpty.Close();
            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception) { }

            lblTenSV.Text = sv.StrHoTen;
            lblTenSV.Location=new Point(this.Size.Width-75- lblTenSV.Width,lblTenSV.Location.Y);
            frmTongQuan = new FTongQuan(sv.StrMaSV);
            frmTongQuan.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frmTongQuan.WindowState = FormWindowState.Maximized;
            frmTongQuan.MdiParent = this;
            frmTongQuan.Show();

           
            tmiDangNhap.Visible = false;
            đăngKýToolStripMenuItem.Visible = false;

            ttxtMatKhau.Visible = false;
            ttxtTaiKhoan.Visible = false;
            tmiDangXuatTongQuan.Visible = true;
            lblTenSV.Visible = true;
        }

        private void lblTenSV_Click(object sender, EventArgs e)
        {        
            cmsAccount.Show(this,lblTenSV.Location.X, lblTenSV.Location.Y+25);
        }

        private void tmiTongQuan_Click(object sender, EventArgs e)
        {
            ttxtTaiKhoan.Focus();
            ttxtTaiKhoan.SelectAll();
            if (sv!=null && this.ActiveMdiChild!=frmTongQuan)
            {
                try
                {
                    this.ActiveMdiChild.Close();
                }
                catch (Exception) { }
                frmTongQuan = new FTongQuan(sv.StrMaSV);
                frmTongQuan.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                frmTongQuan.WindowState = FormWindowState.Maximized;
                frmTongQuan.MdiParent = this;
                frmTongQuan.Show();
                tmiTongQuan.DropDown.Hide();
            }
        }

        Form frmEmpty;
        Label lblChaoMung;
        private void FMainForm_Load(object sender, EventArgs e)
        {
            frmEmpty = new Form();
            frmEmpty.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frmEmpty.WindowState = FormWindowState.Maximized;
            frmEmpty.MdiParent = this;
            frmEmpty.StartPosition = FormStartPosition.CenterParent;
            frmEmpty.Show();


            lblChaoMung = new Label();
            lblChaoMung.Text = "Bạn phải đăng nhập để thao tác với phần mềm.";
            lblChaoMung.Font = new Font("", 40, FontStyle.Bold, GraphicsUnit.Point);
            lblChaoMung.AutoSize = false;
            lblChaoMung.Size = frmEmpty.Size;
            lblChaoMung.ForeColor = Color.Green;
            lblChaoMung.TextAlign = ContentAlignment.MiddleCenter;
            frmEmpty.Controls.Add(lblChaoMung);


            tmiDangXuatTongQuan.Visible = false;
            ///TODO Thu dang nhap nhanh
            ttxtTaiKhoan.Text = "14110182";
            ttxtMatKhau.Text = "ntt";
            tmiDangNhap_Click(this.tmiDangNhap, new EventArgs());
           
        }

        private void FMainForm_SizeChanged(object sender, EventArgs e)
        {
            lblTenSV.Location = new Point(this.Size.Width - 75 - lblTenSV.Width, lblTenSV.Location.Y);
            lblChaoMung.Size = frmEmpty.Size;
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
            if(sv==null)
            {
                MessageBox.Show("Bạn chưa đăng nhập");
                return;
            }

            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception) { }

            FXemDiem frmDiem = new FXemDiem(sv.StrMaSV);
            frmDiem.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frmDiem.WindowState = FormWindowState.Maximized;
            frmDiem.MdiParent = this;
            frmDiem.StartPosition = FormStartPosition.CenterParent;
            frmDiem.Show();
        }

        private void tmiThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmiDangCuatTongQuan_Click(object sender, EventArgs e)
        {
            frmEmpty = new Form();
            frmEmpty.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frmEmpty.WindowState = FormWindowState.Maximized;
            frmEmpty.MdiParent = this;
            frmEmpty.StartPosition = FormStartPosition.CenterParent;
            frmEmpty.Show();

            lblChaoMung = new Label();
            lblChaoMung.Text = "Bạn phải đăng nhập để thao tác với phần mềm.";
            lblChaoMung.Font = new Font("", 40, FontStyle.Bold, GraphicsUnit.Point);
            lblChaoMung.AutoSize = false;
            lblChaoMung.Size = frmEmpty.Size;
            lblChaoMung.ForeColor = Color.Green;
            lblChaoMung.TextAlign = ContentAlignment.MiddleCenter;
            frmEmpty.Controls.Add(lblChaoMung);

            frmTongQuan.Close();
            sv = null;

            tmiDangXuatTongQuan.Visible = false;
            tmiDangNhap.Visible = true;
            đăngKýToolStripMenuItem.Visible = true;
            ttxtMatKhau.Visible = true;
            ttxtTaiKhoan.Visible = true;
            lblTenSV.Visible = false;
        }

        private void tmiSuKienHoatDong_Click(object sender, EventArgs e)
{
            if (sv == null)
            {
                MessageBox.Show("Bạn chưa đăng nhập");
                return;
            }

            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception) { }
            FDSThoiKhoaBieu dsThoiKhoaBieu;
            dsThoiKhoaBieu = new FDSThoiKhoaBieu(sv.StrMaSV);
            dsThoiKhoaBieu.MdiParent = this;
            dsThoiKhoaBieu.WindowState = FormWindowState.Maximized;
            dsThoiKhoaBieu.Show();
           
        }

        private void tmiDangXuat_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception) { }
            sv = null;
            frmEmpty = new Form();
            frmEmpty.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frmEmpty.WindowState = FormWindowState.Maximized;
            frmEmpty.MdiParent = this;
            frmEmpty.StartPosition = FormStartPosition.CenterParent;
            frmEmpty.Show();

            lblChaoMung = new Label();
            lblChaoMung.Text = "Bạn phải đăng nhập để thao tác với phần mềm.";
            lblChaoMung.Font = new Font("", 40, FontStyle.Bold, GraphicsUnit.Point);
            lblChaoMung.AutoSize = false;
            lblChaoMung.Size = frmEmpty.Size;
            lblChaoMung.ForeColor = Color.Green;
            lblChaoMung.TextAlign = ContentAlignment.MiddleCenter;
            frmEmpty.Controls.Add(lblChaoMung);

            frmTongQuan.Close();

            tmiDangXuatTongQuan.Visible = false;
            đăngKýToolStripMenuItem.Visible = true;
            tmiDangNhap.Visible = true;
            ttxtMatKhau.Visible = true;
            ttxtTaiKhoan.Visible = true;
            lblTenSV.Visible = false;
        }

        private void tmiDiemSoBC_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception) { }
            FReportDiem fr = new FReportDiem(sv);
            fr.WindowState = FormWindowState.Maximized;
            fr.MdiParent = this;
            fr.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThemSinhVien frmThemSinhVien= new FThemSinhVien();
            frmThemSinhVien.StartPosition = FormStartPosition.CenterParent;
            frmThemSinhVien.ShowDialog();
        }
    }
}
