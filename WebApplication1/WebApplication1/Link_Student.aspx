<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Link_Student.aspx.cs" Inherits="WebApplication1.Link_Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Link student to course and instructor<br />
            <br />
            CourseID:<br />
            <asp:TextBox ID="crid" runat="server"></asp:TextBox>
            <br />
            <br />
            InstructorID:<br />
            <asp:TextBox ID="insid" runat="server"></asp:TextBox>
            <br />
            <br />
            StudentID:<br />
            <asp:TextBox ID="stid" runat="server"></asp:TextBox>
            <br />
            <br />
            Semester-Code:<br />
            <asp:TextBox ID="semcode" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Link" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go back to main page" />
        </div>
    </form>
</body>
</html>
