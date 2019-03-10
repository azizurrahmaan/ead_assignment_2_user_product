using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace User_Product
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Session["UserEmail"] as String))
            {
                Message.Text = "";
                ProfileLink.Text = "My Profile";
                LogoutButton.Text = "Logout";
                AddProductLink.Text = "Add Product";
                ViewProductsLink.Text = "View Products";

            }
            else
            {
                LogoutButton.Text = "Login";
                Message.Text = "You must login to access this page.";
                LoginLink.Text = "Login";
                ActionsList.Visible = false;
            }
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/login.aspx");
        }
    }
}