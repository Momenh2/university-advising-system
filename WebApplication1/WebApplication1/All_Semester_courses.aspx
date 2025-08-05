<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="All_Semester_courses.aspx.cs" Inherits="WebApplication1.All_Semester_courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Back to main page" OnClick="Button1_Click" />
        <div>
        </div> <br />
 <br />
 <asp:GridView ID="YourGridView" runat="server" AutoGenerateColumns="true">
 </asp:GridView>
    </form>
</body>
</html>
