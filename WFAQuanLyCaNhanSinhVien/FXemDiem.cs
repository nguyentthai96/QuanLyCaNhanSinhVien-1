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
    public partial class FXemDiem : Form
    {
        private string strMaSV;
        private CDiemSo_DTO diem;
        public FXemDiem(string strMaSV)
        {
            InitializeComponent();
            this.strMaSV = strMaSV;
        }

        private void FXemDiem_Load(object sender, EventArgs e)
        {
            loadComboBox();
            if (lists != null)
            {
                loadDSDiemMon(lists[0].Item1);
            }
        }
        public List<Tuple<string, string, string,string >> lists;
        private bool loadComboBox()
        {
            lists= new CMonHoc_BLL().loadDSMonHKDiem(strMaSV);

            if (lists == null)
            {
                return false;
            }
            cmbMonHoc.DataSource = lists;
            cmbMonHoc.ValueMember="Item1";
            cmbMonHoc.DisplayMember= "Item2";
            return true;
        }
        T Cast<T>(object obj, T type) { return (T)obj; }
        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbMonHoc.SelectedIndex;
            
            //var type = Cast(o, new { strMaMon = default(string), strTenMon = default(string) });

            loadDSDiemMon(lists[index].Item1);
        }

        private bool loadDSDiemMon(string strMaMon)
        {
            dgvDiemSo.DataSource = new CDiemSo_BLL().loadDSDiemMon(strMaMon, this.strMaSV);
            return true;
        }

        private void FXemDiem_Resize(object sender, EventArgs e)
        {
            this.dgvDiemSo.Size = new Size(this.Size.Width-this.dgvDiemSo.Location.X-25, this.Size.Height- this.dgvDiemSo.Location.Y-45);
        }

        private void tmiInsert_Click(object sender, EventArgs e)
        {
            int index = cmbMonHoc.SelectedIndex;

            FNhapDiem frm = new FNhapDiem(strMaSV, lists[index].Item1, lists[index].Item4);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            loadDSDiemMon(lists[index].Item1);
        }

        private void tmiEdit_Click(object sender, EventArgs e)
        {
            int index = dgvDiemSo.CurrentRow.Index;
            diem = new CDiemSo_DTO(dgvDiemSo.Rows[index].Cells["StrMaMon"].Value.ToString(), dgvDiemSo.Rows[index].Cells["StrMaSV"].Value.ToString(), dgvDiemSo.Rows[index].Cells["StrMaHK"].Value.ToString(), dgvDiemSo.Rows[index].Cells["StrMaDiem"].Value.ToString(),
                    (float)dgvDiemSo.Rows[index].Cells["FSoDiem"].Value, (float)dgvDiemSo.Rows[index].Cells["FHeSo"].Value,DateTime.Parse(dgvDiemSo.Rows[index].Cells["DtmNgayDiem"].Value.ToString()));
            FSuaDiem frm = new FSuaDiem(diem);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            loadDSDiemMon(cmbMonHoc.SelectedValue.ToString());
        }

        private void dgvDiemSo_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvDiemSo.ClearSelection();
            dgvDiemSo.Rows[e.RowIndex].Selected = true;
            dgvDiemSo.CurrentCell = dgvDiemSo[0, e.RowIndex];
            dgvDiemSo.Refresh();   
        }

        private void tmiRemove_Click(object sender, EventArgs e)
        {
            int index = dgvDiemSo.CurrentRow.Index;
            diem = new CDiemSo_DTO(dgvDiemSo.Rows[index].Cells["StrMaMon"].Value.ToString(), dgvDiemSo.Rows[index].Cells["StrMaSV"].Value.ToString(), dgvDiemSo.Rows[index].Cells["StrMaHK"].Value.ToString(), dgvDiemSo.Rows[index].Cells["StrMaDiem"].Value.ToString(),
                    (float)dgvDiemSo.Rows[index].Cells["FSoDiem"].Value, (float)dgvDiemSo.Rows[index].Cells["FHeSo"].Value, DateTime.Parse(dgvDiemSo.Rows[index].Cells["DtmNgayDiem"].Value.ToString()));
            
            if (new CDiemSo_BLL().removeDiem(diem))
            {
                MessageBox.Show("Xóa thành công");
                loadDSDiemMon(cmbMonHoc.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
