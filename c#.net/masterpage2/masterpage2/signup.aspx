<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="masterpage2.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            text-decoration: underline;
        }
        .auto-style5 {
            width: 100%;
            border-collapse: collapse;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style7 {
            width: 226px;
            text-align: left;
        }
        .auto-style8 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1">
        <span class="auto-style4"><strong>Signup Please<br />
        <br />
        </strong></span>
        <table class="auto-style5">
            <tr>
                <td class="auto-style7">UserName</td>
                <span class="auto-style4">
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox1" runat="server" Width="516px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Password</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="511px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Email</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox3" runat="server" Width="507px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Mobile Number</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox4" runat="server" MaxLength="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="Button1" runat="server" Text="Rigester" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">Status:</td>
            </tr>
        </table>
        </span>
        <br />
    </div>
</asp:Content>
