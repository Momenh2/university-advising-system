using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class update_f : System.Web.UI.Page
    {
        public DateTime dae;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            if (TextBox1.Text.Equals("") || dae == null)
            {
                Response.Write("Data null");
            }
            else
            {

                try
                {
                    if ((DateTime)Session["date"] != DateTime.MinValue)
                    {
                        int c = Int16.Parse(TextBox1.Text);

                        SqlCommand proc = new SqlCommand("Procedures_AdvisorUpdateGP", conn);
                        proc.CommandType = CommandType.StoredProcedure;
                        proc.Parameters.Add(new SqlParameter("@studentID", c));
                        proc.Parameters.Add(new SqlParameter("@expected_grad_date", (DateTime)Session["date"]));
                        proc.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        proc.ExecuteNonQuery();
                        conn.Close();
                        Response.Write("SUCCESS");
                    }

                    else
                    {
                        Response.Write("Date not select");
                    }



                }
               
                catch (Exception ex)
                {
                    Response.Write("Invalid input");
                }
             
                

            
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Session["date"] = Calendar1.SelectedDate;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("advisor.aspx");
        }
    }
}