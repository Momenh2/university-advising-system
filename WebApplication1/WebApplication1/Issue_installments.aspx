<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Issue_installments.aspx.cs" Inherits="WebApplication1.Issue_installments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />
            <br />
            Payment ID:
            <br />
            <asp:TextBox ID="payment_id" runat="server" Height="23px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="issue" runat="server" OnClick="PaymetInstallement" Text="Issue Installement" Width="133px" />
            <br />
            <br />
            <br />
            <asp:Button ID="GoBack" runat="server" OnClick="Go_Back" Text="Go Back" Width="132px" />

        </div>
    </form>
</body>
</html>
