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

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FMainForm : Form
    {
        private string strMaSV;
        bool bDangNhapThanhCong=false;
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
           bool bCheck=CAccountSinhVien_BLL.checkAccount(ttxtTaiKhoan.Text, ttxtMatKhau.Text);
            if (bCheck==false)
            {
                MessageBox.Show("Đăng nhập thất bại.");
                bDangNhapThanhCong = false;
                return;
            }
            frmEmpty.Dispose();
            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception){}

            bDangNhapThanhCong = true;
            this.strMaSV = ttxtTaiKhoan.Text;
            //Tim ten sinh vien
            lblTenSV.Text=CSinhVien_BLL.loadTenSinhVien(strMaSV);

            lblTenSV.Location=new Point(this.Size.Width-75- lblTenSV.Width,lblTenSV.Location.Y);
            
            frmTongQuan = new FTongQuan(strMaSV);
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
            if (bDangNhapThanhCong)//TODO a:&& this.ActiveMdiChild!=frmTongQuan)
            {
                try
                {
                    this.ActiveMdiChild.Close();
                }
                catch (Exception) { }
                
                frmTongQuan = new FTongQuan(strMaSV);
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
            /////TODO Thu dang nhap nhanh
            ttxtTaiKhoan.Text = "1";
            ttxtMatKhau.Text = "1";
            tmiDangNhap_Click(this.tmiDangNhap, new EventArgs());

        }

        private void FMainForm_SizeChanged(object sender, EventArgs e)
        {
            lblTenSV.Location = new Point(this.Size.Width - 75 - lblTenSV.Width, lblTenSV.Location.Y);
            lblChaoMung.Size = frmEmpty.Size;
        }

        private void sửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO a:
            //FThemSinhVien frmSuaThongTin = new FThemSinhVien(strMaSV);
            //frmSuaThongTin.StartPosition = FormStartPosition.CenterParent;
            //frmSuaThongTin.ShowDialog();

            lblTenSV.Text = CSinhVien_BLL.loadTenSinhVien(strMaSV);
            FMainForm_SizeChanged(this, new EventArgs());
        }

        private void tmiDiemSoHT_Click(object sender, EventArgs e)
        {
            if(bDangNhapThanhCong==false)
            {
                MessageBox.Show("Bạn chưa đăng nhập");
                return;
            }

            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception) { }
            //TODO a:
            //FXemDiem frmDiem = new FXemDiem(strMaSV);
            //frmDiem.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //frmDiem.WindowState = FormWindowState.Maximized;
            //frmDiem.MdiParent = this;
            //frmDiem.StartPosition = FormStartPosition.CenterParent;
            //frmDiem.Show();
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

            //ToDo a: frmTongQuan.Close();
            bDangNhapThanhCong = false;

            tmiDangXuatTongQuan.Visible = false;
            tmiDangNhap.Visible = true;
            đăngKýToolStripMenuItem.Visible = true;
            ttxtMatKhau.Visible = true;
            ttxtTaiKhoan.Visible = true;
            lblTenSV.Visible = false;
        }

        private void tmiSuKienHoatDong_Click(object sender, EventArgs e)
{
            if (bDangNhapThanhCong==false)
            {
                MessageBox.Show("Bạn chưa đăng nhập");
                return;
            }

            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception) { }
            //TODO a:
            //FDSThoiKhoaBieu dsThoiKhoaBieu;
            //dsThoiKhoaBieu = new FDSThoiKhoaBieu(strMaSV);
            //dsThoiKhoaBieu.MdiParent = this;
            //dsThoiKhoaBieu.WindowState = FormWindowState.Maximized;
            //dsThoiKhoaBieu.Show();

        }

        private void tmiDangXuat_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveMdiChild.Close();
            }
            catch (Exception) { }
            bDangNhapThanhCong = false;
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

            //ToDo a: frmTongQuan.Close();

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
            //TODO a:
            //FReportDiem fr = new FReportDiem(strMaSV);
            //fr.WindowState = FormWindowState.Maximized;
            //fr.MdiParent = this;
            //fr.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO a:
            //FThemSinhVien frmThemSinhVien= new FThemSinhVien();
            //frmThemSinhVien.StartPosition = FormStartPosition.CenterParent;
            //frmThemSinhVien.ShowDialog();
        }
    }
}
