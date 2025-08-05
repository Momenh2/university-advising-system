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
    public partial class view_i : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Write("Sorry not signed in");
            }
            else
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand func = new SqlCommand("SELECT * FROM dbo.FN_Advisors_Requests(@advisor_Id)", conn);
                conn.Open();
                int id = (int)Session["user"];
                func.Parameters.Add(new SqlParameter("@advisor_Id", id));
                //var stm = "SELECT * dbo.FN_Advisors_Requests(@advisor_Id))";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(func);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
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
