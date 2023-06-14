<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="trust1.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Transaction Details</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="Mode" OnCheckedChanged="RadioButton1_CheckedChanged" Text="issue" />
&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="Mode" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Purchase" />
    </p>
    <p>
        Item Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Item_Name" DataValueField="Item_Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TrustConnectionString %>" ProviderName="<%$ ConnectionStrings:TrustConnectionString.ProviderName %>" SelectCommand="SELECT [Item_Name], [Item_Id] FROM [Item_Master]"></asp:SqlDataSource>
    </p>
<p>
    Transaction Date :<asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
</p>
    <asp:Panel ID="Panel1" runat="server">
        Department Name:<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Department_Name" DataValueField="Department_Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TrustConnectionString %>" SelectCommand="SELECT [Department_Name], [Department_Id] FROM [Department_Master]"></asp:SqlDataSource>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        Vendor Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="Vendor_Name" DataValueField="Vendor_Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:TrustConnectionString %>" SelectCommand="SELECT [Vendor_Id], [Vendor_Name] FROM [Vendor_Master]"></asp:SqlDataSource>
    </asp:Panel>
<p>
    Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="insert" />
&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Update" />
</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
