using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace User_Product
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_Click(object sender, EventArgs e)
        {

            String userEmail = UserEmail.Text;
            String userPassword = UserPassword.Text;

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AssignmentTwoDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[user] WHERE email = @email AND password = @password;", con);
            cmd.Parameters.AddWithValue("@email", userEmail);
            cmd.Parameters.AddWithValue("@password", userPassword);

            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            
            
            if (rdr.HasRows)
            {
                rdr.Read();
                Session["UserEmail"] = userEmail;
                Session["UserName"] = rdr["name"].ToString();
                Session["UserPhotoPath"] = rdr["photo_path"].ToString();
                Session["UserID"] = rdr["id"].ToString();
                Response.Redirect("Home.aspx");
            }
            else
            {
                ErrorMessage.Text = "Login Error! Invalid email or password.";
            }
            con.Close();
        }
    }
}