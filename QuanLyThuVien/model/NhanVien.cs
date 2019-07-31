using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.model
{
    class NhanVien
    {
        private string _maNhanVien;
        private string _hoTenNhanVien;
        private string _diaChi;
        private string _ngaySinh;
        private string _bangCap;
        private string _boPhan;
        private string _chucVu;
        private string _dienThoai;

        public string MaNhanVien { get => _maNhanVien; set => _maNhanVien = value; }
        public string HoTenNhanVien { get => _hoTenNhanVien; set => _hoTenNhanVien = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string BangCap { get => _bangCap; set => _bangCap = value; }
        public string BoPhan { get => _boPhan; set => _boPhan = value; }
        public string ChucVu { get => _chucVu; set => _chucVu = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }
    }
}
