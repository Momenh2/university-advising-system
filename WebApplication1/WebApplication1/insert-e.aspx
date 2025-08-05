<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert-e.aspx.cs" Inherits="WebApplication1.insert_e" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Insert courses for a specific graduation plan.<br />
        Student id:<br />
        <asp:TextBox ID="id" runat="server"></asp:TextBox>
        <br />
        Smester Code:<br />
        <asp:TextBox ID="code" runat="server"></asp:TextBox>
        <br />
        Course name:<br />
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
        <div>
        </div>
    </form>
</body>
</html>
