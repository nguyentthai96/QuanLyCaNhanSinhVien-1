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
    public partial class LinesTableUC : UserControl
    {
        private List<SuKien> lists;



        public LinesTableUC()
        {

            SuKien s = new SuKien(Color.AliceBlue, DateTime.Parse("12:22"), DateTime.Parse("14:33"), "Chets cay");
            lists = new List<SuKien>();
            lists.Add(s);
            s = new SuKien(Color.AliceBlue,DateTime.Parse("12/2/1999 12:22"), DateTime.Parse("14:33"), "Chets cay roi");
            lists.Add(s);
            s = new SuKien(Color.AliceBlue, DateTime.Parse("12/2/1999 12:22"), DateTime.Parse("14:33"), "Cheddts cay roi");
            lists.Add(s);
            s = new SuKien(Color.AliceBlue, DateTime.Parse("12/2/1999 12:22"), DateTime.Parse("14:33"), "Cheddts cay roi");
            lists.Add(s);
            listsTupLable = new List<TreeLabel>();


            //TODO Test
            int index = 0;
            int heightContext = (int)((0.82 * this.Height) / lists.Count);
            foreach (SuKien sk in lists)
            {
                string strTimeLable = sk.DtmBegin.ToShortTimeString() + "\n" + sk.DtmEnd.ToShortTimeString();
                TreeLabel tLab = creatLineHorizotal(strTimeLable, sk.StrNoiDung, index, heightContext);
                listsTupLable.Add(tLab);
                index++;
            }

            InitializeComponent();
            intialComponemt();
        }
        public LinesTableUC(List<SuKien> lists)
        {
            listsTupLable = new List<TreeLabel>();
            int index = 0;
            int heightContext = (int)((0.82 * this.Height) / lists.Count);
            foreach (SuKien sk in lists)
            {
                string strTimeLable = sk.DtmBegin.ToShortTimeString() + "\n" + sk.DtmEnd.ToShortTimeString();
                TreeLabel tLab= creatLineHorizotal(strTimeLable, sk.StrNoiDung, index, heightContext);
                listsTupLable.Add(tLab);
                index++;
            }

            InitializeComponent();
            intialComponemt();
        }
        private TreeLabel creatLineHorizotal(string strTimeLable, string strTextLable, int index, int heightContext)
        {
            //Label lblLineHorizotal;
            //lblLineHorizotal = new Label();
            //lblLineHorizotal.Location = new System.Drawing.Point(0, (int)(0.18*this.Height)+index);
            //lblLineHorizotal.Size = new System.Drawing.Size(this.Width, 2);
            //lblLineHorizotal.AutoSize = false;

            Label lblTime;
            lblTime = new Label();
            lblTime.Text = strTimeLable;
            lblTime.Location = new System.Drawing.Point(0, (int)(0.18 * this.Height)+index* heightContext);
            lblTime.Size = new System.Drawing.Size((int)(0.22 * this.Width), heightContext);
            lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(0.2 * heightContext), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTime.AutoSize = false;

            Label lblContext;
            lblContext = new Label();
            lblContext.AutoSize = false;
            lblContext.Text = strTextLable;
            lblContext.TextAlign = ContentAlignment.MiddleCenter;
            lblContext.Location = new System.Drawing.Point((int)(0.22 * this.Width), (int)(0.18 * this.Height)+index* heightContext);
            lblContext.Size = new System.Drawing.Size(this.Width -lblTime.Width, heightContext);
            lblContext.Font = new Font("Microsoft Sans Serif", (float)(0.2*heightContext) , System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            TreeLabel TLable = new TreeLabel(lblTime, lblContext);
            return TLable;
        }

        private void linesTableUC_Resize(object sender, EventArgs e)
        {
            resizeTitleLineVertical();
            resizeLineHorizotal();
        }
        private void resizeTitleLineVertical()
        {
            this.lblTitle.Size = new System.Drawing.Size(this.Width, (int)(0.18 * this.Height));
            this.lblTitle.Font = new Font(FontFamily.GenericSansSerif, (float)(0.07 * this.Height));
            //Bo duong doc di
            //lblLineVertical.Location = new System.Drawing.Point((int)(0.22 * this.Width), (int)(0.18 * this.Width));
            //lblLineVertical.Size = new System.Drawing.Size(2, (int)(0.82 * this.Height));
        }

        private void resizeLineHorizotal()
        {
            int index = 0;
            int heightContext= (int)((0.82 * this.Height) / listsTupLable.Count);
            foreach (TreeLabel TLable in listsTupLable)
            {
                //TLable.LblLine.Location = new System.Drawing.Point(0, (int)(0.18 * this.Height));
                //TLable.LblLine.Size = new System.Drawing.Size(this.Width, 2);

                TLable.LblTime.Location = new System.Drawing.Point(0, (int)(0.18 * this.Height) + index * heightContext);
                TLable.LblTime.Size = new System.Drawing.Size((int)(0.22 * this.Width), heightContext);
                TLable.LblTime.Font = new Font("", (float)(0.2 * heightContext));


                TLable.LblContext.Location = new System.Drawing.Point((int)(0.22 * this.Width), (int)(0.18 * this.Height) + index * heightContext);
                TLable.LblContext.Size = new System.Drawing.Size(this.Width - TLable.LblTime.Width, heightContext);
                TLable.LblContext.Font = new Font("", (float)(0.2 * heightContext));


                index++;
            }
        }

        public class SuKien
        {
            private Color colorSuKien;
            private DateTime dtmBegin;
            private DateTime dtmEnd;
            private string strNoiDung;

            public SuKien(Color colorSuKien, DateTime dtmBegin, DateTime dtmEnd, string strNoiDung)
            {
                this.colorSuKien = colorSuKien;
                this.dtmBegin = dtmBegin;
                this.dtmEnd = dtmEnd;
                this.strNoiDung = strNoiDung;
            }

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

        private class TreeLabel
        {
            private Label lblLine;
            private Label lblTime;
            private Label lblContext;
            public TreeLabel(Label lblLineHorizotal, Label lblTime, Label lblContext)
            {
                this.lblLine = lblLineHorizotal;
                this.lblTime = lblTime;
                this.lblContext = lblContext;
            }

            public TreeLabel(Label lblTime, Label lblContext)
            {
                this.lblTime = lblTime;
                this.lblContext = lblContext;
            }

            public Label LblLine
            {
                get
                {
                    return lblLine;
                }

                set
                {
                    this.lblLine = value;
                }
            }

            public Label LblTime
            {
                get
                {
                    return lblTime;
                }

                set
                {
                    this.lblTime = value;
                }
            }

            public Label LblContext
            {
                get
                {
                    return lblContext;
                }

                set
                {
                    this.lblContext = value;
                }
            }
        }
    }
}
