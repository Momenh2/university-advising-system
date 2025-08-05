<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Course.aspx.cs" Inherits="WebApplication1.Add_Course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ADD A COURSE<br />
            <br />
            MAJOR:<br />
            <asp:TextBox ID="major" runat="server"></asp:TextBox>
            <br />
            <br />
            SEMESTER # :<br />
            <asp:TextBox ID="semester" runat="server"></asp:TextBox>
            <br />
            <br />
            CREDIT HOURS:<br />
            <asp:TextBox ID="credit_hours" runat="server"></asp:TextBox>
            <br />
            <br />
            NAME:<br />
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            <br />
            IS OFFERED? YES---&gt;1 , NO---&gt;0:<br />
            <asp:TextBox ID="is_offered" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addcourse" runat="server" Text="ADD" OnClick="addcourse_Click" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Go back to main page" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>
