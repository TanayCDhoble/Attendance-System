<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="Attendance.StudentForm" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">

    </asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
        <link href="CSSFolder/StudentCSS.css" rel="stylesheet" />
    <table>
    
        
        <tr>
            <td colspan="4">
                <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="Student Registration"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 103px">
                <asp:Label ID="Label4" runat="server" Font-Size="Larger" Text="First Name"></asp:Label>
            </td>
            <td style="height: 103px; width: 440px">
                <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
            </td>
            <td style="height: 103px">
                <asp:Label ID="Label3" runat="server" Font-Size="Larger" Text="Last Name"></asp:Label>
            </td>
            <td style="height: 103px; width: 266px;">
                <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 102px">
                <asp:Label ID="Label5" runat="server" Font-Size="Larger" Text="Course Name"></asp:Label>
            </td>
            <td style="width: 440px; height: 102px;">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="88px">
                </asp:DropDownList>
            </td>
            <td style="height: 102px">
                <asp:Label ID="Label6" runat="server" Font-Size="Larger" Text="Fees"></asp:Label>
            </td>
            <td style="height: 102px; width: 266px;">
                <asp:Label ID="labelfees" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtfees" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Font-Size="Larger" Text="Course Type"></asp:Label>
            </td>
            <td style="width: 440px">
                <asp:TextBox ID="txtMH" runat="server" Height="17px" Width="31px"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList2" runat="server" Height="19px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    <asp:ListItem>Month/s</asp:ListItem>
                    <asp:ListItem>Hour/s</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Font-Size="Larger" Text="Date"></asp:Label>
            </td>
            <td style="width: 266px">
                <asp:TextBox ID="txtdate" runat="server" TextMode="DateTime" Width="119px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 118px">
                <asp:Label ID="Label9" runat="server" Font-Size="Larger" Text="Student ID"></asp:Label>
            </td>
            <td style="width: 440px; height: 118px;">
                <asp:TextBox ID="txtID" runat="server" Height="16px" Width="30px"></asp:TextBox>
            </td>
            <td>
               
                <asp:Button ID="Btnsearchh" runat="server" Height="36px" OnClick="Btnsearchh_Click" Text="Search" Width="78px" />
               
            </td>
            <td style="width: 266px; height: 118px"></td>
        </tr>
        <tr>
            <td style="height: 109px">
                <asp:Button ID="Button1" runat="server" Height="43px" Text="Add" Width="91px" OnClick="Button1_Click" />
            </td>
            <td style="width: 440px; height: 109px;">
                <asp:Button ID="Button2" runat="server" Height="43px" Text="Update" Width="91px" OnClick="Button2_Click" />
            </td>
            <td style="height: 109px">
                <asp:Button ID="Button3" runat="server" Height="43px" Text="Clear" Width="91px" OnClick="Button3_Click" />
            </td>
            <td style="width: 266px; height: 109px"></td>
        </tr>
        </table>
    
</asp:Content>
    