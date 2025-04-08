<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroEmpresa.aspx.cs" Inherits="RecogeYaWeb.RegistroEmpresa" %>

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
    <h1 style="color: #3E58C9; text-align: center; margin-bottom: 20px;">Registrarse como empresa</h1>
    
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
    
    <!-- Correo -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Correo</label><br />
        <asp:TextBox ID="tbCorreo" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Estado -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Estado</label><br />
        <asp:TextBox ID="tbEstado" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- País -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">País</label><br />
        <asp:TextBox ID="tbPais" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Calle -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Calle</label><br />
        <asp:TextBox ID="tbCalle" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Código postal -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Código postal</label><br />
        <asp:TextBox ID="tbCP" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Colonia -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Colonia</label><br />
        <asp:TextBox ID="tbColonia" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Municipio -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Municipio</label><br />
        <asp:TextBox ID="tbMunicipio" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Nombre del administrador -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Nombre del administrador</label><br />
        <asp:TextBox ID="tbAdmin" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Nombre de la empresa -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Nombre de la empresa</label><br />
        <asp:TextBox ID="tbEmpresa" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Teléfonos (Hasta tres) -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Teléfonos (Hasta tres)</label><br />
        <asp:TextBox ID="tbTel1" runat="server" 
            style="width: 100%; margin-bottom: 8px; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" /><br />
        <asp:TextBox ID="tbTel2" runat="server" 
            style="width: 100%; margin-bottom: 8px; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" /><br />
        <asp:TextBox ID="tbTel3" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>
    
    <!-- Botón de registro -->
    <div style="text-align: center;">
        <asp:Button ID="RegBut" runat="server" Text="Registrarse" OnClick="RegBut_Click"
            style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 10px 20px; cursor: pointer; border-radius: 4px;" />
        <br />
        <br />
        <asp:Button ID="regresarBut" runat="server" OnClick="Button1_Click" Text="Regresar" 
            style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 10px 20px; cursor: pointer; border-radius: 4px;" />
    </div>
</div>

        </div>
    </form>
</body>
</html>
