<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_makeup_exam.aspx.cs" Inherits="WebApplication1.Add_makeup_exam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><br />
Type:
<br />
<asp:TextBox ID="Type" runat="server"></asp:TextBox>
<br />
<br />
Date:
<br />
<asp:TextBox ID="dateTime" runat="server"></asp:TextBox>
<br />
<br />
Course ID:
<br />
<asp:TextBox ID="course_id" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="Adding_button" runat="server" OnClick="AddExam" Text="Add" />
<br />
<br />
<br />
<asp:Button ID="GoBack" runat="server" OnClick="Go_Back" Text="Go Back" />

        </div>
    </form>
</body>
</html>
