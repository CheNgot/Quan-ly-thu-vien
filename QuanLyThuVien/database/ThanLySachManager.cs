using QuanLyThuVien.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyThuVien.database
{
    class ThanLySachManager
    {
        private static string TITTLE_THANHLYSACHS = "ThanhLySachs";
        private static string TITTLE_THANHLYSACH = "ThanhLySach";
        private static string nameFile = @"../../ThanhLySachs.xml";
        private static string MaSach = "MaSachs";
        private static string TenSach = "TenSachs";
        private static string LyDoThanhLy = "LyDoThanhLy";
        public List<TLSach> Getds()
        {
            var xmlDocument = XDocument.Load(nameFile);
            List<TLSach> tl = new List<TLSach>();
            tl = xmlDocument.Root
                .Descendants(TITTLE_THANHLYSACH)
                .Select(node => new TLSach
                {
                    MaSach = node.Element(MaSach).Value,
                    TenSach = node.Element(TenSach).Value,
                    LyDoThanhLy = node.Element(LyDoThanhLy).Value

                }).ToList();

            return tl;
        }
        public void saveThanhLySach(TLSach tl)
        {
            XDocument doc = XDocument.Load(nameFile);
            XElement school = doc.Element(TITTLE_THANHLYSACHS);
            school.Add(new XElement(TITTLE_THANHLYSACH,
                       new XElement(MaSach, tl.MaSach),
                       new XElement(TenSach, tl.TenSach),
                       new XElement(LyDoThanhLy, tl.LyDoThanhLy)));
            doc.Save(nameFile);
        }
    }
}
