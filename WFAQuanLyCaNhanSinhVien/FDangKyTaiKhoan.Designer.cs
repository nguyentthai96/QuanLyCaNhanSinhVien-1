using System;
using TaoTaiKhoan_WFC;

namespace WFAQuanLyCaNhanSinhVien
{
    partial class FDangKyTaiKhoan
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
            this.ucDangKyTK1 = new TaoTaiKhoan_WFC.UCDangKyTK(strMaSV);
            this.SuspendLayout();
            // 
            // ucDangKyTK1
            // 
            this.ucDangKyTK1.Location = new System.Drawing.Point(-2, 6);
            this.ucDangKyTK1.Name = "ucDangKyTK1";
            this.ucDangKyTK1.Size = new System.Drawing.Size(387, 210);
            this.ucDangKyTK1.TabIndex = 0;
            this.ucDangKyTK1.TaoTaiKhoan += new TaoTaiKhoan_WFC.DangKy(ucDangKy_GhiDuLieu_TaoTaiKhoan);
            // 
            // FDangKyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 228);
            this.Controls.Add(this.ucDangKyTK1);
            this.Name = "FDangKyTaiKhoan";
            this.Text = "FDangKyTaiKhoan";
            this.ResumeLayout(false);

        }

        #endregion

        private TaoTaiKhoan_WFC.UCDangKyTK ucDangKyTK1;
    }
}