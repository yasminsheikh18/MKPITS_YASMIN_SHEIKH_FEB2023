<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Trust_project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style3 {
            margin-left: 11px;
        }
        .auto-style4 {
            width: 100%;
            border-style: solid;
            border-width: 2px;
        }
        .auto-style6 {
            height: 186px;
        }
        .auto-style7 {
            height: 216px;
        }
        .auto-style8 {
            height: 186px;
            width: 571px;
        }
        .auto-style9 {
            height: 216px;
            width: 571px;
        }
        .auto-style10 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style12 {
            width: 185px;
        }
        .auto-style13 {
            width: 189px;
        }
        .auto-style14 {
            height: 31px;
        }
        .auto-style15 {
            height: 31px;
            width: 147px;
        }
        .auto-style17 {
            width: 147px;
        }
        .auto-style18 {
            width: 100%;
            border-collapse: collapse;
        }
        .auto-style19 {
            width: 184px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            Store Management System Inventory Development</div>
        <p>
            &nbsp;</p>
&nbsp;<asp:Panel ID="Panel2" runat="server" CssClass="auto-style3" Width="1165px" Height="502px">
            <br />
            &nbsp;
            <table class="auto-style4">
                <tr>
                    <td class="auto-style8">Item Entry<br />
                        <table class="auto-style10">
                            <tr>
                                <td class="auto-style12">Item Name</td>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">Category</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">Rate</td>
                                <td>
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">BalanceQuantity</td>
                                <td>
                                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style6">Vendor
                        <br />
                        <table class="auto-style4">
                            <tr>
                                <td class="auto-style15">VendorName</td>
                                <td class="auto-style14">
                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style17">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style17">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style17">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <br />
                        Department
                        <br />
                        <table class="auto-style4">
                            <tr>
                                <td class="auto-style13">DepartmentName</td>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style13">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style13">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style7">Transaction Details<br />
                        <table class="auto-style18">
                            <tr>
                                <td class="auto-style19">TransactionDate</td>
                                <td>
                                    <asp:TextBox ID="TextBox7" runat="server" TextMode="DateTime"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style19">Quantity</td>
                                <td>
                                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Modify" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Delete" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Search" />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
        </asp:Panel>
    </form>
</body>
</html>
