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
    internal partial class ThuQuyForm : Form
    {
        private Account currentAccount; 
        public ThuQuyForm(Account account)
        {
            InitializeComponent();
            currentAccount = account;
        }

        private void ThuQuyForm_Load(object sender, EventArgs e)
        {
            labelNameAccount.Text = currentAccount.username;
        }

        private void buttonLapPhieuThuTienPhat_Click(object sender, EventArgs e)
        {
            frmLapPhieuThuTienPhat tienPhat = new frmLapPhieuThuTienPhat();
            tienPhat.ShowDialog();
        }
    }
}
