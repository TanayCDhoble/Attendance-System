<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PaymentForm.aspx.cs" Inherits="Attendance.PaymentForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link href="CSSFolder/PaymentCSS.css" rel="stylesheet" />
    <table>
        
        <tr>
            <td colspan="2" style="height: 131px">
                <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="Payments" ForeColor="#33CCCC"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Font-Size="Larger" Text="Student Name" ForeColor="#33CCCC"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownname" runat="server" Height="22px" style="margin-left: 0px" Width="172px" OnSelectedIndexChanged="DropDownname_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Font-Size="Larger" Text="Payment" ForeColor="#33CCCC"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtpayment" runat="server" Height="21px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Labelfees" runat="server" Text="Fees" ForeColor="#33CCFF"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Font-Size="Larger" Text="Balance" ForeColor="#33CCCC"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtbalance" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" ForeColor="#00CCFF" Height="33px" Text="Calculate" Width="103px" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Font-Size="Larger" Text="Date" ForeColor="#33CCCC"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtdate" runat="server" style="margin-left: 0px" Width="156px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnsubmit" runat="server" Height="36px" Text="Submit" Width="107px" ForeColor="#00CCFF" OnClick="btnsubmit_Click" />
            </td>
            <td>
                <asp:Button ID="btnclear" runat="server" Height="36px" Text="Clear" Width="107px" ForeColor="#00CCFF" OnClick="btnclear_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
