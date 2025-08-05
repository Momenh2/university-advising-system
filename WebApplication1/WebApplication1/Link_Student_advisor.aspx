<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Link_Student_advisor.aspx.cs" Inherits="WebApplication1.Link_Student_advisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Link Student to Advisor<br />
            <br />
            StudentID:<br />
            <asp:TextBox ID="SID" runat="server"></asp:TextBox>
            <br />
            <br />
            AdvisorID:<br />
            <asp:TextBox ID="AID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Link" OnClick="Button1_Click" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Back to main page" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
