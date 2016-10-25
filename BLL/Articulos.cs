using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Articulos : ClaseMaestra
    {
        ConexionDb conexion = new ConexionDb();
        public int ArticuloId { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }

        public Articulos()
        {
            this.ArticuloId = 0;
            this.Imagen = "";
            this.Descripcion = "";
            this.Precio = 0;
        }

        public Articulos(int articuloId,string imagen,string descripcion,float precio)
        {
            this.ArticuloId = articuloId;
            this.Imagen = imagen;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("Insert Into Articulos values('{0}','{1}',{2})",this.Imagen,this.Descripcion,this.Precio));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("update Articulos set Imagen='{0}',Descripcion='{1}',Precio={2} where ArticuloId={3})", this.Imagen, this.Descripcion, this.Precio,this.ArticuloId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(String.Format("delete from Articulos where ArticuloId={0})", this.ArticuloId));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;
        }

        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = conexion.ObtenerDatos("select * from Articulos where ArticuloId= " + IdBuscado);
                if (dt.Rows.Count > 0)
                {
                    this.ArticuloId = (int)dt.Rows[0]["ArticuloId"];
                    this.Imagen = dt.Rows[0]["Imagen"].ToString();
                    this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                    this.Precio = (float)dt.Rows[0]["Precio"];
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {

            string OrdenFinal = "";
            if (!Orden.Equals(""))
                OrdenFinal = "Oder by" + Orden;
            return conexion.ObtenerDatos("select" + Campos + "from Articulos where " + Condicion + Orden);
        }
    }
}
