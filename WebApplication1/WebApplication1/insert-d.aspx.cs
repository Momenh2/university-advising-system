using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class insert_d : System.Web.UI.Page
    {
        public DateTime dae;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            if (Session["user"] == null)
            {
                Response.Write("Sorry not signed in");

            }
            
            
            else
            {
                int idd = (int)Session["user"];
                if (semcode.Text.Equals("") || credit.Text.Equals("") || studid.Text.Equals("") || (DateTime)Session["date"] == null)
                {
                    Response.Write("Data null");
                }
                else
                {//dae != DateTime.MinValue ||
                    if ((DateTime)Session["date"] != DateTime.MinValue)
                    {

                        try
                        {
                            String semcod = semcode.Text;
                            DateTime grad = (DateTime)Session["date"];

                            int c = Int16.Parse(credit.Text);
                            int sid = Int16.Parse(studid.Text);


                            SqlCommand proc = new SqlCommand("Procedures_AdvisorCreateGP", conn);
                            proc.CommandType = CommandType.StoredProcedure;
                            proc.Parameters.Add(new SqlParameter("@Semester_code", semcod));
                            proc.Parameters.Add(new SqlParameter("@expected_graduation_date", grad));
                            proc.Parameters.Add(new SqlParameter("@sem_credit_hours", c));
                            proc.Parameters.Add(new SqlParameter("@advisor_id", idd));
                            proc.Parameters.Add(new SqlParameter("@student_id", sid));

                            proc.CommandType = CommandType.StoredProcedure;

                            //SqlParameter id = registerproc.Parameters.Add("@Advisor_id", System.Data.SqlDbType.Int);
                            //id.Direction = System.Data.ParameterDirection.Output;
                            conn.Open();
                            proc.ExecuteNonQuery();
                            conn.Close();
                            //Session["user"] = id.Value;
                            Response.Write("SUCCESS");

                        }
                       catch(Exception ex)
                        {
                            Response.Write("Invalid input");
                        }
                        
                        }

                    else
                    {
                        Response.Write("Date Not Selected");
                    }

                }
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

            dae = Calendar1.SelectedDate.Date;
            Session["date"] = Calendar1.SelectedDate.Date;
            Response.Write(Calendar1.SelectedDate);
            Response.Write((DateTime)Session["date"]);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("advisor.aspx");
        }
    }
}
