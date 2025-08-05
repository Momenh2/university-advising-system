using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login_Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signin_Click(object sender, EventArgs e)
        {

            string conneStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(conneStr);




            if (UserID.Text != "" || Password.Text != "")
            {
                try
                {
                    int id = Int16.Parse(UserID.Text);
                    String pass = Password.Text;
                    SqlCommand loginfunction = new SqlCommand("SELECT dbo.FN_StudentLogin(@Student_id, @password)", connection);
                    loginfunction.Parameters.Add(new SqlParameter("@Student_id", id));
                    loginfunction.Parameters.Add(new SqlParameter("@password", pass));
                    connection.Open();
                    object result = loginfunction.ExecuteScalar();
                    connection.Close();




                    if (Convert.ToInt32(result) == 0)
                    {
                        Response.Write("Invalid Login");
                    }
                    else
                    {
                        Session["user"] = id;

                        Response.Redirect("carrefour.aspx");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("invalid format");
                }

            }
            else
            {
                Response.Write("Please make sure to fill the requirements bellow");
            }

        }


            protected void Register_Click(object sender, EventArgs e)
            {
                Response.Redirect("Register.aspx");     
            }

            protected void Button1_Click(object sender, EventArgs e)
            {
                Response.Redirect("First_page.aspx");
            }
        }
    } 
