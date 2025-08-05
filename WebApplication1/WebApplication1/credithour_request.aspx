<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="credithour_request.aspx.cs" Inherits="WebApplication1.credithour_request" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div><div>
</div>
Student ID:<p>
    <asp:TextBox ID="StudentID" runat="server"></asp:TextBox>
</p>
Credit Hours:<p>
    <asp:TextBox ID="CreditHours" runat="server"></asp:TextBox>
</p>
<p>
    Type:</p>
<p>
    <asp:TextBox ID="Type" runat="server"></asp:TextBox>
</p>
<p>
    Comment:</p>
<p>
    <asp:TextBox ID="Comment" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" Text="Send Request" OnClick="Button1_Click" />
</p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Go back" OnClick="Button2_Click" />
</p>

    </form>
</body>
</html>
