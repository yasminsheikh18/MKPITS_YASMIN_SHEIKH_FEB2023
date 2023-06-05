<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="template2.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 50%;
            border-collapse: collapse;
            border-style: solid;
            border-width: 2px;
        }
        .auto-style3 {
            text-align: left;
            width: 170px;
        }
        .auto-style4 {
            width: 170px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 align="center"> sign up form 
        <br />
        <br />
        <table class="auto-style2" align="center">
        <table class="auto-style2" align="center">
            <tr>
                <td class="auto-style3">Name</td>
                <td class="text-left">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td class="text-left">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
      
    </h1>
</asp:Content>
