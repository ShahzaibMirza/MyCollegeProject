using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Configuration;

public partial class Comment : System.Web.UI.Page
{

    public static string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
    SqlConnection con = new SqlConnection(connectionString);
   // SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Sentiment;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["msg"] == "msg")
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Thank You. Item has been Placed in Cart');", true);
            Session["msg"] = "";
            
        }
        
        Panel1.Visible = false;
        SqlCommand cmd;
        string l = "select top 1 id from comment order by id desc";
        con.Open();
        cmd = new SqlCommand(l, con);
        object count = cmd.ExecuteScalar();
        int c = Convert.ToInt32(count);
        if (c != 0)
        {
            c = c + 1;
            Label3.Text = Convert.ToString(c);

        }
        else
        {
            Label3.Text = "1";
            
        }
        con.Close();
        Label2.Text = Session["name"].ToString();
        Image1.ImageUrl = Session["image"].ToString();
        Label5.Text = Session["price"].ToString();
        Label4.Text = Session["desc"].ToString();
       
    }
   
   
 
   


   
   

    
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (TextBox5.Text == "")
        {
            String alertmsg = "Enter Qauntity";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
        }
        else
        {
            int c = Convert.ToInt32(TextBox5.Text);
            int fc = Convert.ToInt32(Label5.Text) * c;
            try
            {
                string id = Session["uid"].ToString();
                string quantity = TextBox5.Text;
                Session["q"] += quantity;
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into cart values('" + id + "','" +Label2.Text + "-"+TextBox5.Text+"','" + c + "','" + Label5.Text + "','" + fc + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Session["msg"] = "msg";
                Response.Redirect("ViewProducts.aspx");
                
               
               

            }
            catch (HttpException exx)
            { }
        }
    }
}
