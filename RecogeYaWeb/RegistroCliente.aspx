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
            Registrarse como cliente<br />
            <br />
            Nombre de usuario<br />
            <asp:TextBox ID="tbNomUsuario" runat="server"></asp:TextBox>
            &nbsp;
            <asp:Label ID="lbCheck" runat="server" Text=" "></asp:Label>
            <br />
            <br />
            Contraseña<br />
            <asp:TextBox ID="tbContra" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombre de pila<br />
            <asp:TextBox ID="tbNombrePila" runat="server"></asp:TextBox>
            <br />
            <br />
            Apellido materno<br />
            <asp:TextBox ID="tbApellMat" runat="server"></asp:TextBox>
            <br />
            <br />
            Apellido paterno<br />
            <asp:TextBox ID="tbApellPat" runat="server"></asp:TextBox>
            <br />
            <br />
            Correo<br />
            <asp:TextBox ID="tbCorreo" runat="server"></asp:TextBox>
            <br />
            <br />
            Teléfono<br />
            <asp:TextBox ID="tbTel" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="RegBut" runat="server" Text="Registrarse" OnClick="RegBut_Click" />
        </div>
    </form>
</body>
</html>
