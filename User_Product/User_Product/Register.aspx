<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="User_Product.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Regiter</title>
</head>
<body style="font-family: 'Segoe UI'; margin:0px auto; width:800px;">
    <form id="register" runat="server">
        <h1>Register Here!</h1>
        <hr />
        <table style=" margin:0px auto; width: 700px;">
            <tr>
                <td >Name: </td>
                <td>
                    <asp:TextBox ID="UserName" TextMode="Email" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email: </td>
                <td>
                    <asp:TextBox ID="UserEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password: </td>
                <td>
                    <asp:TextBox ID="UserPassword" TextMode="Password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Your Profile Photo: </td>
                <td>
                    <asp:FileUpload ID="FileUploadControl" runat="server"/>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="uploadStatus" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="UploadButton" runat="server" Text="Upload & Register" OnClick="upload_Click"  style="margin-left: 100%"/><br />
                    Have an account? <asp:HyperLink runat="server" NavigateUrl="Login.aspx">Login</asp:HyperLink>.
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
