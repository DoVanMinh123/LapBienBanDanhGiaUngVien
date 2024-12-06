<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GiaoDienThemBienBanDanhGiaUngVien.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Form thêm Biên Bản Đánh Giá</title>
    <style>
        .form-container {
            width: 400px;
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 8px;
        }
        .form-control {
            width: 100%;
            padding: 8px;
            margin: 5px 0;
            border: 1px solid #ccc;
            border-radius: 4px;
        }
        .button-container {
            text-align: center;
            padding-top: 10px;
        }
        .btn {
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .btn-primary {
            background-color: #007bff;
            color: white;
        }
        .btn-secondary {
            background-color: #6c757d;
            color: white;
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h3>Form Đăng Ký Biên Bản Đánh Giá</h3>
            <table>
                <tr>
                    <td><label for="txtMaBienBan">Mã biên bản:</label></td>
                    <td><asp:TextBox ID="txtMaBienBan" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><label for="txtNgayLap">Ngày lập biên bản:</label></td>
                    <td><asp:TextBox ID="txtNgayLap" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><label for="ddlMaNV">Mã nhân viên:</label></td>
                    <td>
                        <asp:DropDownList ID="ddlMaNV" runat="server" CssClass="form-control"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><label for="txtNoiDungDanhGia">Nội dung đánh giá:</label></td>
                    <td>
                        <asp:TextBox ID="txtNoiDungDanhGia" runat="server" TextMode="MultiLine" Rows="4" CssClass="form-control"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="button-container">
                        <asp:Button ID="btnSubmit" runat="server" Text="Lưu" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
                        <asp:Button ID="btnChuyenWebForm2" runat="server" Text="Xem Thông Tin Biên Bản" PostBackUrl="~/HiệnThôngTinBiênBản.aspx" CssClass="btn btn-secondary" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
