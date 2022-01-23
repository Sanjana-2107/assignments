using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace user_login
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select * from [Table] where username = "+username.Text;

                SqlCommand con = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(con.ExecuteScalar().ToString());
                conn.Close();
                if (temp == 1)
                {
                    Response.Write("User already exists");
                }
               
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Guid newguid = Guid.NewGuid();


                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                conn.Open();
                string insert = "insert into  Table (id,username,email,password,country) values (@id,@uname,@email,@password,@country) ";
                SqlCommand con = new SqlCommand(insert, conn);
                con.Parameters.AddWithValue("@id", newguid.ToString());


                con.Parameters.AddWithValue("@uname", username.Text);
                con.Parameters.AddWithValue("@email", email.Text);

                con.Parameters.AddWithValue("@password", password.Text);
                con.Parameters.AddWithValue("@country", country.SelectedItem.ToString());
                con.ExecuteNonQuery();
                Response.Redirect("Manager.aspx");
                Response.Write("Registration is succuessful");


                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
        }

    }
}