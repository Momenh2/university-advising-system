using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class insert_e : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);


                int id1 = Int16.Parse(id.Text);
                String var1 = code.Text;
                String var2 = name.Text;



                SqlCommand proc = new SqlCommand("Procedures_AdvisorAddCourseGP", conn);
                proc.CommandType = CommandType.StoredProcedure;
                proc.Parameters.Add(new SqlParameter("@student_id", id1));
                proc.Parameters.Add(new SqlParameter("@Semester_code", var1));
                proc.Parameters.Add(new SqlParameter("@course_name", var2));


                proc.CommandType = CommandType.StoredProcedure;

                conn.Open();
                proc.ExecuteNonQuery();
                conn.Close();
                Response.Write("SUCCESS");
            }
            catch (Exception r)
            {
                // Action to take if an exception is thrown
                Console.WriteLine(r.Message);
                Response.Write(r.Message);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("advisor.aspx");
        }
    }
}