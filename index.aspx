<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Project1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="MyStyles.css" rel="stylesheet" />

    <title>EZ Pay Cheque Creator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>EZ Pay Cheque Creator</h1>
    </div>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblNumHoursWorked" runat="server" Text="Number of Hours Worked"></asp:Label>
        <asp:TextBox ID="txtNumHoursWorked" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblHourlyRate" runat="server" Text="Hourly Rate of Pay"></asp:Label>
        <asp:TextBox ID="txtHourlyRate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnGetPayCheque" runat="server" Text="Generate My Paycheque" OnClick="btnGetPayCheque_Click" OnClientClick ="showDiv()"/>
        <br />
        <br />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div id ="hiddendiv">
            <h2>Your Pay Cheque for the Month</h2>
            <div class = "on_left">
                <p>Employee:</p>
                <p>Total Number of Hours Worked:</p>
                <p>Number of OT Hours Worked:</p>
                <p>Value of Regular Pay:</p>
                <p>Value of Overtime Pay:</p>
                <p>Hourly Pay:</p>
                <p>Gross Pay:</p>
                <p>Tax Deducted:</p>
                <p>Net Pay:</p>
            </div>
            <asp:TextBox ID="txtOutput" runat="server" Visible="False" TextMode="MultiLine" Height="376px" Width="516px" style="margin-left: 36px; margin-top: 25px"></asp:TextBox>


        </div>
        <br />
        <br />
    </form>

    <script type="text/javascript">
        function showDiv() {
            document.getElementById('hiddendiv').style.visibility = "visible";
        }
     </script>

</body>
</html>
