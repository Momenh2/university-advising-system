<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_a.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            please login<br />
            username:</div>
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
        <br />
        password:<p>
            <asp:TextBox ID="password" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="signin" runat="server" OnClick="Login" Text="login" />
            &nbsp;
            <asp:Button ID="Button1" runat="server" Text="register" OnClick="Button1_Click1" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" Text="Go back" OnClick="Button2_Click" />
    </form>
</body>
</html>