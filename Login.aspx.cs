using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace user_login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginuser_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select *from Table where username = " + Username.Text;
               // "select count(*) from [Table]where username= '" + Username.Text + "' ";

            SqlCommand con = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(con.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                string checkPasswordquery = "select password from Table where username = '" + Username.Text + "' ";
                SqlCommand passcomm = new SqlCommand(checkPasswordquery, conn);
                string password = passcomm.ExecuteScalar().ToString().Replace(" ","");
                if(password==Password.Text)
                {
                    Session["New "] = Username.Text;
                    Response.Write("Password is correct");
                    Response.Redirect("user.aspx");

                }
                else
                {
                    Response.Write("password not correct");
                }


            }
            else
            {
                Response.Write("username not correct");
            }

        }
    }
}
