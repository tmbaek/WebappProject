<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemsofOrder.aspx.cs" Inherits="OnlineShop2.ItemsofOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <br />
    <h3><b>* Shopping Cart - List of Product</b></h3>
    <table class="nav-justified" style="width: 76%">
        <tr>
            <td style="font-size: medium; font-weight: bold; text-align: center">Product ID</td>
            <td style="font-size: medium; font-weight: bold; text-align: center">Model</td>
            <td style="font-size: medium; font-weight: bold; text-align: center">Price</td>
            <td style="font-size: medium; font-weight: bold; text-align: center">Qty</td>
            <td style="font-size: medium; font-weight: bold; text-align: center">Total Price</td>
        </tr>
        <tr>
            <td style="text-align: center">



    <asp:TextBox ID="TextBox1" runat="server" Height="32px" Width="122px" ></asp:TextBox>
            </td>
            <td style="text-align: center">



    <asp:TextBox ID="TextBox2" runat="server" Height="32px" Width="122px" ></asp:TextBox>
            </td>
            <td style="text-align: center">



    <asp:TextBox ID="TextBox3" runat="server" Height="32px" Width="122px" ></asp:TextBox>
            </td>
            <td style="text-align: center">



    <asp:TextBox ID="TextBox4" runat="server" Height="32px" Width="122px" ></asp:TextBox>
            </td>
            <td style="text-align: center">



    <asp:TextBox ID="TextBox5" runat="server" Height="32px" Width="122px" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align: center">&nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
            <td style="text-align: center">
                <br />
                <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" Height="36px" OnClick="Button1_Click" Text="ORDER" Width="108px" />
            </td>
        </tr>
    </table>
    <br />



    <br />
    <br />
    <br />
    <br />
    <br />
    


</asp:Content>
