namespace WFAQuanLyCaNhanSinhVien
{
    partial class FDSThoiKhoaBieu
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.cmsThoiKhoaBieu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmThờiKhóaKiểuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaHoạtĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsThoiKhoaBieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(-1, -3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(816, 446);
            this.tabControl.TabIndex = 0;
            // 
            // cmsThoiKhoaBieu
            // 
            this.cmsThoiKhoaBieu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaHoạtĐộngToolStripMenuItem,
            this.thêmThờiKhóaKiểuToolStripMenuItem});
            this.cmsThoiKhoaBieu.Name = "cmsThoiKhoaBieu";
            this.cmsThoiKhoaBieu.Size = new System.Drawing.Size(187, 70);
            // 
            // thêmThờiKhóaKiểuToolStripMenuItem
            // 
            this.thêmThờiKhóaKiểuToolStripMenuItem.Name = "thêmThờiKhóaKiểuToolStripMenuItem";
            this.thêmThờiKhóaKiểuToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.thêmThờiKhóaKiểuToolStripMenuItem.Text = "Thêm Thời khóa kiểu";
            this.thêmThờiKhóaKiểuToolStripMenuItem.Click += new System.EventHandler(this.thêmThờiKhóaKiểuToolStripMenuItem_Click);
            // 
            // xóaHoạtĐộngToolStripMenuItem
            // 
            this.xóaHoạtĐộngToolStripMenuItem.Name = "xóaHoạtĐộngToolStripMenuItem";
            this.xóaHoạtĐộngToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.xóaHoạtĐộngToolStripMenuItem.Text = "Xóa hoạt động";
            this.xóaHoạtĐộngToolStripMenuItem.Click += new System.EventHandler(this.xóaHoạtĐộngToolStripMenuItem_Click);
            // 
            // FDSThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 445);
            this.Controls.Add(this.tabControl);
            this.Name = "FDSThoiKhoaBieu";
            this.Text = "FDSThoiKhoaBieu";
            this.Load += new System.EventHandler(this.FDSThoiKhoaBieu_Load);
            this.Resize += new System.EventHandler(this.FDSThoiKhoaBieu_Resize);
            this.cmsThoiKhoaBieu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ContextMenuStrip cmsThoiKhoaBieu;
        private System.Windows.Forms.ToolStripMenuItem thêmThờiKhóaKiểuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHoạtĐộngToolStripMenuItem;
    }
}