using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq.Expressions;

namespace WebApplication1
{
    public partial class approve_l : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("advisor.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                int id = Int16.Parse(RID.Text);
                String p = SCode.Text;
                conn.Open();
                SqlCommand proc1 = new SqlCommand("Procedures_AdvisorApproveRejectCourseRequest", conn);
                proc1.Parameters.Add(new SqlParameter("@requestID", id));
                proc1.Parameters.Add(new SqlParameter("@current_semester_code", p));
                proc1.CommandType = CommandType.StoredProcedure;
                proc1.ExecuteNonQuery();
                conn.Close();
                Response.Write("SUCCESS");
            }
            catch (Exception ex)
            {
                Response.Write("invalid input");
            }
        
        }
    }
}