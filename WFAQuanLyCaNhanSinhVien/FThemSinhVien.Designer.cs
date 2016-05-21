namespace WFAQuanLyCaNhanSinhVien
{
    partial class FThemSinhVien
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
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.dtmpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtThongTinKhac = new System.Windows.Forms.TextBox();
            this.lblNgSinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblThongTinKhac = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picImageSV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(123, 28);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(69, 13);
            this.lblMaSinhVien.TabIndex = 0;
            this.lblMaSinhVien.Text = "Mã Sinh viên";
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new System.Drawing.Point(221, 114);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(47, 17);
            this.rdoNam.TabIndex = 1;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            this.rdoNam.CheckedChanged += new System.EventHandler(this.rdoNam_CheckedChanged);
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(316, 114);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(39, 17);
            this.rdoNu.TabIndex = 1;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            this.rdoNu.CheckedChanged += new System.EventHandler(this.rdoNu_CheckedChanged);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(123, 118);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(221, 25);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(223, 20);
            this.txtMaSinhVien.TabIndex = 2;
            // 
            // dtmpNgaySinh
            // 
            this.dtmpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmpNgaySinh.Location = new System.Drawing.Point(221, 152);
            this.dtmpNgaySinh.Name = "dtmpNgaySinh";
            this.dtmpNgaySinh.Size = new System.Drawing.Size(223, 20);
            this.dtmpNgaySinh.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(126, 211);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(318, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtThongTinKhac
            // 
            this.txtThongTinKhac.Location = new System.Drawing.Point(126, 261);
            this.txtThongTinKhac.Multiline = true;
            this.txtThongTinKhac.Name = "txtThongTinKhac";
            this.txtThongTinKhac.Size = new System.Drawing.Size(318, 87);
            this.txtThongTinKhac.TabIndex = 2;
            // 
            // lblNgSinh
            // 
            this.lblNgSinh.AutoSize = true;
            this.lblNgSinh.Location = new System.Drawing.Point(123, 159);
            this.lblNgSinh.Name = "lblNgSinh";
            this.lblNgSinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgSinh.TabIndex = 0;
            this.lblNgSinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(123, 75);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(39, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(221, 72);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(223, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(28, 211);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblThongTinKhac
            // 
            this.lblThongTinKhac.AutoSize = true;
            this.lblThongTinKhac.Location = new System.Drawing.Point(28, 261);
            this.lblThongTinKhac.Name = "lblThongTinKhac";
            this.lblThongTinKhac.Size = new System.Drawing.Size(79, 13);
            this.lblThongTinKhac.TabIndex = 0;
            this.lblThongTinKhac.Text = "Thông tin khác";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(167, 380);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(368, 380);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // picImageSV
            // 
            this.picImageSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picImageSV.ErrorImage = global::WFAQuanLyCaNhanSinhVien.Properties.Resources.student_female_512;
            this.picImageSV.Image = global::WFAQuanLyCaNhanSinhVien.Properties.Resources.student_male_512;
            this.picImageSV.Location = new System.Drawing.Point(12, 28);
            this.picImageSV.Name = "picImageSV";
            this.picImageSV.Size = new System.Drawing.Size(105, 144);
            this.picImageSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageSV.TabIndex = 5;
            this.picImageSV.TabStop = false;
            this.picImageSV.Click += new System.EventHandler(this.picImageSV_Click);
            // 
            // FThemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(476, 430);
            this.Controls.Add(this.picImageSV);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtmpNgaySinh);
            this.Controls.Add(this.txtThongTinKhac);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.lblThongTinKhac);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblNgSinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaSinhVien);
            this.Name = "FThemSinhVien";
            this.Text = "Thêm sinh viên";
            this.Load += new System.EventHandler(this.FThemSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.DateTimePicker dtmpNgaySinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtThongTinKhac;
        private System.Windows.Forms.Label lblNgSinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblThongTinKhac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picImageSV;
    }
}