namespace WFAQuanLyCaNhanSinhVien
{
    partial class FMainForm
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
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.tmiTongQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.ttxtTaiKhoan = new System.Windows.Forms.ToolStripTextBox();
            this.ttxtMatKhau = new System.Windows.Forms.ToolStripTextBox();
            this.tmiDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDangXuatTongQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiHocTap = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDiemSoHT = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiThoiKhoaBieu = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiSuKienHoatDong = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDiemSoBC = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.cmsAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.cmsAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiTongQuan,
            this.tmiHocTap,
            this.tmiThoiKhoaBieu,
            this.tmiBaoCao});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(780, 24);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menMain";
            // 
            // tmiTongQuan
            // 
            this.tmiTongQuan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttxtTaiKhoan,
            this.ttxtMatKhau,
            this.tmiDangNhap,
            this.tmiDangXuatTongQuan,
            this.toolStripSeparator1,
            this.tmiThoat});
            this.tmiTongQuan.Name = "tmiTongQuan";
            this.tmiTongQuan.Size = new System.Drawing.Size(77, 20);
            this.tmiTongQuan.Text = "Tổng quan";
            this.tmiTongQuan.Click += new System.EventHandler(this.tmiTongQuan_Click);
            // 
            // ttxtTaiKhoan
            // 
            this.ttxtTaiKhoan.Name = "ttxtTaiKhoan";
            this.ttxtTaiKhoan.Size = new System.Drawing.Size(100, 23);
            this.ttxtTaiKhoan.Text = "Tài khoản";
            this.ttxtTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttxtTaiKhoan_KeyPress);
            this.ttxtTaiKhoan.Click += new System.EventHandler(this.ttxtTaiKhoan_Click);
            // 
            // ttxtMatKhau
            // 
            this.ttxtMatKhau.Name = "ttxtMatKhau";
            this.ttxtMatKhau.Size = new System.Drawing.Size(100, 23);
            this.ttxtMatKhau.Text = "Mật khẩu";
            this.ttxtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ttxtMatKhau_KeyDown);
            this.ttxtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttxtMatKhau_KeyPress);
            this.ttxtMatKhau.Click += new System.EventHandler(this.ttxtMatKhau_Click);
            // 
            // tmiDangNhap
            // 
            this.tmiDangNhap.Name = "tmiDangNhap";
            this.tmiDangNhap.Size = new System.Drawing.Size(160, 22);
            this.tmiDangNhap.Text = "Đăng nhập";
            this.tmiDangNhap.Click += new System.EventHandler(this.tmiDangNhap_Click);
            // 
            // tmiDangXuatTongQuan
            // 
            this.tmiDangXuatTongQuan.Name = "tmiDangXuatTongQuan";
            this.tmiDangXuatTongQuan.Size = new System.Drawing.Size(160, 22);
            this.tmiDangXuatTongQuan.Text = "Đăng xuất";
            this.tmiDangXuatTongQuan.Click += new System.EventHandler(this.tmiDangCuatTongQuan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // tmiThoat
            // 
            this.tmiThoat.Name = "tmiThoat";
            this.tmiThoat.Size = new System.Drawing.Size(160, 22);
            this.tmiThoat.Text = "Thoát";
            this.tmiThoat.Click += new System.EventHandler(this.tmiThoat_Click);
            // 
            // tmiHocTap
            // 
            this.tmiHocTap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiDiemSoHT});
            this.tmiHocTap.Name = "tmiHocTap";
            this.tmiHocTap.Size = new System.Drawing.Size(61, 20);
            this.tmiHocTap.Text = "Học tập";
            // 
            // tmiDiemSoHT
            // 
            this.tmiDiemSoHT.Name = "tmiDiemSoHT";
            this.tmiDiemSoHT.Size = new System.Drawing.Size(122, 22);
            this.tmiDiemSoHT.Text = "Điểm số";
            this.tmiDiemSoHT.Click += new System.EventHandler(this.tmiDiemSoHT_Click);
            // 
            // tmiThoiKhoaBieu
            // 
            this.tmiThoiKhoaBieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiSuKienHoatDong});
            this.tmiThoiKhoaBieu.Name = "tmiThoiKhoaBieu";
            this.tmiThoiKhoaBieu.Size = new System.Drawing.Size(98, 20);
            this.tmiThoiKhoaBieu.Text = "Thời khóa biểu";
            // 
            // tmiSuKienHoatDong
            // 
            this.tmiSuKienHoatDong.Name = "tmiSuKienHoatDong";
            this.tmiSuKienHoatDong.Size = new System.Drawing.Size(153, 22);
            this.tmiSuKienHoatDong.Text = "Thòi khóa biểu";
            this.tmiSuKienHoatDong.Click += new System.EventHandler(this.tmiSuKienHoatDong_Click);
            // 
            // tmiBaoCao
            // 
            this.tmiBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiDiemSoBC,
            this.tmiMonHoc});
            this.tmiBaoCao.Name = "tmiBaoCao";
            this.tmiBaoCao.Size = new System.Drawing.Size(61, 20);
            this.tmiBaoCao.Text = "Báo cáo";
            // 
            // tmiDiemSoBC
            // 
            this.tmiDiemSoBC.Name = "tmiDiemSoBC";
            this.tmiDiemSoBC.Size = new System.Drawing.Size(122, 22);
            this.tmiDiemSoBC.Text = "Điểm số";
            // 
            // tmiMonHoc
            // 
            this.tmiMonHoc.Name = "tmiMonHoc";
            this.tmiMonHoc.Size = new System.Drawing.Size(122, 22);
            this.tmiMonHoc.Text = "Môn học";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblTenSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(776, 0);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(0, 20);
            this.lblTenSV.TabIndex = 4;
            this.lblTenSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTenSV.Click += new System.EventHandler(this.lblTenSV_Click);
            // 
            // cmsAccount
            // 
            this.cmsAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiDangXuat,
            this.sửaThôngTinToolStripMenuItem});
            this.cmsAccount.Name = "cmsAccount";
            this.cmsAccount.Size = new System.Drawing.Size(146, 48);
            // 
            // tmiDangXuat
            // 
            this.tmiDangXuat.Name = "tmiDangXuat";
            this.tmiDangXuat.Size = new System.Drawing.Size(152, 22);
            this.tmiDangXuat.Text = "Đăng xuất";
            this.tmiDangXuat.Click += new System.EventHandler(this.tmiDangXuat_Click);
            // 
            // sửaThôngTinToolStripMenuItem
            // 
            this.sửaThôngTinToolStripMenuItem.Name = "sửaThôngTinToolStripMenuItem";
            this.sửaThôngTinToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sửaThôngTinToolStripMenuItem.Text = "Sửa thông tin";
            this.sửaThôngTinToolStripMenuItem.Click += new System.EventHandler(this.sửaThôngTinToolStripMenuItem_Click);
            // 
            // FMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 461);
            this.Controls.Add(this.lblTenSV);
            this.Controls.Add(this.Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "FMainForm";
            this.Text = "Quản lý Cá nhân Sinh viên";
            this.Load += new System.EventHandler(this.FMainForm_Load);
            this.SizeChanged += new System.EventHandler(this.FMainForm_SizeChanged);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.cmsAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem tmiTongQuan;
        private System.Windows.Forms.ToolStripTextBox ttxtTaiKhoan;
        private System.Windows.Forms.ToolStripTextBox ttxtMatKhau;
        private System.Windows.Forms.ToolStripMenuItem tmiHocTap;
        private System.Windows.Forms.ToolStripMenuItem tmiDiemSoHT;
        private System.Windows.Forms.ToolStripMenuItem tmiThoiKhoaBieu;
        private System.Windows.Forms.ToolStripMenuItem tmiDangNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tmiThoat;
        private System.Windows.Forms.ToolStripMenuItem tmiSuKienHoatDong;
        private System.Windows.Forms.ToolStripMenuItem tmiBaoCao;
        private System.Windows.Forms.ToolStripMenuItem tmiDiemSoBC;
        private System.Windows.Forms.ToolStripMenuItem tmiMonHoc;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.ContextMenuStrip cmsAccount;
        private System.Windows.Forms.ToolStripMenuItem tmiDangXuat;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmiDangXuatTongQuan;
    }
}

