using QLTV.model;
using QuanLyThuVien.database;
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
    internal partial class ThuThuForm : Form
    {
        private Account currentAccount;
        private XmlGenerate xmlGenerate = new XmlGenerate();
        private ExcelHelper excelHelper = new ExcelHelper();

        public ThuThuForm(Account account)
        {
            InitializeComponent();
            currentAccount = account;
        }

        private void ThuThuForm_Load(object sender, EventArgs e)
        {
            labelNameAccount.Text = currentAccount.username;
        }

        private void buttonLapTheDocGia_Click(object sender, EventArgs e)
        {
            frmTiepNhanDocGia frmTiepNhanDocGia = new frmTiepNhanDocGia();
            frmTiepNhanDocGia.Show();
        }

        private void buttonChoMuonSach_Click(object sender, EventArgs e)
        {
            frmChoMuonSach cms = new frmChoMuonSach();
            cms.Show();
        }

        private void buttonTraCuuSach_Click(object sender, EventArgs e)
        {
            TraCuuSach traCuuSach = new TraCuuSach();
            traCuuSach.Show();
        }

        private void buttonGhiNhanMatSach_Click(object sender, EventArgs e)
        {
            frmGhiNhanMatSach ghinhan = new frmGhiNhanMatSach();
            ghinhan.Show();
        }

        private void buttonNhanTraSach_Click(object sender, EventArgs e)
        {
            frmNhanTraSach ts = new frmNhanTraSach();
            ts.Show();
        }

        private void buttonBackupPhieuMuon_Click(object sender, EventArgs e)
        {
            ChoMuonSachManager choMuonSachManager = new ChoMuonSachManager();
            xmlGenerate.GenerateFromXML(choMuonSachManager.layds());
        }

        private void buttonRestorePhieuMuon_Click(object sender, EventArgs e)
        {
            ChoMuonSachManager choMuonSachManager = new ChoMuonSachManager();
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Excel File";
            theDialog.Filter = "Excel files|*.xlsx";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string path = theDialog.InitialDirectory + theDialog.FileName;
                choMuonSachManager.saveListPhieuMuonSach(excelHelper.GetListPhieuMuonSachFromExcel(path));
            }
        }

        private void buttonBackupDocGia_Click(object sender, EventArgs e)
        {
            DocGiaManager docGiaManager = new DocGiaManager();
            xmlGenerate.GenerateFromXML(docGiaManager.LayDanhSachDocGia());
        }

        private void buttonRestoreDocGia_Click(object sender, EventArgs e)
        {
            DocGiaManager docGiaManager = new DocGiaManager();
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Excel File";
            theDialog.Filter = "Excel files|*.xlsx";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                string path = theDialog.InitialDirectory + theDialog.FileName;
                docGiaManager.saveListDocGia(excelHelper.GetListDocGiaFromExcel(path));
            }
        }
    }
}