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
    public partial class frmNhanTraSach : Form
    {
        PhieuPhatManager pp = new PhieuPhatManager();
        NhanVienManager nvm = new NhanVienManager();
        DocGiaManager dg = new DocGiaManager();
        ChoMuonSachManager cms = new ChoMuonSachManager();
        TraSachManager tsm = new TraSachManager();
        public frmNhanTraSach()
        {
            InitializeComponent();
        }

        private void frmNhanTraSach_Load(object sender, EventArgs e)
        {
            ReLoadFrom();
        }
        void ReLoadFrom()
        {
            dtgDsTraSach.DataSource = tsm.layDsTraSach();
            cbdhoten.DataSource = cms.LayMaNgMuon();
            
        }

        private void cbdhoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ChoMuonSach> ds = cms.layds();
            for (int i = 0; i < ds.Count(); i++)
            {
                if (cbdhoten.SelectedItem.ToString() == ds[i].MaDocGia)
                {
                    txtTenDocGia.Text = ds[i].HoTen;
                    txtMaSach.Text = ds[i].MaSach;
                    dtNgayMuon.Text = ds[i].NgayGhiNhan;
                }
            }
        }

        private void txtTongNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTienPhat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTiepNhanSach_Click(object sender, EventArgs e)
        {
            TraSach ts = new TraSach();
            ts.MaSach = txtMaSach.Text;
            ts.MaDocGia = cbdhoten.Text;
            ts.HoTen = txtTenDocGia.Text;
            ts.NgayMuon = dtNgayMuon.Text;
            ts.NgayTra = dtNgayTra.Text;
            ts.SoNgayMuon = txtSoNgayMuon.Text;
            ts.TienPhat = txtTienPhat.Text;
            ts.TienPhatKyNay = txtTienPhatKyNay.Text;
            ts.TienNo = txtTienNo.Text;
            ts.TongNo = txtTongNo.Text;
            tsm.saveTraSach(ts);
            ReLoadFrom();
        }

        private void txtTienPhat_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtTongNo_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void txtTienPhat_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void txtTongNo_TextChanged_2(object sender, EventArgs e)
        {
            int tienphat = int.Parse(txtTienPhat.Text);
            int tienno = int.Parse(txtTienNo.Text);
            int tienphatkynay = int.Parse(txtTienPhatKyNay.Text);
            txtTongNo.Text = (tienphat + tienno + tienphatkynay).ToString();
        }

        private void txtTienPhat_TextChanged_3(object sender, EventArgs e)
        {
            int ngaymuon = dtNgayMuon.Value.Day;
            int ngaytra = dtNgayTra.Value.Day;
            int tong = ngaytra - ngaymuon;
            int songaymuon = int.Parse(txtSoNgayMuon.Text);
            int x = 0;
            if (songaymuon < tong)
            {
                txtTienPhat.Text = ((tong - songaymuon) * 1000).ToString();
            }
            else txtTienPhat.Text = x.ToString();   
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = txtMaSach.Text;
            tsm.removeTraSach(ma);
            ReLoadFrom();
        }
        private void dtgDanhSachSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgDsTraSach.Rows[e.RowIndex];
            //populate the textbox from specific value of the coordinates of column and row.
            txtMaSach.Text = row.Cells[0].Value.ToString();
            cbdhoten.Text = row.Cells[1].Value.ToString();
            dtNgayMuon.Text = row.Cells[2].Value.ToString();
            dtNgayTra.Text = row.Cells[3].Value.ToString();
            txtSoNgayMuon.Text = row.Cells[4].Value.ToString();
            txtTienPhat.Text = row.Cells[5].Value.ToString();
            txtTienPhatKyNay.Text = row.Cells[6].Value.ToString();
            txtTienNo.Text= row.Cells[7].Value.ToString();
            txtTongNo.Text = row.Cells[8].Value.ToString();
        }
    }
}
