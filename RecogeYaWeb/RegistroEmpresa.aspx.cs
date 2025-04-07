using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecogeYaWeb
{
    public partial class RegistroEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegBut_Click(object sender, EventArgs e)
        {
            String tipo = "Empresa";
            String contraseña = tbContra.Text;
            String nomUusario = tbNomUsuario.Text;
            Usuario usuario = new Usuario(nomUusario, contraseña, tipo);
            if (usuario.insertarUsuario())
            {
                String correo = tbCorreo.Text;
                String estado = tbEstado.Text;
                String pais = tbPais.Text;
                String calle = tbCalle.Text;
                int cp = Int32.Parse(tbCP.Text);
                String colonia = tbColonia.Text;
                String municipio = tbMunicipio.Text;
                String admin = tbAdmin.Text;
                String nomEmpresa = tbEmpresa.Text;
                Empresa empresa = new Empresa(nomUusario, correo, estado, pais, calle, cp, colonia, municipio, admin, nomEmpresa);
                if (empresa.registrarEmpresa())
                {
                    lbCheck.Text = "Alta exitosa";
                }
                else
                {
                    lbCheck.Text = "Alta no exitosa";
                }
            }
            else
            {
                lbCheck.Text = "El nombre de usuario ya existe";
            }
        }
    }
}