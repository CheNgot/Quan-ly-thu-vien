using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.model
{
    class TraSach
    {
        private string _MaSach;
        private string _MaDocGia;
        private string _HoTen;
        private string _NgayMuon;
        private string _NgayTra;
        private string _SoNgayMuon;
        private string _TienPhat;
        private string _TienPhatKyNay;
        private string _TienNo;
        private string _TongNo;

        public string MaSach { get => _MaSach; set => _MaSach = value; }
        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string NgayMuon { get => _NgayMuon; set => _NgayMuon = value; }
        public string NgayTra { get => _NgayTra; set => _NgayTra = value; }
        public string SoNgayMuon { get => _SoNgayMuon; set => _SoNgayMuon = value; }
        public string TienPhat { get => _TienPhat; set => _TienPhat = value; }
        public string TienPhatKyNay { get => _TienPhatKyNay; set => _TienPhatKyNay = value; }
        public string TienNo { get => _TienNo; set => _TienNo = value; }
        public string TongNo { get => _TongNo; set => _TongNo = value; }
        public string MaDocGia { get => _MaDocGia; set => _MaDocGia = value; }
    }
}
