using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace RecogeYaWeb
{
    public class Conexion
    {
        public static SqlConnection agregarConexion()
        {
            SqlConnection cnn;
            try
            {
                cnn = new SqlConnection("Data Source=macareno;Initial Catalog =dbComida; User ID = sa; Password = sqladmin21"); //String conexión Ro: 
                //cnn = new SqlConnection("Data Source=LapAniel;Initial Catalog =dbComida; User ID = sa; Password = sqladmin21");
                cnn.Open();
                //MessageBox.Show("Se conecto");
            }
            catch (Exception ex)
            {
                cnn = null;

            }
            return cnn;
        }

        public static void llenarCombo(DropDownList cb)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                SqlDataReader rd;
                con = Conexion.agregarConexion();
                cmd = new SqlCommand("select Empresa.municipio from Empresa", con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    //cb.Items.Add(rd["nombre"].ToString());
                    cb.Items.Add(rd.GetString(0));
                }
                //cb.SelectedIndex = 0;
                rd.Close();
            }
            catch (Exception ex)
            {
            }
        }
        public static bool llenarComboPOVEmpresa(DropDownList cb, String query)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                SqlDataReader rd;
                con = Conexion.agregarConexion();
                
                cmd = new SqlCommand(query, con);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    //cb.Items.Add(rd["nombre"].ToString());
                    cb.Items.Add(rd.GetInt64(0).ToString());
                }
                //cb.SelectedIndex = 0;
                return true;
                rd.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ClienteIndexBuscar(GridView gvMain, String busco)
        {
            SqlConnection con = Conexion.agregarConexion();
            String query = String.Format("select Producto.tipo, Producto.precioFinal, Producto.cantidadStock, Producto.caducidad,Empresa.nomEmpresa, Empresa.pais, Empresa.municipio,Empresa.estado, Empresa.CP, Empresa.colonia, Empresa.calle from Producto inner join Empresa on Empresa.nomUsuario = Producto.nomUsuario where Producto.tipo like '%{0}%'", busco);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                gvMain.DataSource = rdr;
                gvMain.DataBind();
                return true;
            }
            else
            {
                return false;
            }
        }
    
    public static void ClienteIndexDropdownList(GridView gvMain, String region)
        {
            gvMain.DataSource = null;
            gvMain.DataBind();
            SqlConnection con = Conexion.agregarConexion();
            String query = String.Format("select Producto.tipo, Producto.precioFinal, Producto.cantidadStock, Producto.caducidad,Empresa.nomEmpresa, Empresa.pais, Empresa.municipio,Empresa.estado, Empresa.CP, Empresa.colonia, Empresa.calle from Producto inner join Empresa on Empresa.nomUsuario = Producto.nomUsuario where Empresa.municipio = '{0}'", region);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                gvMain.DataSource = rdr;
                gvMain.DataBind();
            }
        }
    } 
}