<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Consulta_Carrito.aspx.cs" Inherits="CarritoAsp.net.Consulta_Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 95px;
        }
        .auto-style2 {
            width: 868px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="panel panel-success">
            <div class="panel-heading">Listado de Articulos Agregados</div>
                <div class="panel-body">
                    <div class="form-horizontal col-md-12" role="form">

                        
                        <asp:DataList ID="ConsultaDataList" runat="server" CellPadding="4" ForeColor="#333333">
                            <AlternatingItemStyle BackColor="White" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <ItemStyle BackColor="#EFF3FB" />
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text="<%# ArticuloId %>"></asp:Label>
                                <asp:Label ID="Label2" runat="server" Text="<%# Descripcion %>"></asp:Label>
                                <asp:Label ID="Label3" runat="server" Text="<%# Precio %>"></asp:Label>
                            </ItemTemplate>
                            <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        </asp:DataList>

                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>



