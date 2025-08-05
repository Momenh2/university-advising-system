<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="approve-l.aspx.cs" Inherits="WebApplication1.approve_l" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Approve/Reject courses request<br />
            Request ID:<br />
            <asp:TextBox ID="RID" runat="server"></asp:TextBox>
            <br />
            Current Semcode:<br />
            <asp:TextBox ID="SCode" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="pend" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Back" OnClick="Button2_Click" style="height: 29px" />
        </div>
    </form>
</body>
</html>
