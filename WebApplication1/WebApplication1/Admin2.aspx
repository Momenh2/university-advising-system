<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin2.aspx.cs" Inherits="WebApplication1.Admin2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div><asp:Button ID="A" runat="server" OnClick="Delete_a_course" Text="Delete a course along with its related slots" />
            <br />
            <br />
            <asp:Button ID="B" runat="server" OnClick="Delete_a_slot" Text="Delete a slot of a certain course if the course isn’t offered in the current semester" />
            <br />
            <br />
            <asp:Button ID="C" runat="server" OnClick="Add_makeup_exam" Text="Add makeup exam for a certain course" />
            <br />
            <br />
            <asp:Button ID="D" runat="server" OnClick="View_for_payments" Text="View details for all payments along with their corresponding students" />
            <br />
            <br />
            <asp:Button ID="E" runat="server" OnClick="Issue_installments" Text="Issue installments as per the number of installments for a certain payment" />
            <br />
            <br />
            <asp:Button ID="F" runat="server" OnClick="Update_a_student_status" Text="Update a student status based on his/her financial status" />
            <br />
            <br />
            <asp:Button ID="G" runat="server" OnClick="Fetch_details_of_active_students" Text="Fetch all details of active students" />
            <br />
            <br />
            <asp:Button ID="H" runat="server" OnClick="View_all_graduation_plans" Text="View all graduation plans along with their initiated advisors" />
            <br />
            <br />
            <asp:Button ID="I" runat="server" OnClick="View_all_students_transcript" Text="View all students transcript details" />
            <br />
            <br />
            <asp:Button ID="J" runat="server" OnClick="Fetch_semesters" Text="Fetch all semesters along with their offered courses" />


        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Go back " OnClick="Button1_Click" />


    </form>
</body>
</html>
