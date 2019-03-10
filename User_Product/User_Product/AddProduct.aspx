<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="User_Product.AddProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Product</title>
</head>
    <body style="font-family: 'Segoe UI'; margin: 0px auto; width: 800px;">
    <form id="AddProduct" runat="server">
        <h1 style="display: inline-block">Add Product</h1>
        <asp:Button ID="LogoutButton" runat="server" Style="float: right; margin-top: 20px;" OnClick="Logout_Click" Text="Login"></asp:Button>
        <hr />
        <div style="margin: 0px auto; width: 600px;">
            <asp:Label ID="Message" runat="server"></asp:Label><br />

            
        <table  id="ContentTable" runat="server" style=" margin:0px auto; width: 600px;">
            <tr>
                <td >Title: </td>
                <td>
                    <asp:TextBox ID="ProductTitle" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Price: </td>
                <td>
                    <asp:TextBox ID="ProductPrice"  TextMode="Number" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Product Image: </td>
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
                    <asp:Button ID="UploadButton" runat="server" Text="Upload & Add" OnClick="Upload_Click"  style="margin-left: 100%"/>
                </td>
            </tr>
        </table>

            <asp:HyperLink ID="LoginLink" NavigateUrl="login.aspx" runat="server"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
