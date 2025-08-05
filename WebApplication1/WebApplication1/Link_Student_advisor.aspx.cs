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
    public partial class Link_Student_advisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conneStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(conneStr);

            SqlConnection connection1 = new SqlConnection(conneStr);
            SqlConnection connection2 = new SqlConnection(conneStr);





            connection.Open();
            connection1.Open();
            connection2.Open();



            SqlCommand Student_table = new SqlCommand("SELECT * FROM Student", connection1);
            SqlCommand Advisor_table = new SqlCommand("SELECT * FROM Advisor", connection2);



            SqlDataReader rdr = Student_table.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            SqlDataReader rdr1 = Advisor_table.ExecuteReader(System.Data.CommandBehavior.CloseConnection);




            

            if (AID.Text.ToString() == "" ||SID.Text.ToString() == "")
            {
                Response.Write("Unsuccsesfull , one of the inputs is null");
            }

            else
            {
                try { 
                int studentID = int.Parse(SID.Text);
                int AdvisorID = int.Parse(AID.Text);


                bool s = true;
                bool a = true;
                
                while (rdr.Read())
                {
                    if (studentID == rdr.GetInt32(rdr.GetOrdinal("student_id")))
                        s = false;
                }

                while (rdr1.Read())
                {
                    if (AdvisorID == rdr1.GetInt32(rdr1.GetOrdinal("advisor_id")))
                        a = false;
                }


                    if (a || s)
                    {
                        Response.Write("unsuccessfull, one of the inputs does not exists in the Guc database");
                    }


                    else
                    {


                        SqlCommand LinkSAproc = new SqlCommand("[Procedures_AdminLinkStudentToAdvisor]", connection);
                        LinkSAproc.CommandType = System.Data.CommandType.StoredProcedure;
                        LinkSAproc.Parameters.Add(new SqlParameter("@studentID", studentID));
                        LinkSAproc.Parameters.Add(new SqlParameter("@advisorID", AdvisorID));

                        Response.Write("succsesfulll");

                        LinkSAproc.ExecuteNonQuery();
                        connection.Close();

                    }


                }
            
           catch(Exception ex)
                {
                    Response.Write("invalid input");
                }
                
                }
        }

        
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2admin.aspx");
        }
    }

}