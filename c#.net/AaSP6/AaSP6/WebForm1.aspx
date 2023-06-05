<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AaSP6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
            border-collapse: collapse;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style3 {
            width: 191px;
        }
        .auto-style5 {
            width: 191px;
            height: 29px;
        }
        .auto-style6 {
            height: 29px;
        }
        .auto-style7 {
            width: 191px;
            text-align: left;
        }
        .auto-style8 {
            width: 191px;
            height: 29px;
            text-align: left;
        }
        .auto-style9 {
            text-align: left;
        }
        .auto-style10 {
            height: 29px;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Account Details<br />
            <br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style7">Account No</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">Amount</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Type</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style7">Result</td>
                    <td class="auto-style9">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
