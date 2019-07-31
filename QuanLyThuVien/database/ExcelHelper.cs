using LinqToExcel;
using QLTV.model;
using QuanLyThuVien.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.database
{
    class ExcelHelper
    {
        public List<NhanVien> GetListNhanVienFromExcel(string path)
        {
            var excel = new ExcelQueryFactory(path);
            var indianaCompanies = from c in excel.Worksheet<NhanVien>()
                                   select c;
            List<NhanVien> nhanViens = indianaCompanies.ToList();
            return nhanViens;
        }

        public List<Account> GetListAccountFromExcel(string path)
        {
            var excel = new ExcelQueryFactory(path);
            var indianaCompanies = from c in excel.Worksheet<Account>()
                                   select c;
            List<Account> accounts = indianaCompanies.ToList();
            return accounts;
        }

        public List<DocGia> GetListDocGiaFromExcel(string path)
        {
            var excel = new ExcelQueryFactory(path);
            var indianaCompanies = from c in excel.Worksheet<DocGia>()
                                   select c;
            List<DocGia> docGias = indianaCompanies.ToList();
            return docGias;
        }

        public List<Sach> GetListSachFromExcel(string path)
        {
            var excel = new ExcelQueryFactory(path);
            var indianaCompanies = from c in excel.Worksheet<Sach>()
                                   select c;
            List<Sach> saches = indianaCompanies.ToList();
            return saches;
        }

        public List<ChoMuonSach> GetListPhieuMuonSachFromExcel(string path)
        {
            var excel = new ExcelQueryFactory(path);
            var indianaCompanies = from c in excel.Worksheet<ChoMuonSach>()
                                   select c;
            List<ChoMuonSach> saches = indianaCompanies.ToList();
            return saches;
        }
    }
}