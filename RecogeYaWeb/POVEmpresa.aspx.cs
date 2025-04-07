using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecogeYaWeb
{
    public partial class POVEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    String nomUsuario = Session["nomUsuario"].ToString();
                    String query = String.Format("select Producto.idProd from Producto where Producto.nomUsuario = '{0}'", nomUsuario);
                    if(!Conexion.llenarComboPOVEmpresa(ddlProdID, query))
                    {
                        lbCheck1.Text = "No hay productos";
                    }
                }
                catch (Exception ex)
                {
                    lbCheck1.Text = "No hay productos";
                }
            }
        }

        protected void misProdBut_Click(object sender, EventArgs e)
        {

        }

        protected void subirBut_Click(object sender, EventArgs e)
        {

        }

        protected void actBut_Click(object sender, EventArgs e)
        {

        }
    }
}