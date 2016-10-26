<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Registro_Articulos.aspx.cs" Inherits="CarritoAsp.net.Registro_Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 159px;
        }
        .auto-style2 {
            width: 159px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 91px;
        }
        .auto-style5 {
            width: 91px;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <div class="panel panel-success">
                <div class="panel-heading">Catalogo de  Articulos</div>
                <div class="panel-body">
                    <div class="form-horizontal col-md-12" role="form">
                        <table style="width: 100%;">
                            <tr>
                                <td class="auto-style1">
                                    &nbsp;</td>
                                <td class="auto-style4">
                                    <asp:Image ID="FotoImage" runat="server" Height="98px" Width="152px" ImageUrl="C:\Users\ServerBlack\Pictures\0010514427.jpg" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style2"></td>
                                <td class="auto-style5">
                                    <asp:Label ID="Label4" runat="server" Text="ArticuloId"></asp:Label>
                                </td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox>
                                    <asp:Button ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style2"></td>
                                <td class="auto-style5">
                                    <asp:Label ID="Label2" runat="server" Text="Descriocion:"></asp:Label>
                                </td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="DescripcionTextBox" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style4">&nbsp; 
                                    <asp:Label ID="Label3" runat="server" Text="Precio:"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="PrecioTextBox" runat="server" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" Text="Nuevo" />
                                    <asp:Button ID="GuardarButton" runat="server" OnClick="GuardarButton_Click" Text="Guardar" />
                                    <asp:Button ID="EliminarButton" runat="server" OnClick="EliminarButton_Click" Text="Eliminar" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            
                        </table>

					</div>
			</div>		
	</div>				
</div>
</asp:Content>
