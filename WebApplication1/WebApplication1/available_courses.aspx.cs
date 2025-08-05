using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class available_courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conneStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(conneStr);
            int id = (int)Session["user"];
            String semester_code = (string)Session["semester"];

            SqlCommand availablecourses = new SqlCommand("SELECT * FROM dbo.[FN_SemsterAvailableCourses](@semstercode)", connection);
            availablecourses.Parameters.AddWithValue("@semstercode", semester_code);

            connection.Open();
            SqlDataReader reader = availablecourses.ExecuteReader();
            while (reader.Read())
            {
                String courseName = reader.GetString(reader.GetOrdinal("name"));
                Label name = new Label();
                name.Text = courseName;
                form1.Controls.Add(name);

                int coursID = reader.GetInt32(reader.GetOrdinal("course_id"));
                Label course_id = new Label();
                course_id.Text = coursID.ToString();
                form1.Controls.Add(course_id);

            }
            Response.Write("Action done successfully");
            connection.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("carrefour.aspx");
        }
    }
}