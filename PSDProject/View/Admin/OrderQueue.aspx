<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/NavAdmin.Master" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="PSDProject.View.Admin.OrderQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="cartData" runat="server" AutoGenerateSelectButton="true" OnSelectedIndexChanged="cartData_SelectedIndexChanged" ></asp:GridView>
        <asp:Label ID="Label1" runat="server" Text="Select Cart Id that will be handled"></asp:Label><br />
        <asp:TextBox ID="idTxt" runat="server"></asp:TextBox><br />
        <asp:Button ID="handleBtn" runat="server" Text="Handle This Transaction" OnClick="handleBtn_Click" /><br />
        <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
