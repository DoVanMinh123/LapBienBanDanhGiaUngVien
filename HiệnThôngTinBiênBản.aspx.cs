using System;
using System.Linq;
using System.Web.UI;
using WebApplication2.App_core;

namespace WebApplication2
{
    public partial class HiệnThôngTinBiênBản : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadBienBanData();
            }
        }

        // Hàm để load thông tin biên bản từ cơ sở dữ liệu vào GridView
        private void LoadBienBanData()
        {
            using (var db = new QuanLyNhanSu_KTPMEntities1())
            {
                var bienBans = db.tbl_Bienban.ToList();  // Lấy tất cả các bản ghi từ bảng tbl_Bienban
                GridViewBienBan.DataSource = bienBans;
                GridViewBienBan.DataBind();  // Gán dữ liệu cho GridView
            }
        }

        // Optional: Xử lý sự kiện cho mỗi dòng khi dữ liệu được bind
        protected void GridViewBienBan_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.DataRow)
            {
                // Bạn có thể tùy chỉnh thêm cách hiển thị dữ liệu tại đây, ví dụ: định dạng ngày tháng
                e.Row.Cells[1].Text = DateTime.Parse(e.Row.Cells[1].Text).ToString("dd/MM/yyyy");
            }
        }
    }
}
