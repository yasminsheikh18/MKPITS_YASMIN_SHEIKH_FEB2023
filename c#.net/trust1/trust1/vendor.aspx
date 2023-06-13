<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="vendor.aspx.cs" Inherits="trust1.vendor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Vendor Master</p>
    <p>
        VendorId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
<p>
    VendorName :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</p>
    <p>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Load" />
</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
&nbsp;
    <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
&nbsp;
    <asp:Button ID="Button4" runat="server" Text="Search" OnClick="Button4_Click" />
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
</p>
</asp:Content>
