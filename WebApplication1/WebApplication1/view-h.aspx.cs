using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class view_c : System.Web.UI.Page
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
            if (Session["user"] == null)
            {
                Response.Write("sorry not signed in");
            }
            else
            {
                if (major.Text.Equals(""))
                {
                    Response.Write("sorry major empty");
                }
                else
                {

                    String m = major.Text;
                    int id = (int)Session["user"];

                    SqlCommand proc = new SqlCommand("Procedures_AdvisorViewAssignedStudents", conn);
                    proc.Parameters.Add(new SqlParameter("@AdvisorID", id));
                    proc.Parameters.Add(new SqlParameter("@major", m));
                    proc.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(proc);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    grid.DataSource = dataTable;
                    grid.DataBind();
                    conn.Open();
                    proc.ExecuteNonQuery();
                    conn.Close();
                }
            }

        }
    }
}
