using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace RecogeYaWeb
{
    public class Cliente
    {
        public String nomUsuario;
        public String nomPila;
        public String apellMat;
        public String apellPat;
        public String correo;
        public String tel;

        public Cliente(string nomUsuario, string nomPila, string apellMat, string apellPat, string correo, string tel)
        {
            this.nomUsuario = nomUsuario;
            this.nomPila = nomPila;
            this.apellMat = apellMat;
            this.apellPat = apellPat;
            this.correo = correo;
            this.tel = tel;
        }

        public String getNomUsuario() { return nomUsuario; }
        public String getNomPila() { return nomPila; }
        public String getApellMat() { return apellMat; }
        public String getApellPat() { return apellPat; }
        public String getCorreo() { return correo; }
        public String getTel()
        {
            return tel;
        }

        public bool registarCliente()
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                String query = String.Format("insert into Cliente values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", this.nomUsuario, this.nomPila, this.apellPat, this.apellMat, this.correo, this.tel);
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
        public static bool misCompras(String nomUsuario, GridView gv)
        {
            SqlConnection con = Conexion.agregarConexion();
            String query = String.Format("select Compra.fecha, Compra.monto from Compra where Compra.nomUsuario = '{0}'", nomUsuario);
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                gv.DataSource = reader;
                gv.DataBind();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}