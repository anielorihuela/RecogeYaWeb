using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                llenarGV();
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
                ddlProdID.Items.Clear(); // Limpiar el DropDownList antes de volver a llenarlo
                GridView1.DataSource = null;
                GridView1.DataBind(); // Limpiar el GridView
                llenarDDL();
                llenarGV(); // Volver a llenar el GridView
            }
            else
            {
                lbCheck1.Text = "No se pudo subir el producto";
            }
        }

        protected void actBut_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir el valor seleccionado a entero y obtener el comprador
                int idProd = Convert.ToInt32(ddlProdID.SelectedValue);
                string idComprador = tbNomComp.Text;

                using (SqlConnection con = Conexion.agregarConexion())
                {
                    // Iniciar una transacción
                    using (SqlTransaction tran = con.BeginTransaction())
                    {
                        try
                        {
                            // 1. Actualizar el precio final ejecutando el procedimiento almacenado.
                            using (SqlCommand cmdUpdate = new SqlCommand("EXEC sp_UpdatePrecioFinal;", con, tran))
                            {
                                cmdUpdate.ExecuteNonQuery();
                            }

                            // 2. Consultar el stock y el precio final del producto.
                            int stock = 0;
                            decimal price = 0m;
                            using (SqlCommand cmdSelect = new SqlCommand("SELECT cantidadStock, precioFinal FROM Producto WHERE idProd = @idProd;", con, tran))
                            {
                                cmdSelect.Parameters.AddWithValue("@idProd", idProd);
                                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        // Utilizar Convert para transformar el valor a int y decimal.
                                        stock = Convert.ToInt32(reader["cantidadStock"]);
                                        price = Convert.ToDecimal(reader["precioFinal"]);
                                    }
                                    else
                                    {
                                        throw new Exception("Producto no encontrado.");
                                    }
                                }
                            }

                            // 3. Insertar la compra y recuperar el id generado usando SCOPE_IDENTITY().
                            int idCompra = 0;
                            decimal monto = price * stock;
                            using (SqlCommand cmdInsertCompra = new SqlCommand(
                                "INSERT INTO Compra (monto, nomUsuario) VALUES (@monto, @idComprador); SELECT SCOPE_IDENTITY();",
                                con, tran))
                            {
                                cmdInsertCompra.Parameters.AddWithValue("@monto", monto);
                                cmdInsertCompra.Parameters.AddWithValue("@idComprador", idComprador);

                                object result = cmdInsertCompra.ExecuteScalar();
                                if (result != null && result != DBNull.Value)
                                {
                                    // Convertir el valor (que generalmente es decimal) a int.
                                    idCompra = Convert.ToInt32(Convert.ToDecimal(result));
                                }
                                else
                                {
                                    throw new Exception("Error al recuperar SCOPE_IDENTITY.");
                                }
                            }

                            // 4. Insertar en CompraProducto para relacionar la compra con el producto
                            //    y actualizar el stock del producto a 0.
                            using (SqlCommand cmdCompraProd = new SqlCommand(
                                "INSERT INTO CompraProducto (idCompra, idProd, cantidad) VALUES (@idCompra, @idProd, @stock); " +
                                "UPDATE Producto SET cantidadStock = 0 WHERE idProd = @idProd;",
                                con, tran))
                            {
                                cmdCompraProd.Parameters.AddWithValue("@idCompra", idCompra);
                                cmdCompraProd.Parameters.AddWithValue("@idProd", idProd);
                                cmdCompraProd.Parameters.AddWithValue("@stock", stock);
                                cmdCompraProd.ExecuteNonQuery();
                            }

                            // Confirmar la transacción
                            tran.Commit();
                            lbCheck1.Text = "Compra realizada";
                        }
                        catch (Exception exTrans)
                        {
                            // Revertir la transacción en caso de error.
                            tran.Rollback();
                            lbCheck1.Text = "Error al realizar la compra: " + exTrans.Message;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lbCheck1.Text = "Error con la base de datos: " + ex.Message;
            }


        }

        protected void llenarDDL()
        {
            try
            {
                String nomUsuario = Session["nomUsuario"].ToString();
                String query = String.Format("select Producto.idProd from Producto where Producto.nomUsuario = '{0}' and Producto.fechaVenta is null", nomUsuario);
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

        protected void llenarGV()
        {
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                String query = String.Format("select top(10) Producto.tipo, Producto.precioFinal, Producto.cantidadStock, Producto.caducidad from Producto inner join Empresa on Empresa.nomUsuario = Producto.nomUsuario where Producto.nomUsuario = '{0}' order by Producto.fechaPosteo desc", Session["nomUsuario"].ToString());
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
                else
                {
                    lbCheck1.Text = "Error llenando el GV";
                }
            }
            catch (Exception ex)
            {
                lbCheck1.Text = "Error base de datos";
                return;
            }
        }

        protected void ddlProdID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}