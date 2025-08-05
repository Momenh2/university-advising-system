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
    public partial class Delete_a_course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Delete_a_Course(object sender, EventArgs e)
        {

            if (courseId.Text == "")
            {
                Response.Write("no entered Data please enter a course id");
                return;
            }
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String connStr2 = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn2 = new SqlConnection(connStr);
            try
            {
                string query = "SELECT COUNT(*) FROM Course WHERE course_id=@course_id";
                int courseIdToCheck = Int16.Parse(courseId.Text);
                int courseCount;
                using (SqlCommand command = new SqlCommand(query, conn2))
                {
                    // Add parameters to the command to prevent SQL injection
                    command.Parameters.AddWithValue("@course_id", courseIdToCheck);

                    // Open the connection
                    conn2.Open();

                    // ExecuteScalar returns the number of rows that satisfy the condition
                    courseCount = (int)command.ExecuteScalar();
                    conn2.Close();
                    // Check if the course exists
                    if (courseCount > 0)
                    {
                        int course_id = Int16.Parse(courseId.Text);
                        SqlCommand deleteCourseProc = new SqlCommand("Procedures_AdminDeleteCourse", conn);
                        deleteCourseProc.CommandType = CommandType.StoredProcedure;
                        deleteCourseProc.Parameters.Add(new SqlParameter("@courseID", course_id));
                        conn.Open();
                        deleteCourseProc.ExecuteNonQuery();
                        conn.Close();
                        Response.Write("The course has been deleted");
                    }
                    else
                    {
                        // Course does not exist
                        // Do something else, display a message, etc.
                        Response.Write("The course does not exist in the database.");
                    }
                }

            }
            catch (Exception ex)
            {
                Response.Write("invalid Format");
            }





        }
        protected void Go_Back(object sender, EventArgs e)
        {
            Response.Redirect("Admin2.aspx");
        }
    }
}
