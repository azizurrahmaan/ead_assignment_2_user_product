<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="User_Product.ViewProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products</title>
</head>

<body style="font-family: 'Segoe UI'; margin: 0px auto; width: 800px;">
    <form id="ViewProduct" runat="server">
        <h1 style="display: inline-block">Products</h1>
        <asp:Button ID="LogoutButton" runat="server" Style="float: right; margin-top: 20px;" OnClick="Logout_Click" Text="Login"></asp:Button>
        <hr />
        <div style="margin: 0px auto; width: 600px;">
            <asp:Label ID="Message" runat="server"></asp:Label><br />

                <asp:GridView Width="100%" AutoGenerateColumns="false" ID="ProductsGrid" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />

                    <columns>
                        <asp:BoundField HeaderText="#" DataField="#" />
                        <asp:BoundField HeaderText="Product Title" DataField="Product Title" />
                        <asp:BoundField HeaderText="Price(Rs.)" DataField="Price(Rs.)" />
                        <asp:ImageField AlternateText="No Image available." DataImageUrlField="Image" DataImageUrlFormatString="~/ProductImages/{0}" ControlStyle-Width="60" ControlStyle-Height="60"></asp:ImageField>
                    </columns>
                </asp:GridView>

            <asp:HyperLink ID="HomeLink" NavigateUrl="home.aspx" runat="server">Home</asp:HyperLink><br />
            <asp:HyperLink ID="LoginLink" NavigateUrl="login.aspx" runat="server"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
