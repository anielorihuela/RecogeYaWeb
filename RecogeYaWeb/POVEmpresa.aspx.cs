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
                llenarDDL();
            }
        }

        protected void misProdBut_Click(object sender, EventArgs e)
        {

        }

        protected void subirBut_Click(object sender, EventArgs e)
        {
            String tipo = tbTipo.Text; //nombre del producto
            int precioBase = Int32.Parse(tbPrecioBase.Text);
            float desc = float.Parse(tbDesc.Text);
            int cant = Int32.Parse(tbCant.Text);
            String cad = tbFechaCad.Text;
            String nomUsuario = Session["nomUsuario"].ToString();
            Producto producto = new Producto(tipo, precioBase, desc, cant, cad, nomUsuario);
            if (producto.insertarProd())
            {
                lbCheck1.Text = "Producto subido";
                llenarDDL();
            }
            else
            {
                lbCheck1.Text = "No se pudo subir el producto";
            }
        }

        protected void actBut_Click(object sender, EventArgs e)
        {

        }

        protected void llenarDDL()
        {
            try
            {
                String nomUsuario = Session["nomUsuario"].ToString();
                String query = String.Format("select Producto.idProd from Producto where Producto.nomUsuario = '{0}'", nomUsuario);
                if (!Conexion.llenarComboPOVEmpresa(ddlProdID, query))
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
}