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
    public partial class All_Instructors_courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            // Define the SQL query to fetch data from the view
            string query = "SELECT * FROM Instructors_AssignedCourses";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            YourGridView.DataSource = dataTable;
            YourGridView.DataBind();

        }

      
        protected void back_to_main_page(object sender, EventArgs e)
        {
            Response.Redirect("page2admin.aspx");
        }
    }
}