<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="RecogeYaWeb.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Recoge ya<br />
            <asp:Label ID="lbCheck" runat="server" Text="check"></asp:Label>
            <br />
            <br />
            &nbsp;<asp:Label ID="Label1" runat="server" Text="Región"></asp:Label>
&nbsp;<asp:Button ID="BuscarBut" runat="server" Text="Buscar" OnClick="BuscarBut_Click" />
            <asp:TextBox ID="tbBuscar" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="RegistroClienteBut" runat="server" Text="Registrarse como cliente" OnClick="Button3_Click" />
            &nbsp;
            <asp:Button ID="RegistroEmpresaBut" runat="server" Text="Registrarse como empresa" OnClick="RegistroEmpresaBut_Click" />
            &nbsp;
            <asp:Button ID="IniciarSesBut" runat="server" Text="Iniciar sesión" OnClick="IniciarSesBut_Click" />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <asp:GridView ID="gvMain" runat="server" Height="241px" Width="733px">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
