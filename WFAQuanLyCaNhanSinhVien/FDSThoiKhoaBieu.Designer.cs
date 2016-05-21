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
            this.cmsThoiKhoaBieu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaHoạtĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmThờiKhóaKiểuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNextThu = new System.Windows.Forms.Button();
            this.dgvThu = new System.Windows.Forms.DataGridView();
            this.btnPrevThu = new System.Windows.Forms.Button();
            this.cmsThoiKhoaBieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThu)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsThoiKhoaBieu
            // 
            this.cmsThoiKhoaBieu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaHoạtĐộngToolStripMenuItem,
            this.thêmThờiKhóaKiểuToolStripMenuItem});
            this.cmsThoiKhoaBieu.Name = "cmsThoiKhoaBieu";
            this.cmsThoiKhoaBieu.Size = new System.Drawing.Size(187, 48);
            // 
            // xóaHoạtĐộngToolStripMenuItem
            // 
            this.xóaHoạtĐộngToolStripMenuItem.Name = "xóaHoạtĐộngToolStripMenuItem";
            this.xóaHoạtĐộngToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.xóaHoạtĐộngToolStripMenuItem.Text = "Xóa hoạt động";
            // 
            // thêmThờiKhóaKiểuToolStripMenuItem
            // 
            this.thêmThờiKhóaKiểuToolStripMenuItem.Name = "thêmThờiKhóaKiểuToolStripMenuItem";
            this.thêmThờiKhóaKiểuToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.thêmThờiKhóaKiểuToolStripMenuItem.Text = "Thêm Thời khóa kiểu";
            // 
            // btnNextThu
            // 
            this.btnNextThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextThu.Location = new System.Drawing.Point(691, 12);
            this.btnNextThu.Name = "btnNextThu";
            this.btnNextThu.Size = new System.Drawing.Size(110, 23);
            this.btnNextThu.TabIndex = 1;
            this.btnNextThu.Text = "Thứ tiếp theo";
            this.btnNextThu.UseVisualStyleBackColor = true;
            this.btnNextThu.Click += new System.EventHandler(this.btnNextThu_Click);
            // 
            // dgvThu
            // 
            this.dgvThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThu.Location = new System.Drawing.Point(12, 41);
            this.dgvThu.Name = "dgvThu";
            this.dgvThu.Size = new System.Drawing.Size(789, 392);
            this.dgvThu.TabIndex = 2;
            // 
            // btnPrevThu
            // 
            this.btnPrevThu.Location = new System.Drawing.Point(12, 12);
            this.btnPrevThu.Name = "btnPrevThu";
            this.btnPrevThu.Size = new System.Drawing.Size(110, 23);
            this.btnPrevThu.TabIndex = 1;
            this.btnPrevThu.Text = "Thứ trước";
            this.btnPrevThu.UseVisualStyleBackColor = true;
            this.btnPrevThu.Click += new System.EventHandler(this.btnPrevThu_Click);
            // 
            // FDSThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 445);
            this.Controls.Add(this.dgvThu);
            this.Controls.Add(this.btnPrevThu);
            this.Controls.Add(this.btnNextThu);
            this.Name = "FDSThoiKhoaBieu";
            this.Text = "FDSThoiKhoaBieu";
            this.Load += new System.EventHandler(this.FDSThoiKhoaBieu_Load);
            this.cmsThoiKhoaBieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsThoiKhoaBieu;
        private System.Windows.Forms.ToolStripMenuItem thêmThờiKhóaKiểuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaHoạtĐộngToolStripMenuItem;
        private System.Windows.Forms.Button btnNextThu;
        private System.Windows.Forms.DataGridView dgvThu;
        private System.Windows.Forms.Button btnPrevThu;
    }
}