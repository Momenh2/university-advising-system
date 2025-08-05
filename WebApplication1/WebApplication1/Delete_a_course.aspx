<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete_a_course.aspx.cs" Inherits="WebApplication1.Delete_a_course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div><br />
<br />
course ID: <br />
 
<asp:TextBox ID="courseId" runat="server"></asp:TextBox>
<br />
<br />
<br />
<asp:Button ID="delete" runat="server" OnClick="Delete_a_Course" Text="Delete" />
<br />
<br />
<br />
<asp:Button ID="GoBack" runat="server" OnClick="Go_Back" Text="Go Back" />
    </form>
</body>
</html>
