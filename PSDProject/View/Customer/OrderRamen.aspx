<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/NavCustomer.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="PSDProject.View.Customer.OrderRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="ramenData" runat="server" AutoGenerateSelectButton= "true" OnSelectedIndexChanged="ramenData_SelectedIndexChanged"></asp:GridView>
        <br />

        <asp:Label ID="Label1" runat="server" Text="Select Ramen ID"></asp:Label>
        <br />
        <asp:TextBox ID="idTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Quantity"></asp:Label>
        <br />
        <asp:TextBox ID="quantityTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="orderBtn" runat="server" Text="Order" OnClick="orderBtn_Click" />
        <asp:Button ID="clearBtn" runat="server" Text="Clear Cart" OnClick="clearBtn_Click" />
        <asp:Button ID="buyBtn" runat="server" Text="Buy Cart" OnClick="buyBtn_Click" />
        <br />
        <asp:Button ID="backBtn" runat="server" Text="Back" />
        <br />
        <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:GridView ID="cartData" runat="server"></asp:GridView>
    </div>
</asp:Content>
