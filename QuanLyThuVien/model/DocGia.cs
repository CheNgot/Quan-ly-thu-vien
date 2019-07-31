using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.model
{
    class DocGia
    {
        private string _maDocGia;
        private string _hoTen;
        private string _ngaySinh;
        private string _diaChi;
        private string _loaiDocGia;
        private string _email;
        private string _ngayLapThe;

        public string MaDocGia { get => _maDocGia; set => _maDocGia = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string LoaiDocGia { get => _loaiDocGia; set => _loaiDocGia = value; }
        public string Email { get => _email; set => _email = value; }
        public string NgayLapThe { get => _ngayLapThe; set => _ngayLapThe = value; }
    }
}
