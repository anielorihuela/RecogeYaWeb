using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RecogeYaWeb
{
    public partial class POVCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = Conexion.agregarConexion();
                String query = "select Producto.tipo, Producto.precioFinal, Producto.cantidadStock, Producto.caducidad,Empresa.nomEmpresa, Empresa.pais, Empresa.municipio,Empresa.estado, Empresa.CP, Empresa.colonia, Empresa.calle from Producto inner join Empresa on Empresa.nomUsuario = Producto.nomUsuario where Producto.fechaVenta is null and CONVERT(date, Producto.caducidad) >= CONVERT(date, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    gvMain.DataSource = rdr;
                    gvMain.DataBind();
                }
                Conexion.llenarCombo(DropDownList1);
            }
        }

        protected void buscarBut_Click(object sender, EventArgs e)
        {
            String busco = tbBuscar.Text;
            if (!String.IsNullOrEmpty(busco))
            {

                if (!Conexion.ClienteIndexBuscar(gvMain, busco))
                {
                    lbCheck.Text = "No funcionó";
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String region = DropDownList1.SelectedValue.ToString();
            Conexion.ClienteIndexDropdownList(gvMain, region);
        }

        protected void comprasClienteBut_Click(object sender, EventArgs e)
        {
            Response.Redirect("MisCompras.aspx");


        }
    }
}