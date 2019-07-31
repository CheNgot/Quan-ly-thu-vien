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
    public partial class ThanhLySach : Form
    {
        ThanLySachManager tl = new ThanLySachManager();
        NhanVienManager nvm = new NhanVienManager();
        SachManager sm = new SachManager();
        public ThanhLySach()
        {
            InitializeComponent();
        }

        private void ThanhLySach_Load(object sender, EventArgs e)
        {
            ReLoadForm();
        }
        public void ReLoadForm()
        {
            dtgThanhLy.DataSource = tl.Getds();
            cbLyDo.DataSource = LyDoThanhLys.laydanhsachLydo();
            cbNguoiThanhLy.DataSource = nvm.LayNhanVienThuKho();
            cbdsms.DataSource = sm.LayDanhSachMaSach();
        }

        private void btnThanhLy_Click(object sender, EventArgs e)
        {
            string masach = cbdsms.Text;
            TLSach tls = new TLSach();
            tls.MaSach = cbdsms.Text;
            tls.TenSach = txtTenSach.Text;
            tls.LyDoThanhLy = cbLyDo.Text;
            tl.saveThanhLySach(tls);
            sm.removeSach(masach);
            ReLoadForm();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void dtgThanhLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
