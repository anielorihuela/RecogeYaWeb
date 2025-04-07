using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecogeYaWeb
{
    public partial class RegistroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegBut_Click(object sender, EventArgs e)
        {
            String tipo = "Cliente";
            String contraseña = tbContra.Text;
            String nomUusario = tbNomUsuario.Text;
            Usuario usuario = new Usuario(nomUusario, contraseña, tipo);
            if (usuario.insertarUsuario())
            {
                String nomPila = tbNombrePila.Text;
                String apellidoMat = tbApellMat.Text;
                String apellidoPat = tbApellPat.Text;
                String correo = tbCorreo.Text;
                String tel = tbTel.Text;
                Cliente cliente = new Cliente(nomUusario, nomPila, apellidoMat, apellidoPat, correo, tel);
                if (cliente.registarCliente())
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