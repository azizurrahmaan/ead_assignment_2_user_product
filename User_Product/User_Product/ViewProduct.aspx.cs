using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace User_Product
{
    public partial class ViewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["UserEmail"] as String))
            {
                LogoutButton.Text = "Logout";

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AssignmentTwoDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("SELECT ROW_NUMBER() OVER(ORDER BY title) AS '#', title AS 'Product Title', price AS 'Price(Rs.)', image_path AS 'Image' FROM [dbo].[product] WHERE user_id = @id;", con);
                cmd.Parameters.AddWithValue("@id", (String)Session["UserID"]);

                con.Open();

                SqlDataReader rdr = cmd.ExecuteReader();


                if (rdr.HasRows)
                {
                    ProductsGrid.DataSource = rdr;
                    ProductsGrid.DataBind();
                    //ProductsGrid.Columns[2].HeaderImageUrl = "~/ProductImages/" + rdr["Image"].ToString();

                }
                else
                {
                    Message.Text = "No Product Availabe.";
                }
                con.Close();

            }
            else
            {
                ProductsGrid.Visible = false;
                LogoutButton.Text = "Login";
                Message.Text = "You must login to access this page.";
                LoginLink.Text = "Login";
                HomeLink.Visible = false;
            }
        }
        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/login.aspx");
        }
    }
}