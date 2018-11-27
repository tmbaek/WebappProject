<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OnlineShop2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
    <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="Blue" Text="Welcome to Auto Shop!!!"></asp:Label>

     <br />
    * Click a image to order<br />
 
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDataBound="OnRowDataBound" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="Image">
            <ItemTemplate>
                <asp:ImageButton ID="car_image" runat="server" Height="120px" Width="150px" CommandName="Select" CommandArgument="<%# Container.DataItemIndex %>"  />
            </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="car_name" HeaderText="Model" SortExpression="car_name" />
            <asp:BoundField DataField="price" HeaderText="Price" SortExpression="price" />
            <asp:BoundField DataField="Added_date" HeaderText="Registered Date" SortExpression="Added_date" />
        </Columns>
    </asp:GridView>
    
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

     </asp:Content>
