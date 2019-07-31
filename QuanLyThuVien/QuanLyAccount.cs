using QLTV.database;
using QLTV.model;
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
    public partial class QuanLyAccount : Form
    {
        AccountManager acm = new AccountManager();
        NhanVienManager nvm = new NhanVienManager();
        public QuanLyAccount()
        {
            InitializeComponent();
        }

        private void QuanLyAccount_Load(object sender, EventArgs e)
        {
            ReloadForm();
        }
        public void ReloadForm()
        {
            cbLoaiTaiKhoan.DataSource = TypeAcccount.getAllTypeAccounts();

            dtgDanhSach.DataSource = acm.GetAccounts();
        }
        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        { 
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int dem = 0;
            Account acc = new Account();
            acc.maNhanVien = txtMaNhanVien.Text;
            acc.username = txtUserName.Text;
            acc.password = txtPass.Text;
            acc.typeAccount = cbLoaiTaiKhoan.Text;

            List<NhanVien> ds = nvm.LayDanhSachNhanVien();
            for (int i=0;i<ds.Count();i++)
            {
                if(ds[i].MaNhanVien==txtMaNhanVien.Text)
                {
                    dem++;
                }
            }
            if(dem==1)
            {
                List<Account> danhsachacc = acm.GetAccounts();
                int count = 0;
                for (int i = 0; i < danhsachacc.Count(); i++)
                {
                    
                    if (danhsachacc[i].username==txtUserName.Text)
                    {
                        count++;
                    }
                        
                }
                if(count==0)
                {
                    acm.saveAccount(acc);
                    ReloadForm();
                }
                else
                {
                    MessageBox.Show("Phải Nhập Thông tin rồi mới click Thêm!!!", "Thông Báo");
                    ReloadForm();
                }
            }
            else
            {
                MessageBox.Show("Mã Nhân Viên Không Tồn Tại", "Thông Báo");
                ReloadForm();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            acm.removeAccount(txtUserName.Text);
            ReloadForm();
        }

        private void dtgDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.dtgDanhSach.Rows[e.RowIndex];
            //populate the textbox from specific value of the coordinates of column and row.
            txtUserName.Text = row.Cells[0].Value.ToString();
            txtPass.Text = row.Cells[1].Value.ToString();
            cbLoaiTaiKhoan.Text = row.Cells[2].Value.ToString();
            txtMaNhanVien.Text = row.Cells[3].Value.ToString();
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.maNhanVien = txtMaNhanVien.Text;
            acc.username = txtUserName.Text;
            acc.password = txtPass.Text;
            acc.typeAccount = cbLoaiTaiKhoan.Text;
            acm.removeAccount(txtUserName.Text);
            acm.saveAccount(acc);
            ReloadForm();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
