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
    class SachManager
    {
        public static string TITTLE_SACHS = "Sachs";
        public static string TITTLE_SACH = "Sach";
        public static string nameFile = @"../../Sachs.xml";
        public static string MaSach = "MaSach";
        public static string TenSach = "TenSach";
        public static string TheLoai = "TheLoai";
        public static string TacGia = "TacGia";
        public static string NamXuatBan = "NamXuatBan";
        public static string NhaXuatBan = "NhaXuatBan";
        public static string NgayNhap = "NgayNhap";
        public static string TriGia = "TriGia";
        public static string NguoiTiepNhan = "NguoiTiepNhan";

        public List<Sach> LayDanhSachSach()
        {
            var xmlDocument = XDocument.Load(nameFile);
            List<Sach> s = new List<Sach>();
            s = xmlDocument.Root
               .Descendants(TITTLE_SACH)
               .Select(node => new Sach
               {
                   MaSach = node.Element(MaSach).Value,
                   TenSach = node.Element(TenSach).Value,
                   TheLoai = node.Element(TheLoai).Value,
                   TacGia = node.Element(TacGia).Value,
                   NamXuatBan = node.Element(NamXuatBan).Value,
                   NhaXuatBan = node.Element(NhaXuatBan).Value,
                   NgayNhap = node.Element(NgayNhap).Value,
                   TriGia = node.Element(TriGia).Value,
                   NguoiTiepNhan = node.Element(NguoiTiepNhan).Value
               }).ToList();

            return s;
        }

        public int GetLastNode()
        {
            List<Sach> nv = LayDanhSachSach();
            int max = int.Parse(nv[0].MaSach.ToString().Substring(2));
            for (int i = 0; i < nv.Count(); i++)
            {

                if (int.Parse(nv[i].MaSach.ToString().Substring(2)) > max)
                {
                    max = int.Parse(nv[i].MaSach.ToString().Substring(2));
                }
            }
            return max + 1;



        }

        public List<string> LayDanhSachMaSach()
        {
            List<string> ds = new List<string>();
            List<Sach> s = LayDanhSachSach();
            for (int i = 0; i < s.Count(); i++)
            {
                ds.Add(s[i].MaSach);
            }
            return ds;
        }

        public void saveSach(Sach s)
        {
            XDocument doc = XDocument.Load(nameFile);
            XElement school = doc.Element(TITTLE_SACHS);
            school.Add(new XElement(TITTLE_SACH,
                       new XElement(MaSach, s.MaSach),
                       new XElement(TenSach, s.TenSach),
                       new XElement(TheLoai, s.TheLoai),
                       new XElement(TacGia, s.TacGia),
                       new XElement(NamXuatBan, s.NamXuatBan),
                       new XElement(NhaXuatBan, s.NhaXuatBan),
                       new XElement(NgayNhap, s.NgayNhap),
                       new XElement(TriGia, s.TriGia),
                       new XElement(NguoiTiepNhan, s.NguoiTiepNhan)

                       ));
            doc.Save(nameFile);
        }

        public void saveListSach(List<Sach> saches)
        {
            List<Sach> currentSaches = LayDanhSachSach();
            for (int i = 0; i < saches.Count; i++)
            {
                bool flag = false;
                foreach (var sach in currentSaches)
                {
                    if (saches[i].MaSach == sach.MaSach)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false) saveSach(saches[i]);
            }
        }

        public void removeSach(string masach)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(nameFile);
            XmlNode node = doc.SelectSingleNode("/" + TITTLE_SACHS + "/" + TITTLE_SACH +
                "[MaSach='" + masach + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(nameFile);
        }
    }
}
