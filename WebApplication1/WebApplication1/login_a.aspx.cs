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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (username.Text.Equals("") || password.Text.Equals(""))
            {
                Response.Write("data null");
            }
            else
            {
                int id = Int16.Parse(username.Text);
                String pass = password.Text;



                SqlCommand loginfunc = new SqlCommand("SELECT dbo.FN_AdvisorLogin(@advisor_Id, @password)", conn);
                conn.Open();
                //SqlCommand loginfunc = new SqlCommand("advisorlogin", conn);
                loginfunc.Parameters.Add(new SqlParameter("@advisor_Id", id));
                loginfunc.Parameters.Add(new SqlParameter("@password", pass));
                SqlParameter success = loginfunc.Parameters.Add("@success", System.Data.SqlDbType.Int);
                success.Direction = System.Data.ParameterDirection.Output;
                Object flag = loginfunc.ExecuteScalar();
                conn.Close();

                if ((bool)flag == true)
                {
                    Response.Write("hello");
                    Session["user"] = id;
                    Response.Redirect("advisor.aspx");
                }
                else
                {
                    Response.Write("wrong inputs");
                }
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("register_a.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("First_page.aspx");
        }
    }
}