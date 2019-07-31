using LinqToExcel;
using QLTV.database;
using QLTV.model;
using QuanLyThuVien.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.database
{
    class XmlGenerate
    {
        private string apiurl = "http://demos.componentone.com/ASPNET/C1WebAPIService/api/excel";

        public void GenerateFromXML(List<NhanVien> nhanViens)
        {
            DataTable dt = this.createNhanVienDataTable(nhanViens);
            //Create Temp directory to save xml file  
            var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            string path = Path.Combine(tempDir, string.Format("{0}.{1}", "Prodcuts", "xml"));
            //Write to xml file  
            dt.WriteXml(path, XmlWriteMode.IgnoreSchema);

            //Create HttpClient and MultipartFormDataContent  
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            using (var fromFile = File.OpenRead(path))
            {

                formData.Add(new StringContent(NhanVienManager.TITTLE_NHANVIEN), "FileName");
                formData.Add(new StringContent("xlsx"), "FileFormat");
                formData.Add(new StreamContent(fromFile), "DataFile", Path.GetFileName(path));
                //Call WebAPI  
                var response = client.PostAsync(apiurl, formData).Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Invalid response.");
                    return;
                }
                var tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                }
                var tempFilePath = Path.Combine(tempPath, string.Format("{0}.{1}", NhanVienManager.TITTLE_NHANVIEN, "xlsx"));
                using (var newFile = File.Create(tempFilePath))
                {
                    response.Content.ReadAsStreamAsync().Result.CopyTo(newFile);
                }
                //Open In Excel  
                Process.Start(tempFilePath);
            }
        }

        public void GenerateFromXML(List<Account> accounts)
        {
            DataTable dt = this.createAccountDataTable(accounts);
            //Create Temp directory to save xml file  
            var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            string path = Path.Combine(tempDir, string.Format("{0}.{1}", "Prodcuts", "xml"));
            //Write to xml file  
            dt.WriteXml(path, XmlWriteMode.IgnoreSchema);

            //Create HttpClient and MultipartFormDataContent  
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            using (var fromFile = File.OpenRead(path))
            {

                formData.Add(new StringContent(NhanVienManager.TITTLE_NHANVIEN), "FileName");
                formData.Add(new StringContent("xlsx"), "FileFormat");
                formData.Add(new StreamContent(fromFile), "DataFile", Path.GetFileName(path));
                //Call WebAPI  
                var response = client.PostAsync(apiurl, formData).Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Invalid response.");
                    return;
                }
                var tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                }
                var tempFilePath = Path.Combine(tempPath, string.Format("{0}.{1}", AccountManager.TITTLE_ACCOUNT, "xlsx"));
                using (var newFile = File.Create(tempFilePath))
                {
                    response.Content.ReadAsStreamAsync().Result.CopyTo(newFile);
                }
                //Open In Excel  
                Process.Start(tempFilePath);
            }
        }

        public void GenerateFromXML(List<DocGia> docGias)
        {
            DataTable dt = this.createDocGiaDataTable(docGias);
            //Create Temp directory to save xml file  
            var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            string path = Path.Combine(tempDir, string.Format("{0}.{1}", "Prodcuts", "xml"));
            //Write to xml file  
            dt.WriteXml(path, XmlWriteMode.IgnoreSchema);

            //Create HttpClient and MultipartFormDataContent  
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            using (var fromFile = File.OpenRead(path))
            {

                formData.Add(new StringContent(NhanVienManager.TITTLE_NHANVIEN), "FileName");
                formData.Add(new StringContent("xlsx"), "FileFormat");
                formData.Add(new StreamContent(fromFile), "DataFile", Path.GetFileName(path));
                //Call WebAPI  
                var response = client.PostAsync(apiurl, formData).Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Invalid response.");
                    return;
                }
                var tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                }
                var tempFilePath = Path.Combine(tempPath, string.Format("{0}.{1}", DocGiaManager.TITTLE_DOCGIA, "xlsx"));
                using (var newFile = File.Create(tempFilePath))
                {
                    response.Content.ReadAsStreamAsync().Result.CopyTo(newFile);
                }
                //Open In Excel  
                Process.Start(tempFilePath);
            }
        }

        public void GenerateFromXML(List<Sach> saches)
        {
            DataTable dt = this.createSachDataTable(saches);
            //Create Temp directory to save xml file  
            var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            string path = Path.Combine(tempDir, string.Format("{0}.{1}", "Prodcuts", "xml"));
            //Write to xml file  
            dt.WriteXml(path, XmlWriteMode.IgnoreSchema);

            //Create HttpClient and MultipartFormDataContent  
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            using (var fromFile = File.OpenRead(path))
            {

                formData.Add(new StringContent(NhanVienManager.TITTLE_NHANVIEN), "FileName");
                formData.Add(new StringContent("xlsx"), "FileFormat");
                formData.Add(new StreamContent(fromFile), "DataFile", Path.GetFileName(path));
                //Call WebAPI  
                var response = client.PostAsync(apiurl, formData).Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Invalid response.");
                    return;
                }
                var tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                }
                var tempFilePath = Path.Combine(tempPath, string.Format("{0}.{1}", SachManager.TITTLE_SACH, "xlsx"));
                using (var newFile = File.Create(tempFilePath))
                {
                    response.Content.ReadAsStreamAsync().Result.CopyTo(newFile);
                }
                //Open In Excel  
                Process.Start(tempFilePath);
            }
        }

        public void GenerateFromXML(List<ChoMuonSach> choMuonSaches)
        {
            DataTable dt = this.createPhieuMuonSachDataTable(choMuonSaches);
            //Create Temp directory to save xml file  
            var tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDir);
            string path = Path.Combine(tempDir, string.Format("{0}.{1}", "Prodcuts", "xml"));
            //Write to xml file  
            dt.WriteXml(path, XmlWriteMode.IgnoreSchema);

            //Create HttpClient and MultipartFormDataContent  
            using (var client = new HttpClient())
            using (var formData = new MultipartFormDataContent())
            using (var fromFile = File.OpenRead(path))
            {

                formData.Add(new StringContent(ChoMuonSachManager.TITTLE_MUONSACH), "FileName");
                formData.Add(new StringContent("xlsx"), "FileFormat");
                formData.Add(new StreamContent(fromFile), "DataFile", Path.GetFileName(path));
                //Call WebAPI  
                var response = client.PostAsync(apiurl, formData).Result;
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Invalid response.");
                    return;
                }
                var tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                }
                var tempFilePath = Path.Combine(tempPath, string.Format("{0}.{1}", SachManager.TITTLE_SACH, "xlsx"));
                using (var newFile = File.Create(tempFilePath))
                {
                    response.Content.ReadAsStreamAsync().Result.CopyTo(newFile);
                }
                //Open In Excel  
                Process.Start(tempFilePath);
            }
        }

        private DataTable createNhanVienDataTable(List<NhanVien> nhanViens)
        {
            DataTable dt = new DataTable();
            dt.TableName = NhanVienManager.TITTLE_NHANVIEN;
            dt.Columns.Add(NhanVienManager.MaNhanVien, typeof(string));
            dt.Columns.Add(NhanVienManager.HoTenNhanVien, typeof(string));
            dt.Columns.Add(NhanVienManager.DiaChi, typeof(string));
            dt.Columns.Add(NhanVienManager.NgaySinh, typeof(string));
            dt.Columns.Add(NhanVienManager.BangCap, typeof(string));
            dt.Columns.Add(NhanVienManager.BoPhan, typeof(string));
            dt.Columns.Add(NhanVienManager.ChucVu, typeof(string));
            dt.Columns.Add(NhanVienManager.DienThoai, typeof(string));
            for(int i = 0; i < nhanViens.Count; i++)
            {
                dt.Rows.Add(
                    nhanViens[i].MaNhanVien,
                    nhanViens[i].HoTenNhanVien,
                    nhanViens[i].DiaChi,
                    nhanViens[i].NgaySinh,
                    nhanViens[i].BangCap,
                    nhanViens[i].BoPhan,
                    nhanViens[i].ChucVu,
                    nhanViens[i].DienThoai
                );
            }
            return dt;
        }

        private DataTable createAccountDataTable(List<Account> accounts)
        {
            DataTable dt = new DataTable();
            dt.TableName = AccountManager.TITTLE_ACCOUNT;
            dt.Columns.Add(AccountManager.usernameAttribute, typeof(string));
            dt.Columns.Add(AccountManager.passwordAttribute, typeof(string));
            dt.Columns.Add(AccountManager.typeAccountAttribute, typeof(string));
            dt.Columns.Add(AccountManager.maNhanVienAttribute, typeof(string));
            for (int i = 0; i < accounts.Count; i++)
            {
                dt.Rows.Add(
                    accounts[i].username,
                    accounts[i].password,
                    accounts[i].typeAccount,
                    accounts[i].maNhanVien
                );
            }
            return dt;
        }

        private DataTable createDocGiaDataTable(List<DocGia> docGias)
        {
            DataTable dt = new DataTable();
            dt.TableName = DocGiaManager.TITTLE_DOCGIA;
            dt.Columns.Add(DocGiaManager.MaDocGia, typeof(string));
            dt.Columns.Add(DocGiaManager.HoTen, typeof(string));
            dt.Columns.Add(DocGiaManager.NgaySinh, typeof(string));
            dt.Columns.Add(DocGiaManager.DiaChi, typeof(string));
            dt.Columns.Add(DocGiaManager.LoaiDocGia, typeof(string));
            dt.Columns.Add(DocGiaManager.Email, typeof(string));
            dt.Columns.Add(DocGiaManager.NgayLapThe, typeof(string));
            for (int i = 0; i < docGias.Count; i++)
            {
                dt.Rows.Add(
                    docGias[i].MaDocGia,
                    docGias[i].HoTen,
                    docGias[i].NgaySinh,
                    docGias[i].DiaChi,
                    docGias[i].LoaiDocGia,
                    docGias[i].Email,
                    docGias[i].NgayLapThe
                );
            }
            return dt;
        }

        private DataTable createSachDataTable(List<Sach> saches)
        {
            DataTable dt = new DataTable();
            dt.TableName = SachManager.TITTLE_SACH;
            dt.Columns.Add(SachManager.MaSach, typeof(string));
            dt.Columns.Add(SachManager.TenSach, typeof(string));
            dt.Columns.Add(SachManager.TheLoai, typeof(string));
            dt.Columns.Add(SachManager.TacGia, typeof(string));
            dt.Columns.Add(SachManager.NamXuatBan, typeof(string));
            dt.Columns.Add(SachManager.NhaXuatBan, typeof(string));
            dt.Columns.Add(SachManager.NgayNhap, typeof(string));
            dt.Columns.Add(SachManager.TriGia, typeof(string));
            dt.Columns.Add(SachManager.NguoiTiepNhan, typeof(string));
            for (int i = 0; i < saches.Count; i++)
            {
                dt.Rows.Add(
                    saches[i].MaSach,
                    saches[i].TenSach,
                    saches[i].TheLoai,
                    saches[i].TacGia,
                    saches[i].NamXuatBan,
                    saches[i].NhaXuatBan,
                    saches[i].NgayNhap,
                    saches[i].TriGia,
                    saches[i].NguoiTiepNhan
                );
            }
            return dt;
        }

        private DataTable createPhieuMuonSachDataTable(List<ChoMuonSach> choMuonSaches)
        {
            DataTable dt = new DataTable();
            dt.TableName = ChoMuonSachManager.TITTLE_MUONSACH;
            dt.Columns.Add(ChoMuonSachManager.HoTen, typeof(string));
            dt.Columns.Add(ChoMuonSachManager.MaSach, typeof(string));
            dt.Columns.Add(ChoMuonSachManager.TenSach, typeof(string));
            dt.Columns.Add(ChoMuonSachManager.TheLoai, typeof(string));
            dt.Columns.Add(ChoMuonSachManager.TacGia, typeof(string));
            dt.Columns.Add(ChoMuonSachManager.LoaiDocGia, typeof(string));
            dt.Columns.Add(ChoMuonSachManager.NgayGhiNhan, typeof(string));
            dt.Columns.Add(ChoMuonSachManager.MaDocGia, typeof(string));
            for (int i = 0; i < choMuonSaches.Count; i++)
            {
                dt.Rows.Add(
                    choMuonSaches[i].HoTen,
                    choMuonSaches[i].MaSach,
                    choMuonSaches[i].TenSach,
                    choMuonSaches[i].TheLoai,
                    choMuonSaches[i].TacGia,
                    choMuonSaches[i].LoaiDocGia,
                    choMuonSaches[i].NgayGhiNhan,
                    choMuonSaches[i].MaDocGia
                );
            }
            return dt;
        }
    }
}