using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecogeYaWeb
{
    public partial class MisCompras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    String nomUsuario = Session["nomUsuario"].ToString();
                    Cliente.misCompras(nomUsuario, gvMisCompras);
                }
                catch (Exception ex)
                {
                    lbCheck.Text = "Algo falló";
                }
            }
        }

        protected void gvMisCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void regresarBut_Click(object sender, EventArgs e)
        {
            Response.Redirect("POVCliente.aspx");
        }
    }
}