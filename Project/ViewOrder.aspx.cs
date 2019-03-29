using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class ViewOrder : System.Web.UI.Page
{

    public static string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
    SqlConnection con = new SqlConnection(connectionString);
    //SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Sentiment;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string aa = "select * from order1 order by date ASC";
        da = new SqlDataAdapter(aa, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        

    }
}