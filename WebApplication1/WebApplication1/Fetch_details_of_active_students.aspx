<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fetch_details_of_active_students.aspx.cs" Inherits="WebApplication1.Fetch_details_of_active_students" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div><asp:Button ID="Button1" runat="server" OnClick="View_Students" Text="View Students" />
<br />
<br />
<asp:GridView ID="YourGridView" runat="server" AutoGenerateColumns="true">
</asp:GridView>

<br />
<br />
<br />
<asp:Button ID="GoBack" runat="server" OnClick="Go_Back" Text="Go Back" />
    </form>
</body>
</html>
