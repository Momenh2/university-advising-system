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
    public partial class Delete_a_slot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private int GetCoursesCountForSemester(SqlConnection connection, string semesterCode)
        {
            string query = "SELECT COUNT(*) FROM Course_Semester WHERE semester_code = @SemesterCode";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SemesterCode", semesterCode);
                connection.Open();
                int coursesCount = (int)command.ExecuteScalar();
                return coursesCount;
            }
        }

        protected void Delete_a_Slot(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String connStr2 = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn2 = new SqlConnection(connStr2);





            // Define the SQL query to check if the slot exists
            try
            {
                String semesterCode = semester_Code.Text;
                int coursesCount = GetCoursesCountForSemester(conn2, semesterCode);
                SqlCommand deleteSlotProc = new SqlCommand("Procedures_AdminDeleteSlots", conn);
                if (coursesCount > 0)
                {
                    // Courses exist for the given semester code
                    // Call stored procedure to delete the courses

                    deleteSlotProc.CommandType = CommandType.StoredProcedure;
                    deleteSlotProc.Parameters.Add(new SqlParameter("@current_semester", semesterCode));

                    conn.Open();
                    deleteSlotProc.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("Courses related to the Semester Code were deleted.");
                }
                else
                {
                    // No courses found for the given semester code
                    Response.Write("No courses found for the Semester Code. No deletion performed.");
                }
            }
            catch (Exception ex)
            {
                Response.Write("invalid input format");
            }







        }
        protected void Go_Back(object sender, EventArgs e)
        {
            Response.Redirect("Admin2.aspx");
        }
    }
}