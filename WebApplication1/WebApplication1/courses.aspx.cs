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
    public partial class courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conneStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(conneStr);
            connection.Open();
            int id = (int)Session["user"];
            String semester_code = (string)Session["semester"];


            SqlCommand courses = new SqlCommand("[Procedures_ViewOptionalCourse]", connection);
            courses.CommandType = System.Data.CommandType.StoredProcedure;
            courses.Parameters.Add(new SqlParameter("@StudentID", id));
            courses.Parameters.Add(new SqlParameter("@current_semester_code", semester_code));






            SqlDataReader reader = courses.ExecuteReader(CommandBehavior.CloseConnection);
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("carrefour.aspx");
        }
    }
}