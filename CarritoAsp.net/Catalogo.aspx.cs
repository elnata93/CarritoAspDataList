using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace CarritoAsp.net
{
    public partial class Catalogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            CargarProducto1();
        }
        Articulos art = new Articulos();

        private void CargarProducto1()
        {   Articulos art = new Articulos();
            DataTable dt = new DataTable();
            dt=art.ListArticulo1("1");
            foreach (DataRow item in dt.Rows)
            {
                IdLabel.Text = dt.Rows[0]["ArticuloId"].ToString(); //art.ArticuloId.ToString();
                //CatImage.ImageUrl = dt.Rows[0]["Imagen"];//art.Imagen;
                DescripcionLabel.Text = dt.Rows[0]["Descripcion"].ToString();//art.Descripcion;
                PrecioLabel.Text = dt.Rows[0]["Precio"].ToString(); //art.Precio.ToString();
            }
            
        }
    }
}