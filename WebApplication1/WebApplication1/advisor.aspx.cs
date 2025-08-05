using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class advisor : System.Web.UI.Page
    {
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome user:" + Session["user"]);
        }
        protected void a(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
        protected void b(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
        protected void c(object sender, EventArgs e)
        {
            Response.Redirect("view-c.aspx");
        }
        protected void d(object sender, EventArgs e)
        {
            Response.Redirect("insert-d.aspx");
        }
        protected void e(object sender, EventArgs e)
        {
            Response.Redirect("insert-e.aspx");
        }
        protected void f(object sender, EventArgs e)
        {
            Response.Redirect("update-f.aspx");
        }
        protected void g(object sender, EventArgs e)
        {
            Response.Redirect("delete.aspx");
        }
        protected void h(object sender, EventArgs e)
        {
            Response.Redirect("view-h.aspx");
        }
        protected void i(object sender, EventArgs e)
        {
            Response.Redirect("view-i.aspx");
        }
        protected void j(object sender, EventArgs e)
        {
            Response.Redirect("view-j.aspx");
        }
        protected void k(object sender, EventArgs e)
        {
            Response.Redirect("approve-k.aspx");
        }
        protected void l(object sender, EventArgs e)
        {
            Response.Redirect("approve-l.aspx");
        }
        protected void back(object sender, EventArgs e)
        {
            Response.Redirect("login_a.aspx");
        }

    }
}
