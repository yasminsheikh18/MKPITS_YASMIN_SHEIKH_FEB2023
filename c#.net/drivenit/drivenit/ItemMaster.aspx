<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemMaster.aspx.cs" Inherits="drivenit.ItemMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    ItemMaster Details</p>
<p>
    Item Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</p>
<p>
&nbsp;Item Description :
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    Balance quantity :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    CreatedOn&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
&nbsp;</p>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="Button2_Click" />
&nbsp;
    <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
&nbsp;</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <br />
</p>
<p>
</p>
<p>
</p>
</asp:Content>
