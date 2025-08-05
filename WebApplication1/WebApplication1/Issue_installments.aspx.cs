using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace WebApplication1
{
    public partial class Issue_installments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void PaymetInstallement(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String connStr2 = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn2 = new SqlConnection(connStr2);

            SqlCommand Procedures_AdminIssueInstallment = new SqlCommand("Procedures_AdminIssueInstallment", conn);
            try
            {

                if (payment_id.Text == "")
                {
                    Response.Write("please enter the required data");
                    return;
                }
                int Payment_id = Int16.Parse(payment_id.Text);

                string query = "SELECT COUNT(*) FROM Payment WHERE payment_id = @payment_id";

                using (SqlCommand command = new SqlCommand(query, conn2))
                {
                    // Add parameter to the command to prevent SQL injection
                    command.Parameters.AddWithValue("@payment_id", Payment_id);

                    // Open the connection
                    conn2.Open();

                    // ExecuteScalar returns the number of rows that satisfy the condition
                    int paymentCount = (int)command.ExecuteScalar();

                    // Check if the Payment ID exists
                    if (paymentCount > 0)
                    {
                        // Payment ID exists in the Payment table

                        Procedures_AdminIssueInstallment.CommandType = CommandType.StoredProcedure;
                        Procedures_AdminIssueInstallment.Parameters.Add(new SqlParameter("@payment_id", Payment_id));
                        try
                        {
                            conn.Open();
                            Procedures_AdminIssueInstallment.ExecuteNonQuery();
                            conn.Close();

                            Response.Write("The Payment has been divided into installemnts");
                        }
                        catch (Exception ex)
                        {
                            Response.Write("cannot issue a payment that has an installement");
                        }
                    }
                    else
                    {
                        // Payment ID does not exist in the Payment table
                        Response.Write("The Payment ID does not exist in the Payment table.");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("invalid format");
            }


        }
        protected void Go_Back(object sender, EventArgs e)
        {
            Response.Redirect("Admin2.aspx");
        }
    }
}