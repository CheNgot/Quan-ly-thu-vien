using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.database
{
    class loaiDocGia
    {
        public const string x = "Độc Giả X";
        public const string y = "Độc Giả Y";

        public static List<string> laydsdocgia()
        {
            List<string> dg = new List<string>();
            dg.Add(x);
            dg.Add(y);
            return dg;
        }
    }
}
