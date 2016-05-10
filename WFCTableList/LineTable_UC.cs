using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCTableList
{
    public partial class LineTable_UC : UserControl
    {
        private List<SuKien> lists;
        public LineTable_UC()
        {
            InitializeComponent();
            creatLineVertical(70, this.lblMonHocHomNay.Height, this.pnlThongTin.Height - this.lblMonHocHomNay.Height);
        }
        public LineTable_UC(List<SuKien> lists)
        {
            InitializeComponent();
            this.lists = lists;
            creatLineVertical(70, this.lblMonHocHomNay.Height,this.pnlThongTin.Height- this.lblMonHocHomNay.Height);
            int iCountLists = lists.Count;
            foreach (SuKien sk in lists)
            {
                creatLineHorizotal(sk.DtmBegin.ToShortTimeString()+"\n"+sk.DtmEnd.ToShortTimeString(),sk.StrNoiDung,0,this.lblMonHocHomNay.Height,this.pnlThongTin.Width,70,this.pnlThongTin.Height-this.lblMonHocHomNay.Height);
            }
        }
        
        public List<SuKien> List
        {
            get
            {
                return lists;
            }

            set
            {
                this.lists = value;
            }
        }

        private Label creatLineHorizotal(string strTimeLable, string strTextLable, int x, int y, int width, int locationVertical, int heightContext)
        {
            Label lblLineHorizotal;
            lblLineHorizotal = new Label();
            lblLineHorizotal.AutoSize = false;
            lblLineHorizotal.Location = new System.Drawing.Point(x, y);
            lblLineHorizotal.BorderStyle = BorderStyle.Fixed3D;
            lblLineHorizotal.Size = new System.Drawing.Size(width, 2);
            this.pnlThongTin.Controls.Add(lblLineHorizotal);

            Label lblTime;
            lblTime = new Label();
            lblTime.AutoSize = false;
            lblTime.Text = strTimeLable;
            lblTime.TextAlign= ContentAlignment.MiddleCenter;
            lblTime.Location = new System.Drawing.Point(x, y);
            lblTime.Size = new System.Drawing.Size(locationVertical, heightContext);
            this.pnlThongTin.Controls.Add(lblTime);

            Label lblContext;
            lblContext = new Label();
            lblContext.AutoSize = false;
            lblContext.Text = strTextLable;
            lblContext.TextAlign = ContentAlignment.MiddleCenter;
            lblContext.Location = new System.Drawing.Point(x+70, y);
            lblContext.Size = new System.Drawing.Size(width - locationVertical, heightContext);
            this.pnlThongTin.Controls.Add(lblContext);

            return lblLineHorizotal;
        }
        private Label creatLineVertical(int x, int y, int heigh)
        {
            Label lblLineVertical;
            lblLineVertical = new Label();
            lblLineVertical.AutoSize = false;
            lblLineVertical.Location = new System.Drawing.Point(x, y);
            lblLineVertical.BorderStyle = BorderStyle.Fixed3D;
            lblLineVertical.Size = new System.Drawing.Size(2,heigh);
            this.pnlThongTin.Controls.Add(lblLineVertical);
            return lblLineVertical;
        }
        public class SuKien
        {
            private Color colorSuKien;
            private DateTime dtmBegin;
            private DateTime dtmEnd;
            private string strNoiDung;

            public Color ColorSuKien
            {
                get
                {
                    return colorSuKien;
                }

                set
                {
                    this.colorSuKien = value;
                }
            }

            public DateTime DtmBegin
            {
                get
                {
                    return dtmBegin;
                }

                set
                {
                    this.dtmBegin = value;
                }
            }

            public DateTime DtmEnd
            {
                get
                {
                    return dtmEnd;
                }

                set
                {
                    this.dtmEnd = value;
                }
            }

            public string StrNoiDung
            {
                get
                {
                    return strNoiDung;
                }

                set
                {
                    this.strNoiDung = value;
                }
            }
        }
    }   
}
