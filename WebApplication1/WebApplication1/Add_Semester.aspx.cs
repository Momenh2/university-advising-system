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
    public partial class Add_Semester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ADD_Click(object sender, EventArgs e)
        {
            string conneStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(conneStr);


            if (Start_Date.Text.ToString() == "" || End_Date.Text.ToString() == "" || Semester_code.Text.ToString() == "")
            
                Response.Write("Unsuccsesfull , one of the inputs is null");
            

           
               
                else
               {
                try
                {
                    DateTime start_Date = DateTime.Parse(Start_Date.Text);
                    DateTime end_Date = DateTime.Parse(End_Date.Text);
                    String semester_code = Semester_code.Text;

                    SqlCommand AddSemproc = new SqlCommand("[AdminAddingSemester]", connection);
                    AddSemproc.CommandType = System.Data.CommandType.StoredProcedure;
                    AddSemproc.Parameters.Add(new SqlParameter("@start_date", start_Date));
                    AddSemproc.Parameters.Add(new SqlParameter("@end_date", end_Date));
                    AddSemproc.Parameters.Add(new SqlParameter("@semester_code", semester_code));


                    Response.Write("Successfully added ..  .. :) ");
                    connection.Open();
                    AddSemproc.ExecuteNonQuery();
                    connection.Close();

                }
                catch(Exception ex)
                {
                    Response.Write("Invalid date format");
                }
                }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2admin.aspx");
        }
    }
}