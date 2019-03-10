using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_Product
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Session["UserEmail"] as String))
            {
                NameLabel.Text = "Name:";
                EmailLabel.Text = "Email:";
                Name.Text = (String)Session["UserName"];
                Email.Text = (String)Session["UserEmail"];
                if ((String)Session["UserPhotoPath"] == "NoFile")
                {
                    Photo.AlternateText = "Profile photo not availabe.";
                }
                else
                {
                    Photo.ImageUrl = "~/UserProfilePhotos/" + (String)Session["UserPhotoPath"];
                }
                LogoutButton.Text = "Logout";
                
                
            }
            else
            {
                Photo.Visible = false;
                LogoutButton.Text = "Login";
                Message.Text = "You must login to access this page.";
                LoginLink.Text = "Login";
            }
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/login.aspx");
        }
    }
}