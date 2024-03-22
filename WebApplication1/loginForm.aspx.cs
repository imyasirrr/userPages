using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class loginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=YASIR\\SQLEXPRESS;Database=login;User Id=sa;Password=123;");
            SqlCommand cmd = new SqlCommand("SELECT * FROM [user] WHERE username=@username AND password=@password", connection);
            cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            cmd.Parameters.AddWithValue("@password", TextBox2.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "user"); 
            if (ds.Tables["user"].Rows.Count == 0)
            {
                Response.Write("Invalid user");
            }
            else
            {
                Response.Redirect("homePage.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("sign_up.aspx");
        }
    }
}