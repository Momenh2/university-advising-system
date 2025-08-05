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
    public partial class Update_a_student_status : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void UpdateSatus(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            if (Student_id.Text == "")
            {
                Response.Write("please enter the Student id");
                return;
            }
            try
            {
                int studentId = Int16.Parse(Student_id.Text);
                SqlCommand UpdateStudentProc = new SqlCommand("Procedure_AdminUpdateStudentStatus", conn);
                UpdateStudentProc.CommandType = CommandType.StoredProcedure;
                UpdateStudentProc.Parameters.Add(new SqlParameter("@student_id", studentId));

                conn.Open();
                UpdateStudentProc.ExecuteNonQuery();
                conn.Close();
                Response.Write("the status hes been updated");
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
