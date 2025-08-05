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
    public partial class carrefour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String semester_code = semestercode.Text;
            Session["semester"] = semester_code;
            if (semester_code == "")
            {
                Response.Write("Please insert a semester code");
            }
            else
            {
                Response.Redirect("courses.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String semester_code = semestercode.Text;
            Session["semester"] = semester_code;
            if (semester_code == "")
            {
                Response.Write("Please insert a semester code");
            }
            else
            {
                Response.Redirect("available_courses.aspx");
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            String semester_code = semestercode.Text;
            Session["semester"] = semester_code;
            if (semester_code == "")
            {
                Response.Write("Please insert a semester code");
            }
            else
            {
                Response.Redirect("required_courses.aspx");
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            String semester_code = semestercode.Text;

            Session["semester"] = semester_code;
            if (semester_code == "")
            {
                Response.Write("Please insert a semester code");
            }
            else
            {
                Response.Redirect("missing_courses.aspx");
            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("course_request.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("credithour_request.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {

            string conneStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(conneStr);
            connection.Open();
            int id = (int)Session["user"];
            String phone_number = PhoneNumber.Text;

            if (phone_number == "")
            {
                Response.Write("You must enter a phone number");
            }

            else
            {
                SqlCommand phoneNumber = new SqlCommand("[Procedures_StudentaddMobile]", connection);
                phoneNumber.CommandType = System.Data.CommandType.StoredProcedure;
                phoneNumber.Parameters.Add(new SqlParameter("@StudentID", id));
                phoneNumber.Parameters.Add(new SqlParameter("@mobile_number", phone_number));

                phoneNumber.ExecuteNonQuery();
                connection.Close();

                Response.Write("You have successfully added a phone number");

            }











        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("David.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login_Student.aspx");
        }
    }
}