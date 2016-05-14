namespace WFAQuanLyCaNhanSinhVien
{
    partial class FReportDiem
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
            
            this.reportViewerDiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cDiemSoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cDiemSoDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerDiem
            // 
            
           
            this.reportViewerDiem.LocalReport.ReportEmbeddedResource = "WFAQuanLyCaNhanSinhVien.ReportDiem.rdlc";
            this.reportViewerDiem.Location = new System.Drawing.Point(-2, -1);
            this.reportViewerDiem.Name = "reportViewerDiem";
            this.reportViewerDiem.Size = new System.Drawing.Size(797, 448);
            this.reportViewerDiem.TabIndex = 0;
            // 
            // cDiemSoDTOBindingSource
            // 
            this.cDiemSoDTOBindingSource.DataSource = typeof(QuanLyCaNhanSinhVien_DTO.CDiemSo_DTO);
            // 
            // FReportDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 446);
            this.Controls.Add(this.reportViewerDiem);
            this.Name = "FReportDiem";
            this.Text = "FReportDiem";
            this.Load += new System.EventHandler(this.FReportDiem_Load);
            this.Resize += new System.EventHandler(this.FReportDiem_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.cDiemSoDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDiem;
        private Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1;
        private System.Windows.Forms.BindingSource cDiemSoDTOBindingSource;
    }
}