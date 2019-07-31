using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.database
{
    class ChucVus
    {
        public const string gd = "Giám Đốc";
        public const string pgd = "Phó Giám Đốc";
        public const string tp = "Trưởng Phòng";
        public const string pp = "Phó Phòng";
        public const string nv = "Nhân Viên";


        public static List<string> laydanhsachchucvu()
        {
            List<string> bc = new List<string>();
            bc.Add(nv);
            bc.Add(pp);
            bc.Add(tp);
            bc.Add(pgd);
            bc.Add(gd);
            return bc;
        }
    }
}
