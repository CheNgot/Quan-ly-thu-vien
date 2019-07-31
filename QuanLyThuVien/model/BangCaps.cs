using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.database
{
    class BangCaps
    {
        public const string tutai = "Tú Tài";
        public const string trungcap = "Trung Cấp";
        public const string caodang = "Cao Đẳng";
        public const string daihoc = "Đại Học";
        public const string thacsi = "Thạc Sĩ";
        public const string tiensi = "Tiến Sĩ";

        public static List<string> laydanhsachbangcap()
        {
            List<string> bc = new List<string>();
            bc.Add(tutai);
            bc.Add(trungcap);
            bc.Add(caodang);
            bc.Add(daihoc);
            bc.Add(thacsi);
            bc.Add(tiensi);
            return bc;
        }
    }
}
