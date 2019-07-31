using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.model
{
    class ChoMuonSach
    {
        private string _MaDocGia;
        private string _HoTen;
        private string _MaSach;
        private string _TenSach;
        private string _TheLoai;
        private string _TacGia;
        private string _LoaiDocGia;
        private string _NgayGhiNhan;

        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string MaSach { get => _MaSach; set => _MaSach = value; }
        public string TenSach { get => _TenSach; set => _TenSach = value; }
        public string TheLoai { get => _TheLoai; set => _TheLoai = value; }
        public string TacGia { get => _TacGia; set => _TacGia = value; }
        public string LoaiDocGia { get => _LoaiDocGia; set => _LoaiDocGia = value; }
        public string NgayGhiNhan { get => _NgayGhiNhan; set => _NgayGhiNhan = value; }
        public string MaDocGia { get => _MaDocGia; set => _MaDocGia = value; }
    }
}
