using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.App_core;

namespace WebApplication2
{
    public class KiemTraTinhHopLe
    {
        private QuanLyNhanSu_KTPMEntities1 _db;

        public KiemTraTinhHopLe()
        {
            _db = new QuanLyNhanSu_KTPMEntities1();
        }

        // Kiểm tra dữ liệu hợp lệ
        public string ValidateForm(string maBienBan, string ngayLap, string maNV, string noiDungDanhGia)
        {
            // Kiểm tra các trường không được để trống
            if (string.IsNullOrWhiteSpace(maBienBan)) return "Mã biên bản không được để trống.";
            if (string.IsNullOrWhiteSpace(ngayLap)) return "Ngày lập biên bản không được để trống.";
            if (string.IsNullOrWhiteSpace(maNV)) return "Mã nhân viên không được để trống.";
            if (string.IsNullOrWhiteSpace(noiDungDanhGia)) return "Nội dung đánh giá không được để trống.";

            // Kiểm tra mã biên bản không được trùng
            if (_db.tbl_Bienban.Any(bb => bb.PK_sMabienban == maBienBan))
            {
                return "Mã biên bản đã tồn tại. Vui lòng nhập mã khác.";
            }

            // Kiểm tra mã nhân viên phải tồn tại
            if (!_db.tbl_Nhanvien.Any(nv => nv.PK_sMaNV == maNV))
            {
                return "Mã nhân viên không tồn tại.";
            }

            // Nếu hợp lệ
            return string.Empty;
        }
    }
}