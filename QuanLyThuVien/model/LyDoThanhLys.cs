using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.model
{
    class LyDoThanhLys
    {
        public const string mat = "Mất";
        public const string huhong = "Hư Hỏng";
        public const string nguoidunglammat = "Người Dùng làm mất";

        public static List<string> laydanhsachLydo()
        {
            List<string> bc = new List<string>();
            bc.Add(mat);
            bc.Add(huhong);
            bc.Add(nguoidunglammat);

            return bc;
        }
    }
}
