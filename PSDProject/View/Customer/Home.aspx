<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/NavCustomer.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PSDProject.View.Customer.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Current Role: "></asp:Label>
        <asp:Label ID="roleLbl" runat="server" Text=""></asp:Label>

        <asp:GridView ID="userData" runat="server"></asp:GridView>

    </div>
</asp:Content>
