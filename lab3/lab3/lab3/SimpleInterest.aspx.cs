<%@ Page Language="C#" %>
<!DOCTYPE html>
<html>
<head>
    <title>Simple Interest Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Simple Interest Calculator</h2>
            Principal: <asp:TextBox ID="txtPrincipal" runat="server"></asp:TextBox><br />
            Rate: <asp:TextBox ID="txtRate" runat="server"></asp:TextBox><br />
            Time (years): <asp:TextBox ID="txtTime" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" /><br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
<script runat="server">
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        if (double.TryParse(txtPrincipal.Text, out double principal) &&
            double.TryParse(txtRate.Text, out double rate) &&
            double.TryParse(txtTime.Text, out double time))
        {
            double si = (principal * rate * time) / 100;
            lblResult.Text = $"Simple Interest: {si}";
        }
        else
        {
            lblResult.Text = "Please enter valid numbers.";
        }
    }
</script>