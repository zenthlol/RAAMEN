<%@ Page Title="" Language="C#" MasterPageFile="~/View/Staff/NavStaff.Master" AutoEventWireup="true" CodeBehind="InsertRamen.aspx.cs" Inherits="PSDProject.View.Staff.InsertRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <br />
        <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:RadioButtonList ID="MeatList" runat="server">
            <asp:ListItem Selected ="True">Beef</asp:ListItem>
            <asp:ListItem>Chicken</asp:ListItem>
            <asp:ListItem>Fish</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />

        <asp:Label ID="Label3" runat="server" Text="Broth"></asp:Label>
        <br />
        <asp:TextBox ID="brothTxt" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
        <br />
        <asp:TextBox ID="priceTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
        <br />
        <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
