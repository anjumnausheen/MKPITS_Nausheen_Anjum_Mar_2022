<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>

    <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    
    <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    
    <asp:Label ID="Label4" runat="server" Text="DOB"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
    
    <asp:Label ID="Label5" runat="server" Text="email"></asp:Label>
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
   
    
    <asp:Button ID="Button1" runat="server" Text="OKAY!" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
    <br />

    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    <br />
    
    
    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
    <br />
    <br />

    <br />
    <br />


    <br />


    <br />
    <br />


     






</asp:Content>
