namespace WFAQuanLyCaNhanSinhVien
{
    partial class FThemSuKien
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
            this.lblThemHoatDong = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblDen2 = new System.Windows.Forms.Label();
            this.dtmpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblThoiGianBatDau = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblDen1 = new System.Windows.Forms.Label();
            this.dtmpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.dtmpThoiGianDen = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtmpThoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThemHoatDong
            // 
            this.lblThemHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemHoatDong.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblThemHoatDong.Location = new System.Drawing.Point(23, 21);
            this.lblThemHoatDong.Name = "lblThemHoatDong";
            this.lblThemHoatDong.Size = new System.Drawing.Size(544, 61);
            this.lblThemHoatDong.TabIndex = 0;
            this.lblThemHoatDong.Text = "Thêm hoạt động";
            this.lblThemHoatDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThemHoatDong.UseWaitCursor = true;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBatDau.Location = new System.Drawing.Point(37, 35);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(97, 17);
            this.lblNgayBatDau.TabIndex = 1;
            this.lblNgayBatDau.Text = "Ngày bắt đầu:";
            // 
            // lblDen2
            // 
            this.lblDen2.AutoSize = true;
            this.lblDen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDen2.Location = new System.Drawing.Point(322, 105);
            this.lblDen2.Name = "lblDen2";
            this.lblDen2.Size = new System.Drawing.Size(36, 17);
            this.lblDen2.TabIndex = 1;
            this.lblDen2.Text = "đến:";
            // 
            // dtmpNgayBatDau
            // 
            this.dtmpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmpNgayBatDau.Location = new System.Drawing.Point(171, 35);
            this.dtmpNgayBatDau.Name = "dtmpNgayBatDau";
            this.dtmpNgayBatDau.Size = new System.Drawing.Size(121, 23);
            this.dtmpNgayBatDau.TabIndex = 2;
            // 
            // lblThoiGianBatDau
            // 
            this.lblThoiGianBatDau.AutoSize = true;
            this.lblThoiGianBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianBatDau.Location = new System.Drawing.Point(37, 105);
            this.lblThoiGianBatDau.Name = "lblThoiGianBatDau";
            this.lblThoiGianBatDau.Size = new System.Drawing.Size(123, 17);
            this.lblThoiGianBatDau.TabIndex = 4;
            this.lblThoiGianBatDau.Text = "Thời gian bắt đầu:";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.Location = new System.Drawing.Point(37, 170);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(66, 17);
            this.lblMonHoc.TabIndex = 5;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(171, 170);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(121, 24);
            this.cmbMonHoc.TabIndex = 6;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(171, 236);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(314, 100);
            this.txtMoTa.TabIndex = 7;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(37, 236);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(47, 17);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // lblDen1
            // 
            this.lblDen1.AutoSize = true;
            this.lblDen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDen1.Location = new System.Drawing.Point(322, 35);
            this.lblDen1.Name = "lblDen1";
            this.lblDen1.Size = new System.Drawing.Size(36, 17);
            this.lblDen1.TabIndex = 1;
            this.lblDen1.Text = "đến:";
            // 
            // dtmpNgayDen
            // 
            this.dtmpNgayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmpNgayDen.Location = new System.Drawing.Point(364, 34);
            this.dtmpNgayDen.Name = "dtmpNgayDen";
            this.dtmpNgayDen.Size = new System.Drawing.Size(121, 23);
            this.dtmpNgayDen.TabIndex = 2;
            // 
            // dtmpThoiGianDen
            // 
            this.dtmpThoiGianDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmpThoiGianDen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmpThoiGianDen.Location = new System.Drawing.Point(364, 106);
            this.dtmpThoiGianDen.Name = "dtmpThoiGianDen";
            this.dtmpThoiGianDen.ShowUpDown = true;
            this.dtmpThoiGianDen.Size = new System.Drawing.Size(121, 23);
            this.dtmpThoiGianDen.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lblNgayBatDau);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.lblDen2);
            this.panel1.Controls.Add(this.cmbMonHoc);
            this.panel1.Controls.Add(this.lblDen1);
            this.panel1.Controls.Add(this.lblMoTa);
            this.panel1.Controls.Add(this.dtmpNgayBatDau);
            this.panel1.Controls.Add(this.lblMonHoc);
            this.panel1.Controls.Add(this.dtmpNgayDen);
            this.panel1.Controls.Add(this.lblThoiGianBatDau);
            this.panel1.Controls.Add(dtmpThoiGianBatDau);
            this.panel1.Controls.Add(this.dtmpThoiGianDen);
            this.panel1.Location = new System.Drawing.Point(23, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 404);
            this.panel1.TabIndex = 8;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(410, 360);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(283, 360);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtmpThoiGianBatDau
            // 
            this.dtmpThoiGianBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmpThoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmpThoiGianBatDau.Location = new System.Drawing.Point(171, 105);
            this.dtmpThoiGianBatDau.Name = "dtmpThoiGianBatDau";
            this.dtmpThoiGianBatDau.ShowUpDown = true;
            this.dtmpThoiGianBatDau.Size = new System.Drawing.Size(121, 23);
            this.dtmpThoiGianBatDau.TabIndex = 3;
            // 
            // FThemSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblThemHoatDong);
            this.Name = "FThemSuKien";
            this.Text = "FThemHoatDong";
            this.Load += new System.EventHandler(this.FThemSuKien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThemHoatDong;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblDen2;
        private System.Windows.Forms.DateTimePicker dtmpNgayBatDau;
        private System.Windows.Forms.Label lblThoiGianBatDau;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblDen1;
        private System.Windows.Forms.DateTimePicker dtmpNgayDen;
        private System.Windows.Forms.DateTimePicker dtmpThoiGianDen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtmpThoiGianBatDau;
    }
}