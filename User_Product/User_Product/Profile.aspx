<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="User_Product.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-family: 'Segoe UI'; margin: 0px auto; width: 800px;">
    <form id="home" runat="server">
        <h1 style="display: inline-block">Profile</h1>
        <asp:Button ID="LogoutButton" runat="server" style="float:right; margin-top:20px;" OnClick="Logout_Click" Text="Login"></asp:Button>
        <hr />
        <div style="margin: 0px auto; width: 450px;">
            <asp:Label runat="server" ID="Message"></asp:Label><br />
            <asp:HyperLink runat="server" ID="LoginLink" NavigateUrl="~/login.aspx"></asp:HyperLink>
            <table style="float: left;">
                <tr>
                    <td>
                        <asp:Label runat="server" ID="NameLabel"></asp:Label>
                    </td>

                    <td>
                        <asp:Label runat="server" ID="Name"></asp:Label>

                    </td>
                    <td rowspan="3" style="align-items: flex-end;"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="EmailLabel"></asp:Label>
                    </td>
                    <td>
                        <asp:Label runat="server" ID="Email"></asp:Label>
                    </td>
                    <td></td>
                </tr>
            </table>
            <asp:Image runat="server" AlternateText="Photo couldn't be loaded." ID="Photo" Style="float: right; border: none; max-width: 150px; min-height: 150px;" />
        </div>
    </form>
</body>
</html>
