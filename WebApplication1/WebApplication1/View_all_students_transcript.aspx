<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_all_students_transcript.aspx.cs" Inherits="WebApplication1.View_all_students_transcript" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div><asp:Button ID="Button1" runat="server" OnClick="View_student_trans" Text="View Student Transcript" />
<br />
<br />
<asp:GridView ID="YourGridView" runat="server" AutoGenerateColumns="true">
</asp:GridView>

<br />
<br />
<br />
<asp:Button ID="GoBack" runat="server" OnClick="Go_Back" Text="Go Back" />
    </form>
</body>
</html>
