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
    class ChoMuonSachManager
    {
        public static string TITTLE_MUONSACHS = "MuonSachs";
        public static string TITTLE_MUONSACH = "MuonSach";
        public static string nameFile = @"../../chomuonsach.xml";
        public static string MaDocGia = "MaDocGia";
        public static string HoTen = "HoTen";
        public static string MaSach = "MaSach";
        public static string TenSach = "TenSach";
        public static string TheLoai = "TheLoai";
        public static string TacGia = "TacGia";
        public static string LoaiDocGia = "LoaiDocGia";
        public static string NgayGhiNhan = "NgayGhiNhan";

        public List<ChoMuonSach> layds()
        {
            var xmlDocument = XDocument.Load(nameFile);
            List<ChoMuonSach> chomuon = new List<ChoMuonSach>();
            chomuon = xmlDocument.Root
                .Descendants(TITTLE_MUONSACH)
                .Select(node => new ChoMuonSach
                {
                    MaDocGia = node.Element(MaDocGia).Value,
                    HoTen = node.Element(HoTen).Value,
                    MaSach = node.Element(MaSach).Value,
                    TenSach = node.Element(TenSach).Value,
                    TheLoai = node.Element(TheLoai).Value,
                    TacGia = node.Element(TacGia).Value,
                    LoaiDocGia = node.Element(LoaiDocGia).Value,
                    NgayGhiNhan = node.Element(NgayGhiNhan).Value
                }).ToList();
            return chomuon;
        }

        public void saveChoMuonSach(ChoMuonSach cms)
        {
            XDocument doc = XDocument.Load(nameFile);
            XElement school = doc.Element(TITTLE_MUONSACHS);
            school.Add(new XElement(TITTLE_MUONSACH,
                       new XElement(MaDocGia, cms.MaDocGia),
                       new XElement(HoTen, cms.HoTen),
                       new XElement(MaSach, cms.MaSach),
                       new XElement(TenSach, cms.TenSach),
                       new XElement(TheLoai, cms.TheLoai),
                       new XElement(TacGia, cms.TacGia),
                       new XElement(LoaiDocGia, cms.LoaiDocGia),
                       new XElement(NgayGhiNhan, cms.NgayGhiNhan)));
            doc.Save(nameFile);
        }

        public void saveListPhieuMuonSach(List<ChoMuonSach> choMuonSaches)
        {
            List<ChoMuonSach> currentNhanviens = layds();
            for (int i = 0; i < choMuonSaches.Count; i++)
            {
                bool flag = false;
                foreach (var phieuMuon in choMuonSaches)
                {
                    if (choMuonSaches[i].MaDocGia == phieuMuon.MaDocGia && choMuonSaches[i].MaSach == phieuMuon.MaSach)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false) saveChoMuonSach(choMuonSaches[i]);
            }
        }

        public List<string> LayTenNgMuon()
        {
            List<string> ds = new List<string>();
            List<ChoMuonSach> s = layds();
            for (int i = 0; i < s.Count(); i++)
            {
                ds.Add(s[i].HoTen);
            }
            return ds;
        }
        public List<string> LayMaNgMuon()
        {
            List<string> ds = new List<string>();
            List<ChoMuonSach> s = layds();
            for (int i = 0; i < s.Count(); i++)
            {
                ds.Add(s[i].MaDocGia);
            }
            return ds;
        }
        public List<string> LayMaSach()
        {
            List<string> ds = new List<string>();
            List<ChoMuonSach> s = layds();
            for (int i = 0; i < s.Count(); i++)
            {
                ds.Add(s[i].MaSach);
            }
            return ds;
        }

        public void removeChoMuon(string ma)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(nameFile);
            XmlNode node = doc.SelectSingleNode("/" + TITTLE_MUONSACHS + "/" + TITTLE_MUONSACH +
                "[MaSach='" + ma + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(nameFile);
        }
    }
}
