<%@ Page Title="" Language="C#" MasterPageFile="~/Cau_2/Site1.Master" AutoEventWireup="true" CodeBehind="DanhSachSinhVien.aspx.cs" Inherits="BTH7.Cau_2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <p>DANH SÁCH SINH VIÊN KHÓA 56 NGÀNH CÔNG NGHỆ THÔNG TIN</p>
        
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="4">
             <ItemTemplate>
           <div style="text-align:center;">
                <p>Mã số sinh viên : <%#Eval("masv") %></p>
                <p>Họ và tên: <%#Eval("hoTen") %></p>
                <p>Lớp: <%#Eval("lop1") %></p>
                <p>Tỉnh: <%#Eval("tinh") %></p>
                <p>Điện thoại: <%#Eval("dienThoai") %></p>
               <img src="<%#Eval("hinhAnh") %>" />
           </div>
       </ItemTemplate>
        </asp:DataList>
    </div>

    </asp:Content>
