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
        int n1, n2;
        n1 = Convert.ToInt32(TextBox1.Text);
        n2 = Convert.ToInt32(TextBox2.Text);
        string ch = TextBox3.Text;
        int res = 0;
        switch (ch)
        {
            case "+":
                res = n1 + n2;
                break;
            case "-":
                res = n1 - n2;
                break;
            case "*":
                res = n1 * n2;
                break;
        }
        Label1.Text = "result = " + res;


    }
    }