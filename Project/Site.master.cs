using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["msg"] == "msg")
        {
            Panel2.Visible =true;
            Panel1.Visible = false;
        }
        else
        {
            Panel2.Visible =  false;
            Panel1.Visible = true;
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}
