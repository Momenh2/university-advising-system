using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Admin2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Delete_a_course(object sender, EventArgs e)
        {
            Response.Redirect("Delete_a_course.aspx");
        }
        protected void Delete_a_slot(object sender, EventArgs e)
        {
            Response.Redirect("Delete_a_slot.aspx");
        }
        protected void Add_makeup_exam(object sender, EventArgs e)
        {
            Response.Redirect("Add_makeup_exam.aspx");
        }
        protected void View_for_payments(object sender, EventArgs e)
        {
            Response.Redirect("View_for_payments.aspx");
        }
        protected void Issue_installments(object sender, EventArgs e)
        {
            Response.Redirect("Issue_installments.aspx");
        }
        protected void Update_a_student_status(object sender, EventArgs e)
        {
            Response.Redirect("Update_a_student_status.aspx");
        }
        protected void Fetch_details_of_active_students(object sender, EventArgs e)
        {
            Response.Redirect("Fetch_details_of_active_students.aspx");
        }
        protected void View_all_graduation_plans(object sender, EventArgs e)
        {
            Response.Redirect("View_all_graduation_plans.aspx");
        }
        protected void View_all_students_transcript(object sender, EventArgs e)
        {
            Response.Redirect("View_all_students_transcript.aspx");
        }
        protected void Fetch_semesters(object sender, EventArgs e)
        {
            Response.Redirect("Fetch_semesters.aspx");
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2admin.aspx");
        }



    }
}
