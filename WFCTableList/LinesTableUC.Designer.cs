using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WFCTableList
{
    partial class LinesTableUC
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
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion

        private void intialComponemt()
        {
            ///Lable Context
            ///
            this.lblTitle = new Label();
        this.lblTitle.AutoEllipsis = true;
        this.lblTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
        this.lblTitle.Location = new System.Drawing.Point(0, 0);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(this.Width, (int)(0.18 * this.Height));
        float emSize = (float)(0.07 * this.Height);
        this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", emSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Môn học hôm nay";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(lblTitle);

            //Bo duong doc
            ///Lable lblLineVertical
            ///
            //lblLineVertical = new Label();
            //lblLineVertical.AutoSize = false;
            //lblLineVertical.BorderStyle = BorderStyle.Fixed3D;
            //lblLineVertical.Location = new System.Drawing.Point((int)(0.22*this.Width), (int)(0.18 * this.Width));
            //lblLineVertical.Size = new System.Drawing.Size(2,(int)(0.82*this.Height));
            //this.Controls.Add(lblLineVertical);

            foreach (TreeLabel tupLable in listsTupLable)
            {
                //tupLable.LblLine.BorderStyle = BorderStyle.Fixed3D;
                //this.Controls.Add(tupLable.LblLine);

                tupLable.LblTime.BorderStyle = BorderStyle.Fixed3D;
                tupLable.LblTime.AutoSize = false;
                tupLable.LblTime.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(tupLable.LblTime);

                tupLable.LblContext.BorderStyle = BorderStyle.Fixed3D;
                tupLable.LblContext.AutoSize = false;
                tupLable.LblContext.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(tupLable.LblContext);
            }

            ///UserControl
            ///
            this.Resize += new EventHandler(linesTableUC_Resize);
        }

        private Label lblTitle;
        //private Label lblLineVertical;
        private List<TreeLabel> listsTupLable;
    }
}
