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
    public partial class course_request : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conneStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(conneStr);

            if (StudentID.Text != "" && courseID.Text != "" && Type.Text != "" && Comment.Text != "")
            {
                try
                {
                    int student_id = Int16.Parse(StudentID.Text);
                    int course_id = Int16.Parse(courseID.Text);
                    String type = Type.Text;
                    String comment = Comment.Text;

                    SqlCommand requestcourse = new SqlCommand("[Procedures_StudentSendingCourseRequest]", connection);
                    requestcourse.CommandType = System.Data.CommandType.StoredProcedure;
                    requestcourse.Parameters.Add(new SqlParameter("@StudentID", student_id));
                    requestcourse.Parameters.Add(new SqlParameter("@courseID", course_id));
                    requestcourse.Parameters.Add(new SqlParameter("@type", type));
                    requestcourse.Parameters.Add(new SqlParameter("@comment", comment));

                    connection.Open();
                    requestcourse.ExecuteNonQuery();
                    connection.Close();

                    Response.Write("You have successfully sent your request");
                }
                catch (Exception ex)
                {
                    Response.Write("Invalid format");
                }

            }
            else
            {
                Response.Write("Please make sure to fill the requirements bellow");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("carrefour.aspx");
        }
    }
}