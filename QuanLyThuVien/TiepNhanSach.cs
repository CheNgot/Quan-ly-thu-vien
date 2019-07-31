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
    public partial class TiepNhanSach : Form
    {
        private SachManager sm = new SachManager();
        private NhanVienManager nvm = new NhanVienManager();
        public TiepNhanSach()
        {
            InitializeComponent();
        }

        private void TiepNhanSach_Load(object sender, EventArgs e)
        {
            ReLoadForm();
        }
        public void ReLoadForm()
        {
            cbTheLoai.DataSource = TheLoaiSach.laydanhsachtheloai();
            dtgDanhSachSach.DataSource = sm.LayDanhSachSach();
            txtMaSach.Text = sm.GetLastNode().ToString("MS000");
            cbNguoiTiepNhan.DataSource = nvm.LayNhanVienThuKho();
            cbNamXuatBan.DataSource = DanhSachNamXuatban();
        }
        public List<string> DanhSachNamXuatban()
        {
            List<string> ds = new List<string>();
            int namhientai = DateTime.Now.Year;
            for (int i = namhientai - 8; i <= namhientai; i++)
            {
                ds.Add(i.ToString());
            }
            return ds;

        }

        private void txtTriGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        
        private void btnTiepNhanSach_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            string masach = txtMaSach.Text;
            s.MaSach = txtMaSach.Text;
            s.TenSach = txtTenSach.Text;
            s.TacGia = txtTacGia.Text;
            s.TheLoai = cbTheLoai.Text;
            s.NamXuatBan = cbNamXuatBan.Text;
            s.NhaXuatBan = txtNhaXuatBan.Text;
            s.NgayNhap = dtNgayNhap.Text;
            s.TriGia = txtTriGia.Text;
            s.NguoiTiepNhan = cbNguoiTiepNhan.Text;
            List<Sach> ds = sm.LayDanhSachSach();
            int dem = 0;
            for(int i=0;i<ds.Count();i++)
            {
                if(ds[i].MaSach==masach)
                {
                    dem++;
                }
            }
            if(dem==0)
            {
                sm.saveSach(s);
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
            string masach = txtMaSach.Text;
            Sach s = new Sach();
            s.MaSach = txtMaSach.Text;
            s.TenSach = txtTenSach.Text;
            s.TacGia = txtTacGia.Text;
            s.TheLoai = cbTheLoai.Text;
            s.NamXuatBan = cbNamXuatBan.Text;
            s.NhaXuatBan = txtNhaXuatBan.Text;
            s.NgayNhap = dtNgayNhap.Text;
            s.TriGia = txtTriGia.Text;
            s.NguoiTiepNhan = cbNguoiTiepNhan.Text;
            sm.removeSach(masach);
            sm.saveSach(s);
            ReLoadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void dtgDanhSachSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgDanhSachSach.Rows[e.RowIndex];
            //populate the textbox from specific value of the coordinates of column and row.
            txtMaSach.Text = row.Cells[0].Value.ToString();
            txtTenSach.Text = row.Cells[1].Value.ToString();
            txtTacGia.Text = row.Cells[3].Value.ToString();
            cbTheLoai.Text = row.Cells[2].Value.ToString();
            cbNamXuatBan.Text = row.Cells[4].Value.ToString();
            txtNhaXuatBan.Text = row.Cells[5].Value.ToString();
            dtNgayNhap.Text = row.Cells[6].Value.ToString();
            txtTriGia.Text = row.Cells[7].Value.ToString();
            cbNguoiTiepNhan.Text = row.Cells[8].Value.ToString();
        }
    }
}
