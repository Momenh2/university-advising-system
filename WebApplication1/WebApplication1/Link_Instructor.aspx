<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Link_Instructor.aspx.cs" Inherits="WebApplication1.Link_Instructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Link instructor to course on specific slot<br />
            <br />
            Course-ID:<br />
            <asp:TextBox ID="CID" runat="server"></asp:TextBox>
            <br />
            <br />
            Instructor-ID:<br />
            <asp:TextBox ID="IID" runat="server"></asp:TextBox>
            <br />
            <br />
            Slot-ID:<br />
            <asp:TextBox ID="SID" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Button ID="link" runat="server" Text="LINK" OnClick="link_Click" />
        <p>
            <asp:Button ID="Button1" runat="server" Text="Go back to main page" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
