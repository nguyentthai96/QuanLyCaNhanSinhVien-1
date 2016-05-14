using System.Drawing;
using System.Windows.Forms;

namespace WFAQuanLyCaNhanSinhVien
{
    partial class FTongQuan
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
            this.lblChaoMung = new System.Windows.Forms.Label();
            this.pnlCacSuKien = new System.Windows.Forms.Panel();
            this.cmsSuKienHomNay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiThemSuKien = new System.Windows.Forms.ToolStripMenuItem();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblPrev = new System.Windows.Forms.Label();
            this.lblCacSuKien = new System.Windows.Forms.Label();
            this.linesTableUC = new WFCTableList.LinesTableUC();
            this.cmsMonHocHomNay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiThemLich = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiThoiKhoaBieu = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCacSuKien.SuspendLayout();
            this.cmsSuKienHomNay.SuspendLayout();
            this.cmsMonHocHomNay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChaoMung
            // 
            this.lblChaoMung.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblChaoMung.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChaoMung.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblChaoMung.Location = new System.Drawing.Point(4, 50);
            this.lblChaoMung.Name = "lblChaoMung";
            this.lblChaoMung.Size = new System.Drawing.Size(875, 74);
            this.lblChaoMung.TabIndex = 0;
            this.lblChaoMung.Text = "Học tập vui vẻ";
            this.lblChaoMung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCacSuKien
            // 
            this.pnlCacSuKien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCacSuKien.ContextMenuStrip = this.cmsSuKienHomNay;
            this.pnlCacSuKien.Controls.Add(this.lblThoiGian);
            this.pnlCacSuKien.Controls.Add(this.lblThongTin);
            this.pnlCacSuKien.Controls.Add(this.lblNext);
            this.pnlCacSuKien.Controls.Add(this.lblPrev);
            this.pnlCacSuKien.Controls.Add(this.lblCacSuKien);
            this.pnlCacSuKien.Location = new System.Drawing.Point(95, 150);
            this.pnlCacSuKien.Name = "pnlCacSuKien";
            this.pnlCacSuKien.Size = new System.Drawing.Size(320, 252);
            this.pnlCacSuKien.TabIndex = 1;
            // 
            // cmsSuKienHomNay
            // 
            this.cmsSuKienHomNay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiThemSuKien});
            this.cmsSuKienHomNay.Name = "cmsSuKienHomNay";
            this.cmsSuKienHomNay.Size = new System.Drawing.Size(147, 26);
            // 
            // tmiThemSuKien
            // 
            this.tmiThemSuKien.Name = "tmiThemSuKien";
            this.tmiThemSuKien.Size = new System.Drawing.Size(146, 22);
            this.tmiThemSuKien.Text = "Thêm Sự kiện";
            this.tmiThemSuKien.Click += new System.EventHandler(this.tmiThemSuKien_Click);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblThoiGian.Location = new System.Drawing.Point(5, 207);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(309, 45);
            this.lblThoiGian.TabIndex = 3;
            this.lblThoiGian.Text = "Thời gian học";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThongTin
            // 
            this.lblThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblThongTin.Location = new System.Drawing.Point(41, 50);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(237, 142);
            this.lblThongTin.TabIndex = 2;
            this.lblThongTin.Text = "Học tập";
            this.lblThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNext
            // 
            this.lblNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(284, 96);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(45, 45);
            this.lblNext.TabIndex = 1;
            this.lblNext.Text = ">";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNext.Click += new System.EventHandler(this.lblNext_Click);
            // 
            // lblPrev
            // 
            this.lblPrev.Enabled = false;
            this.lblPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrev.Location = new System.Drawing.Point(-6, 96);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.Size = new System.Drawing.Size(45, 45);
            this.lblPrev.TabIndex = 1;
            this.lblPrev.Text = "<";
            this.lblPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrev.Click += new System.EventHandler(this.lblPrev_Click);
            // 
            // lblCacSuKien
            // 
            this.lblCacSuKien.AutoEllipsis = true;
            this.lblCacSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCacSuKien.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblCacSuKien.Location = new System.Drawing.Point(3, 2);
            this.lblCacSuKien.Name = "lblCacSuKien";
            this.lblCacSuKien.Size = new System.Drawing.Size(313, 36);
            this.lblCacSuKien.TabIndex = 0;
            this.lblCacSuKien.Text = "Các sự kiện sắp tới";
            this.lblCacSuKien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linesTableUC
            // 
            this.linesTableUC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linesTableUC.ContextMenuStrip = this.cmsMonHocHomNay;
            this.linesTableUC.Location = new System.Drawing.Point(467, 150);
            this.linesTableUC.Name = "linesTableUC";
            this.linesTableUC.Size = new System.Drawing.Size(320, 252);
            this.linesTableUC.TabIndex = 6;
            // 
            // cmsMonHocHomNay
            // 
            this.cmsMonHocHomNay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiThemLich,
            this.tmiThoiKhoaBieu});
            this.cmsMonHocHomNay.Name = "cmsMonHocHomNay";
            this.cmsMonHocHomNay.Size = new System.Drawing.Size(154, 70);
            // 
            // tmiThemLich
            // 
            this.tmiThemLich.Name = "tmiThemLich";
            this.tmiThemLich.Size = new System.Drawing.Size(153, 22);
            this.tmiThemLich.Text = "Thêm Lịch";
            this.tmiThemLich.Click += new System.EventHandler(this.tmiThemLich_Click);
            // 
            // tmiThoiKhoaBieu
            // 
            this.tmiThoiKhoaBieu.Name = "tmiThoiKhoaBieu";
            this.tmiThoiKhoaBieu.Size = new System.Drawing.Size(153, 22);
            this.tmiThoiKhoaBieu.Text = "Thời khóa biểu";
            this.tmiThoiKhoaBieu.Click += new System.EventHandler(this.tmiThoiKhoaBieu_Click);
            // 
            // FTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 550);
            this.Controls.Add(this.linesTableUC);
            this.Controls.Add(this.pnlCacSuKien);
            this.Controls.Add(this.lblChaoMung);
            this.Name = "FTongQuan";
            this.Text = "FTongQuan";
            this.Load += new System.EventHandler(this.FTongQuan_Load);
            this.SizeChanged += new System.EventHandler(this.FTongQuan_SizeChanged);
            this.pnlCacSuKien.ResumeLayout(false);
            this.cmsSuKienHomNay.ResumeLayout(false);
            this.cmsMonHocHomNay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChaoMung;
        private System.Windows.Forms.Panel pnlCacSuKien;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblPrev;
        private System.Windows.Forms.Label lblCacSuKien;

        private WFCTableList.LinesTableUC linesTableUC;
        private ContextMenuStrip cmsMonHocHomNay;
        private ToolStripMenuItem tmiThemLich;
        private ToolStripMenuItem tmiThoiKhoaBieu;
        private ContextMenuStrip cmsSuKienHomNay;
        private ToolStripMenuItem tmiThemSuKien;
    }
}