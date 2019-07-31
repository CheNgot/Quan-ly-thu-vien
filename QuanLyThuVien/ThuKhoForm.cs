using QLTV.model;
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
    internal partial class ThuKhoForm : Form
    {
        private Account currentAccount;

        public ThuKhoForm(Account account)
        {
            InitializeComponent();
            currentAccount = account;
        }

        private void buttonThanhLySach_Click(object sender, EventArgs e)
        {
            ThanhLySach thanhly = new ThanhLySach();
            thanhly.ShowDialog();
        }

        private void buttonTiepNhanSachMoi_Click(object sender, EventArgs e)
        {
            TiepNhanSach tiepNhan = new TiepNhanSach();
            tiepNhan.ShowDialog();
        }

        private void ThuKhoForm_Load(object sender, EventArgs e)
        {
            labelNameAccount.Text = currentAccount.username;
        }
    }
}
