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
        public String contraseña;
        public String tipo;
        public String nomEmpresa;
        public String correo;
        public String estado;
        public String pais;
        public String calle;
        public int cp;
        public String colonia;
        public String municipio;
        public String admin;
        public String telefono1;
        public String telefono2;
        public String telefono3;

        public Empresa()
        {
        }

        public Empresa(string nomUsuario, string nomEmpresa, string correo, string estado, string pais, string calle, int cp, string colonia, string municipio, string admin, String telefono1, String telefono2, String telefono3)
        {
            this.nomUsuario = nomUsuario;
            this.tipo = "Empresa";
            this.nomEmpresa = nomEmpresa;
            this.correo = correo;
            this.estado = estado;
            this.pais = pais;
            this.calle = calle;
            this.cp = cp;
            this.colonia = colonia;
            this.municipio = municipio;
            this.admin = admin;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.telefono3 = telefono3;
        }

        public Empresa(string nomUsuario, string nomEmpresa, string correo, string estado, string pais, string calle, int cp, string colonia, string municipio, string admin, String telefono1, String telefono2)
        {
            this.nomUsuario = nomUsuario;
            this.tipo = "Empresa";
            this.nomEmpresa = nomEmpresa;
            this.correo = correo;
            this.estado = estado;
            this.pais = pais;
            this.calle = calle;
            this.cp = cp;
            this.colonia = colonia;
            this.municipio = municipio;
            this.admin = admin;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
        }

        public Empresa(string nomUsuario, string nomEmpresa, string correo, string estado, string pais, string calle, int cp, string colonia, string municipio, string admin, String telefono1)
        {
            this.nomUsuario = nomUsuario;
            this.tipo = "Empresa";
            this.nomEmpresa = nomEmpresa;
            this.correo = correo;
            this.estado = estado;
            this.pais = pais;
            this.calle = calle;
            this.cp = cp;
            this.colonia = colonia;
            this.municipio = municipio;
            this.admin = admin;
            this.telefono1 = telefono1;
        }

        public bool registrarEmpresa1Telefono()
        {
            try
            {
                bool resp = false;
                SqlConnection con = Conexion.agregarConexion();
                String query = String.Format("INSERT INTO Empresa (nomUsuario, correo, estado, pais, calle, CP, colonia, municipio, administrador, nomEmpresa) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}', '{9}');", this.nomUsuario, this.correo, this.estado, this.pais, this.calle, this.cp, this.colonia, this.municipio, this.admin, this.nomEmpresa);
                SqlCommand cmd = new SqlCommand(query, con);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    string query2 = String.Format("INSERT INTO Telefono (telefono, nomUsuario) VALUES ('{0}', '{1}');", this.telefono1, this.nomUsuario);
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    int newRes = cmd2.ExecuteNonQuery();
                    if (newRes > 0)
                    {
                        resp = true;
                    }
                }
                return resp;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool registrarEmpresa2Telefonos()
        {
            try
            {
                bool resp = false;
                SqlConnection con = Conexion.agregarConexion();
                String query = String.Format("INSERT INTO Empresa (nomUsuario, correo, estado, pais, calle, CP, colonia, municipio, administrador, nomEmpresa) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}', '{9}');", this.nomUsuario, this.correo, this.estado, this.pais, this.calle, this.cp, this.colonia, this.municipio, this.admin, this.nomEmpresa);
                SqlCommand cmd = new SqlCommand(query, con);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    string query2 = String.Format("INSERT INTO Telefono (telefono, nomUsuario) VALUES ('{0}', '{1}');", this.telefono1, this.nomUsuario);
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    int res2 = cmd2.ExecuteNonQuery();
                    if (res2 > 0)
                    {
                        string query3 = String.Format("INSERT INTO Telefono (telefono, nomUsuario) VALUES ('{0}', '{1}');", this.telefono2, this.nomUsuario);
                        SqlCommand cmd3 = new SqlCommand(query3, con);
                        int res3 = cmd3.ExecuteNonQuery();
                        if (res3 > 0)
                        {
                            resp = true;
                        }
                    }
                }
                return resp;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool registrarEmpresa3Telefonos()
        {
            try
            {
                bool resp = false;
                SqlConnection con = Conexion.agregarConexion();
                String query = String.Format("INSERT INTO Empresa (nomUsuario, correo, estado, pais, calle, CP, colonia, municipio, administrador, nomEmpresa) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', '{8}', '{9}');", this.nomUsuario, this.correo, this.estado, this.pais, this.calle, this.cp, this.colonia, this.municipio, this.admin, this.nomEmpresa);
                SqlCommand cmd = new SqlCommand(query, con);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    string query2 = String.Format("INSERT INTO Telefono (telefono, nomUsuario) VALUES ('{0}', '{1}');", this.telefono1, this.nomUsuario);
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    int res2 = cmd2.ExecuteNonQuery();
                    if (res2 > 0)
                    {
                        string query3 = String.Format("INSERT INTO Telefono (telefono, nomUsuario) VALUES ('{0}', '{1}');", this.telefono2, this.nomUsuario);
                        SqlCommand cmd3 = new SqlCommand(query3, con);
                        int res3 = cmd3.ExecuteNonQuery();
                        if (res3 > 0)
                        {
                            string query4 = String.Format("INSERT INTO Telefono (telefono, nomUsuario) VALUES ('{0}', '{1}');", this.telefono3, this.nomUsuario);
                            SqlCommand cmd4 = new SqlCommand(query4, con);
                            int res4 = cmd4.ExecuteNonQuery();
                            if (res4 > 0)
                            {
                                resp = true;
                            }
                        }
                    }
                }
                return resp;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}