<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_a_student_status.aspx.cs" Inherits="WebApplication1.Update_a_student_status" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <br />
            <br />
            Student Id:
            <br />
            <asp:TextBox ID="Student_id" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="update" runat="server" OnClick="UpdateSatus" Text="Update The Status" Width="140px" />
            <br />
            <br />
            <br />
            <asp:Button ID="GoBack" runat="server" OnClick="Go_Back" Text="Go Back" />
        </div>
    </form>
</body>
</html>
