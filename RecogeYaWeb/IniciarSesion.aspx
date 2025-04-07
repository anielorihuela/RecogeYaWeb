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
            Iniciar sesión<br />
            <br />
            Nombre de usuario<br />
            <asp:TextBox ID="tbNomUsuario" runat="server"></asp:TextBox>
            &nbsp;<br />
            <br />
            Contraseña<br />
            <asp:TextBox ID="tbContra" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lbCheck" runat="server" Text=" "></asp:Label>
            <br />
            <br />
            <asp:Button ID="IniciarSesBut" runat="server" Text="Iniciar sesión" OnClick="IniciarSesBut_Click" />
        </div>
    </form>
</body>
</html>
