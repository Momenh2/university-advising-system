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
    public partial class view_j : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (Session["user"] == null)
            {
                Response.Write("sorry not signed in");
            }
            else
            {


                int id = (int)Session["user"];

                SqlCommand proc1 = new SqlCommand("Procedures_AdvisorViewPendingRequests", conn);
                proc1.Parameters.Add(new SqlParameter("@Advisor_ID", id));
                proc1.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(proc1);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
                conn.Open();
                proc1.ExecuteNonQuery();
                conn.Close();

            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("advisor.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {


        }
    }
}
