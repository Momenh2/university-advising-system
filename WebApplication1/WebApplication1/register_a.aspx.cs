using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void regist(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (name.Text == null || pass.Text == null || mail.Text == null || off.Text == null)
            {
                Response.Write("Data Null!");
            }
            else
            {
                String n = name.Text;
                String p = pass.Text;
                String m = mail.Text;
                String o = off.Text;

                SqlCommand registerproc = new SqlCommand("Procedures_AdvisorRegistration", conn);
                registerproc.Parameters.Add(new SqlParameter("@advisor_name", n));
                registerproc.Parameters.Add(new SqlParameter("@password", p));
                registerproc.Parameters.Add(new SqlParameter("@email", n));
                registerproc.Parameters.Add(new SqlParameter("@office", p));
                registerproc.CommandType = CommandType.StoredProcedure;
                SqlParameter id = registerproc.Parameters.Add("@Advisor_id", System.Data.SqlDbType.Int);
                id.Direction = System.Data.ParameterDirection.Output;
                conn.Open();
                registerproc.ExecuteNonQuery();
                conn.Close();
                Session["user"] = id.Value;
                Response.Redirect("advisor.aspx");
            }
        }
        protected void back(object sender, EventArgs e)
        {
            Response.Redirect("login_a.aspx");
        }
    }
}
