<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="trust1.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Transaction Details</p>
<p>
    Transaction Date :<asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
</p>
<p>
    Quantity&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
</asp:Content>
