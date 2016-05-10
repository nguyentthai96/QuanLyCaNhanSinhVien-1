namespace WFAQuanLyCaNhanSinhVien
{
    partial class FSuaDiem
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
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.lblSoDiem = new System.Windows.Forms.Label();
            this.lblHeSo = new System.Windows.Forms.Label();
            this.lblNgayDiem = new System.Windows.Forms.Label();
            this.txtSoDiem = new System.Windows.Forms.TextBox();
            this.dtmpNgayDiem = new System.Windows.Forms.DateTimePicker();
            this.txtHeSo = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(23, 27);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(49, 13);
            this.lblMonHoc.TabIndex = 1;
            this.lblMonHoc.Text = "Môn học";
            // 
            // lblSoDiem
            // 
            this.lblSoDiem.AutoSize = true;
            this.lblSoDiem.Location = new System.Drawing.Point(23, 109);
            this.lblSoDiem.Name = "lblSoDiem";
            this.lblSoDiem.Size = new System.Drawing.Size(46, 13);
            this.lblSoDiem.TabIndex = 2;
            this.lblSoDiem.Text = "Số điểm";
            // 
            // lblHeSo
            // 
            this.lblHeSo.AutoSize = true;
            this.lblHeSo.Location = new System.Drawing.Point(23, 150);
            this.lblHeSo.Name = "lblHeSo";
            this.lblHeSo.Size = new System.Drawing.Size(35, 13);
            this.lblHeSo.TabIndex = 2;
            this.lblHeSo.Text = "Hệ số";
            // 
            // lblNgayDiem
            // 
            this.lblNgayDiem.AutoSize = true;
            this.lblNgayDiem.Location = new System.Drawing.Point(23, 67);
            this.lblNgayDiem.Name = "lblNgayDiem";
            this.lblNgayDiem.Size = new System.Drawing.Size(58, 13);
            this.lblNgayDiem.TabIndex = 2;
            this.lblNgayDiem.Text = "Ngày điểm";
            // 
            // txtSoDiem
            // 
            this.txtSoDiem.Location = new System.Drawing.Point(113, 106);
            this.txtSoDiem.Name = "txtSoDiem";
            this.txtSoDiem.Size = new System.Drawing.Size(59, 20);
            this.txtSoDiem.TabIndex = 3;
            // 
            // dtmpNgayDiem
            // 
            this.dtmpNgayDiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmpNgayDiem.Location = new System.Drawing.Point(113, 61);
            this.dtmpNgayDiem.Name = "dtmpNgayDiem";
            this.dtmpNgayDiem.Size = new System.Drawing.Size(121, 20);
            this.dtmpNgayDiem.TabIndex = 4;
            // 
            // txtHeSo
            // 
            this.txtHeSo.Location = new System.Drawing.Point(113, 147);
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.Size = new System.Drawing.Size(59, 20);
            this.txtHeSo.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(113, 202);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(220, 202);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.Enabled = false;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(113, 24);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cmbMonHoc.TabIndex = 6;
            // 
            // FSuaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 249);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dtmpNgayDiem);
            this.Controls.Add(this.txtHeSo);
            this.Controls.Add(this.txtSoDiem);
            this.Controls.Add(this.lblNgayDiem);
            this.Controls.Add(this.lblHeSo);
            this.Controls.Add(this.lblSoDiem);
            this.Controls.Add(this.lblMonHoc);
            this.Name = "FSuaDiem";
            this.Text = "FSuaDiem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Label lblSoDiem;
        private System.Windows.Forms.Label lblHeSo;
        private System.Windows.Forms.Label lblNgayDiem;
        private System.Windows.Forms.TextBox txtSoDiem;
        private System.Windows.Forms.DateTimePicker dtmpNgayDiem;
        private System.Windows.Forms.TextBox txtHeSo;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cmbMonHoc;
    }
}