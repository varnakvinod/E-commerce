using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class Register : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "User")
            {
                Response.Redirect("User.aspx");
            }
            else if (DropDownList1.SelectedItem.Text == "Admin")
            {
                Response.Redirect("Admin.aspx");
            }
        }
    }
}