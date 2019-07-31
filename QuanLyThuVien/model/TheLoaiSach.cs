using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.model
{
    class TheLoaiSach
    {
        public const string A = "A";
        public const string B = "B";
        public const string C = "C";

        public static List<string> laydanhsachtheloai()
        {
            List<string> bc = new List<string>();
            bc.Add(A);
            bc.Add(B);
            bc.Add(C);

            return bc;
        }
    }
}
