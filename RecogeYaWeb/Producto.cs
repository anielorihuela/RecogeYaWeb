using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RecogeYaWeb
{
    public class Producto
    {
        public String tipo;
        public String fechaPost;
        public int precioBase;
        public float desc;
        public int precioFinal;
        public int cant;
        public String cad;
        public String fechaVenta;
        public String nomUsuario;

        public Producto(string tipo, string fechaPost, int precioBase, float desc, int precioFinal, int cant, string cad, string fechaVenta, string nomUsuario)
        {
            this.tipo = tipo;
            this.fechaPost = fechaPost;
            this.precioBase = precioBase;
            this.desc = desc;
            this.precioFinal = precioFinal;
            this.cant = cant;
            this.cad = cad;
            this.fechaVenta = fechaVenta;
            this.nomUsuario = nomUsuario;
        }

        public Boolean insertarProd()
        {
            long id = generarId();
            SqlConnection con = Conexion.agregarConexion();
            String query = "";
            return true;

        }
        private long generarId()
        {
            SqlConnection con = Conexion.agregarConexion();
            String query = String.Format("select top(1) Producto.idProd from Producto where Producto.nomUsuario = '{0}' order by Producto.idProd desc", this.nomUsuario);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            long id = 0;
            if (reader.Read())
            {
                id = reader.GetInt64(0);
            }
            return id;
        }
    }
}