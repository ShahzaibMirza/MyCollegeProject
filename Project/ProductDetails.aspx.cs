using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ProductDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Sentiment;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

        Image1.ImageUrl = Session["image"].ToString();
        Lblname.Text = Session["name"].ToString();
        Label10.Text = Session["desc"].ToString();
        lblcost.Text = Session["price"].ToString();

       
       
    }
}