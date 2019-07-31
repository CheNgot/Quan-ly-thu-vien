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
    public partial class frmChoMuonSach : Form
    {
        ChoMuonSachManager cms = new ChoMuonSachManager();
        DocGiaManager dgm = new DocGiaManager();
        NhanVienManager nvm = new NhanVienManager();
        SachManager sm = new SachManager();
        public frmChoMuonSach()
        {
            InitializeComponent();
        }

        private void cbNguoiTiepNhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmChoMuonSach_Load(object sender, EventArgs e)
        {
            ReLoadForm();
        }
        public void ReLoadForm()
        {
            dgvchoMuonSach.DataSource = cms.layds();
            cbLoaiDocGia.DataSource = loaiDocGia.laydsdocgia();
            cbdsms.DataSource = sm.LayDanhSachMaSach();
            //laymadg
            cbdsmdg.DataSource = dgm.LayDsDG();
        }
        private void cbdsms_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Sach> ds = sm.LayDanhSachSach();
            for (int i = 0; i < ds.Count(); i++)
            {
                if (cbdsms.SelectedItem.ToString() == ds[i].MaSach)
                {
                    txtTenSach.Text = ds[i].TenSach;
                }
            }
        }

        private void cbdsmdg_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DocGia> dg = dgm.LayDanhSachDocGia();
            for (int i = 0; i < dg.Count(); i++)
            {
                if (cbdsmdg.SelectedItem.ToString() == dg[i].MaDocGia)
                {
                    txtTenDG.Text = dg[i].HoTen;
                }
            }
        }

        private void btnTiepNhanSach_Click(object sender, EventArgs e)
        {
            string ms = cbdsms.Text;
            string mdg = cbdsmdg.Text;
            ChoMuonSach cmsach = new ChoMuonSach();
            
            cmsach.MaDocGia = cbdsmdg.Text;
            cmsach.HoTen = txtTenDG.Text;          
            cmsach.MaSach = cbdsms.Text;
            cmsach.TenSach = txtTenSach.Text;
            cmsach.TheLoai = txtTheLoai.Text;
            cmsach.TacGia = txtTacGia.Text;
            cmsach.LoaiDocGia = cbLoaiDocGia.Text;
            cmsach.NgayGhiNhan = dtNgayGhiNhan.Text;
            cms.saveChoMuonSach(cmsach);
            ReLoadForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        //Xoa
        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ///xoa
            string ma = cbdsms.Text;
            cms.removeChoMuon(ma);
            ReLoadForm();
        }
        private void dtgDanhSachSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvchoMuonSach.Rows[e.RowIndex];
            //populate the textbox from specific value of the coordinates of column and row.
            cbdsms.Text = row.Cells[1].Value.ToString();
            txtTenSach.Text = row.Cells[2].Value.ToString();
            txtTheLoai.Text = row.Cells[3].Value.ToString();
            txtTacGia.Text = row.Cells[4].Value.ToString();
            cbdsmdg.Text = row.Cells[7].Value.ToString();
            txtTenDG.Text = row.Cells[0].Value.ToString();
            cbLoaiDocGia.Text = row.Cells[5].Value.ToString();
            dtNgayGhiNhan.Text = row.Cells[6].Value.ToString();
           
        }
    }
}
