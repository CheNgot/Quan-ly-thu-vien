using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.model
{
    class PhieuPhats
    {
        private  string _maPhieuPhat ;
        private  string _maDocGia ;
        private  string _hoTenDocGia;
        private string _tienNo ;
        private  string _tienThu ;
        private  string _conLai ;
        private  string _ngayGhiNhan ;
        private  string _nguoiTiepNhan ;

        public string MaPhieuPhat { get => _maPhieuPhat; set => _maPhieuPhat = value; }
        public string MaDocGia { get => _maDocGia; set => _maDocGia = value; }
        public string HoTenDocGia { get => _hoTenDocGia; set => _hoTenDocGia = value; }
        public string TienNo { get => _tienNo; set => _tienNo = value; }
        public string TienThu { get => _tienThu; set => _tienThu = value; }
        public string ConLai { get => _conLai; set => _conLai = value; }
        public string NgayGhiNhan { get => _ngayGhiNhan; set => _ngayGhiNhan = value; }
        public string NguoiTiepNhan { get => _nguoiTiepNhan; set => _nguoiTiepNhan = value; }
    }
}
