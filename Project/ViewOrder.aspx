<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/MasterPage.master" CodeFile="ViewOrder.aspx.cs" Inherits="ViewOrder" %>

<asp:Content ID="body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>


    <asp:Label ID="Label1" runat="server" style="font-weight: 700" 
        Text="View Order"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" BackColor="White" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
        ForeColor="Black" GridLines="Vertical" Width="80%" 
        AutoGenerateColumns="False">
           <Columns>
                <asp:BoundField HeaderText="User ID" DataField="uid"/>
                <asp:BoundField HeaderText="Items" DataField="items"/>
                <asp:BoundField HeaderText="Quantity" DataField="quantity" />
                <asp:BoundField HeaderText="Cost" DataField="cost" />
                <asp:BoundField HeaderText="Total" DataField="Total" />
                <asp:BoundField HeaderText="Mode of Payment" DataField="modeofpayment" />
                 <asp:BoundField HeaderText="Date" DataField="date" />
                </Columns>
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
       
    </asp:GridView>
  

</div>




</asp:Content>
