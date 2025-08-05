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
    public partial class View_all_graduation_plans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void View_Graduation(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);


            // Define the SQL query to fetch data from the Student_Payment view
            string query = "SELECT * FROM Advisors_Graduation_Plan";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            // Bind the data to a GridView or any other control
            YourGridView.DataSource = dataTable;
            YourGridView.DataBind();


        }
        protected void Go_Back(object sender, EventArgs e)
        {
            Response.Redirect("Admin2.aspx");
        }
    }
}