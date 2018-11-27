<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="OnlineShop2.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


This is Order page<br />
    <br />
    <table class="nav-justified" style="width: 68%; height: 114px">
        <tr>
            <td rowspan="6" style="width: 171px">
                <asp:Image ID="Image1" runat="server" Height="259px" Width="351px" OnRowDataBound="OnRowDataBound"/>
            </td>
            <td class="modal-sm" style="font-weight: bold; font-size: medium; text-align: right">Product ID : </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="32px" Width="207px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="font-weight: bold; font-size: medium; text-align: right">Model : </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="32px" Width="207px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="font-weight: bold; font-size: medium; text-align: right">Price ($) :</td>
            <td style="height: 20px">
                <asp:TextBox ID="TextBox3" runat="server" Height="32px" Width="207px"></asp:TextBox>
            </td>
            &nbsp;</tr>
        <tr>
            <td class="modal-sm" style="font-weight: bold; font-size: medium; text-align: right">Date Produced :</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Height="32px" Width="207px"></asp:TextBox>
            </td>
            &nbsp;</tr>
        <tr>
            <td class="modal-sm" style="font-weight: bold; font-size: medium; text-align: right">Qty :</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="47px" Width="72px">
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2">2</asp:ListItem>
                    <asp:ListItem Value="3">3</asp:ListItem>
                    <asp:ListItem Value="4">4</asp:ListItem>
                    <asp:ListItem Value="5">5</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="font-weight: bold; font-size: medium; text-align: right">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" Height="37px" OnClick="Button1_Click" Text="Order" Width="141px" />
            </td>
        </tr>
    </table>
&nbsp;


</asp:Content>
