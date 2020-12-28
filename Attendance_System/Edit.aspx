<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Attendance.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <link href="CSSFolder/EditCSS.css" rel="stylesheet" />
    <table>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" Text="Deactivation"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Font-Size="Larger" Text="Student ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="44px" Width="97px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Font-Size="Larger" Text="Selected Student"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Labeltext" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="labeltext2" runat="server" Text="Label" BorderColor="Yellow"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Font-Size="Larger" Text="Date"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="DateTime"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Btnsearch" runat="server" Height="48px" OnClick="Btnsearch_Click" Text="Search" Width="99px" />
            </td>
            <td>
                
                <asp:Button ID="Btnendbatch" runat="server" Height="42px" OnClick="Btnendbatch_Click" Text="End Batch" Width="109px" />
                
            </td>
        </tr>
    </table>
</asp:Content>
