<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ADMIN<br />
            <br />
            Please Log in<br />
            <br />
            USERNAME:<br />
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            <br />
            Password:<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="signin" runat="server" OnClick="login" Text="log in" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Go back " OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
