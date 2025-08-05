<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="WebApplication1.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Delete course from certain graduation plan in certain semester:<br />
            Student ID<br />
            <asp:TextBox ID="SID" runat="server"></asp:TextBox>
            <br />
            Sem Code<br />
            <asp:TextBox ID="Code" runat="server"></asp:TextBox>
            <br />
            Course ID<br />
            <asp:TextBox ID="CID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
