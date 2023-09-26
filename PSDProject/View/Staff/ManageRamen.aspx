<%@ Page Title="" Language="C#" MasterPageFile="~/View/Staff/NavStaff.Master" AutoEventWireup="true" CodeBehind="ManageRamen.aspx.cs" Inherits="PSDProject.View.Staff.ManageRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="ramenData" runat="server" AutoGenerateSelectButton="true" OnSelectedIndexChanged="ramenData_SelectedIndexChanged" ></asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Select the data that want to be deleted"></asp:Label>
        <br />
        <asp:Label ID="deleteLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="insertBtn" runat="server" Text="Insert Ramen" OnClick="insertBtn_Click" />
        <asp:Button ID="updateBtn" runat="server" Text="Update Ramen" OnClick="updateBtn_Click" />
    </div>

</asp:Content>
