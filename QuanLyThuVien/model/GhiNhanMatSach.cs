using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.model
{
    class GhiNhanMatSach
    {
        private string _MaSach;
        private string _TenSach;
        private string _HoTen;
        private string _NgayGhiNhan;
        private string _TienPhat;
        private string _NguoiTiepNhan;

        public string TenSach { get => _TenSach; set => _TenSach = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string NgayGhiNhan { get => _NgayGhiNhan; set => _NgayGhiNhan = value; }
        public string TienPhat { get => _TienPhat; set => _TienPhat = value; }
        public string NguoiTiepNhan { get => _NguoiTiepNhan; set => _NguoiTiepNhan = value; }
        public string MaSach { get => _MaSach; set => _MaSach = value; }
    }
}
