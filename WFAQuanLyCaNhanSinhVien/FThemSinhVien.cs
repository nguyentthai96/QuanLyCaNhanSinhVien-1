using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaNhanSinhVien_BLL;
using System.IO;
using System.Drawing.Imaging;

namespace WFAQuanLyCaNhanSinhVien
{
    public partial class FThemSinhVien : Form
    {
        bool bOpenedImage = false;
        private string strMaSV;
        public FThemSinhVien()
        {
            InitializeComponent();
            button1.Enabled = false;
        }
        public FThemSinhVien(string strMaSV)
        {
            InitializeComponent();
            this.strMaSV = strMaSV;
            txtMaSinhVien.Enabled = false;
            btnThem.Enabled = false;

            txtMaSinhVien.Text = strMaSV;
            DataTable tb = new DataTable();
            tb = CSinhVien_BLL.loadSinhVienInfor(strMaSV);
            txtHoTen.Text = tb.Rows[0]["HoTen"].ToString();
            txtDiaChi.Text = tb.Rows[0]["DiaChi"].ToString();
            txtThongTinKhac.Text = tb.Rows[0]["CacThongTin"].ToString();
            dtmpNgaySinh.Value = DateTime.Parse(tb.Rows[0]["NgaySinh"].ToString());

            picImageSV.Image = convertDataToImage(tb.Rows[0]["HinhAnh"].ToString());
            
            if (tb.Rows[0]["GioiTinh"].ToString()=="True")
            {
                rdoNam.Checked = true;
                rdoNam.Select();
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
                rdoNu.Select();
            }
        }

        private Image loadStudentImage(byte[] imageSVData)
        {
            Image image;
            if (imageSVData == null)
            {
                if (rdoNam.Checked)
                {
                    image = Properties.Resources.student_male_512;
                }
                else
                {
                    image = Properties.Resources.student_female_512;
                }
            }
            else
            {
                image = convertDataToImage(imageSVData);
            }
            return image;
        }

        private Image convertDataToImage(Byte[] imageData)
        {
            Image image;
            MemoryStream memoryStream = new MemoryStream(imageData);
            try
            {
                image = Image.FromStream(memoryStream);
            }
            catch (Exception ex)
            {
                try
                {
                    memoryStream = new MemoryStream(imageData, 0, imageData.Length);
                    memoryStream.Seek(0, SeekOrigin.End);
                    image = System.Drawing.Image.FromStream(memoryStream);
                    return image;
                }
                catch (Exception exx)
                {
                    return null;
                    throw;
                }   
            }
            return image;
        }
        private Image convertDataToImage(string base64String)
        {
            Image image;
            try
            {
 // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
             image = Image.FromStream(ms, true);
            }
            catch (Exception ex)
            {
                return null;
            }
           
            return image;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.strMaSV = txtMaSinhVien.Text;
            if (CSinhVien_BLL.themSinhVien(strMaSV, txtHoTen.Text, rdoNam.Checked, dtmpNgaySinh.Value.Date, txtDiaChi.Text, txtThongTinKhac.Text, convertImageToData(picImageSV.Image)))
            {
                #region Tạo account để sử dụng
                FDangKyTaiKhoan frmDangKyTaiKhoan = new FDangKyTaiKhoan(strMaSV);
                frmDangKyTaiKhoan.StartPosition = FormStartPosition.CenterParent;
                frmDangKyTaiKhoan.ShowDialog();

                #endregion

                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm Thất bại.");
            }
        }
        private string convertImageToData(Image image)
        {
            try
            {
MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            //byte[] imageBuffer = memoryStream.GetBuffer();
            byte[] imageBuffer = memoryStream.ToArray();
            memoryStream.Close();
                return Convert.ToBase64String(imageBuffer);
            }
            catch (Exception)
            {
                return "";
            }
            return "";           
        }
        private void FThemSinhVien_Load(object sender, EventArgs e)
        {
        
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CSinhVien_BLL.suaSinhVien(strMaSV, txtHoTen.Text, rdoNam.Checked, dtmpNgaySinh.Value.Date, txtDiaChi.Text, txtThongTinKhac.Text, convertImageToData(picImageSV.Image)))
            {
                MessageBox.Show("Sửa Thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sửa Thất bại.");
            }
        }

        private void picImageSV_Click(object sender, EventArgs e)
        {
            picImageSV.Image = loadStudentPicturebox();
        }
        private Image loadStudentPicturebox()
        {
            Image image;
            string strPathImage = openFileImage();
            try
            {
                image = Image.FromFile(strPathImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load image\n" + ex);
                bOpenedImage = false;
                return null;
            }
            bOpenedImage = true;
            return image;
        }
        private string openFileImage()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            string strPath = "";
            bool bReload = true;
            while (bReload)
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    strPath = openFile.FileName;
                    bReload = false;
                }
                if (strPath == "")
                {
                    DialogResult diaResual = MessageBox.Show("Not select image.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (diaResual == DialogResult.OK)
                    {
                        bReload = false;
                    }
                }
            }
            return strPath;
        }

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {
            if (bOpenedImage == false)
            {
                if (rdoNam.Checked)
                {
                    picImageSV.Image = Properties.Resources.student_male_512;
                }
                else
                {
                    picImageSV.Image = Properties.Resources.student_female_512;
                }
            }
        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {
            if (bOpenedImage == false)
            {
                if (rdoNam.Checked)
                {
                    picImageSV.Image = Properties.Resources.student_male_512;
                }
                else
                {
                    picImageSV.Image = Properties.Resources.student_female_512;
                }
            }
        }
    }
}
