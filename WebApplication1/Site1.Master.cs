using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Login_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginForm.aspx");
        }

        protected void Signup_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("sign_up.aspx");
        }
    }
}