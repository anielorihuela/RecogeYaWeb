<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="POVCliente.aspx.cs" Inherits="RecogeYaWeb.POVCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><div style="max-width: 1000px; margin: 50px auto; background-color: #FFFFFF; padding: 20px; border-radius: 8px; box-shadow: 0 0 10px rgba(0,0,0,0.1);">
    <!-- Encabezado -->
    <h1 style="color: #3E58C9; text-align: center; margin-bottom: 20px;">Recoge ya</h1>
    
    <!-- Sección de selección de región -->
    <div style="margin-bottom: 20px;">
        <label style="font-weight: bold; color: #3E58C9;">Región</label><br />
        <asp:DropDownList ID="DropDownList1" runat="server" 
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" 
            AutoPostBack="True" 
            style="width: 100%; max-width: 300px; padding: 8px; margin-top: 5px; border: 1px solid #ccc; border-radius: 4px;">
        </asp:DropDownList>
    </div>
    
    <!-- Sección de búsqueda -->
    <div style="margin-bottom: 20px;">
        <asp:Button ID="buscarBut" runat="server" Text="Buscar" 
            OnClick="buscarBut_Click" 
            style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 8px 16px; cursor: pointer; border-radius: 4px; margin-right: 10px;" />
        <asp:TextBox ID="tbBuscar" runat="server" 
            style="width: 200px; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Botón para ver "Mis compras" -->
    <div style="margin-bottom: 20px;">
        <asp:Button ID="comprasClienteBut" runat="server" Text="Mis compras" 
            OnClick="comprasClienteBut_Click" 
            style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 8px 16px; cursor: pointer; border-radius: 4px;" />
    </div>
    
    <!-- Label para mensajes -->
    <div style="margin-bottom: 20px; text-align: center;">
        <asp:Label ID="lbCheck" runat="server" Text=" " style="color: red;"></asp:Label>
    </div>
    
    <!-- GridView para mostrar resultados -->
    <div>
        <asp:GridView ID="gvMain" runat="server" 
            style="width: 100%; border-collapse: collapse;">
        </asp:GridView>
    </div>
</div>

        </div>
    </form>
</body>
</html>
