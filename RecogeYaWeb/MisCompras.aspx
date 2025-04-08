<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MisCompras.aspx.cs" Inherits="RecogeYaWeb.MisCompras" %>

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
    <!-- Título principal -->
    <h1 style="color: #3E58C9; text-align: center;">Mis Compras</h1>
    
    <!-- Label para mensajes de validación o información -->
    <asp:Label ID="lbCheck" runat="server" Text=" " 
        style="display: block; text-align: center; color: red; margin-bottom: 20px;"></asp:Label>
    
    <!-- GridView para mostrar las compras -->
    <asp:GridView ID="gvMisCompras" runat="server" OnSelectedIndexChanged="gvMisCompras_SelectedIndexChanged" 
        style="width: 100%; border-collapse: collapse; margin-bottom: 20px;"></asp:GridView>
    
    <!-- Botón para regresar -->
    <div style="text-align: center;">
        <asp:Button ID="regresarBut" runat="server" Text="Regresar" OnClick="regresarBut_Click" 
            style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 10px 20px; cursor: pointer; border-radius: 4px;" />
    </div>
</div>

        </div>
    </form>
</body>
</html>
