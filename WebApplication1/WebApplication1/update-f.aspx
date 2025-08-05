<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update-f.aspx.cs" Inherits="WebApplication1.update_f" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Update expected graduation date in a certain graduation plan:-<asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            Student ID:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="update" />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="back" />
        </div>
    </form>
</body>
</html>