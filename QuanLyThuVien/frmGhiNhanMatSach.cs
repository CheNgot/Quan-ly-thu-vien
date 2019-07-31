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
    public partial class frmGhiNhanMatSach : Form
    {
        ChoMuonSachManager cms = new ChoMuonSachManager();
        DocGiaManager dgm = new DocGiaManager();
        NhanVienManager nvm = new NhanVienManager();
        SachManager sm = new SachManager();
        GhiNhanMatSachManager gnm = new GhiNhanMatSachManager();
        public frmGhiNhanMatSach()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmGhiNhanMatSach_Load(object sender, EventArgs e)
        {
            ReLoadForm();
        }
        public void ReLoadForm()
        {
            dtgDanhSachGhiNhan.DataSource = gnm.LayDanhSachMatSach();
            txtMaSach.Text = gnm.GetLastNode().ToString("MS000");
            cbNguoiTiepNhan.DataSource = nvm.LayNhanVienThuThu();
        }


        //sua
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void cbdsmdg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTiepNhanSach_Click(object sender, EventArgs e)
        {
            GhiNhanMatSach g = new GhiNhanMatSach();
            string masach = txtMaSach.Text;
            g.MaSach = txtMaSach.Text;
            g.TenSach = txtTenSach.Text;
            g.HoTen = txtHoTen.Text;
            g.NgayGhiNhan = dtNgayGhiNhan.Text;
            g.TienPhat = txtTienPhat.Text;
            g.NguoiTiepNhan = cbNguoiTiepNhan.Text;
            List<GhiNhanMatSach> ds = gnm.LayDanhSachMatSach();
            int dem = 0;
            for (int i = 0; i < ds.Count(); i++)
            {
                if (ds[i].MaSach == masach)
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                gnm.saveGhiNhanMatSach(g);
                ReLoadForm();
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin rồi click thêm", "Thông báo");
                ReLoadForm();
            }
        }
        private void dtgDanhSachSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgDanhSachGhiNhan.Rows[e.RowIndex];
            //populate the textbox from specific value of the coordinates of column and row.
            txtMaSach.Text = row.Cells[5].Value.ToString();
            txtTenSach.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            dtNgayGhiNhan.Text = row.Cells[2].Value.ToString();
            txtTienPhat.Text = row.Cells[3].Value.ToString();
            cbNguoiTiepNhan.Text = row.Cells[4].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string MaSach = txtMaSach.Text;

            gnm.removeGhiNhanMatSach(MaSach);
            //gnm.saveGhiNhanMatSach(g);
            ReLoadForm();
        }

        private void btnTiepNhanSach_Click_1(object sender, EventArgs e)
        {
            GhiNhanMatSach g = new GhiNhanMatSach();
            string masach = txtMaSach.Text;
            g.MaSach = txtMaSach.Text;
            g.TenSach = txtTenSach.Text;
            g.HoTen = txtHoTen.Text;
            g.NgayGhiNhan = dtNgayGhiNhan.Text;
            g.TienPhat = txtTienPhat.Text;
            g.NguoiTiepNhan = cbNguoiTiepNhan.Text;
            List<GhiNhanMatSach> ds = gnm.LayDanhSachMatSach();
            int dem = 0;
            for (int i = 0; i < ds.Count(); i++)
            {
                if (ds[i].MaSach == masach)
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                gnm.saveGhiNhanMatSach(g);
                ReLoadForm();
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin rồi click thêm", "Thông báo");
                ReLoadForm();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSach = txtMaSach.Text;
            GhiNhanMatSach g = new GhiNhanMatSach();
            g.MaSach = txtMaSach.Text;
            g.TenSach = txtTenSach.Text;
            g.HoTen = txtHoTen.Text;
            g.NgayGhiNhan = dtNgayGhiNhan.Text;
            g.TienPhat = txtTienPhat.Text;
            g.NguoiTiepNhan = cbNguoiTiepNhan.Text;
            gnm.removeGhiNhanMatSach(MaSach);
            gnm.saveGhiNhanMatSach(g);
            ReLoadForm();
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string MaSach = txtMaSach.Text;

            gnm.removeGhiNhanMatSach(MaSach);
            //gnm.saveGhiNhanMatSach(g);
            ReLoadForm();
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
