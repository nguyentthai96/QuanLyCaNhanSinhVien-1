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
        public LineTable_UC()
        {
            InitializeComponent();
            creatLineVertical(70, 32);
            creatLineHorizotal(0, 32);
            creatLineHorizotal(0, 86);
            creatLineHorizotal(0, 140);
            creatLineHorizotal(0, 194);
            creatLineHorizotal(0, pnlThongTin.Height-2);
        }
        private List<SuKien> list = new List<SuKien>();
        public List<SuKien> List
        {
            get
            {
                return list;
            }

            set
            {
                this.list = value;
            }
        }

        private Label creatLineHorizotal(int x, int y)
        {
            Label lblLineHorizotal;
            lblLineHorizotal = new Label();
            lblLineHorizotal.AutoSize = false;
            lblLineHorizotal.Location = new System.Drawing.Point(x, y);
            lblLineHorizotal.BorderStyle = BorderStyle.Fixed3D;
            lblLineHorizotal.Size = new System.Drawing.Size(pnlThongTin.Width, 2);
            this.pnlThongTin.Controls.Add(lblLineHorizotal);

            SuKien sk = new SuKien();

            Label lblTime;
            lblTime = new Label();
            lblTime.AutoSize = false;
            lblTime.Text = sk.StrNoiDung==null ? "" : sk.DtmBegin.ToShortTimeString()+"\n"+ sk.DtmEnd.ToShortTimeString();
            lblTime.TextAlign= ContentAlignment.MiddleCenter;
            lblTime.Location = new System.Drawing.Point(x, y);
            lblTime.Size = new System.Drawing.Size(70, 54);
            this.pnlThongTin.Controls.Add(lblTime);

            Label lblContext;
            lblContext = new Label();
            lblContext.AutoSize = false;
            lblContext.Text = sk.StrNoiDung;
            lblContext.TextAlign = ContentAlignment.MiddleCenter;
            lblContext.Location = new System.Drawing.Point(x+70, y);
            lblContext.Size = new System.Drawing.Size(pnlThongTin.Width-70, 54);
            this.pnlThongTin.Controls.Add(lblContext);

            list.Add(sk);

            return lblLineHorizotal;
        }
        private Label creatLineVertical(int x, int y)
        {
            Label lblLineVertical;
            lblLineVertical = new Label();
            lblLineVertical.AutoSize = false;
            lblLineVertical.Location = new System.Drawing.Point(x, y);
            lblLineVertical.BorderStyle = BorderStyle.Fixed3D;
            lblLineVertical.Size = new System.Drawing.Size(2, pnlThongTin.Height-y);
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
