<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleInterest.aspx.cs" Inherits="Lab3Examples.SimpleInterest" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Interest Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Principal: <asp:TextBox ID="txtPrincipal" runat="server" /><br />
            Rate: <asp:TextBox ID="txtRate" runat="server" /><br />
            Time: <asp:TextBox ID="txtTime" runat="server" /><br />
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" /><br />
            <asp:Label ID="lblResult" runat="server" />
        </div>
    </form>
</body>
</html> 