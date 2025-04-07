<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="RecogeYaWeb.IniciarSesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="max-width: 500px; margin: 50px auto; background-color: #FFFFFF; padding: 30px; border-radius: 8px; box-shadow: 0 0 10px rgba(0,0,0,0.1);">
    <!-- Título -->
    <div style="text-align: center; margin-bottom: 20px;">
        <h1 style="color: #3E58C9; margin: 0;">Iniciar sesión</h1>
    </div>

    <!-- Nombre de usuario -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Nombre de usuario</label><br />
        <asp:TextBox ID="tbNomUsuario" runat="server" 
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>

    <!-- Contraseña -->
    <div style="margin-bottom: 15px;">
        <label style="font-weight: bold; color: #3E58C9;">Contraseña</label><br />
        <asp:TextBox ID="tbContra" runat="server" TextMode="Password"
            style="width: 100%; padding: 8px; border: 1px solid #ccc; border-radius: 4px;" />
    </div>

    <!-- Mensaje de validación -->
    <div style="margin-bottom: 15px; text-align: center;">
        <asp:Label ID="lbCheck" runat="server" Text=" " style="color: red;"></asp:Label>
    </div>

    <!-- Botón de iniciar sesión -->
    <div style="text-align: center;">
        <asp:Button ID="IniciarSesBut" runat="server" Text="Iniciar sesión" OnClick="IniciarSesBut_Click"
            style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 10px 20px; cursor: pointer; border-radius: 4px;" />
    </div>
</div>

        </div>
    </form>
</body>
</html>
