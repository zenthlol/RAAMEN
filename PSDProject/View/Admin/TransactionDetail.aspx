<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/NavAdmin.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="PSDProject.View.Admin.TransactionDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Transaction Header ID: "></asp:Label>
        <asp:Label ID="headerIdLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Transaction Detail ID: "></asp:Label>
        <asp:Label ID="detailIdLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Transaction Date: "></asp:Label>
        <asp:Label ID="dateLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Order"></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Name: "></asp:Label>
        <asp:Label ID="ramenLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Broth Type: "></asp:Label>
        <asp:Label ID="brothLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Price: "></asp:Label>
        <asp:Label ID="priceLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Quantity: "></asp:Label>
        <asp:Label ID="quantityLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Total Price: "></asp:Label>
        <asp:Label ID="totalLbl" runat="server" Text=""></asp:Label>
        <br />
    </div>
</asp:Content>
