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
    public partial class TraCuuSach : Form
    {
        private SachManager sachManager = new SachManager();

        public TraCuuSach()
        {
            InitializeComponent();
        }

        private void TraCuuSach_Load(object sender, EventArgs e)
        {
            dtgDanhSachSach.DataSource = sachManager.LayDanhSachSach();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtgDanhSachSach.DataSource = sachManager.LayDanhSachSach();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(txtTenSach.Text.ToLower() != string.Empty)
            {
                List<Sach> saches = sachManager.LayDanhSachSach();
                for(int i = 0;i < saches.Count; i++)
                {
                    if (!saches[i].TenSach.ToLower().Contains(txtTenSach.Text.ToLower())) saches.RemoveAt(i);
                }
                if (txtTacGia.Text.ToLower() != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].TacGia.ToLower().Contains(txtTacGia.Text.ToLower())) saches.RemoveAt(i);
                    }
                }
                else if (txtNhaXuatBan.Text != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].NhaXuatBan.ToLower().Contains(txtNhaXuatBan.Text)) saches.RemoveAt(i);
                    }
                }
                else if (cbTheLoai.Text.ToLower() != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].TheLoai.ToLower().Contains(cbTheLoai.Text.ToLower())) saches.RemoveAt(i);
                    }
                }
                dtgDanhSachSach.DataSource = saches;
            }
            else if(txtTacGia.Text.ToLower() != string.Empty)
            {
                List<Sach> saches = sachManager.LayDanhSachSach();
                for (int i = 0; i < saches.Count; i++)
                {
                    if (!saches[i].TacGia.ToLower().Contains(txtTacGia.Text.ToLower())) saches.RemoveAt(i);
                }
                if (txtTenSach.Text.ToLower() != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].TenSach.ToLower().Contains(txtTenSach.Text.ToLower())) saches.RemoveAt(i);
                    }
                }
                else if (txtNhaXuatBan.Text != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].NhaXuatBan.ToLower().Contains(txtNhaXuatBan.Text)) saches.RemoveAt(i);
                    }
                }
                else if (cbTheLoai.Text.ToLower() != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].TheLoai.ToLower().Contains(cbTheLoai.Text.ToLower())) saches.RemoveAt(i);
                    }
                }
                dtgDanhSachSach.DataSource = saches;
            }
            else if(txtNhaXuatBan.Text != string.Empty)
            {
                List<Sach> saches = sachManager.LayDanhSachSach();
                for (int i = 0; i < saches.Count; i++)
                {
                    if (!saches[i].NhaXuatBan.ToLower().Contains(txtNhaXuatBan.Text)) saches.RemoveAt(i);
                }
                if (txtTenSach.Text.ToLower() != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].TenSach.ToLower().Contains(txtTenSach.Text.ToLower())) saches.RemoveAt(i);
                    }
                }
                else if (txtTacGia.Text.ToLower() != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].TacGia.ToLower().Contains(txtTacGia.Text.ToLower())) saches.RemoveAt(i);
                    }
                }
                else if (cbTheLoai.Text.ToLower() != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].TheLoai.ToLower().Contains(cbTheLoai.Text.ToLower())) saches.RemoveAt(i);
                    }
                }
                dtgDanhSachSach.DataSource = saches;
            }
            else if(cbTheLoai.Text.ToLower() != string.Empty)
            {
                List<Sach> saches = sachManager.LayDanhSachSach();
                for (int i = 0; i < saches.Count; i++)
                {
                    if (!saches[i].TheLoai.ToLower().Contains(cbTheLoai.Text.ToLower())) saches.RemoveAt(i);
                }
                if (txtTenSach.Text.ToLower() != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].TenSach.ToLower().Contains(txtTenSach.Text.ToLower().ToLower())) saches.RemoveAt(i);
                    }
                }
                else if (txtTacGia.Text.ToLower() != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].TacGia.ToLower().Contains(txtTacGia.Text.ToLower().ToLower())) saches.RemoveAt(i);
                    }
                }
                else if (txtNhaXuatBan.Text != string.Empty)
                {
                    for (int i = 0; i < saches.Count; i++)
                    {
                        if (!saches[i].NhaXuatBan.ToLower().Contains(txtNhaXuatBan.Text.ToLower())) saches.RemoveAt(i);
                    }
                }
                dtgDanhSachSach.DataSource = saches;
            }
        }
    }
}