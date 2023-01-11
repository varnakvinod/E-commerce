using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_project
{
    public partial class Admin : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int lgid = 0;
            string sel = "select max(log_id) from login";
            string v = obj.Fn_Exescalar(sel);
            if (v == null | v == "")
            {
                lgid = 1;
            }
            else
            {
                int id = Convert.ToInt32(v);
                lgid = id + 1;
            }
            string s = "insert into adminreg values(" + lgid + ",'" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ",'" + TextBox4.Text + "')";
            int i = obj.Fn_Exenonquery(s);
            string u = "Admin";
            string log = "insert into login values(" + lgid + ",'" + TextBox5.Text + "','" + TextBox6.Text + "')";
            int j = obj.Fn_Exenonquery(log);

            Label7.Text = "Inserted";

        }
    }
}