<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert-d.aspx.cs" Inherits="WebApplication1.insert_d" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Insert graduation plan for a certain student:<br />
            Semester code:<br />
            <asp:TextBox ID="semcode" runat="server" Width="191px"></asp:TextBox>
            <br />
            expected graduation date:<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            semester credit hours:<br />
            <asp:TextBox ID="credit" runat="server" Width="191px"></asp:TextBox>
            <br />
            student id:<br />
            <asp:TextBox ID="studid" runat="server" Width="191px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
        </div>
    </form>
</body>
</html>
