namespace WFAQuanLyCaNhanSinhVien
{
    partial class FormTest
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
            this.linesTableUC1 = new WFCTableList.LinesTableUC();
            this.SuspendLayout();
            // 
            // linesTableUC1
            // 
            this.linesTableUC1.Location = new System.Drawing.Point(158, 56);
            this.linesTableUC1.Name = "linesTableUC1";
            this.linesTableUC1.Size = new System.Drawing.Size(186, 132);
            this.linesTableUC1.TabIndex = 0;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 554);
            this.Controls.Add(this.linesTableUC1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private WFCTableList.LinesTableUC linesTableUC1;
    }
}