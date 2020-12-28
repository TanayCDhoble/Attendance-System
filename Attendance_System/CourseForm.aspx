<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CourseForm.aspx.cs" Inherits="Attendance.CourseForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link href="CSSFolder/CourseCSS.css" rel="stylesheet" />
    <table>
        <tr>
            <td colspan="3">
               <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" Height="58px" Text="Courses" Width="333px" ForeColor="#990033"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Font-Size="Larger" Text="Course ID" ForeColor="#CC0000" Font-Bold="False" Font-Italic="False"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcourseid" runat="server" Height="37px" Width="106px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnsearchcourseid" runat="server" ForeColor="#CC0000" Height="35px" Text="Search" Width="141px" OnClick="btnsearchcourseid_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Font-Size="Larger" Text="Course Name" ForeColor="#CC0000"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtcoursename" runat="server" Height="45px" Width="236px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator">Incorrect</asp:RequiredFieldValidator>
            </td>
            
        </tr>
        <tr>
            <td style="height: 94px">
                <asp:Label ID="Label6" runat="server" Font-Size="Larger" Text="Fees" ForeColor="#CC0000"></asp:Label>
            </td>
            <td style="height: 94px">
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtcoursefees" runat="server" Height="45px" Width="236px"></asp:TextBox>
            </td>
            <td style="height: 94px">
                </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnaddcourse" runat="server" ForeColor="#CC0000" Height="35px" OnClick="btnaddcourse_Click" Text="Add" Width="141px" />
            </td>
            <td>
                <asp:Button ID="btnchangecourse" runat="server" ForeColor="#CC0000" Height="35px" Text="Change" Width="141px" OnClick="btnchangecourse_Click" />
            </td>
            <td>
                <asp:Button ID="btnclear" runat="server" ForeColor="#CC0000" Height="35px" Text="Clear" Width="141px" OnClick="btnclear_Click" />
            </td>
        </tr>
        </table>
</asp:Content>
