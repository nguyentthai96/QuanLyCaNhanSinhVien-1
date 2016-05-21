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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyCaNhanSinhVienDataSet = new WFAQuanLyCaNhanSinhVien.QuanLyCaNhanSinhVienDataSet();
            this.reportViewerDiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportDiemTableAdapter = new WFAQuanLyCaNhanSinhVien.QuanLyCaNhanSinhVienDataSetTableAdapters.reportDiemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCaNhanSinhVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDiemBindingSource
            // 
            this.reportDiemBindingSource.DataMember = "reportDiem";
            this.reportDiemBindingSource.DataSource = this.QuanLyCaNhanSinhVienDataSet;
            // 
            // QuanLyCaNhanSinhVienDataSet
            // 
            this.QuanLyCaNhanSinhVienDataSet.DataSetName = "QuanLyCaNhanSinhVienDataSet";
            this.QuanLyCaNhanSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerDiem
            // 
            this.reportViewerDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsDiem";
            reportDataSource1.Value = this.reportDiemBindingSource;
            this.reportViewerDiem.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDiem.LocalReport.ReportEmbeddedResource = "WFAQuanLyCaNhanSinhVien.Report1.rdlc";
            this.reportViewerDiem.Location = new System.Drawing.Point(-2, 44);
            this.reportViewerDiem.Name = "reportViewerDiem";
            this.reportViewerDiem.Size = new System.Drawing.Size(797, 403);
            this.reportViewerDiem.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(394, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Học kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Môn học";
            // 
            // reportDiemTableAdapter
            // 
            this.reportDiemTableAdapter.ClearBeforeFill = true;
            // 
            // FReportDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewerDiem);
            this.Name = "FReportDiem";
            this.Text = "FReportDiem";
            this.Load += new System.EventHandler(this.FReportDiem_Load);
            this.Resize += new System.EventHandler(this.FReportDiem_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.reportDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyCaNhanSinhVienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDiem;
        private Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.ReportingServices.Diagnostics.Internal.DataSet dsReport;
        private System.Windows.Forms.BindingSource reportDiemBindingSource;
        private QuanLyCaNhanSinhVienDataSet QuanLyCaNhanSinhVienDataSet;
        private QuanLyCaNhanSinhVienDataSetTableAdapters.reportDiemTableAdapter reportDiemTableAdapter;
    }
}