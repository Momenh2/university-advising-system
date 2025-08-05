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
    public partial class Add_makeup_exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddExam(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            String connStr2 = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn2 = new SqlConnection(connStr2);



            if (Type.Text == "" || course_id.Text == "" || dateTime.Text == "")
            {
                Response.Write("Please enter the required data.");
                return;
            }


            try
            {


                DateTime inputDate = DateTime.Parse(dateTime.Text);

                String type = Type.Text;
                int courseId = Int16.Parse(course_id.Text);

                SqlCommand AddExamProc = new SqlCommand("Procedures_AdminAddExam", conn);
                AddExamProc.CommandType = CommandType.StoredProcedure;
                AddExamProc.CommandType = CommandType.StoredProcedure;
                AddExamProc.Parameters.Add(new SqlParameter("@Type", type));
                AddExamProc.Parameters.Add(new SqlParameter("@date", inputDate));
                AddExamProc.Parameters.Add(new SqlParameter("@courseID", courseId));





                string query = "SELECT COUNT(*) FROM MakeUp_Exam WHERE date = @date AND type = @type AND course_id = @course_id";

                using (SqlCommand command = new SqlCommand(query, conn2))
                {
                    // Add parameters to the command to prevent SQL injection
                    command.Parameters.AddWithValue("@date", inputDate);
                    command.Parameters.AddWithValue("@type", type);
                    command.Parameters.AddWithValue("@course_id", courseId);

                    // Open the connection
                    conn2.Open();

                    // ExecuteScalar returns the number of rows that satisfy the condition
                    int examCount = (int)command.ExecuteScalar();

                    // Check if the exam exists
                    if (examCount > 0)
                    {
                        // Exam exists
                        Response.Write("The exam exists in the database.");
                    }
                    else
                    {
                        // Exam does not exist
                        conn.Open();
                        AddExamProc.ExecuteNonQuery();
                        conn.Close();
                        Response.Write("The exam has been added.");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("invalid format");
            }


        }
        protected void Go_Back(object sender, EventArgs e)
        {
            Response.Redirect("Admin2.aspx");
        }
    }
}
