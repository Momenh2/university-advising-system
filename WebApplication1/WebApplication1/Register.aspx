<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div><div>
</div>
First Name:<p>
    <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
</p>
<p>
    Last Name:</p>
<p>
    <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
</p>
<p>
    Password:</p>
<asp:TextBox ID="Password" runat="server"></asp:TextBox>
<br />
<br />
Faculty:<p>
    <asp:TextBox ID="Faculty" runat="server"></asp:TextBox>
</p>
<p>
    Email:</p>
<p>
    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
</p>
Major:<br />
<br />
<asp:TextBox ID="Major" runat="server"></asp:TextBox>
<br />
<br />
Semester:<br />
<br />
<asp:TextBox ID="Semester" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="reg" runat="server" Text="Register" OnClick="reg_Click" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Go back to login" OnClick="Button1_Click" />
    </form>
</body>
</html>
