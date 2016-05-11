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
        public List<SuKien> lists;
        private List<TreeLabel> listsTupLable;
        private Label lblTitle;

        public List<SuKien> Lists
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

        public LinesTableUC()
        {
            listsTupLable = new List<TreeLabel>(); //quan ly danh sach list label
            InitializeComponent();
            loadDuLieu();
            intialComponemt();
        }
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

        private void loadDuLieu()
        {
            int index = 0;
            if (this.lists == null)
            {
                this.lists = new List<SuKien>();
                this.lists.Add(new SuKien(Color.AliceBlue, DateTime.Parse("00:00"), DateTime.Parse("23:59"), "Không có học gì."));
            }
            int heightContext = (int)((0.82 * this.Height) / this.lists.Count);
            foreach (SuKien sk in this.lists)
            {
                string strTimeLable = sk.DtmBegin.ToShortTimeString() + "\n" + sk.DtmEnd.ToShortTimeString();
                TreeLabel tLab = creatLineHorizotal(strTimeLable, sk.StrNoiDung, index, heightContext);
                listsTupLable.Add(tLab);
                index++;
            }
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
            lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)(0.15 * heightContext), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTime.AutoSize = false;

            Label lblContext;
            lblContext = new Label();
            lblContext.AutoSize = false;
            lblContext.Text = strTextLable;
            lblContext.TextAlign = ContentAlignment.MiddleCenter;
            lblContext.Location = new System.Drawing.Point((int)(0.22 * this.Width), (int)(0.18 * this.Height)+index* heightContext);
            lblContext.Size = new System.Drawing.Size(this.Width -lblTime.Width, heightContext);
            lblContext.Font = new Font("Microsoft Sans Serif", (float)(0.2*heightContext) * (float)(1.0 / lblContext.Text.Length), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            lblTime.MouseHover += new EventHandler(lblLabel_MouseHover);
            lblContext.MouseHover += new EventHandler(lblLabel_MouseHover);

            lblTime.MouseLeave += new EventHandler(lblLabel_MouseLeave);
            lblContext.MouseLeave += new EventHandler(lblLabel_MouseLeave); 

            TreeLabel TLable = new TreeLabel(lblTime, lblContext);
            return TLable;
        }

        private void lblLabel_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            try
            {
                listsTupLable.Where(i => i.LblTime == lbl).SingleOrDefault().LblContext.BackColor = SystemColors.Control;
            }
            catch (Exception)
            {

                try
                {
                    listsTupLable.Where(i => i.LblContext == lbl).SingleOrDefault().LblTime.BackColor = SystemColors.Control;
                }
                catch (Exception)
                {
                    ///Todo Cath empty                    
                }
            }
            
            lbl.BackColor = SystemColors.Control;
        }

        private void lblLabel_MouseHover(object sender, EventArgs e)
        {
            int index = -1;
            Label lbl = sender as Label;
            try
            {
                TreeLabel lbl_ = listsTupLable.Where(i => i.LblTime == lbl).Single();
                 index=listsTupLable.IndexOf(lbl_);
                lbl_.LblContext.BackColor = this.lists[index].ColorSuKien;
            }
            catch (Exception)
            {

                try
                {
                    TreeLabel lbl_ = listsTupLable.Where(i => i.LblContext == lbl).Single();
                    index = listsTupLable.IndexOf(lbl_);
                    lbl_.LblTime.BackColor = this.lists[index].ColorSuKien;
                }
                catch (Exception)
                {
                    ///Todo Cath empty  
                    ///
                    return;
                }
            }
            if (index < 0)
            {
                return;
            }
            lbl.BackColor = this.lists[index].ColorSuKien;
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
                TLable.LblTime.Font = new Font("", (float)(0.15 * heightContext));


                TLable.LblContext.Location = new System.Drawing.Point((int)(0.22 * this.Width), (int)(0.18 * this.Height) + index * heightContext);
                TLable.LblContext.Size = new System.Drawing.Size(this.Width - TLable.LblTime.Width, heightContext);
                TLable.LblContext.Font = new Font("", (float)(0.2 * heightContext)*(float)(1.0/ TLable.LblContext.Text.Length));


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

        private void LinesTableUC_Load(object sender, EventArgs e)
        {
            loadDuLieu();
            refreshContext();
        }
        public void refreshContext()
        {
            int iCount = lists.Count;
            for  (int i=0; i<iCount;i++)
            {
                listsTupLable[i].LblTime.Text = lists[i].DtmBegin.ToShortTimeString() + "\n" + lists[i].DtmEnd.ToShortTimeString();
                listsTupLable[i].LblContext.Text = lists[i].StrNoiDung;
            }
        }
    }
}
