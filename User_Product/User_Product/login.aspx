<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="User_Product.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
    <body style="font-family: 'Segoe UI'; margin:0px auto; width:800px;">
    <form id="register" runat="server">
        <h1>Login Here!</h1>
        <hr />
        <table style=" margin:0px auto; width: 450px;">
            <tr>
                <td colspan="2" style="text-align:center; color:red;">
                    <asp:Label ID="ErrorMessage" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Email:
                </td>
                <td>
                    <asp:TextBox ID="UserEmail" TextMode="Email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td>
                    <asp:TextBox ID="UserPassword" TextMode="Password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Login" style="margin-left: 100%" OnClick="Login_Click"/><br />
                    Not a user? <asp:HyperLink runat="server" NavigateUrl="Register.aspx">Register</asp:HyperLink>.
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
