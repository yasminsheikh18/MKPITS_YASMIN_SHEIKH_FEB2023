<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="usermanagement.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type =" text/javascript" language="javascript">
        function alert_meth()
        {
        alert("client side message box");
        }

        function confirm_meth()
        {
         if(confirm("Do you want to continue 'yes'")== true)
        {
        document.writeln("<b> you had click on 'Yes' Button </b>");
        }
        else
        {
        document.writeln("<b> you had click on 'No' Button </b>");
        
        }
        }

        </script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button OnClientClick ="alert_meth() " ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
        </div>
        <asp:Button OnClientClick="confirm_meth()" ID="Button2" runat="server" OnClick="Button2_Click" Text="Button"  />
    </form>
</body>
</html>
