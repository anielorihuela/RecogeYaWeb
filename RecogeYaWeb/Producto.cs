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
        public int precioBase;
        public float desc;
        public int cant;
        public String cad;
        public String nomUsuario;

        public Producto(string tipo, int precioBase, float desc, int cant, string cad, string nomUsuario)
        {
            this.tipo = tipo;
            this.precioBase = precioBase;
            this.desc = desc;
            this.cant = cant;
            this.cad = cad;
            this.nomUsuario = nomUsuario;
        }

        public Boolean insertarProd()
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                if (con != null) 
                {
                    String query = String.Format("INSERT INTO Producto (tipo, precioBase, descuento, cantidadStock, caducidad, nomUsuario) VALUES ('{0}', {1}, {2}, {3}, '{4}', '{5}');", this.tipo, this.precioBase, this.desc, this.cant, this.cad, this.nomUsuario);
                    SqlCommand cmd = new SqlCommand(query, con);
                    int res = cmd.ExecuteNonQuery();
                    if(res > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }
    }
}