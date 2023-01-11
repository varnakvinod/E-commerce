using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace final_project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ConnectionClass pro = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "select category_id,category_name from category";
            DataSet ds = pro.Fn_Exedataset(str);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "category_name";
            DropDownList1.DataValueField = "category_id";
            DropDownList1.DataBind();



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pa = "~/Product/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(pa));
            string stat = "Available";
            string prins = "insert into product values(" + DropDownList1.SelectedItem.Value + ",'" + TextBox1.Text + "','" + pa + "','" + TextBox2.Text + "','" + TextBox3.Text + "',,'" + stat + "')";
            int j = pro.Fn_Exenonquery(prins);
            if (j != 0)
            {
                Label6.Text = "added";
            }
           

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}