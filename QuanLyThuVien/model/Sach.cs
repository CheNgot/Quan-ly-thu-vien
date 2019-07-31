using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.model
{
    class Sach
    {
        private string _maSach;
        private string _tenSach;
        private string _theLoai;
        private string _tacGia;
        private string _namXuatBan;
        private string _nhaXuatBan;
        private string _ngayNhap;
        private string _triGia;
        private string _nguoiTiepNhan;

        public string MaSach { get => _maSach; set => _maSach = value; }
        public string TenSach { get => _tenSach; set => _tenSach = value; }
        public string TheLoai { get => _theLoai; set => _theLoai = value; }
        public string TacGia { get => _tacGia; set => _tacGia = value; }
        public string NamXuatBan { get => _namXuatBan; set => _namXuatBan = value; }
        public string NhaXuatBan { get => _nhaXuatBan; set => _nhaXuatBan = value; }
        public string NgayNhap { get => _ngayNhap; set => _ngayNhap = value; }
        public string TriGia { get => _triGia; set => _triGia = value; }
        public string NguoiTiepNhan { get => _nguoiTiepNhan; set => _nguoiTiepNhan = value; }
    }
}
