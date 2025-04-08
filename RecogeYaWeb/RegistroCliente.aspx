<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCliente.aspx.cs" Inherits="RecogeYaWeb.RegistroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="max-width: 600px; margin: 50px auto; background-color: #FFFFFF; padding: 20px; border-radius: 8px; box-shadow: 0 0 10px rgba(0,0,0,0.1);">
    <h1 style="color: #3E58C9; text-align: center; margin-bottom: 20px;">Registrarse como cliente</h1>
    
    <!-- Nombre de usuario -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Nombre de usuario</label><br />
        <asp:TextBox ID="tbNomUsuario" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
        <asp:Label ID="lbCheck" runat="server" Text=" " 
            style="color: red; margin-left: 10px;" />
    </div>
    
    <!-- Contraseña -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Contraseña</label><br />
        <asp:TextBox ID="tbContra" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Nombre de pila -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Nombre de pila</label><br />
        <asp:TextBox ID="tbNombrePila" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Apellido materno -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Apellido materno</label><br />
        <asp:TextBox ID="tbApellMat" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Apellido paterno -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Apellido paterno</label><br />
        <asp:TextBox ID="tbApellPat" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Correo -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Correo</label><br />
        <asp:TextBox ID="tbCorreo" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Teléfono -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Teléfono</label><br />
        <asp:TextBox ID="tbTel" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Botón de registro -->
    <div style="text-align: center;">
        <asp:Button ID="RegBut" runat="server" Text="Registrarse" OnClick="RegBut_Click"
            style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 10px 20px; cursor: pointer; border-radius: 4px;" />
    </div>
</div>

        </div>
    </form>
</body>
</html>
