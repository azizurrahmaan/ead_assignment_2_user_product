using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace User_Product
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["UserEmail"] as String))
            {
                Message.Text = "";
                LogoutButton.Text = "Logout";

            }
            else
            {
                ContentTable.Visible = false;
                LogoutButton.Text = "Login";
                Message.Text = "You must login to access this page.";
                LoginLink.Text = "Login";
            }
        }

        protected void Upload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session["UserEmail"] as String))
            {

                bool isFileUploadSuccessfull = true;
                if (FileUploadControl.HasFile)
                {
                    try
                    {
                        if (FileUploadControl.PostedFile.ContentType == "image/jpeg")
                        {
                            if (FileUploadControl.PostedFile.ContentLength <= 102400)
                            {
                                String filename = Path.GetFileName(FileUploadControl.FileName);
                                FileUploadControl.SaveAs(Server.MapPath("~/ProductImages/") + filename);
                                uploadStatus.Text = "File Uploaded.";
                            }
                            else
                            {
                                isFileUploadSuccessfull = false;
                                uploadStatus.Text = "File size must be not be more than 100KB.";
                            }
                        }
                        else
                        {
                            isFileUploadSuccessfull = false;
                            uploadStatus.Text = "sorry! jpeg files are accepted only.";
                        }
                    }
                    catch (Exception ex)
                    {
                        isFileUploadSuccessfull = false;
                        uploadStatus.Text = "Error! File could not be uploaded. " + ex.Message;
                    }
                }
                else
                {
                }
                if (isFileUploadSuccessfull)
                {
                    String productTitle = ProductTitle.Text;
                    String productPrice = ProductPrice.Text;

                    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AssignmentTwoDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[product] (user_id, title, price, image_path) VALUES (@user_id, @title, @price, @path)", con);
                    cmd.Parameters.AddWithValue("@user_id", Session["UserID"]);
                    cmd.Parameters.AddWithValue("@title", productTitle);
                    cmd.Parameters.AddWithValue("@price", productPrice);

                    if (FileUploadControl.HasFile)
                    {
                        cmd.Parameters.AddWithValue("@path", FileUploadControl.FileName);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@path", "NoFile");
                    }



                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected < 0)
                    {
                        Console.WriteLine("Error inserting data to database!");
                    }
                    else
                    {
                        Response.Redirect("~/AddProduct.aspx");
                    }
                    con.Close();
                }
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/login.aspx");
        }
    }
}