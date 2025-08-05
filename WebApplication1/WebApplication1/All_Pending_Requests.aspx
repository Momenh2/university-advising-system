<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="All_Pending_Requests.aspx.cs" Inherits="WebApplication1.All_Pending_Requests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ALL PENDING REQUESTS:</div><asp:Button ID="Button1" runat="server" OnClick="back_to_main_page" Text="back to main page" />
 <br />
 <br />
 <asp:GridView ID="YourGridView" runat="server" AutoGenerateColumns="true">
 </asp:GridView>
    </form>
</body>
</html>
