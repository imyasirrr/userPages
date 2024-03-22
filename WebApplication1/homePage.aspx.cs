using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = "Data Source=YASIR\\SQLEXPRESS;Initial Catalog=login;User Id=sa;Password=123";

        protected void insert_Click(object sender, EventArgs e)
        {
            
            string studentName = StudentName.Text;
            string mobileNo = MobileNo.Text;

            if (!RecordExists(connectionString, studentName))
            {
                InsertRecord(connectionString, studentName, mobileNo);
                Response.Write("Record inserted successfully.");
            }
            else
            {
                
                Response.Write("Record already exists.");
            }
        }

        bool RecordExists(string connectionString, string studentName)
        {
            string query = "SELECT COUNT(*) FROM Student_data WHERE Student_Name = @StudentName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentName", studentName);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        void InsertRecord(string connectionString, string studentName, string mobileNo)
        {
            string query = "INSERT INTO Student_data (Student_Name, Mobile_No) VALUES (@StudentName, @MobileNo)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentName", studentName);
                    command.Parameters.AddWithValue("@MobileNo", mobileNo);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        protected void fetchData_Click(object sender, EventArgs e)
        {
            string studentName = StudentName.Text;
            string mobileNo = MobileNo.Text;

            string query = "SELECT * FROM Student_data WHERE Student_Name = @StudentName AND Mobile_No = @MobileNo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentName", studentName);
                    command.Parameters.AddWithValue("@MobileNo", mobileNo);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            Response.Write("No records found for the specified student name and mobile number.");
                        }
                        else
                        {
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            string studentName = StudentName.Text;
            string mobileNo = MobileNo.Text;
            string fName = FathersName.Text;
            string email = Email.Text;

            if (RecordExists(connectionString, studentName))
            {
                if (UpdateRecord(connectionString, studentName, mobileNo, fName, email))
                {
                    Response.Write("Record updated successfully.");
                }
                else
                {
                    Response.Write("Failed to update record.");
                }
            }
            else
            {
                Response.Write("Record does not exist.");
            }
        }

        bool UpdateRecord(string connectionString, string studentName, string mobileNo, string fName, string email)
        {
            string query = "UPDATE Student_data SET Fathers_Name = @FathersName, Email_Address = @EmailAddress WHERE Student_Name = @StudentName AND Mobile_No = @MobileNo";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FathersName", fName);
                    command.Parameters.AddWithValue("@EmailAddress", email);
                    command.Parameters.AddWithValue("@MobileNo", mobileNo);
                    command.Parameters.AddWithValue("@StudentName", studentName);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            string studentName = StudentName.Text;

            if (RecordExists(connectionString, studentName))
            {
                if (DeleteRecord(connectionString, studentName))
                {
                    Response.Write("Record deleted successfully.");
                }
                else
                {
                    Response.Write("Failed to delete record.");
                }
            }
            else
            {
                Response.Write("Record does not exist.");
            }
        }

        bool DeleteRecord(string connectionString, string studentName)
        {
            string query = "DELETE FROM Student_data WHERE Student_Name = @StudentName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentName", studentName);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        protected void reset_btn_Click(object sender, EventArgs e)
        {
            StudentName.Text = string.Empty;
            MobileNo.Text = string.Empty;
            FathersName.Text = string.Empty;
            Email.Text = string.Empty;
            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView2.DataSource = null;
            GridView2.DataBind();
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Your event handling code here
        }

        protected void All_Records_Click(object sender, EventArgs e)
        {

            string studentName = StudentName.Text;
            string mobileNo = MobileNo.Text;

            string query = "SELECT * FROM Student_data";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentName", studentName);
                    command.Parameters.AddWithValue("@MobileNo", mobileNo);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            Response.Write("No records found for the specified student name and mobile number.");
                        }
                        else
                        {
                            GridView2.DataSource = dt;
                            GridView2.DataBind();
                        }
                    }
                }
            }
        }
    }
}
