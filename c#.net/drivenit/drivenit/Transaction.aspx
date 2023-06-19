<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="drivenit.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Transaction Form</p>
<p>
    Item id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="ItemDescr" DataValueField="ItemID">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:drivenitdbConnectionString %>" SelectCommand="SELECT [ItemID], [ItemDescr] FROM [ItemMaster]"></asp:SqlDataSource>
</p>
<p>
    Transaction Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="tt" Text="Issue" />
&nbsp;
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="tt" Text="Recieved" />
</p>
<p>
    Transaction quantity&nbsp;&nbsp; :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    Transaction Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="Button2_Click" />
&nbsp;
    <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TransID" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="TransID" HeaderText="TransID" InsertVisible="False" ReadOnly="True" SortExpression="TransID" />
            <asp:BoundField DataField="ItemID" HeaderText="ItemID" SortExpression="ItemID" />
            <asp:BoundField DataField="TransType" HeaderText="TransType" SortExpression="TransType" />
            <asp:BoundField DataField="TransQty" HeaderText="TransQty" SortExpression="TransQty" />
            <asp:BoundField DataField="TransDate" HeaderText="TransDate" SortExpression="TransDate" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:drivenitdbConnectionString %>" DeleteCommand="DELETE FROM [Transactions] WHERE [TransID] = @TransID" InsertCommand="INSERT INTO [Transactions] ([ItemID], [TransType], [TransQty], [TransDate]) VALUES (@ItemID, @TransType, @TransQty, @TransDate)" ProviderName="<%$ ConnectionStrings:drivenitdbConnectionString.ProviderName %>" SelectCommand="SELECT [TransID], [ItemID], [TransType], [TransQty], [TransDate] FROM [Transactions]" UpdateCommand="UPDATE [Transactions] SET [ItemID] = @ItemID, [TransType] = @TransType, [TransQty] = @TransQty, [TransDate] = @TransDate WHERE [TransID] = @TransID">
        <DeleteParameters>
            <asp:Parameter Name="TransID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ItemID" Type="Int32" />
            <asp:Parameter Name="TransType" Type="String" />
            <asp:Parameter Name="TransQty" Type="Int32" />
            <asp:Parameter Name="TransDate" Type="DateTime" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ItemID" Type="Int32" />
            <asp:Parameter Name="TransType" Type="String" />
            <asp:Parameter Name="TransQty" Type="Int32" />
            <asp:Parameter Name="TransDate" Type="DateTime" />
            <asp:Parameter Name="TransID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
<p>
    &nbsp;</p>
</asp:Content>
