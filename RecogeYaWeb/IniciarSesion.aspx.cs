using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecogeYaWeb
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IniciarSesBut_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                String nomUsuario = tbNomUsuario.Text;
                String query = String.Format("select Usuario.contraseña, Usuario.tipo from Usuario where Usuario.nomUsuario = '{0}'", nomUsuario);
                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    String contra = tbContra.Text;
                    if (reader.GetString(0).Equals(contra))
                    {
                        Session["nomUsuario"] = nomUsuario;
                        if (reader.GetString(1).Equals("Cliente"))
                        {
                            Session["tipo"] = "Cliente";
                            Response.Redirect("POVCliente.aspx");
                        }
                        else
                        {
                            Session["tipo"] = "Empresa";
                            Response.Redirect("POVEmpresa.aspx");
                        }
                    }
                    else
                    {
                        lbCheck.Text = "Nombre de usuario o contraseña incorrectos";
                    }
                }
            }
            catch (Exception ex)
            {
                lbCheck.Text = "Algo falló";
            }
        }

        protected void RegresarBut_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}