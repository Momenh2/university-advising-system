<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete_a_slot.aspx.cs" Inherits="WebApplication1.Delete_a_slot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div><br />
<br />
course semester code:
<br />
<asp:TextBox ID="semester_Code" runat="server"></asp:TextBox>
<br />
<br />

<asp:Button ID="deletebutt" runat="server" OnClick="Delete_a_Slot" Text="Delete" />
<br />
<br />
<br />
<asp:Button ID="GoBack" runat="server" OnClick="Go_Back" Text="Go Back" />
    </form>
</body>
</html>
