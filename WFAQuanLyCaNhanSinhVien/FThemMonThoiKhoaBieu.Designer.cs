﻿namespace WFAQuanLyCaNhanSinhVien
{
    partial class FThemMonThoiKhoaBieu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMauLich = new System.Windows.Forms.Label();
            this.numbTiet = new System.Windows.Forms.NumericUpDown();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTiet = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblDen2 = new System.Windows.Forms.Label();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtmpDen = new System.Windows.Forms.DateTimePicker();
            this.lblThemHoatDong = new System.Windows.Forms.Label();
            this.cold = new System.Windows.Forms.ColorDialog();
            this.lblThu = new System.Windows.Forms.Label();
            this.numbThu = new System.Windows.Forms.NumericUpDown();
            dtmpTu = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMauLich);
            this.panel1.Controls.Add(this.numbThu);
            this.panel1.Controls.Add(this.numbTiet);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lblThu);
            this.panel1.Controls.Add(this.lblTiet);
            this.panel1.Controls.Add(this.txtMoTa);
            this.panel1.Controls.Add(this.lblDen2);
            this.panel1.Controls.Add(this.cmbMonHoc);
            this.panel1.Controls.Add(this.lblMoTa);
            this.panel1.Controls.Add(this.lblMonHoc);
            this.panel1.Controls.Add(this.lblTu);
            this.panel1.Controls.Add(dtmpTu);
            this.panel1.Controls.Add(this.dtmpDen);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 386);
            this.panel1.TabIndex = 10;
            // 
            // lblMauLich
            // 
            this.lblMauLich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMauLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMauLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMauLich.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMauLich.Location = new System.Drawing.Point(342, 30);
            this.lblMauLich.Name = "lblMauLich";
            this.lblMauLich.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMauLich.Size = new System.Drawing.Size(121, 62);
            this.lblMauLich.TabIndex = 10;
            this.lblMauLich.Text = "Màu lịch";
            this.lblMauLich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMauLich.Click += new System.EventHandler(this.lblMauLich_Click);
            // 
            // numbTiet
            // 
            this.numbTiet.Location = new System.Drawing.Point(153, 72);
            this.numbTiet.Name = "numbTiet";
            this.numbTiet.Size = new System.Drawing.Size(120, 20);
            this.numbTiet.TabIndex = 9;
            this.numbTiet.ValueChanged += new System.EventHandler(this.numbTiet_ValueChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(392, 329);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(265, 329);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTiet
            // 
            this.lblTiet.AutoSize = true;
            this.lblTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiet.Location = new System.Drawing.Point(19, 72);
            this.lblTiet.Name = "lblTiet";
            this.lblTiet.Size = new System.Drawing.Size(63, 17);
            this.lblTiet.TabIndex = 1;
            this.lblTiet.Text = "Tiết học:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(153, 205);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(314, 100);
            this.txtMoTa.TabIndex = 7;
            // 
            // lblDen2
            // 
            this.lblDen2.AutoSize = true;
            this.lblDen2.Enabled = false;
            this.lblDen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDen2.Location = new System.Drawing.Point(300, 118);
            this.lblDen2.Name = "lblDen2";
            this.lblDen2.Size = new System.Drawing.Size(36, 17);
            this.lblDen2.TabIndex = 1;
            this.lblDen2.Text = "đến:";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(153, 30);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(121, 24);
            this.cmbMonHoc.TabIndex = 6;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(19, 205);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(47, 17);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.Location = new System.Drawing.Point(19, 30);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(66, 17);
            this.lblMonHoc.TabIndex = 5;
            this.lblMonHoc.Text = "Môn học:";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTu.Location = new System.Drawing.Point(19, 112);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(29, 17);
            this.lblTu.TabIndex = 4;
            this.lblTu.Text = "Từ:";
            // 
            // dtmpTu
            // 
            dtmpTu.Enabled = false;
            dtmpTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtmpTu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtmpTu.Location = new System.Drawing.Point(153, 112);
            dtmpTu.Name = "dtmpTu";
            dtmpTu.ShowUpDown = true;
            dtmpTu.Size = new System.Drawing.Size(121, 23);
            dtmpTu.TabIndex = 3;
            // 
            // dtmpDen
            // 
            this.dtmpDen.Enabled = false;
            this.dtmpDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmpDen.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmpDen.Location = new System.Drawing.Point(342, 114);
            this.dtmpDen.Name = "dtmpDen";
            this.dtmpDen.ShowUpDown = true;
            this.dtmpDen.Size = new System.Drawing.Size(121, 23);
            this.dtmpDen.TabIndex = 3;
            // 
            // lblThemHoatDong
            // 
            this.lblThemHoatDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemHoatDong.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblThemHoatDong.Location = new System.Drawing.Point(12, 9);
            this.lblThemHoatDong.Name = "lblThemHoatDong";
            this.lblThemHoatDong.Size = new System.Drawing.Size(544, 61);
            this.lblThemHoatDong.TabIndex = 9;
            this.lblThemHoatDong.Text = "Thêm lịch học vào TKB";
            this.lblThemHoatDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThemHoatDong.UseWaitCursor = true;
            // 
            // cold
            // 
            this.cold.Color = System.Drawing.SystemColors.ControlLight;
            // 
            // lblThu
            // 
            this.lblThu.AutoSize = true;
            this.lblThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThu.Location = new System.Drawing.Point(22, 156);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(37, 17);
            this.lblThu.TabIndex = 1;
            this.lblThu.Text = "Thứ:";
            // 
            // numbThu
            // 
            this.numbThu.Location = new System.Drawing.Point(156, 156);
            this.numbThu.Name = "numbThu";
            this.numbThu.Size = new System.Drawing.Size(120, 20);
            this.numbThu.TabIndex = 9;
            this.numbThu.ValueChanged += new System.EventHandler(this.numbTiet_ValueChanged);
            // 
            // FThemMonThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblThemHoatDong);
            this.Name = "FThemMonThoiKhoaBieu";
            this.Text = "FMonThoiKhoaBieu";
            this.Load += new System.EventHandler(this.FThemMonThoiKhoaBieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTiet;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblDen2;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtmpDen;
        private System.Windows.Forms.Label lblThemHoatDong;
        private System.Windows.Forms.NumericUpDown numbTiet;
        private System.Windows.Forms.Label lblMauLich;
        private System.Windows.Forms.ColorDialog cold;
        private System.Windows.Forms.NumericUpDown numbThu;
        private System.Windows.Forms.Label lblThu;
        private System.Windows.Forms.DateTimePicker dtmpTu;
    }
}