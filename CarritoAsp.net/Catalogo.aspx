<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Catalogo.aspx.cs" Inherits="CarritoAsp.net.Catalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Image ID="CatImage" runat="server" Height="99px" ImageUrl="~/Imagenes/0010514427.jpg" Width="131px" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Id:"></asp:Label>
        <asp:Label ID="IdLabel" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Descripcion:"></asp:Label>
        <asp:Label ID="DescripcionLabel" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Precio:"></asp:Label>
        <asp:Label ID="PrecioLabel" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="ComprarButton" runat="server" Text="Comprar" />
    </div>
    
</asp:Content>
