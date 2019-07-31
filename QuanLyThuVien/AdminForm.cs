using QLTV.database;
using QLTV.model;
using QuanLyThuVien.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    internal partial class AdminForm : Form
    {
        private XmlGenerate xmlGenerate = new XmlGenerate();
        private ExcelHelper excelHelper = new ExcelHelper();
        private NhanVienManager nhanVienManager = new NhanVienManager();
        private Account currentAccount;
        public AdminForm(Account account)
        {
            InitializeComponent();
            currentAccount = account;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            labelNameAccount.Text = currentAccount.username;
        }

        private void buttonTiepNhanNhanVien_Click(object sender, EventArgs e)
        {
            frmTiepNhanNhanVien frm = new frmTiepNhanNhanVien();
            frm.Show();
        }

        private void buttonExportDSNV_Click(object sender, EventArgs e)
        {
            xmlGenerate.GenerateFromXML(nhanVienManager.LayDanhSachNhanVien());
        }

        private void buttonRestoreDSNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Excel File";
            theDialog.Filter = "Excel files|*.xlsx";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                String path = theDialog.InitialDirectory + theDialog.FileName;
                nhanVienManager.saveListNhanVien(excelHelper.GetListNhanVienFromExcel(path));
            }
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            QuanLyAccount ql = new QuanLyAccount();
            ql.ShowDialog();
        }

        private void buttonBackupTaiKhoan_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager();
            xmlGenerate.GenerateFromXML(accountManager.GetAccounts());
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager();
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Excel File";
            theDialog.Filter = "Excel files|*.xlsx";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string path = theDialog.InitialDirectory + theDialog.FileName;
                accountManager.saveListAccount(excelHelper.GetListAccountFromExcel(path));
            }
        }

        private void buttonBackupSach_Click(object sender, EventArgs e)
        {
            SachManager sachManager = new SachManager();
            xmlGenerate.GenerateFromXML(sachManager.LayDanhSachSach());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SachManager sachManager = new SachManager();
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Excel File";
            theDialog.Filter = "Excel files|*.xlsx";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string path = theDialog.InitialDirectory + theDialog.FileName;
                sachManager.saveListSach(excelHelper.GetListSachFromExcel(path));
            }
        }
    }
}