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
    public partial class frmTiepNhanNhanVien : Form
    {
        private NhanVienManager nvm = new NhanVienManager();
        public frmTiepNhanNhanVien()
        {
            InitializeComponent();
        }

        private void frmTiepNhanNhanVien_Load(object sender, EventArgs e)
        {
            ReLoadForm();
        }
        void ReLoadForm()
        {
            dtgDanhSachNV.DataSource = nvm.LayDanhSachNhanVien();
            txtMaNV.Text = nvm.GetLastNode().ToString("NV000");
            cbBoPhan.DataSource = BoPhans.laydanhsachbophan();
            cbBangCap.DataSource = BangCaps.laydanhsachbangcap();
            cbChucVu.DataSource = ChucVus.laydanhsachchucvu();
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            dtNgaySinh.Text = DateTime.Now.ToShortDateString();
        }
        private void txtThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            string manv = txtMaNV.Text;
            nv.MaNhanVien = txtMaNV.Text;
            nv.HoTenNhanVien = txtHoTen.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.NgaySinh = dtNgaySinh.Text;
            nv.DienThoai = txtDienThoai.Text;
            nv.BangCap = cbBangCap.Text;
            nv.BoPhan = cbBoPhan.Text;
            nv.ChucVu = cbChucVu.Text;
            List<NhanVien> ds = nvm.LayDanhSachNhanVien();
            int dem = 0;
            for(int i=0;i<ds.Count();i++)
            {
                if(ds[i].MaNhanVien==manv)
                {
                    dem++;
                }
                
            }
            if(dem==0)
            {
                nvm.saveNhanVien(nv);
                ReLoadForm();
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin rồi click thêm", "Thông báo");
                ReLoadForm();
            }
           

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = txtMaNV.Text;
            nv.HoTenNhanVien = txtHoTen.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.NgaySinh = dtNgaySinh.Text;
            nv.DienThoai = txtDienThoai.Text;
            nv.BangCap = cbBangCap.Text;
            nv.BoPhan = cbBoPhan.Text;
            nv.ChucVu = cbChucVu.Text;
            string manv = txtMaNV.Text;
            nvm.removeNhanVien(manv);
            nvm.saveNhanVien(nv);
            ReLoadForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            nvm.removeNhanVien(manv);
            ReLoadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

       

        private void dtgDanhSachNV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgDanhSachNV.Rows[e.RowIndex];
            //populate the textbox from specific value of the coordinates of column and row.
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            dtNgaySinh.Text = row.Cells[3].Value.ToString();
            cbBangCap.Text = row.Cells[4].Value.ToString();
            cbBoPhan.Text = row.Cells[5].Value.ToString();
            cbChucVu.Text = row.Cells[6].Value.ToString();
            txtDienThoai.Text = row.Cells[7].Value.ToString();
        }
    }
}
