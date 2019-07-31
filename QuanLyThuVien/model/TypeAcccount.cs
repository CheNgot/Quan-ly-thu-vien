using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.model
{
    class TypeAcccount
    {
        public const string THU_QUY = "Thủ Qũy";
        public const string THU_THU = "Thủ Thư";
        public const string THU_KHO = "Thủ Kho";
        public const string ADMIN = "Admin";

        public static List<string> getAllTypeAccounts()
        {
            List<string> accounts = new List<string>();
            accounts.Add(THU_QUY);
            accounts.Add(THU_THU);
            accounts.Add(THU_KHO);
            accounts.Add(ADMIN);
            return accounts;
        }
    }
}