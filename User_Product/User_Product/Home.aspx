<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="User_Product.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
</head>
<body style="font-family: 'Segoe UI'; margin: 0px auto; width: 800px;">
    <form id="register" runat="server">
        <h1 style="display: inline-block">Home</h1>
        <asp:Button ID="LogoutButton" runat="server" Style="float: right; margin-top: 20px;" OnClick="Logout_Click" Text="Login"></asp:Button>
        <hr />
        <div style="margin: 0px auto; width: 450px;">
            <asp:Label ID="Message" runat="server"></asp:Label><br />
            <ul id="ActionsList" runat="server">
                <li>
                    <asp:HyperLink ID="ProfileLink" NavigateUrl="profile.aspx" runat="server"></asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="AddProductLink" NavigateUrl="AddProduct.aspx" runat="server"></asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="ViewProductsLink" NavigateUrl="ViewProduct.aspx" runat="server"></asp:HyperLink>
                </li>
            </ul>
            <asp:HyperLink ID="LoginLink" NavigateUrl="login.aspx" runat="server"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
