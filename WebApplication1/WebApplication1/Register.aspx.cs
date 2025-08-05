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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reg_Click(object sender, EventArgs e)
        {
            string conneStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(conneStr);


            if (FirstName.Text != "" && LastName.Text != "" && Password.Text != "" && Faculty.Text != "" && Email.Text != "" && Major.Text != "" && Semester.Text != "")
            {
                try
                {
                    String first_name = FirstName.Text;
                    String last_name = LastName.Text;
                    String pass = Password.Text;
                    String faculty = Faculty.Text;
                    String email = Email.Text;
                    String major = Major.Text;
                    int semester = Int16.Parse(Semester.Text);

                    SqlCommand registerproc = new SqlCommand("[Procedures_StudentRegistration]", connection);
                    registerproc.CommandType = System.Data.CommandType.StoredProcedure;
                    registerproc.Parameters.Add(new SqlParameter("@first_name", first_name));
                    registerproc.Parameters.Add(new SqlParameter("@last_name", last_name));
                    registerproc.Parameters.Add(new SqlParameter("@password", pass));
                    registerproc.Parameters.Add(new SqlParameter("@faculty", faculty));
                    registerproc.Parameters.Add(new SqlParameter("@email", email));
                    registerproc.Parameters.Add(new SqlParameter("@major", major));
                    registerproc.Parameters.Add(new SqlParameter("@Semester", semester));

                    SqlParameter Student_id = registerproc.Parameters.Add(new SqlParameter("@Student_id", System.Data.SqlDbType.Int));
                    Student_id.Direction = System.Data.ParameterDirection.Output;

                    connection.Open();
                    registerproc.ExecuteNonQuery();
                    connection.Close();
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


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login_Student.aspx");
        }
    }
}
    

