﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Register : System.Web.UI.Page
{


    public static string connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
    SqlConnection con = new SqlConnection(connectionString);
    //SqlConnection con = new SqlConnection(@"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=Sentiment;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd;
        string a = "select top 1 id from topic order by id desc";
        cmd = new SqlCommand(a, con);
        object count = cmd.ExecuteScalar();
        int c = Convert.ToInt32(count);
        if (c != 0)
        {
            c = c + 1;
            txtuid.Text = Convert.ToString(c);
            txtuid.ReadOnly = true;

        }
        else
        {
            txtuid.Text = "1001";
            txtuid.ReadOnly = true;
        }
        con.Close();
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da2 = new SqlDataAdapter("Select * from login where username='" + txtusername.Text + "'", con);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);

        if (ds2.Tables[0].Rows.Count == 0)
        {
            lblusername.Text = "Username Available";
        }
        else
        {
            lblusername.Text = "Username Not Available";
        }

        if (lblusername.Text == "Username Available")
        {
            txtpassword.Enabled = true;
        }
        else if (lblusername.Text == "Username Not Available")
        {
            txtpassword.Enabled = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (txtfname.Text != "")
        {
            if (txtmname.Text != "")
            {
                if (txtlname.Text != "")
                {
                    if (txtemail.Text != "")
                    {
                        if (txtcontact.Text != "")
                        {
                            if (txtusername.Text != "")
                            {
                                if (txtpassword.Text != "")
                                {

                                    if (lblusername.Text == "Username Available")
                                    {
                                        try
                                        {
                                            con.Open();
                                            SqlCommand cmd = new SqlCommand("Insert into Login values('" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txtemail.Text + "','" + txtcontact.Text + "','" + txtcity.Text + "','" + txtaddress.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + Convert.ToInt32(txtuid.Text) + "','" + DropDownList1.SelectedItem.Value + "')", con);
                                            cmd.ExecuteNonQuery();
                                            con.Close();
                                            String alertmsg = "Thank You for Registering";
                                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);

                                            Response.Redirect("Login.aspx");
                                        }
                                        catch (FormatException exx)
                                        {
                                            
                                            SqlCommand cmd = new SqlCommand("Insert into Login values('" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txtemail.Text + "','" + txtcontact.Text + "','" + txtcity.Text + "','" + txtaddress.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','0','" + DropDownList1.SelectedItem.Value + "')", con);
                                            cmd.ExecuteNonQuery();
                                            con.Close();
                                            String alertmsg = "Thank You for Registering";
                                            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);

                                            Response.Redirect("Login.aspx");
                                        }
                                    }
                                    else
                                    {
                                        String alertmsg = "Enter valid username";
                                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);

                                    }
                                }
                                else
                                { Label1.Visible = true; }
                            }
                            else
                            { Label1.Visible = true; }
                        }
                        else
                        { Label1.Visible = true; }
                    }
                    else
                    { Label1.Visible = true; }
                }
                else
                { Label1.Visible = true; }
            }
            else
            { Label1.Visible = true; }
        }
        else
        { Label1.Visible = true; }
    }
}