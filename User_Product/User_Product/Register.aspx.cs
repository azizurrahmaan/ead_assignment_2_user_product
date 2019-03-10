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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void upload_Click(object sender, EventArgs e)
        {
            bool isFileUploadSuccessfull = true;
            if (FileUploadControl.HasFile)
            {
                try
                {
                    if (FileUploadControl.PostedFile.ContentType == "image/jpeg")
                    {
                        if(FileUploadControl.PostedFile.ContentLength <= 102400)
                        {
                            String filename = Path.GetFileName(FileUploadControl.FileName);
                            FileUploadControl.SaveAs(Server.MapPath("~/UserProfilePhotos/") + filename);
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
                catch(Exception ex)
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
                String userName = UserName.Text;
                String userEmail = UserEmail.Text;
                String userPassword = UserPassword.Text;

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AssignmentTwoDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[User] (name, email, password, photo_path) VALUES (@name, @email, @password, @path)", con);
                cmd.Parameters.AddWithValue("@name", userName);
                cmd.Parameters.AddWithValue("@email", userEmail);
                cmd.Parameters.AddWithValue("@password", userPassword);

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
                    Response.Redirect("login.aspx");
                }
                con.Close();
            }
        }
    }
}