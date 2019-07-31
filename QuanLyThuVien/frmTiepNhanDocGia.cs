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
    public partial class frmTiepNhanDocGia : Form
    {
        private DocGiaManager qldg = new DocGiaManager();
        public frmTiepNhanDocGia()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmTiepNhanDocGia_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        public void LoadForm()
        {
            dtgDanhSachDG.DataSource = qldg.LayDanhSachDocGia();
            txtMaDG.Text = qldg.GetLastNode().ToString("DG000");           
            txtHoTen.Text = "";
            dtNgaySinh.Text = DateTime.Now.ToLongDateString();            
            txtDiaChi.Text = "";
            cbLoaiDocGia.DataSource = loaiDocGia.laydsdocgia();
            txtEmail.Text = "";
            dtNgayLapThe.Text = DateTime.Now.ToLongDateString();
        }

        //add
        private void button1_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            string madg = txtMaDG.Text;
            dg.MaDocGia = txtMaDG.Text;
            dg.HoTen = txtHoTen.Text;
            dg.NgaySinh = dtNgaySinh.Text;
            dg.DiaChi = txtDiaChi.Text;
            dg.LoaiDocGia = cbLoaiDocGia.Text;
            dg.Email = txtEmail.Text;
            dg.NgayLapThe = dtNgayLapThe.Text;
            List<DocGia> ldg = qldg.LayDanhSachDocGia();
            
            int dem = 0;
            for (int i = 0; i < ldg.Count(); i++)
            {
                if (ldg[i].MaDocGia==madg)
                {
                    dem++;
                }

            }
            if (dem == 0)
            {
                qldg.saveDocGia(dg);
                LoadForm();
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin rồi click thêm", "Thông báo");
                LoadForm();
            }



        }
        private void dtgDanhSachSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgDanhSachDG.Rows[e.RowIndex];
            //populate the textbox from specific value of the coordinates of column and row.
            txtMaDG.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            dtNgaySinh.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();
            cbLoaiDocGia.Text = row.Cells[4].Value.ToString();
            txtEmail.Text = row.Cells[5].Value.ToString();
            dtNgayLapThe.Text = row.Cells[6].Value.ToString();
        }

        //Xoa
        private void button2_Click(object sender, EventArgs e)
        {
            string madg = txtMaDG.Text;
            qldg.removeDocGia(madg);
            LoadForm();
        }

        //Sua
        private void button4_Click(object sender, EventArgs e)
        {
            string madg = txtMaDG.Text;
            DocGia dg = new DocGia();
            dg.MaDocGia = txtMaDG.Text;
            dg.HoTen = txtHoTen.Text;
            dg.NgaySinh = dtNgaySinh.Text;
            dg.DiaChi = txtDiaChi.Text;
            dg.LoaiDocGia = cbLoaiDocGia.Text;
            dg.Email = txtEmail.Text;
            dg.NgayLapThe = dtNgayLapThe.Text;
            qldg.removeDocGia(madg);
            qldg.saveDocGia(dg);
            LoadForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
