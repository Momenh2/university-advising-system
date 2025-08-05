using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class delete : System.Web.UI.Page
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




            if (Code.Text.Equals("") || CID.Text.Equals("") || SID.Text.Equals(""))
            {
                Response.Write("Data null");
            }
            else
            {
                try
                {


                    String semcod = Code.Text;
                    int cid = Int16.Parse(CID.Text);
                    int sid = Int16.Parse(SID.Text);

                    SqlCommand proc = new SqlCommand("Procedures_AdvisorDeleteFromGP", conn);
                    proc.CommandType = CommandType.StoredProcedure;
                    proc.Parameters.Add(new SqlParameter("@studentID", sid));
                    proc.Parameters.Add(new SqlParameter("@sem_code", semcod));
                    proc.Parameters.Add(new SqlParameter("@courseID", cid));

                    proc.CommandType = CommandType.StoredProcedure;

                    //SqlParameter id = registerproc.Parameters.Add("@Advisor_id", System.Data.SqlDbType.Int);
                    //id.Direction = System.Data.ParameterDirection.Output;
                    conn.Open();
                    proc.ExecuteNonQuery();
                    conn.Close();
                    //Session["user"] = id.Value;
                    Response.Write("SUCCESS");
                }
                catch(Exception ex)
                {
                    Response.Write("invalid input");
                }


            }
        }
    }
}
