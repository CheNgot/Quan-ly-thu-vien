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
    class TraSachManager
    {
        private static string TITTLE_TRASACHS = "NhanTraSachs";
        private static string TITTLE_TRASACH = "NhanTraSach";
        private static string nameFile = @"../../trasach.xml";
        private static string MaSach = "MaSach";
        private static string MaDocGia = "MaDocGia";
        private static string HoTen = "HoTen";
        private static string NgayMuon = "NgayMuon";
        private static string NgayTra = "NgayTra";
        private static string SoNgayMuon = "SoNgayMuon";
        private static string TienPhat = "TienPhat";
        private static string TienPhatKyNay = "TienPhatKyNay";
        private static string TienNo = "TienNo";
        private static string TongNo = "TongNo";

        public List<TraSach> layDsTraSach()
        {
            var xmlDocument = XDocument.Load(nameFile);
            List<TraSach> chomuon = new List<TraSach>();
            chomuon = xmlDocument.Root
                .Descendants(TITTLE_TRASACH)
                .Select(node => new TraSach
                {
                    MaSach=node.Element(MaSach).Value,
                    MaDocGia=node.Element(MaDocGia).Value,
                    HoTen= node.Element(HoTen).Value,
                    NgayMuon= node.Element(NgayMuon).Value,
                    NgayTra=node.Element(NgayTra).Value,
                    SoNgayMuon=node.Element(SoNgayMuon).Value,
                    TienPhat=node.Element(TienPhat).Value,
                    TienPhatKyNay=node.Element(TienPhatKyNay).Value,
                    TienNo=node.Element(TienNo).Value,
                    TongNo=node.Element(TongNo).Value
                }).ToList();
            return chomuon;
        }

        public void saveTraSach(TraSach a)
        {
            XDocument doc = XDocument.Load(nameFile);
            XElement school = doc.Element(TITTLE_TRASACHS);
            school.Add(new XElement(TITTLE_TRASACH,
                       new XElement(MaSach, a.MaSach),
                       new XElement(MaDocGia,a.MaDocGia),
                       new XElement(HoTen, a.HoTen),
                       new XElement(NgayMuon, a.NgayMuon),
                       new XElement(NgayTra, a.NgayTra),
                       new XElement(SoNgayMuon, a.SoNgayMuon),
                       new XElement(TienPhat, a.TienPhat),
                       new XElement(TienPhatKyNay,a.TienPhatKyNay),
                       new XElement(TienNo, a.TienNo),
                       new XElement(TongNo, a.TongNo)));
            doc.Save(nameFile);
        }

        public void saveListTraSach(List<TraSach> traSaches)
        {
            List<TraSach> currentSaches = layDsTraSach();
            for (int i = 0; i < traSaches.Count; i++)
            {
                bool flag = false;
                foreach (var sach in currentSaches)
                {
                    if (traSaches[i].MaSach == sach.MaSach)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false) saveTraSach(traSaches[i]);
            }
        }

        public void removeTraSach(string ma)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(nameFile);
            XmlNode node = doc.SelectSingleNode("/" + TITTLE_TRASACHS + "/" + TITTLE_TRASACH +
                "[MaSach='" + ma + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(nameFile);
        }
    }
}
