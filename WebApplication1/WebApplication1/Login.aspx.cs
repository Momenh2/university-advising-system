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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create new connection
            SqlConnection conn = new SqlConnection(connStr);

            //  int Student_id = Int16.Parse(username.Text);
            //String pass = password.Text;

            // SqlCommand loginproc = new SqlCommand("userLogin", conn);
            try {
                using (conn)
                {
                    int Admin_id = 558016;
                    String pass = "carvajal";
                    //SqlCommand loginproc = new SqlCommand("userLogin", conn);
                    // SqlCommand loginproc = new SqlCommand("FN_StudentLogin", conn);


                    //   SqlCommand loginproc = new SqlCommand("SELECT dbo.FN_StudentLogin(@Student_id, @password)", conn);
                    conn.Open();


                    //loginproc.Parameters.Add(new SqlParameter("@Student_id", Student_id));
                    //loginproc.Parameters.Add(new SqlParameter("@password", pass));

                    // SqlParameter success = loginproc.Parameters.Add("@success", System.Data.SqlDbType.Int);
                    // SqlParameter Type = loginproc.Parameters.Add("@type", System.Data.SqlDbType.Int);
                    //  int returnValue = (int)loginproc.ExecuteScalar();

                    //success.Direction = System.Data.ParameterDirection.Output;
                    //Type.Direction = System.Data.ParameterDirection.Output;

                    //Object returnValue = loginproc.ExecuteScalar();
                    if (username.Text == "" || password.Text == "")
                    {
                        Response.Write("One of the inputs is empty, please fill the blanks");
                    }
                    else
                    {
                        if (Admin_id == Int32.Parse(username.Text) && pass == password.Text)
                        {

                            Response.Write("Success");
                            Response.Redirect("page2admin.aspx");

                        }
                        else
                        {
                            Response.Write("invalid login");
                        }

                        //int returnValue = (int)loginproc.ExecuteScalar();
                        //Console.WriteLine(returnValue.ToString());


                        //   conn.Open();
                        //  loginproc.ExecuteNonQuery();
                        conn.Close();
                    }
                } 


            }
       catch(Exception ex)
            {
                Response.Write("Invalid input");
            }
           
        }

  
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("First_Page.aspx");
        }
    }
}
