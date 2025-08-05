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
    public partial class All_Students_Advisors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlConnection conn1 = new SqlConnection(connStr);

            SqlCommand Students_Advisors = new SqlCommand("AdminListStudentsWithAdvisors", conn);
            SqlCommand Students_Advisors1 = new SqlCommand("AdminListStudentsWithAdvisors", conn1);
            Students_Advisors.CommandType = System.Data.CommandType.StoredProcedure;
            Students_Advisors1.CommandType = System.Data.CommandType.StoredProcedure;

            conn.Open();
            conn1.Open();
            SqlDataReader rdr = Students_Advisors.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            SqlDataReader rdr1 = Students_Advisors1.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            Response.Write("all students with their corresponding advisors in the system :  " + "<br >" + "<br >");
            int i = 1;
            int j = 0;
            
            while (rdr1.Read())
            {
                j++;
            }
            
            if(j == 0)
            {
                Response.Write("No studnet linked to advisors in the System");
            }
          
       
            else
            {
                rdr1.Close();
              
                while (rdr.Read())
                {

                    int student_id = rdr.GetInt32(rdr.GetOrdinal("student_id"));
                    Label s_id = new Label();
                    s_id.Text = "Studnet number " + i + " : " + "<br >" + "Stduent ID : " + student_id.ToString() + "<br >";
                    form1.Controls.Add(s_id);


                    String first_name = rdr.GetString(rdr.GetOrdinal("f_name"));
                    Label f_name = new Label();
                    f_name.Text = "studnet first name : " + first_name + "<br >";
                    form1.Controls.Add(f_name);


                    String last_name = rdr.GetString(rdr.GetOrdinal("l_name"));
                    Label l_name = new Label();
                    l_name.Text = "student last name : " + last_name + "<br >";
                    form1.Controls.Add(l_name);


                    int advisorId1 = rdr.GetInt32(rdr.GetOrdinal("advisor_id"));
                    Label advisor_id = new Label();
                    advisor_id.Text = "Advisor ID : " + advisorId1.ToString() + "<br >";
                    form1.Controls.Add(advisor_id);


                    String advisor_name1 = rdr.GetString(rdr.GetOrdinal("advisor_name"));
                    Label advisor_name = new Label();
                    advisor_name.Text = "Advisor name : " + advisor_name1 + "<br  >" + "<br  >";
                    form1.Controls.Add(advisor_name);
                    i++;
                }
            }
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2admin.aspx");
        }
    }
}