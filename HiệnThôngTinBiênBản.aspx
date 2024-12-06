<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiệnThôngTinBiênBản.aspx.cs" Inherits="WebApplication2.HiệnThôngTinBiênBản" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hiển Thị Thông Tin Biên Bản</title>
    <style>
        table, th, td {
            border: 1px solid black;
            border-collapse: collapse;
            padding: 8px;
            text-align: left;
        }
        th {
            background-color: #f2f2f2;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Thông Tin Biên Bản Đánh Giá</h2>
            <asp:GridView ID="GridViewBienBan" runat="server" AutoGenerateColumns="False" 
                OnRowDataBound="GridViewBienBan_RowDataBound" 
                CellPadding="4" ForeColor="#333333" 
                GridLines="None">
                <Columns>
                    <asp:BoundField DataField="PK_sMabienban" HeaderText="Mã Biên Bản" SortExpression="PK_sMabienban" />
                    <asp:BoundField DataField="dNgaylap" HeaderText="Ngày Lập" SortExpression="dNgaylap" />
                    <asp:BoundField DataField="FK_sMaNV" HeaderText="Mã Nhân Viên" SortExpression="FK_sMaNV" />
                    <asp:BoundField DataField="sNddanhgia" HeaderText="Nội Dung Đánh Giá" SortExpression="sNddanhgia" />
                </Columns>
            </asp:GridView>
            <td> <asp:Button ID="btnQuayLaiWebForm1" runat="server" Text="Quay Lại Đăng biên bản" PostBackUrl="~/GiaoDienThemBienBanDanhGiaUngVien.aspx" /></td>
        </div>
    </form>
</body>
</html>
