using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RecogeYaWeb
{
    public class Usuario
    {
        public String nomUsuario;
        public String contraseña;
        public String tipo;


        public Usuario(string nomUsuario, string contraseña, string tipo)
        {
            this.nomUsuario = nomUsuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
        }

        public String getNomUsuario()
        {
            return nomUsuario;
        }
        public String getContraseña()
        {
            return contraseña;
        }
        public String getTipo()
        {
            return tipo;
        }
        public bool insertarUsuario()
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                String query = String.Format("insert into Usuario values('{0}', '{1}', '{2}')", this.nomUsuario, this.contraseña, this.tipo);
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