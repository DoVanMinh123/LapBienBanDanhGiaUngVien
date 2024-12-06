using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.App_core;

namespace WebApplication2
{
    public class DataProcessing : IDisposable
    {
        private QuanLyNhanSu_KTPMEntities1 _dbContext;

        public DataProcessing()
        {
            _dbContext = new QuanLyNhanSu_KTPMEntities1();
        }

        // Lấy danh sách tất cả nhân viên
        public List<tbl_Nhanvien> GetAllNhanVien()
        {
            return _dbContext.tbl_Nhanvien.ToList();
        }

        // Kiểm tra xem mã nhân viên có tồn tại không
        public bool CheckMaNhanVienExists(string maNV)
        {
            return _dbContext.tbl_Nhanvien.Any(nv => nv.PK_sMaNV == maNV);
        }

        // Kiểm tra xem mã biên bản có tồn tại không
        public bool CheckMaBienBanExists(string maBienBan)
        {
            return _dbContext.tbl_Bienban.Any(bb => bb.PK_sMabienban == maBienBan);
        }

        // Thêm biên bản mới
        public void AddBienBan(tbl_Bienban bienBan)
        {
            _dbContext.tbl_Bienban.Add(bienBan);
            _dbContext.SaveChanges();
        }

        // Lấy danh sách biên bản
        public List<tbl_Bienban> GetAllBienBan()
        {
            return _dbContext.tbl_Bienban.ToList();
        }

        // Đóng kết nối
        public void Dispose()
        {
            _dbContext.Dispose();
        }

    }
}