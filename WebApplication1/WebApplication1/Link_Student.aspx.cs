using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class Link_Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2admin.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conneStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            
            SqlConnection connection = new SqlConnection(conneStr);
            SqlConnection connection1 = new SqlConnection(conneStr);
            SqlConnection connection2 = new SqlConnection(conneStr);
            SqlConnection connection4 = new SqlConnection(conneStr);

            


            SqlCommand courses_table = new SqlCommand("SELECT * FROM Course", connection);

            SqlCommand Instructor_table = new SqlCommand("SELECT * FROM Instructor", connection1);

            SqlCommand Student_table = new SqlCommand("SELECT * FROM Student", connection2);

            connection.Open();
            
            connection1.Open();
            
            connection2.Open();
            
            connection4.Open();
            
            SqlDataReader rdr = courses_table.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            
            SqlDataReader rdr1 = Instructor_table.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            
            SqlDataReader rdr2 = Student_table.ExecuteReader(System.Data.CommandBehavior.CloseConnection);




            if (crid.Text.ToString() == "" || insid.Text.ToString() == "" || stid.Text.ToString() == "" || semcode.Text == "")
            {
                Response.Write("Unsuccsesfull , one of the inputs is null");
            }
            else
            {
                try { 
                int course_id = int.Parse(crid.Text);
                int instructor_id = int.Parse(insid.Text);
                int student_id = int.Parse(stid.Text);
                String semester_code = semcode.Text;



                bool c = true;
                bool i = true;
                bool s = true;

                while (rdr.Read())
                {
                    if (course_id == rdr.GetInt32(rdr.GetOrdinal("course_id")))
                        c = false;
                }

                while (rdr1.Read())
                {
                    if (instructor_id == rdr1.GetInt32(rdr1.GetOrdinal("instructor_id")))
                        i = false;
                }
                while (rdr2.Read())
                {
                    if (student_id == rdr2.GetInt32(rdr2.GetOrdinal("student_id")))
                        s = false;
                }


                if (c || i || s)
                {
                    Response.Write("unsuccessfull, one of the inputs does not exists in the Guc database");
                }



                else
                {


                    SqlCommand LinkSTproc = new SqlCommand("[Procedures_AdminLinkStudent]", connection4);
                    LinkSTproc.CommandType = System.Data.CommandType.StoredProcedure;
                    LinkSTproc.Parameters.Add(new SqlParameter("@cours_id", course_id));
                    LinkSTproc.Parameters.Add(new SqlParameter("@instructor_id", instructor_id));
                    LinkSTproc.Parameters.Add(new SqlParameter("@studentID", student_id));
                    LinkSTproc.Parameters.Add(new SqlParameter("@semester_code", semester_code));





                    Response.Write("Successfull , mabrok");
                    // connection.Open();
                    LinkSTproc.ExecuteNonQuery();

                    connection.Close();
                }

            }    
              catch(Exception ex) {
                    Response.Write("invalid format");
                }      
               
                }
            }
        }
    }
