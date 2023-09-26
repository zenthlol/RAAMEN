<%@ Page Title="" Language="C#" MasterPageFile="~/View/Staff/NavStaff.Master" AutoEventWireup="true" CodeBehind="UpdateRamen.aspx.cs" Inherits="PSDProject.View.Staff.UpdateRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <asp:GridView ID="ramenData" runat="server" AutoGenerateSelectButton= "true" OnSelectedIndexChanged="ramenData_SelectedIndexChanged"></asp:GridView>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Selected Id"></asp:Label>
        <br />
        <asp:TextBox ID="idTxt" runat="server"></asp:TextBox>
        <br />
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

        <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
        <br />
        <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label>
    </div>
    
</asp:Content>
