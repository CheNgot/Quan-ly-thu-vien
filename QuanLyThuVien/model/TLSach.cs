using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.model
{
    class TLSach
    {
        private string _maSach;
        private string _tenSach;
        private string _lyDoThanhLy;

        public string MaSach { get => _maSach; set => _maSach = value; }
        public string TenSach { get => _tenSach; set => _tenSach = value; }
        public string LyDoThanhLy { get => _lyDoThanhLy; set => _lyDoThanhLy = value; }
    }
}
