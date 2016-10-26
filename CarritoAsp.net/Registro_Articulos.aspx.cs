using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace CarritoAsp.net
{
    public partial class Registro_Carrito : System.Web.UI.Page
    {
        Articulos articulo = new Articulos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            //FotoImage.ImageUrl = @"C:\Users\ServerBlack\Pictures\0010514427.jpg";
        }

        private void LlenarCampos()
        {
            IdTextBox.Text = articulo.ArticuloId.ToString();
            FotoImage.ImageUrl = articulo.Imagen;
            DescripcionTextBox.Text = articulo.Descripcion;
            PrecioTextBox.Text = articulo.Precio.ToString();
        }
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "")
            {
                mensajes("Introdusca el ID");
            }
            else
            if (IdTextBox.Text.Length != 0)
            {
                if (articulo.Buscar(IdTextBox.Text.Length))
                {
                    LlenarCampos();
                }
                else
                {
                    mensajes("Id no exite");
                }
            }
            else
            {
                mensajes("Id no encontrado");
            }
        }

        private void Limpiar()
        {
            IdTextBox.Text = "";
            DescripcionTextBox.Text = "";
            PrecioTextBox.Text = "";
        }
        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LlenarDatos()
        {
            articulo.Imagen = FotoImage.ImageUrl;
            articulo.Descripcion = DescripcionTextBox.Text;
            articulo.Precio = Convert.ToDouble(PrecioTextBox.Text);
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            if(IdTextBox.Text.Length == 0)
            {
                LlenarDatos();
                if (articulo.Insertar())
                {
                    mensajes("Articulo Guardado");
                }else
                {
                    mensajes("Error al guardar");
                }
            }
            
        }

        private void mensajes(string mensaje)
        {
            Response.Write("<script>alert('"+mensaje+"')</script>");
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text.Length == 0)
            {
                mensajes("Debe Ingresar el ID");
            }
            else
            {
                if (articulo.Buscar(IdTextBox.Text.Length))
                {
                    articulo.Eliminar();
                    mensajes("Articulo Eliminado");
                }
                else
                {
                    mensajes("Error al Eliminar");
                }
            }
        }
    }
}