<%@ Page Title="" Language="C#"  MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AttendanceForm.aspx.cs" Inherits="Attendance.AttendanceForm" %>
<asp:Content ID="Content1"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="CSSFolder/AttendanceCSS.css" rel="stylesheet" />
    <table>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server" Font-Size="XX-Large" Text="Attendance Entry" ForeColor="Black"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="labelname" runat="server" Font-Size="Larger" Text="Student Name" ForeColor="Black"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="45px" Width="138px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-bottom: 0px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="height: 94px">
                <asp:Label ID="labelname0" runat="server" Font-Size="Larger" Text="Presenty" ForeColor="Black"></asp:Label>
            </td>
            <td style="height: 94px">
                <asp:DropDownList ID="DropDownList2" runat="server" Height="45px" Width="138px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    <asp:ListItem>Present</asp:ListItem>
                    <asp:ListItem>Leave</asp:ListItem>
                    <asp:ListItem>Absent</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                
    <asp:Calendar ID="Calendar1" runat="server" ShowDayHeader="False" ShowNextPrevMonth="False" BackColor="White" BorderColor="White" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="16px" NextPrevFormat="FullMonth" style="margin-top: 1px" Width="352px" BorderWidth="1px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="Lime" CssClass="NotSet" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" BorderColor="Black" BorderWidth="4px" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
   
                </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btndetail" runat="server" Height="38px" OnClick="btndetail_Click" Text="Detail" Width="90px" ForeColor="Black" />
            </td>
            <td>
                <asp:Label ID="Labeldetail" runat="server" Font-Bold="True" Text="Detail" ForeColor="Black"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnsubmitattendace" runat="server" Height="35px" Text="Submit" Width="92px" OnClick="btnsubmitattendace_Click" />
            </td>
            <td>
                <asp:Button ID="btnclear" runat="server" Height="35px" Text="Clear" Width="92px" OnClick="btnclear_Click" />
            </td>
        </tr>
    </table>
      
</asp:Content>
