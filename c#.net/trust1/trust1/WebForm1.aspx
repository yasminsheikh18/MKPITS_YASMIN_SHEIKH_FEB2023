<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="trust1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        margin-left: 117px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    Product Details</p>
<asp:Panel ID="Panel1" runat="server" CssClass="auto-style2" Height="626px" Width="667px">
    <br />
    Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Electronics</asp:ListItem>
        <asp:ListItem>Consumable</asp:ListItem>
        <asp:ListItem>Furtinure</asp:ListItem>
        <asp:ListItem>Sationary</asp:ListItem>
        <asp:ListItem></asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    ItemName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <br />
    Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    Rate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" Text="Serch" OnClick="Button4_Click" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Button" />
</asp:Panel>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
