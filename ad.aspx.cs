using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class ad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string NAME; int contact_no; string Address;
            contact_no = Convert.ToInt32(txtcontact_no.Text);
            NAME = txtNAME.Text;
            Address = txtAddress.Text;
            lblResult.Text = "Your ADMIN details:" + NAME + " , " + contact_no + "," + Address;

        }
    }
}