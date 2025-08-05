<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Student.aspx.cs" Inherits="WebApplication1.Login_Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><div>
</div>
User ID:<p>
    <asp:TextBox ID="UserID" runat="server"></asp:TextBox>
</p>
Password:<p>
    <asp:TextBox ID="Password" runat="server"></asp:TextBox>
</p>
<asp:Button ID="signin" runat="server" Text="Login" OnClick="signin_Click" />
<asp:Button ID="Register" runat="server" Text="Register" OnClick="Register_Click" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Go back" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
