using QuanLyCaNhanSinhVien_BLL;
using QuanLyCaNhanSinhVien_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FDSMonHoc : Form
    {
        private string strMaSV;
        private List<CMonHoc_DTO> lists;
        public FDSMonHoc(string strMaSV)
        {
            InitializeComponent();
            this.strMaSV = strMaSV;
        }

        private void FDSMonHoc_Load(object sender, EventArgs e)
        {
            loadCmbHocKy();
        }
        private bool loadCmbHocKy()
        {
            cmbHocKy.DataSource = new CHocKy_BLL().loadDSHocKy();
            if (cmbHocKy.DataSource==null)
            {
                return false;
            }

            cmbHocKy.DisplayMember = "TenHK";
            cmbHocKy.ValueMember = "MaHK";
            return true;
        }

        private void cmbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMonHoc(this.strMaSV, cmbHocKy.SelectedValue.ToString());
        }

        private bool loadMonHoc(string strMaSV, string strMaHK)
        {
           lists = new List<CMonHoc_DTO>();
            lists = new CMonHoc_BLL().loadDSMonDangKyHK(strMaSV, strMaHK);

            if (lists==null)
            {
                MessageBox.Show("Danh sách dữ liệu rỗng");
                return true;
            }

            dgvDSMon.DataSource = lists;

            return true;
        }

        private void FDSMonHoc_Resize(object sender, EventArgs e)
        {
            this.dgvDSMon.Size = new Size(this.Size.Width - this.dgvDSMon.Location.X - 25, this.Size.Height - this.dgvDSMon.Location.Y - 45);
        }
       
        //private void tmiInsert_Click(object sender, EventArgs e)
        //{
        //    int index = cmbHocKy.SelectedIndex;

        //    FNhapDiem frm = new FNhapDiem(strMaSV, lists[index].Item1);
        //    frm.StartPosition = FormStartPosition.CenterParent;
        //    frm.ShowDialog();
        //    loadDSDiemMon(lists[index].Item1);
        //}

        //private void tmiEdit_Click(object sender, EventArgs e)
        //{
        //    int index = dgvDiemSo.CurrentRow.Index;
        //    diem = new CDiemSo_DTO(dgvDiemSo.Rows[index].Cells["StrMaMon"].Value.ToString(), dgvDiemSo.Rows[index].Cells["StrMaSV"].Value.ToString(), dgvDiemSo.Rows[index].Cells["StrMaDiem"].Value.ToString(),
        //            (float)dgvDiemSo.Rows[index].Cells["FSoDiem"].Value, (float)dgvDiemSo.Rows[index].Cells["FHeSo"].Value, DateTime.Parse(dgvDiemSo.Rows[index].Cells["DtmNgayDiem"].Value.ToString()));
        //    FSuaDiem frm = new FSuaDiem(diem);
        //    frm.StartPosition = FormStartPosition.CenterParent;
        //    frm.ShowDialog();
        //    loadDSDiemMon(cmbMonHoc.SelectedValue.ToString());
        //}

        private void dgvDiemSo_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvDSMon.ClearSelection();
            dgvDSMon.Rows[e.RowIndex].Selected = true;
            dgvDSMon.CurrentCell = dgvDSMon[0, e.RowIndex];
            dgvDSMon.Refresh();
        }

        private void tmiDelete_Click(object sender, EventArgs e)
        {
            int index = dgvDSMon.CurrentRow.Index;
            string error;
            if (new CMonHoc_BLL().deleteMon(strMaSV, dgvDSMon.Rows[index].Cells["StrMaMon"].Value.ToString(), cmbHocKy.SelectedValue.ToString(),out error))
            {
                MessageBox.Show("Xóa thành công");
                loadMonHoc(strMaSV, cmbHocKy.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                if (error == "Có danh sách điểm đã nhập không thể xóa.\nBạn có muốn xóa luôn danh sách điểm không?")
                {
                    DialogResult result = MessageBox.Show("Lỗi xóa", error, MessageBoxButtons.OKCancel);
                    if (result==DialogResult.OK)
                    {
                        List<CDiemSo_DTO> listDiemMons = new List<CDiemSo_DTO>();
                        listDiemMons = new CDiemSo_BLL().loadDSDiemMon(strMaSV, dgvDSMon.Rows[index].Cells["StrMaMon"].Value.ToString(), cmbHocKy.SelectedValue.ToString());
                    }
                }
                return;
            }
        }
    }
}
