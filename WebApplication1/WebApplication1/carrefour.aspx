<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="carrefour.aspx.cs" Inherits="WebApplication1.carrefour" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div><div>
    Add a phone number:</div>
<asp:TextBox ID="PhoneNumber" runat="server"></asp:TextBox>
<br />
<asp:Label ID="Label1" runat="server" Text="Semester Code:"></asp:Label>
<p>
    <asp:TextBox ID="semestercode" runat="server"></asp:TextBox>
</p>
        <p>
            <asp:Button ID="Button8" runat="server" Text="Add phone Number" OnClick="Button8_Click" />
</p>
<p>
<asp:Button ID="Button1" runat="server" Text="Optional courses" OnClick="Button1_Click" Width="220px" />
</p>
<p>
    <asp:Button ID="Button2" runat="server" Text="Available courses" OnClick="Button2_Click" Width="220px" />
</p>
<p>
    <asp:Button ID="Button3" runat="server" Text="Required courses" Width="220px" OnClick="Button3_Click" />
</p>
<p>
<asp:Button ID="Button4" runat="server" Text="Missing courses" Width="220px" OnClick="Button4_Click" />
</p>
<p>
    <asp:Button ID="Button5" runat="server" Text="Course Request" Width="220px" OnClick="Button5_Click" />
</p>
<p>
    <asp:Button ID="Button6" runat="server" Text="Credit hour request" Width="220px" OnClick="Button6_Click" />
</p>
        <p>
            <asp:Button ID="Button7" runat="server" Text="Go back" OnClick="Button7_Click" />
</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button9" runat="server" Text="Go to next page (Student part2)" OnClick="Button9_Click" />
</p>

    </form>
</body>
</html>
