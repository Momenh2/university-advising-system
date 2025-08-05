<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view-j.aspx.cs" Inherits="WebApplication1.view_j" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View pending requests of specific advisor students<asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" style="height: 29px" />
        </div>
    </form>
</body>
</html>