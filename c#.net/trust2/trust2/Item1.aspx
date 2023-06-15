<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Item1.aspx.cs" Inherits="trust2.Item1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Item Details</p>
    <p>
        Item Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Electronics</asp:ListItem>
            <asp:ListItem>stationary</asp:ListItem>
            <asp:ListItem>Consumable</asp:ListItem>
            <asp:ListItem>Furniture</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Rate&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Balance Quantity&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Insert" />
&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Modify" />
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Delete" />
&nbsp;
        <asp:Button ID="Button4" runat="server" Text="serach" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
