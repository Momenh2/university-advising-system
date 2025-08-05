<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Semester.aspx.cs" Inherits="WebApplication1.Add_Semester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ADD A SEMESTER<br />
            <br />
            START DATE:<br />
            <asp:TextBox ID="Start_Date" runat="server"></asp:TextBox>
            <br />
            <br />
            END_DATE:<br />
            <asp:TextBox ID="End_Date" runat="server"></asp:TextBox>
            <br />
            <br />
            SEMESTER CODE:<br />
            <asp:TextBox ID="Semester_code" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ADD" runat="server" Text="ADD" OnClick="ADD_Click" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Back to main page" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>
