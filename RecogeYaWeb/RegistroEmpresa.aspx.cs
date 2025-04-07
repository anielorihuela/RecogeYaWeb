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
            String nomUsuario = tbNomUsuario.Text;
            Usuario usuario = new Usuario(nomUsuario, contraseña, tipo);
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
                if(tbTel1.Text != "" && tbTel2.Text == "" && tbTel3.Text == "")
                {
                    int telefono1 = Int32.Parse(tbTel1.Text);
                    Empresa empresa = new Empresa(nomUsuario, nomEmpresa, correo, estado, pais, calle, cp, colonia, municipio, admin, telefono1);
                    if (empresa.registrarEmpresa1Telefono())
                    {
                        lbCheck.Text = "Alta exitosa";
                    }
                    else
                    {
                        lbCheck.Text = "Alta no exitosa";
                    }
                }
                else if (tbTel1.Text != "" && tbTel2.Text != "" && tbTel3.Text == "")
                {
                    int telefono1 = Int32.Parse(tbTel1.Text);
                    int telefono2= Int32.Parse(tbTel2.Text);
                    Empresa empresa = new Empresa(nomUsuario, nomEmpresa, correo, estado, pais, calle, cp, colonia, municipio, admin, telefono1, telefono2);
                    if (empresa.registrarEmpresa2Telefonos())
                    {
                        lbCheck.Text = "Alta exitosa";
                    }
                    else
                    {
                        lbCheck.Text = "Alta no exitosa";
                    }
                } else if (tbTel1.Text != "" && tbTel2.Text != "" && tbTel3.Text != "")
                {
                    int telefono1 = Int32.Parse(tbTel1.Text);
                    int telefono2 = Int32.Parse(tbTel2.Text);
                    int telefono3 = Int32.Parse(tbTel3.Text);
                    Empresa empresa = new Empresa(nomUsuario, nomEmpresa, correo, estado, pais, calle, cp, colonia, municipio, admin, telefono1, telefono2, telefono3);
                    if (empresa.registrarEmpresa3Telefonos())
                    {
                        lbCheck.Text = "Alta exitosa";
                    }
                    else
                    {
                        lbCheck.Text = "Alta no exitosa";
                    }
                } else lbCheck.Text = "Ingresa al menos un telefono, de arriba hacia abajo";
            }
            else
            {
                lbCheck.Text = "El nombre de usuario ya existe";
            }
        }
    }
}