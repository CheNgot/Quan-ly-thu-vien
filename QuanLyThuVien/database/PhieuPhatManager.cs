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
    class PhieuPhatManager
    {
        private static string TITTLE_PHIEUPHATS = "PhieuPhats";
        private static string TITTLE_PHIEUPHAT = "PhieuPhat";
        private static string nameFile = @"../../PhieuPhats.xml";
        private static string MaPhieuPhat = "MaPhieuPhat";
        private static string MaDocGia = "MaDocGia";
        private static string HoTenDocGia = "HoTenDocGia";
        private static string TienNo = "TienNo";
        private static string TienThu = "TienThu";
        private static string ConLai = "ConLai";
        private static string NgayGhiNhan = "NgayGhiNhan";
        private static string NguoiTiepNhan = "NguoiTiepNhan";
        public List<PhieuPhats> LayDanhPhieuPhat()
        {
            var xmlDocument = XDocument.Load(nameFile);
            List<PhieuPhats> nv = new List<PhieuPhats>();
            nv = xmlDocument.Root
               .Descendants(TITTLE_PHIEUPHAT)
               .Select(node => new PhieuPhats
               {
                   MaPhieuPhat = node.Element(MaPhieuPhat).Value,
                   MaDocGia = node.Element(MaDocGia).Value,
                   HoTenDocGia = node.Element(HoTenDocGia).Value,
                   TienNo = node.Element(TienNo).Value,
                   TienThu = node.Element(TienThu).Value,
                   ConLai = node.Element(ConLai).Value,
                   NgayGhiNhan = node.Element(NgayGhiNhan).Value,
                   NguoiTiepNhan = node.Element(NguoiTiepNhan).Value
               }).ToList();

            return nv;

        }
        public int GetLastNode()
        {

            List<PhieuPhats> nv = LayDanhPhieuPhat();
            int max = int.Parse(nv[0].MaPhieuPhat.ToString().Substring(2));
            for (int i = 0; i < nv.Count(); i++)
            {

                if (int.Parse(nv[i].MaPhieuPhat.ToString().Substring(2)) > max)
                {
                    max = int.Parse(nv[i].MaPhieuPhat.ToString().Substring(2));
                }
            }
            return max + 1;



        }
        public void savePhieuPhat(PhieuPhats nv)
        {
            XDocument doc = XDocument.Load(nameFile);
            XElement school = doc.Element(TITTLE_PHIEUPHATS);
            school.Add(new XElement(TITTLE_PHIEUPHAT,
                       new XElement(MaPhieuPhat, nv.MaPhieuPhat),
                       new XElement(HoTenDocGia, nv.HoTenDocGia),
                       new XElement(MaDocGia, nv.MaDocGia),
                       new XElement(TienNo, nv.TienNo),
                       new XElement(TienThu, nv.TienThu),
                       new XElement(ConLai, nv.ConLai),
                       new XElement(NgayGhiNhan, nv.NgayGhiNhan),
                       new XElement(NguoiTiepNhan, nv.NguoiTiepNhan)

                       ));
            doc.Save(nameFile);
        }

        public void removePhieu(string maphieu)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(nameFile);
            XmlNode node = doc.SelectSingleNode("/" + TITTLE_PHIEUPHATS + "/" + TITTLE_PHIEUPHAT +
                "[MaPhieuPhat='" + maphieu + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(nameFile);
        }
    }
}
