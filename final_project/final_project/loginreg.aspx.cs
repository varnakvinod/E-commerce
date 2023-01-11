using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class loginreg : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string lid = "select count(log_id) from login where UserName='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string ccid = obj.Fn_Exescalar(lid);
            if (ccid == "1")
            {
                string iid = "select log_id from login where UserName='" + TextBox1.Text + "' and Password=" + TextBox2.Text + " ";
                string logid = obj.Fn_Exescalar(iid);
                string sel = "select Usertype from login where log_id =" + logid + " ";

                //string s= "select Usertype from LoginTab where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";

                string r = obj.Fn_Exescalar(sel);
                if (r == "User")
                {
                    Response.Redirect("WebForm1.aspx");
                }
                else if (r=="Admin")
                {
                    Response.Redirect("CategoryPage.aspx");
                }

                }
            }
        }
    }
