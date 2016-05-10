namespace WFAQuanLyCaNhanSinhVien
{
    partial class FDSMonHoc
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
            this.dgvDSMon = new System.Windows.Forms.DataGridView();
            this.cmsRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).BeginInit();
            this.cmsRightClick.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSMon
            // 
            this.dgvDSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMon.ContextMenuStrip = this.cmsRightClick;
            this.dgvDSMon.Location = new System.Drawing.Point(148, 12);
            this.dgvDSMon.Name = "dgvDSMon";
            this.dgvDSMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMon.Size = new System.Drawing.Size(652, 522);
            this.dgvDSMon.TabIndex = 0;
            // 
            // cmsRightClick
            // 
            this.cmsRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiInsert,
            this.tmiEdit,
            this.tmiDelete});
            this.cmsRightClick.Name = "cmsRightClick";
            this.cmsRightClick.Size = new System.Drawing.Size(108, 70);
            // 
            // tmiInsert
            // 
            this.tmiInsert.Name = "tmiInsert";
            this.tmiInsert.Size = new System.Drawing.Size(107, 22);
            this.tmiInsert.Text = "Insert";
            // 
            // tmiEdit
            // 
            this.tmiEdit.Name = "tmiEdit";
            this.tmiEdit.Size = new System.Drawing.Size(107, 22);
            this.tmiEdit.Text = "Edit";
            // 
            // tmiDelete
            // 
            this.tmiDelete.Name = "tmiDelete";
            this.tmiDelete.Size = new System.Drawing.Size(107, 22);
            this.tmiDelete.Text = "Delete";
            this.tmiDelete.Click += new System.EventHandler(this.tmiDelete_Click);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(12, 81);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(130, 21);
            this.cmbHocKy.TabIndex = 2;
            this.cmbHocKy.SelectedIndexChanged += new System.EventHandler(this.cmbHocKy_SelectedIndexChanged);
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(9, 52);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(41, 13);
            this.lblHocKy.TabIndex = 3;
            this.lblHocKy.Text = "Học kỳ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "cmsRightClick";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Insert";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Text = "Edit";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem3.Text = "Delete";
            // 
            // FDSMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 546);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.cmbHocKy);
            this.Controls.Add(this.dgvDSMon);
            this.Name = "FDSMonHoc";
            this.Text = "FDSMonHoc";
            this.Load += new System.EventHandler(this.FDSMonHoc_Load);
            this.Resize += new System.EventHandler(this.FDSMonHoc_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).EndInit();
            this.cmsRightClick.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSMon;
        private System.Windows.Forms.ContextMenuStrip cmsRightClick;
        private System.Windows.Forms.ToolStripMenuItem tmiInsert;
        private System.Windows.Forms.ToolStripMenuItem tmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tmiDelete;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}