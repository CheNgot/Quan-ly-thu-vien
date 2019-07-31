using QuanLyThuVien.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace QuanLyThuVien.database
{
    class NhanVienManager
    {
        public static string TITTLE_NHANVIENS = "NhanViens";
        public static string TITTLE_NHANVIEN = "NhanVien";
        public static string nameFile = @"../../NhanViens.xml";
        public static string MaNhanVien = "MaNhanVien";
        public static string HoTenNhanVien = "HoTenNhanVien";
        public static string DiaChi = "DiaChi";
        public static string NgaySinh = "NgaySinh";
        public static string BangCap = "BangCap";
        public static string BoPhan = "BoPhan";
        public static string ChucVu = "ChucVu";
        public static string DienThoai = "DienThoai";

        public List<NhanVien> LayDanhSachNhanVien()
        {
            var xmlDocument = XDocument.Load(nameFile);
            List<NhanVien> nv = new List<NhanVien>();
            nv = xmlDocument.Root
               .Descendants(TITTLE_NHANVIEN)
               .Select(node => new NhanVien
               {
                   MaNhanVien = node.Element(MaNhanVien).Value,
                   HoTenNhanVien = node.Element(HoTenNhanVien).Value,
                   DienThoai = node.Element(DienThoai).Value,
                   DiaChi = node.Element(DiaChi).Value,
                   NgaySinh = node.Element(NgaySinh).Value,
                   BangCap = node.Element(BangCap).Value,
                   BoPhan = node.Element(BoPhan).Value,
                   ChucVu = node.Element(ChucVu).Value
               }).ToList();

            return nv;

        }

        public int GetLastNode()
        {

            List<NhanVien> nv = LayDanhSachNhanVien();
            int max = int.Parse(nv[0].MaNhanVien.ToString().Substring(2));
            for (int i=0;i<nv.Count();i++)
            {
                
                if (int.Parse(nv[i].MaNhanVien.ToString().Substring(2)) > max)
                {
                    max = int.Parse(nv[i].MaNhanVien.ToString().Substring(2));
                }
            }
            return max+1;
        }

        public List<string> LayNhanVienThuKho()
        {
            string thukho = "Thủ Kho";
            List<string> ds = new List<string>();
            List<NhanVien> nv = LayDanhSachNhanVien();
            for (int i = 0; i < nv.Count; i++)
            {
                if (nv[i].BoPhan == thukho)
                {

                    ds.Add(nv[i].HoTenNhanVien);

                }
            }
            return ds;
        }
        public List<string> LayNhanVienThuThu()
        {
            string thuthu = "Thủ Thư";
            List<string> ds = new List<string>();
            List<NhanVien> nv = LayDanhSachNhanVien();
            for (int i = 0; i < nv.Count; i++)
            {
                if (nv[i].BoPhan == thuthu)
                {

                    ds.Add(nv[i].HoTenNhanVien);

                }
            }
            return ds;
        }
        public List<string> LayNhanVienThuQuy()
        {
            string thukho = "Thủ Quỹ";
            List<string> ds = new List<string>();
            List<NhanVien> nv = LayDanhSachNhanVien();
            for (int i = 0; i < nv.Count; i++)
            {
                if (nv[i].BoPhan == thukho)
                {

                    ds.Add(nv[i].HoTenNhanVien);

                }
            }
            return ds;
        }

        public void saveNhanVien(NhanVien nv)
        {
            XDocument doc = XDocument.Load(nameFile);
            XElement school = doc.Element(TITTLE_NHANVIENS);
            school.Add(new XElement(TITTLE_NHANVIEN,
                       new XElement(MaNhanVien, nv.MaNhanVien),
                       new XElement(HoTenNhanVien, nv.HoTenNhanVien),
                       new XElement(DiaChi, nv.DiaChi),
                       new XElement(DienThoai, nv.DienThoai),
                       new XElement(NgaySinh, nv.NgaySinh),
                       new XElement(BangCap, nv.BangCap),
                       new XElement(BoPhan, nv.BoPhan),
                       new XElement(ChucVu, nv.ChucVu)

                       ));
            doc.Save(nameFile);
        }

        public void saveListNhanVien(List<NhanVien> nhanViens)
        {
            List<NhanVien> currentNhanviens = LayDanhSachNhanVien();
            for (int i = 0; i < nhanViens.Count; i++)
            {
                bool flag = false;
                foreach(var nhanvien in currentNhanviens)
                {
                    if (nhanViens[i].MaNhanVien == nhanvien.MaNhanVien)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false) saveNhanVien(nhanViens[i]);
            }
        }

        public void removeNhanVien(string manhanvien)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(nameFile);
            XmlNode node = doc.SelectSingleNode("/" + TITTLE_NHANVIENS + "/" + TITTLE_NHANVIEN +
                "[MaNhanVien='" + manhanvien + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(nameFile);
        }
    }
}
