using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class Link_Instructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void link_Click(object sender, EventArgs e)
        {
            string conneStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(conneStr);
            SqlConnection connection1 = new SqlConnection(conneStr);
            SqlConnection connection2 = new SqlConnection(conneStr);
            SqlConnection connection4 = new SqlConnection(conneStr);

            if (CID.Text == "" || IID.Text == "" || SID.Text == "")
            {
                Response.Write("unsuccessfull, one of the inputs is empty");
            }
            else
            {
                try
                {
                    int CourseID = int.Parse(CID.Text);
                    int InstructorID = int.Parse(IID.Text);
                    int SlotID = int.Parse(SID.Text);

                    SqlCommand LinkICproc = new SqlCommand("[Procedures_AdminLinkInstructor]", connection4);


                    SqlCommand courses_table = new SqlCommand("SELECT * FROM Course", connection);

                    SqlCommand Instructor_table = new SqlCommand("SELECT * FROM Instructor", connection1);

                    SqlCommand Slot_table = new SqlCommand("SELECT * FROM Slot", connection2);

                    connection.Open();
                    connection1.Open();
                    connection2.Open();
                    connection4.Open();


                    SqlDataReader rdr = courses_table.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    SqlDataReader rdr1 = Instructor_table.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    SqlDataReader rdr2 = Slot_table.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    bool c = true;
                    bool i = true;
                    bool s = true;

                    while (rdr.Read())
                    {
                        if (CourseID == rdr.GetInt32(rdr.GetOrdinal("course_id")))
                            c = false;
                    }

                    while (rdr1.Read())
                    {
                        if (InstructorID == rdr1.GetInt32(rdr1.GetOrdinal("instructor_id")))
                            i = false;
                    }
                    while (rdr2.Read())
                    {
                        if (SlotID == rdr2.GetInt32(rdr2.GetOrdinal("slot_id")))
                            s = false;
                    }


                    if (c || i || s)
                    {
                        Response.Write("unsuccessfull, one of the inputs does not exists in the Guc database");
                    }




                    else
                    {
                        LinkICproc.CommandType = System.Data.CommandType.StoredProcedure;
                        LinkICproc.Parameters.Add(new SqlParameter("@cours_id", CourseID));
                        LinkICproc.Parameters.Add(new SqlParameter("@instructor_id", InstructorID));
                        LinkICproc.Parameters.Add(new SqlParameter("@slot_id", SlotID));


                        Response.Write("Linked successfully");
                        LinkICproc.ExecuteNonQuery();
                        connection4.Close();

                    }

                }
                catch(Exception ex)
                {
                    Response.Write("invalid format");
                }
                
                }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2admin.aspx");
        }
    }
}