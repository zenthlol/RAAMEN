<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/NavCustomer.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="PSDProject.View.Customer.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:GridView ID="historyData" runat="server" AutoGenerateSelectButton="true" OnSelectedIndexChanged="historyData_SelectedIndexChanged"></asp:GridView>
    </div>

</asp:Content>
