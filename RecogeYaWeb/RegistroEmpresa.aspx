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
            Registrarse como empresa<br />
            <br />
            Nombre de usuario<br />
            <asp:TextBox ID="tbNomUsuario" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbCheck" runat="server" Text=" "></asp:Label>
            <br />
            <br />
            Contraseña<br />
            <asp:TextBox ID="tbContra" runat="server"></asp:TextBox>
            <br />
            <br />
            Correo<br />
            <asp:TextBox ID="tbCorreo" runat="server"></asp:TextBox>
            <br />
            <br />
            Estado<br />
            <asp:TextBox ID="tbEstado" runat="server"></asp:TextBox>
            <br />
            <br />
            País<br />
            <asp:TextBox ID="tbPais" runat="server"></asp:TextBox>
            <br />
            <br />
            Calle<br />
            <asp:TextBox ID="tbCalle" runat="server"></asp:TextBox>
            <br />
            <br />
            Código postal<br />
            <asp:TextBox ID="tbCP" runat="server"></asp:TextBox>
            <br />
            <br />
            Colonia<br />
            <asp:TextBox ID="tbColonia" runat="server"></asp:TextBox>
            <br />
            <br />
            Municipio<br />
            <asp:TextBox ID="tbMunicipio" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombre del administrador<br />
            <asp:TextBox ID="tbAdmin" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombre de la empresa<br />
            <asp:TextBox ID="tbEmpresa" runat="server"></asp:TextBox>
            <br />
            <br />
            Teléfonos (separados por comas)<br />
            <asp:TextBox ID="tbTel" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="RegBut" runat="server" Text="Registrarse" OnClick="RegBut_Click" />
        </div>
    </form>
</body>
</html>
