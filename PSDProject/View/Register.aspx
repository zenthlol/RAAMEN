<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PSDProject.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label><br />
            <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label><br />
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label><br />
            <asp:RadioButtonList ID="GenderList" runat="server">
                <asp:ListItem Selected ="True">Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />

            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="Label5" runat="server" Text="Confirmation Password"></asp:Label><br />
            <asp:TextBox ID="passwordConfTxt" runat="server"></asp:TextBox>
            <br />

            <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />
            <br />

            <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
