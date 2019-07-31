using QuanLyThuVien.database;
using QuanLyThuVien.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmLapPhieuThuTienPhat : Form
    {
        PhieuPhatManager pp = new PhieuPhatManager();
        NhanVienManager nvm = new NhanVienManager();
        DocGiaManager dg = new DocGiaManager();
        public frmLapPhieuThuTienPhat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLapPhieuThuTienPhat_Load(object sender, EventArgs e)
        {
            ReLoadFrom();
        }
        void ReLoadFrom()
        {
                dtgDanhSachPhieuPhat.DataSource = pp.LayDanhPhieuPhat();
                cbNguoiTiepNhan.DataSource = nvm.LayNhanVienThuQuy();
                txtMaPP.Text = pp.GetLastNode().ToString("PP000");
            
        }

        private void txtHoTenDocGia_TextChanged(object sender, EventArgs e)
        {
            List<DocGia> ds = dg.LayDanhSachDocGia();
            for (int i=0;i<ds.Count();i++)
            {
                if(ds[i].MaDocGia==txtMaDocGia.Text)
                {
                    txtHoTen.Text = ds[i].HoTen;
                }
                else
                {
                    txtHoTen.Text = "";
                }
            }
        }

        private void txtMaDocGia_MouseCaptureChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTienThu_TextChanged(object sender, EventArgs e)
        {
            float tienthu = float.Parse(txtTienThu.Text);
            float tienno = float.Parse(txtTienNo.Text);
            if(tienthu>tienno)
            {
                MessageBox.Show("Nhập sai!!Hãy Nhập lại", "Thông Báo");
                txtTienThu.Text = "";
            }
            else
            {
                txtConLai.Text = (tienno - tienthu).ToString();
            }
        }

        private void btnTiepNhanSach_Click(object sender, EventArgs e)
        {
            PhieuPhats phieu = new PhieuPhats();
            phieu.MaPhieuPhat = txtMaPP.Text;
            phieu.MaDocGia = txtMaDocGia.Text;
            phieu.HoTenDocGia = txtHoTen.Text;
            phieu.TienNo = txtTienNo.Text;
            phieu.TienThu = txtTienThu.Text;
            phieu.ConLai = txtConLai.Text;
            phieu.NgayGhiNhan = dtNgayGhiNhan.Text;
            phieu.NguoiTiepNhan = cbNguoiTiepNhan.Text;
            List<PhieuPhats> ds = pp.LayDanhPhieuPhat();
            int dem = 0;
            for(int i=0;i<ds.Count();i++)
            {
                if(ds[i].MaPhieuPhat==txtMaPP.Text)
                { dem++; }
            }
            if(dem==0)
            {
                pp.savePhieuPhat(phieu);
                ReLoadFrom();
            }
            else
            {

                MessageBox.Show("Nhập đầy đủ thông tin rồi click thêm", "Thông báo");
                ReLoadFrom();
            }
        }

        private void dtgDanhSachPhieuPhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgDanhSachPhieuPhat.Rows[e.RowIndex];
            //populate the textbox from specific value of the coordinates of column and row.
            txtMaPP.Text = row.Cells[0].Value.ToString();
            txtMaDocGia.Text = row.Cells[1].Value.ToString();
            txtHoTen.Text = row.Cells[2].Value.ToString();
            txtTienNo.Text = row.Cells[3].Value.ToString();
            txtTienThu.Text = row.Cells[4].Value.ToString();
            txtConLai.Text = row.Cells[5].Value.ToString();
            dtNgayGhiNhan.Text = row.Cells[6].Value.ToString();
            cbNguoiTiepNhan.Text = row.Cells[7].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnXoaphieu_Click(object sender, EventArgs e)
        {
            string maphieu = txtMaPP.Text;
            pp.removePhieu(maphieu);
            ReLoadFrom();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhieuPhats phieu = new PhieuPhats();
            phieu.MaPhieuPhat = txtMaPP.Text;
            phieu.MaDocGia = txtMaDocGia.Text;
            phieu.HoTenDocGia = txtHoTen.Text;
            phieu.TienNo = txtTienNo.Text;
            phieu.TienThu = txtTienThu.Text;
            phieu.ConLai = txtConLai.Text;
            phieu.NgayGhiNhan = dtNgayGhiNhan.Text;
            phieu.NguoiTiepNhan = cbNguoiTiepNhan.Text;
            pp.removePhieu(txtMaPP.Text);
            pp.savePhieuPhat(phieu);
            ReLoadFrom();
        }

        private void txtConLai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
