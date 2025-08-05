<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2admin.aspx.cs" Inherits="WebApplication1.page2admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            login success, choose whatever you want<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text=" List all advisors" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="List all students with their corresponding advisors in the system" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="List all pending requests" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text=" Add a new semester" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="ADD a new course" OnClick="Button5_Click" />
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Link Instructor" OnClick="Button6_Click" />
            <br />
            <br />
            <asp:Button ID="Button7" runat="server" Text="Link student to course and instructor" OnClick="Button7_Click" />
            <br />
            <br />
            <asp:Button ID="Button8" runat="server" Text="Link student to advisor" OnClick="Button8_Click" />
            <br />
            <br />
            <asp:Button ID="Button9" runat="server" Text="all details of instructors along with their assigned courses" OnClick="Button9_Click" />
            <br />
            <br />
            <asp:Button ID="Button10" runat="server" Text="all semesters along with their offered courses" OnClick="Button10_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button11" runat="server" Text="admin next page(part2)" OnClick="Button11_Click" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button12" runat="server" Text="back to login page" OnClick="Button12_Click" />
        </div>
    </form>
</body>
</html>
