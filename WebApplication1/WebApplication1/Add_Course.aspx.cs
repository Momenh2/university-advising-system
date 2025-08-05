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
    public partial class Add_Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addcourse_Click(object sender, EventArgs e)
        {

            string conneStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(conneStr);

            if (major.Text.ToString() == "" || semester.Text.ToString() == "" || credit_hours.Text.ToString() == "" || name.Text == "" || is_offered.Text == "")
            {
                Response.Write("Unsuccsesfull , one of the inputs is null");
            }

            else
            {
                try
                {
                    String Major = major.Text;
                    int Semester = int.Parse(semester.Text);
                    int Credit_hours = int.Parse(credit_hours.Text);
                    String Name = name.Text;
                    String Is_offered = is_offered.Text;


                    SqlCommand AddCRproc = new SqlCommand("[Procedures_AdminAddingCourse]", connection);
                    AddCRproc.CommandType = System.Data.CommandType.StoredProcedure;
                    AddCRproc.Parameters.Add(new SqlParameter("@major", Major));
                    AddCRproc.Parameters.Add(new SqlParameter("@semester", Semester));
                    AddCRproc.Parameters.Add(new SqlParameter("@credit_hours", Credit_hours));
                    AddCRproc.Parameters.Add(new SqlParameter("@name", Name));
                    AddCRproc.Parameters.Add(new SqlParameter("@is_offered", Is_offered));

                    connection.Open();
                    AddCRproc.ExecuteNonQuery();
                    connection.Close();
                    Response.Write("added successfully..... ;)");

                }

                catch (Exception ex)
                {
                    Response.Write("Unsuccsesfull , invalid format");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
            
            Response.Redirect("page2admin.aspx");
        }
    }
}