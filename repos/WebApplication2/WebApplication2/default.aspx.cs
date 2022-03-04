using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAzureSQL_Click_Click(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection();
             connection1.ConnectionString = "Server=tcp:anjanserver.database.windows.net,1433;Initial Catalog=anjandatabase;Persist Security Info=False;User ID=anjan;Password=Pass1234567890-=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            connection1.Open();

            Label1.Text = $"<h1> SQL connection state : {connection1.State} <br> <h1> Machine name : {Environment.MachineName.ToString()}";
            
            string SQL = "SELECT * FROM Employee";

            SqlCommand cmd = new SqlCommand(SQL,connection1);

            SqlDataReader reader = cmd.ExecuteReader();

            Label1.Text = $"<br><br><br>ID      FirstName       LastName<br><br>";

            while (reader.Read())
            {
                Label1.Text += reader["EmpId"].ToString() + ",       <br>";
                Label1.Text += reader["FirstName"].ToString() + "       <br>";
                Label1.Text += reader["LastName"].ToString() + "       <br>";
            }
            reader.Close(); 
           connection1.Close();


        }

       /* protected void btnAzureSQL22_Click(object sender, EventArgs e)
        {

            SqlConnection connection1 = new SqlConnection();
           connection1.ConnectionString = "Server=tcp:anjanserver.database.windows.net,1433;Initial Catalog=anjandatabase;Persist Security Info=False;User ID=anjan;Password=Pass1234567890-=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection1.Open(); 

            string SQL = "SELECT * FROM Employee";

            SqlCommand cmd = new SqlCommand(SQL, connection1);

            SqlDataReader reader = cmd.ExecuteReader();

            Label2.Text = $"<br><br><br>ID      FirstName       LastName<br><br><br>";

            while (reader.Read())
            {
                Label2.Text = reader["EmpId"].ToString() + ",       <br>";
                Label2.Text = reader["FirstName"].ToString() + ",       <br>";
                Label2.Text = reader["LastName"].ToString() + ",       <br>";
            }
            reader.Close();
            connection1.Close();
        } */
    }
}