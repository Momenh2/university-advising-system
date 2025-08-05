<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="All_Instructors_courses.aspx.cs" Inherits="WebApplication1.All_Instructors_courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div><asp:Button ID="Button1" runat="server" OnClick="back_to_main_page" Text="Back to main page" style="height: 29px" />
 <br />
 <br />
 <asp:GridView ID="YourGridView" runat="server" AutoGenerateColumns="true">
 </asp:GridView>
    </form>
</body>
</html>
