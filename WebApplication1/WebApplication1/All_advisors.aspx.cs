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
    public partial class All_advisors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlConnection conn1 = new SqlConnection(connStr);
            SqlCommand advisors = new SqlCommand("Procedures_AdminListAdvisors", conn);
            SqlCommand advisors1 = new SqlCommand("Procedures_AdminListAdvisors", conn1);
          
            advisors.CommandType = System.Data.CommandType.StoredProcedure;
            advisors1.CommandType = System.Data.CommandType.StoredProcedure;
            conn.Open();
            conn1.Open();
           
            SqlDataReader rdr = advisors.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            SqlDataReader rdr1 = advisors1.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            int j = 0;
            int i = 1;
            Response.Write("all advisors :  " + "<br >" + "<br >");
            while (rdr1.Read())
            {
                j++;
            }

            if (j == 0)
            {
                Response.Write("No advisors in the System");
            }
            else
            {
                rdr1.Close();
          
               
                while (rdr.Read())
                {

                    int advisorId = rdr.GetInt32(rdr.GetOrdinal("advisor_id"));
                    Label advisor_id = new Label();
                    advisor_id.Text = "Advisor number  " + i + " :" + "<br >" + "Advisor ID :  " + advisorId.ToString() + "<br >";
                    form1.Controls.Add(advisor_id);


                    String advisorName = rdr.GetString(rdr.GetOrdinal("advisor_name"));
                    Label name = new Label();
                    name.Text = "Advisor Name :  " + advisorName + "<br >";
                    form1.Controls.Add(name);



                    String advisorEmail = rdr.GetString(rdr.GetOrdinal("email"));
                    Label email = new Label();
                    email.Text = "Advisor Email :  " + advisorEmail + "<br >";
                    form1.Controls.Add(email);

                    String advisorOffice = rdr.GetString(rdr.GetOrdinal("office"));
                    Label office = new Label();
                    office.Text = "Advisor Office : " + advisorOffice + "<br   >" + "<br   >";
                    form1.Controls.Add(office);

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