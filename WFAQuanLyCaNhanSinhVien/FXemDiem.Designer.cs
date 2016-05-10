namespace WFAQuanLyCaNhanSinhVien
{
    partial class FXemDiem
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
            this.dgvDiemSo = new System.Windows.Forms.DataGridView();
            this.cmsClickDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmiInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMonHoc = new System.Windows.Forms.Label();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).BeginInit();
            this.cmsClickDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiemSo
            // 
            this.dgvDiemSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemSo.ContextMenuStrip = this.cmsClickDgv;
            this.dgvDiemSo.Location = new System.Drawing.Point(209, 5);
            this.dgvDiemSo.Name = "dgvDiemSo";
            this.dgvDiemSo.Size = new System.Drawing.Size(577, 522);
            this.dgvDiemSo.TabIndex = 0;
            this.dgvDiemSo.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDiemSo_CellMouseDown);
            // 
            // cmsClickDgv
            // 
            this.cmsClickDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiInsert,
            this.tmiEdit,
            this.tmiRemove});
            this.cmsClickDgv.Name = "cmsClickDgv";
            this.cmsClickDgv.Size = new System.Drawing.Size(153, 92);
            // 
            // tmiInsert
            // 
            this.tmiInsert.Name = "tmiInsert";
            this.tmiInsert.Size = new System.Drawing.Size(152, 22);
            this.tmiInsert.Text = "Insert";
            this.tmiInsert.Click += new System.EventHandler(this.tmiInsert_Click);
            // 
            // tmiEdit
            // 
            this.tmiEdit.Name = "tmiEdit";
            this.tmiEdit.Size = new System.Drawing.Size(152, 22);
            this.tmiEdit.Text = "Edit";
            this.tmiEdit.Click += new System.EventHandler(this.tmiEdit_Click);
            // 
            // tmiRemove
            // 
            this.tmiRemove.Name = "tmiRemove";
            this.tmiRemove.Size = new System.Drawing.Size(152, 22);
            this.tmiRemove.Text = "Remove";
            this.tmiRemove.Click += new System.EventHandler(this.tmiRemove_Click);
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.AutoSize = true;
            this.txtMonHoc.Location = new System.Drawing.Point(13, 40);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(49, 13);
            this.txtMonHoc.TabIndex = 1;
            this.txtMonHoc.Text = "Môn học";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(16, 68);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(178, 21);
            this.cmbMonHoc.TabIndex = 2;
            this.cmbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbMonHoc_SelectedIndexChanged);
            // 
            // FXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 532);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.txtMonHoc);
            this.Controls.Add(this.dgvDiemSo);
            this.Name = "FXemDiem";
            this.Text = "FXemDiem";
            this.Load += new System.EventHandler(this.FXemDiem_Load);
            this.Resize += new System.EventHandler(this.FXemDiem_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).EndInit();
            this.cmsClickDgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiemSo;
        private System.Windows.Forms.Label txtMonHoc;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.ContextMenuStrip cmsClickDgv;
        private System.Windows.Forms.ToolStripMenuItem tmiInsert;
        private System.Windows.Forms.ToolStripMenuItem tmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tmiRemove;
    }
}