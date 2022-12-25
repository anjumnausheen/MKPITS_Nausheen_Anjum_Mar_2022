using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Label1.Text = Calendar1.SelectedDate.ToString(); 

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        
        
        Label1.Text = Calendar1.SelectedDate.Date.ToShortDateString();


    }
}