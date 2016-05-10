namespace WFCTableList
{
    partial class LineTable_UC
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.lblMonHocHomNay = new System.Windows.Forms.Label();
            this.pnlThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.Controls.Add(this.lblMonHocHomNay);
            this.pnlThongTin.Location = new System.Drawing.Point(0, 0);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(319, 252);
            this.pnlThongTin.TabIndex = 3;
            // 
            // lblMonHocHomNay
            // 
            this.lblMonHocHomNay.AutoEllipsis = true;
            this.lblMonHocHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHocHomNay.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblMonHocHomNay.Location = new System.Drawing.Point(3, -1);
            this.lblMonHocHomNay.Name = "lblMonHocHomNay";
            this.lblMonHocHomNay.Size = new System.Drawing.Size(313, 30);
            this.lblMonHocHomNay.TabIndex = 0;
            this.lblMonHocHomNay.Text = "Môn học hôm nay";
            this.lblMonHocHomNay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LineTable_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlThongTin);
            this.Name = "LineTable_UC";
            this.Size = new System.Drawing.Size(321, 253);
            this.pnlThongTin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label lblMonHocHomNay;
    }
}
