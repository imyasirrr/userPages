using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class sign_up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string UserName = TextBox1.Text;
            string Password = TextBox2.Text;

            string connString = "Data Source=YASIR\\SQLEXPRESS;Initial Catalog=login;User Id=sa;Password=123";

            if (!RecordExists(connString, UserName))
            {
                if (InsertRecord(connString, UserName, Password))
                {
                    Response.Write("Username Created");
                }
                else
                {
                    Response.Write("Failed to create username");
                }
            }
            else
            {
                Response.Write( "Username already exists, please choose another one");
            }
        }

        private bool RecordExists(string connectionString, string userName)
        {
            string query = "SELECT COUNT(*) FROM [user] WHERE Username = @UserName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool InsertRecord(string connectionString, string userName, string password)
        {
            string query = "INSERT INTO [user] (Username, Password) VALUES (@UserName, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        
    }
}



