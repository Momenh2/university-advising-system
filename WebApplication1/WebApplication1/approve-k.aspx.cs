using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class approve_k : System.Web.UI.Page
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
                SqlCommand proc = new SqlCommand("Procedures_AdvisorApproveRejectCHRequest", conn);
                proc.Parameters.Add(new SqlParameter("@requestID", id));
                proc.Parameters.Add(new SqlParameter("@current_sem_code", p));
                proc.CommandType = CommandType.StoredProcedure;
                proc.ExecuteNonQuery();
                conn.Close();
                Response.Write("SUCCESS");
            }
        catch(Exception ex)
            {
                Response.Write("invalid input");
            }
            
            }

    }
}
