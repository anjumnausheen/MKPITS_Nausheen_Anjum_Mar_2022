<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.<asp:Label ID="Label2" runat="server" Text="Select City"></asp:Label>
    
    </p>
    
    
    <asp:Label ID="Label1" runat="server" Text="Select Country"></asp:Label>
    
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ></asp:DropDownList>

   
    <asp:Label ID="Label3" runat="server" Text="Select City"></asp:Label>
    
    <asp:DropDownList ID="DropDownList2" runat="server" ></asp:DropDownList>

    
    
    
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />











</asp:Content>
