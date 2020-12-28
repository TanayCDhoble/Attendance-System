<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Attendance_System.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <link href="CSSFolder/CourseCSS.css" rel="stylesheet" />
        <tr>
            <td colspan="3" style="height: 263px">
                <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Font-Underline="True" ForeColor="#0066CC" Text="Search"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 215px; width: 272px">
                <asp:Label ID="Label3" runat="server" ForeColor="#0033CC" Text="Enter the Name of student "></asp:Label>
            </td>
            <td style="height: 215px">
                <asp:TextBox ID="txtsearch" runat="server"></asp:TextBox>
            </td>
            <td style="height: 215px">
                <asp:Button ID="Btnsearch" runat="server" ForeColor="#0099FF" Height="29px" OnClick="Btnsearch_Click" Text="Search" Width="83px" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="studID" ForeColor="Black" GridLines="None" Height="467px" Width="864px">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:BoundField DataField="studID" HeaderText="studID" ReadOnly="True" SortExpression="studID" />
                        <asp:BoundField DataField="fname" HeaderText="fname" SortExpression="fname" />
                        <asp:BoundField DataField="lname" HeaderText="lname" SortExpression="lname" />
                        <asp:BoundField DataField="payment" HeaderText="payment" SortExpression="payment" />
                        <asp:BoundField DataField="balance" HeaderText="balance" SortExpression="balance" />
                        <asp:BoundField DataField="paydate" HeaderText="paydate" SortExpression="paydate" />
                    </Columns>
                    <FooterStyle BackColor="Tan" />
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                    <SortedAscendingCellStyle BackColor="#FAFAE7" />
                    <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                    <SortedDescendingCellStyle BackColor="#E1DB9C" />
                    <SortedDescendingHeaderStyle BackColor="#C2A47B" />
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
