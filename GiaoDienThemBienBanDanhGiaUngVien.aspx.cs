using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using WebApplication2.App_core;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private DataProcessing _repository;

        protected void Page_Load(object sender, EventArgs e)
        {
            _repository = new DataProcessing();
            if (!IsPostBack)
            {
                
                LoadMaNhanVien();
            }
        }

        private void LoadMaNhanVien()
        {
            var nhanVienList = _repository.GetAllNhanVien();

            ddlMaNV.DataSource = nhanVienList;
            ddlMaNV.DataTextField = "sTenNV";
            ddlMaNV.DataValueField = "PK_sMaNV";
            ddlMaNV.DataBind();
            ddlMaNV.Items.Insert(0, new ListItem("-- Chọn nhân viên --", ""));
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string maBienBan = txtMaBienBan.Text.Trim();
            string ngayLap = txtNgayLap.Text.Trim();
            string maNV = ddlMaNV.SelectedValue;
            string noiDungDanhGia = txtNoiDungDanhGia.Text.Trim();

            KiemTraTinhHopLe validator = new KiemTraTinhHopLe();
            string validationMessage = validator.ValidateForm(maBienBan, ngayLap, maNV, noiDungDanhGia);

            if (!string.IsNullOrEmpty(validationMessage))
            {
                Response.Write($"<script>alert('{validationMessage}');</script>");
                return;
            }

            try
            {
                var bienBan = new tbl_Bienban
                {
                    PK_sMabienban = maBienBan,
                    dNgaylap = DateTime.Parse(ngayLap),
                    FK_sMaNV = maNV,
                    sNddanhgia = noiDungDanhGia
                };

                _repository.AddBienBan(bienBan);
                Response.Write("<script>alert('Đăng ký thành công!');</script>");
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('Lỗi: {ex.Message}');</script>");
            }
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            _repository.Dispose();
        }

    }
}