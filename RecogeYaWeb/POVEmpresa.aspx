<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="POVEmpresa.aspx.cs" Inherits="RecogeYaWeb.POVEmpresa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <div style="max-width: 800px; margin: 50px auto; background-color: #FFFFFF; padding: 20px; border-radius: 8px; box-shadow: 0 0 10px rgba(0,0,0,0.1);">
    <!-- Encabezado -->
    <h1 style="color: #3E58C9; text-align: center;">RecogeYa</h1>
    
    <!-- Botón para ver "Mis productos" -->
    <div style="text-align: center; margin-bottom: 30px;">
        <asp:Button ID="misProdBut" runat="server" Text="Mis productos" OnClick="misProdBut_Click" 
            style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 10px 20px; cursor: pointer; border-radius: 4px;" />
    </div>
    
    <!-- Sección: Subir un producto -->
    <div style="margin-bottom: 40px;">
        <h2 style="color: #0277BD;">Subir un producto</h2>
        
        <!-- Tipo -->
        <div style="margin-bottom: 10px;">
            <label style="font-weight: bold; color: #3E58C9;">Tipo</label><br />
            <asp:TextBox ID="tbTipo" runat="server" 
                style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
        </div>
        
        <!-- Precio base -->
        <div style="margin-bottom: 10px;">
            <label style="font-weight: bold; color: #3E58C9;">Precio base</label><br />
            <asp:TextBox ID="tbPrecioBase" runat="server" 
                style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
        </div>
        
        <!-- Descuento -->
        <div style="margin-bottom: 10px;">
            <label style="font-weight: bold; color: #3E58C9;">Descuento</label><br />
            <asp:TextBox ID="tbDesc" runat="server" 
                style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
        </div>
        
        <!-- Cantidad -->
        <div style="margin-bottom: 10px;">
            <label style="font-weight: bold; color: #3E58C9;">Cantidad</label><br />
            <asp:TextBox ID="tbCant" runat="server" 
                style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
        </div>
        
        <!-- Fecha de caducidad -->
        <div style="margin-bottom: 10px;">
            <label style="font-weight: bold; color: #3E58C9;">Fecha de caducidad (formato yyyy-MM-dd)</label><br />
            <asp:TextBox ID="tbFechaCad" runat="server" 
                style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
        </div>
        
        <!-- Fecha de hoy -->
        <div style="margin-bottom: 20px;">
            <label style="font-weight: bold; color: #3E58C9;">Fecha de hoy (formato yyyy-MM-dd)</label><br />
            <asp:TextBox ID="tbFechaHoy" runat="server" 
                style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
        </div>
        
        <!-- Botón para subir producto -->
        <div style="text-align: center;">
            <asp:Button ID="subirBut" runat="server" Text="Subir" OnClick="subirBut_Click" 
                style="background-color: #0288D1; color: #FFFFFF; border: none; padding: 10px 20px; cursor: pointer; border-radius: 4px;" />
            <br />
        </div>
        
        <!-- Label para mensajes de subida -->
        <div style="text-align: center; margin-top: 10px;">
            <h2 style="color: #0277BD;">Todos tus productos</h2>
            <asp:Label ID="lbCheck1" runat="server" Text=" " style="color: red;"></asp:Label>
            <asp:GridView ID="GridView1" runat="server" Height="183px" Width="918px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </div>
    
    <!-- Sección: Actualizar un producto vendido -->
    <div style="margin-bottom: 20px;">
        <h3 style="color: #0277BD;">Venta de un producto</h3>
        
        <!-- Producto (ID) -->
        <div style="margin-bottom: 10px;">
            <label style="font-weight: bold; color: #3E58C9;">Producto (ID)</label><br />
            <asp:DropDownList ID="ddlProdID" runat="server" 
                style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" OnSelectedIndexChanged="ddlProdID_SelectedIndexChanged" />
        </div>
        
        <!-- Fecha de venta -->
        
        <!-- Nombre del comprador -->
        <div style="margin-bottom: 20px;">
            <label style="font-weight: bold; color: #3E58C9;">Username del comprador</label><br />
            <asp:TextBox ID="tbNomComp" runat="server" 
                style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
        </div>
        
        <!-- Botón para actualizar producto -->
        <div style="text-align: center;">
            <asp:Button ID="actBut" runat="server" Text="Vender" OnClick="actBut_Click" 
                style="background-color: #0288D1; color: #FFFFFF; border: none; padding: 10px 20px; cursor: pointer; border-radius: 4px;" />
        </div>
    </div>
</div>

        </div>
    </form>
</body>
</html>

