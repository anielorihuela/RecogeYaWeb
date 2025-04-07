using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RecogeYaWeb
{
    public class Empresa
    {
        public String nomUsuario;
        public String correo;
        public String estado;
        public String pais;
        public String calle;
        public int cp;
        public String colonia;
        public String municipio;
        public String admin;
        public String nombre;

        public Empresa(string nomUsuario, string correo, string estado, string pais, string calle, int cp, string colonia, string municipio, string admin, string nombre)
        {
            this.nomUsuario = nomUsuario;
            this.correo = correo;
            this.estado = estado;
            this.pais = pais;
            this.calle = calle;
            this.cp = cp;
            this.colonia = colonia;
            this.municipio = municipio;
            this.admin = admin;
            this.nombre = nombre;
        }

        public bool registrarEmpresa()
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                String query = String.Format("insert into Empresa values('{0}', '{1}', '{2}', '{3}', {4}, '{5}','{6}','{7}','{8}','{9}')", this.nomUsuario, this.correo, this.estado, this.pais, this.correo, this.calle, this.cp, this.colonia, this.municipio, this.admin, this.nombre);
                SqlCommand cmd = new SqlCommand(query, con);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
      
    }
}