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

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        string str = DropDownList1.SelectedItem.Text;
        if (str == "india")
        {
            DropDownList2.Items.Add("nagpur");
            DropDownList2.Items.Add("mumbai");
            DropDownList2.Items.Add("delhi");

        }
        else if (str == "usa")
        {
            DropDownList2.Items.Add("newyork");
            DropDownList2.Items.Add("chicago");


        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("country " + DropDownList1.Text);
        sb.Append("<br>city " + DropDownList2.Text);
        Label1.Text = sb.ToString();

    }
}