using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        //SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Sentiment;Integrated Security=True");
        con.Open();
        string s = "delete  from cart";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }
}