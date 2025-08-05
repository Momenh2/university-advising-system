<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register_a.aspx.cs" Inherits="WebApplication1.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Your data:-<br />
            Name:<br />
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            Password:<br />
            <asp:TextBox ID="pass" runat="server"></asp:TextBox>
            <br />
            Email:<br />
            <asp:TextBox ID="mail" runat="server"></asp:TextBox>
            <br />
            Office:<br />
            <asp:TextBox ID="off" runat="server"></asp:TextBox>
            <br />
    <asp:Button ID="signin" runat="server" OnClick="regist" Text="Register" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="signin0" runat="server" OnClick="back" Text="Back" />
        </div>
    </form>
</body>
</html>
