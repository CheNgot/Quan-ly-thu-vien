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
    class GhiNhanMatSachManager
    {
        private static string TITTLE_GHINHANMATSACHS = "GhiNhanMatSachs";
        private static string TITTLE_GHINHANMATSACH = "GhiNhanMatSach";
        private static string nameFile = @"../../ghinhanmatsach.xml";
        private static string MaSach = "MaSach";
        private static string TenSach = "TenSach";
        private static string HoTen = "HoTen";
        private static string NgayGhiNhan = "NgayGhiNhan";
        private static string TienPhat = "TienPhat";
        private static string NguoiTiepNhan = "NguoiTiepNhan";

        public List<GhiNhanMatSach> LayDanhSachMatSach()
        {
            var xmlDocument = XDocument.Load(nameFile);
            List<GhiNhanMatSach> gnms = new List<GhiNhanMatSach>();
            gnms = xmlDocument.Root
               .Descendants(TITTLE_GHINHANMATSACH)
               .Select(node => new GhiNhanMatSach
               {
                   MaSach = node.Element(MaSach).Value,
                   TenSach = node.Element(TenSach).Value,
                   HoTen = node.Element(HoTen).Value,
                   NgayGhiNhan = node.Element(NgayGhiNhan).Value,
                   TienPhat = node.Element(TienPhat).Value,
                   NguoiTiepNhan = node.Element(NguoiTiepNhan).Value
               }).ToList();

            return gnms;
        }

        public int GetLastNode()
        {

            List<GhiNhanMatSach> nv = LayDanhSachMatSach();
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
        public void saveGhiNhanMatSach(GhiNhanMatSach s)
        {
            XDocument doc = XDocument.Load(nameFile);
            XElement school = doc.Element(TITTLE_GHINHANMATSACHS);
            school.Add(new XElement(TITTLE_GHINHANMATSACH,
                       new XElement(MaSach, s.MaSach),
                       new XElement(TenSach, s.TenSach),
                       new XElement(HoTen, s.HoTen),
                       new XElement(NgayGhiNhan, s.NgayGhiNhan),
                       new XElement(TienPhat, s.TienPhat),
                       new XElement(NguoiTiepNhan, s.NguoiTiepNhan)

                       ));
            doc.Save(nameFile);
        }
        public void removeGhiNhanMatSach(string masach)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(nameFile);
            XmlNode node = doc.SelectSingleNode("/" + TITTLE_GHINHANMATSACHS + "/" + TITTLE_GHINHANMATSACH +
                "[MaSach='" + masach + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(nameFile);
        }
    }
}
