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
            <div style="background-color: #E0E8F9; padding: 20px;">
    <!-- Encabezado principal -->
    <div id="header" style="background-color: #3E58C9; text-align: center; padding: 30px 0;">
        <h1 style="color: #FFFFFF; margin: 0;">Recoge ya</h1>
    </div>

    <!-- Contenedor principal de la página -->
    <div id="mainContainer" style="max-width: 1000px; margin: 30px auto; background-color: #FFFFFF; padding: 20px; border-radius: 8px;">
        <!-- Label de verificación -->
        <asp:Label ID="lbCheck" runat="server" Text="check" style="display: none;"></asp:Label>

        <!-- Sección de búsqueda -->
        <div class="search-section" style="margin-bottom: 20px;">
            <asp:Label ID="Label1" runat="server" Text="Región" style="font-weight: bold; margin-right: 10px;"></asp:Label>
            <asp:TextBox ID="tbBuscar" runat="server" style="width: 200px; padding: 5px; margin-right: 10px;"></asp:TextBox>
            <asp:Button ID="BuscarBut" runat="server" Text="Buscar" 
                style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 6px 12px; cursor: pointer; border-radius: 4px;" OnClick="BuscarBut_Click1" />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" style="margin-top: 10px;" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1"></asp:DropDownList>
        </div>

        <!-- Sección de botones de registro e inicio de sesión -->
        <div class="buttons-section" style="margin-bottom: 20px;">
            <asp:Button ID="RegistroClienteBut" runat="server" Text="Registrarse como cliente" 
                style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 8px 16px; margin-right: 10px; cursor: pointer; border-radius: 4px;" OnClick="RegistroClienteBut_Click" />
            <asp:Button ID="RegistroEmpresaBut" runat="server" Text="Registrarse como empresa" 
                style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 8px 16px; margin-right: 10px; cursor: pointer; border-radius: 4px;" OnClick="RegistroEmpresaBut_Click1" />
            <asp:Button ID="IniciarSesBut" runat="server" Text="Iniciar sesión" 
                style="background-color: #4A63A8; color: #FFFFFF; border: none; padding: 8px 16px; margin-right: 10px; cursor: pointer; border-radius: 4px;" OnClick="IniciarSesBut_Click1" />
        </div>

        <!-- GridView para mostrar datos -->
        <asp:GridView ID="gvMain" runat="server" 
            style="width: 100%; border-collapse: collapse; margin-top: 20px;"></asp:GridView>
    </div>
</div>

        </div>
    </form>
</body>
</html>
