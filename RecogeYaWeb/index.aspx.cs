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
    public partial class index : System.Web.UI.Page
    {
        public static String region = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = Conexion.agregarConexion();
                String query = "select Producto.tipo, Producto.precioFinal, Producto.cantidadStock, Producto.caducidad,Empresa.nombre, Empresa.pais, Empresa.municipio,Empresa.estado, Empresa.CP, Empresa.colonia, Empresa.calle from Producto inner join Empresa on Empresa.nomUsuario = Producto.nomUsuario where Producto.fechaVenta is null and CONVERT(date, Producto.caducidad) >= CONVERT(date, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    gvMain.DataSource = rdr;
                    gvMain.DataBind();
                }
                Conexion.llenarCombo(DropDownList1);
            }
        }
    
        

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e) //Registrarse cliente
        {
            Response.Redirect("RegistroCliente.aspx");
        }

        protected void BuscarBut_Click(object sender, EventArgs e)
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

        protected void RegistroEmpresaBut_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroEmpresa.aspx");
        }

        protected void IniciarSesBut_Click(object sender, EventArgs e)
        {
            Response.Redirect("IniciarSesion.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            region = DropDownList1.SelectedValue.ToString();
            Conexion.ClienteIndexDropdownList(gvMain, region);
        }
    }
}