<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advisor.aspx.cs" Inherits="WebApplication1.advisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head><body>
    <form id="form1" runat="server">
        <p>
    <asp:Button ID="Button2" runat="server" OnClick="c" Text="View all advising students" />
</p><p>
    <asp:Button ID="Button3" runat="server" OnClick="d" Text="Insert graduation plan for a certain student" />
</p><p>
    <asp:Button ID="Button4" runat="server" OnClick="e" Text="Insert courses for a specific graduation plan" />
</p><p>
    <asp:Button ID="Button5" runat="server" OnClick="f" Text="Update expected graduation date in a certain graduation plan" />
</p><p>
    <asp:Button ID="Button6" runat="server" OnClick="g" Text="Delete course from a certain graduation plan in a certain semester" />
</p><p>
    <asp:Button ID="Button7" runat="server" OnClick="h" Text="View all students assigned to him/her from a certain major along with their taken courses" />
</p><p>
    <asp:Button ID="Button8" runat="server" OnClick="i" Text="View all requests" />
</p><p>
    <asp:Button ID="Button9" runat="server" OnClick="j" Text="View all pending requests" />
</p><p>
    <asp:Button ID="Button10" runat="server" OnClick="k" Text="Approve/ reject extra credit hours request" />
</p><p>
    <asp:Button ID="Button11" runat="server" OnClick="l" Text="Approve/ reject extra courses request" />
</p>
        <p>
    <asp:Button ID="Button12" runat="server" OnClick="back" Text="Back" />
        </p>
    </form>
</body>
</html>
