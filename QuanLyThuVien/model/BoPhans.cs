using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.database
{
    class BoPhans
    {
        public const string thuthu = "Thủ Thư";
        public const string thukho = "Thủ Kho";
        public const string thuquy = "Thủ Quỹ";
        public const string bangiamdoc = "Ban Giám Đốc";


        public static List<string> laydanhsachbophan()
        {
            List<string> bc = new List<string>();
            bc.Add(thuthu);
            bc.Add(thukho);
            bc.Add(thuquy);
            bc.Add(bangiamdoc);

            return bc;
        }
    }
}
