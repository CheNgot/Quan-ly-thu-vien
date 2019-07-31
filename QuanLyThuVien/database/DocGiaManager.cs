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
    class DocGiaManager
    {
        public static string TITTLE_DOCGIAS = "DocGias";
        public static string TITTLE_DOCGIA = "DocGia";
        public static string nameFile = @"../../docgia.xml";
        public static string MaDocGia = "MaDocGia";
        public static string HoTen = "HoTen";
        public static string NgaySinh = "NgaySinh";
        public static string DiaChi = "DiaChi";
        public static string LoaiDocGia = "LoaiDocGia";
        public static string Email = "Email";
        public static string NgayLapThe = "NgayLapThe";
        public List<DocGia> LayDanhSachDocGia()
        {
            var xmlDocument = XDocument.Load(nameFile);
            List<DocGia> dg = new List<DocGia>();
            dg = xmlDocument.Root
               .Descendants(TITTLE_DOCGIA)
               .Select(node => new DocGia
               {
                   MaDocGia = node.Element(MaDocGia).Value,
                 HoTen=node.Element(HoTen).Value,
                   NgaySinh = node.Element(NgaySinh).Value,
                   DiaChi = node.Element(DiaChi).Value,
                   LoaiDocGia = node.Element(LoaiDocGia).Value,
                   Email = node.Element(Email).Value,
                   NgayLapThe = node.Element(NgayLapThe).Value
               }).ToList();

            return dg;

        }

        public List<string> LayDsDG()
        {
            List<string> ds = new List<string>();
            List<DocGia> dg = LayDanhSachDocGia();
            for (int i = 0; i < dg.Count(); i++)
            {
                ds.Add(dg[i].MaDocGia);
            }
            return ds;
        }

        public int GetLastNode()
        {
            var xmlDocument = XDocument.Load(nameFile);
            var lastPost = xmlDocument.Descendants("MaDocGia").Last().Value.ToString().Substring(2);
            int id = int.Parse(lastPost) + 1;
            return id;
        }

        public void saveDocGia(DocGia dg)
        {
            XDocument doc = XDocument.Load(nameFile);
            XElement school = doc.Element(TITTLE_DOCGIAS);
            school.Add(new XElement(TITTLE_DOCGIA,
                       new XElement(MaDocGia, dg.MaDocGia),
                       new XElement(HoTen, dg.HoTen),
                       new XElement(NgaySinh, dg.NgaySinh),
                       new XElement(DiaChi, dg.DiaChi),
                       new XElement(LoaiDocGia, dg.LoaiDocGia),
                       new XElement(Email, dg.Email),
                       new XElement(NgayLapThe, dg.NgayLapThe)

                       ));
            doc.Save(nameFile);
        }

        public void saveListDocGia(List<DocGia> docGias)
        {
            List<DocGia> currentDocGias = LayDanhSachDocGia();
            for (int i = 0; i < docGias.Count; i++)
            {
                bool flag = false;
                foreach (var docGia in currentDocGias)
                {
                    if (docGias[i].MaDocGia == docGia.MaDocGia)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false) saveDocGia(docGias[i]);
            }
        }

        public void removeDocGia(string madg)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(nameFile);
            XmlNode node = doc.SelectSingleNode("/" + TITTLE_DOCGIAS + "/" + TITTLE_DOCGIA +
                "[MaDocGia='" + madg + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(nameFile);
        }

    }
}
