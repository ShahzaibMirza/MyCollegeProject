<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="Comment.aspx.cs" Inherits="Comment" %>
<asp:Content ID="head" ContentPlaceHolderID="HeadContent" runat="server">
    <script type="text/javascript" src="JScript.js"></script>
<script src="JScript2.js" type="text/javascript"></script>
<link href="JScript3.js"
    rel="stylesheet" type="text/css" />


</asp:Content>
<asp:Content ID="body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>


    <br />
   <b><h1>Product Details</h1></b>
    <br />
    <br />
    <table border="1" width="80%">
    <tr>
    <td class="style1"><h2>Product Name :</h2></td>
    <td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td colspan="2"><center><asp:Image ID="Image1" runat="server" /></center>
        <br />
        <br />
       <center> <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></center>
        </td>
    
        </tr>
    <tr>
    <td class="style1"><h2>Description:</h2></td>
     <td><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
    </tr>
    <tr>
    <td colspan="2"> 
        <br />
        <center>&nbsp;<asp:Button ID="Button2" runat="server" 
                onclick="Button2_Click" Text="Buy" />
        </center>
                <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
        <br />
        <asp:Panel ID="Panel1" runat="server"><center>
            <asp:Label ID="Label6" runat="server" Text="Enter Quantity :-"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                Text="Add To Cart" /></center>
        </asp:Panel>
        </td>
     
    </tr>
    
    </table>

    
   
</div>

</asp:Content>
