<%@ Page Title="Login Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineShop2.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <body>
        
            <div>
                <asp:Label ID="Label1" runat="server" Text="Username :"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server">Enter username</asp:TextBox>
            </div>
            <asp:Label ID="Label2" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server">Enter Password</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
       
    </body>
    </html>

</asp:Content>
