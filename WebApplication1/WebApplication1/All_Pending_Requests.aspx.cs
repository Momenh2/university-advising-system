using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace WebApplication1
{
    public partial class All_Pending_Requests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
          
            // Define the SQL query to fetch data from the view
            string q = "SELECT * FROM all_Pending_Requests";

            SqlDataAdapter ad = new SqlDataAdapter(q, conn);
            DataTable dataTable = new DataTable();

            ad.Fill(dataTable);

            YourGridView.DataSource = dataTable;
            YourGridView.DataBind();

        }

      
        protected void back_to_main_page(object sender, EventArgs e)
        {
            Response.Redirect("page2admin.aspx");
        }
    }
}