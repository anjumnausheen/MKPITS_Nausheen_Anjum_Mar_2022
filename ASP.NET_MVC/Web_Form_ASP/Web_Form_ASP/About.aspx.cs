using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label7.Text = "username : " + TextBox1.Text;
        Label8.Text = "address : " + TextBox2.Text;
        Label9.Text = "password : " + TextBox3.Text;
        Label6.Text = "dob : " + TextBox4.Text;
        Label10.Text = "email : " + TextBox5.Text;
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {

        Response.Redirect("webform1.aspx");

    }
}