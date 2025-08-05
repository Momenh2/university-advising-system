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
    public partial class view_c1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (Session["user"] == null) { Response.Write("Sorry Not Signed In"); }
            else
            {


                int Aid = (int)Session["user"];
                SqlCommand proc = new SqlCommand("Select * FROM Student Where Student.advisor_id=@aid", conn);
                proc.Parameters.AddWithValue("@aid", Aid);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(proc);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
                conn.Open();
                proc.ExecuteNonQuery();
                conn.Close();

            }


        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("advisor.aspx");
        }
    }
}