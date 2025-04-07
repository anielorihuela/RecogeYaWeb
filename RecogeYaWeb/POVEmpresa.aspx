<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="POVEmpresa.aspx.cs" Inherits="RecogeYaWeb.POVEmpresa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            RecogeYa</p>
        <p>
            <asp:Button ID="misProdBut" runat="server" Text="Mis productos" OnClick="misProdBut_Click" />
        </p>
        <p>
            Subir un producto</p>
        <p>
            Tipo</p>
        <p>
            <asp:TextBox ID="tbTipo" runat="server"></asp:TextBox>
        </p>
        <p>
            Precio base</p>
        <p>
            <asp:TextBox ID="tbPrecioBase" runat="server"></asp:TextBox>
        </p>
        <p>
            Descuento</p>
        <p>
            <asp:TextBox ID="tbDesc" runat="server"></asp:TextBox>
        </p>
        <p>
            Cantidad</p>
        <p>
            <asp:TextBox ID="tbCant" runat="server"></asp:TextBox>
        </p>
        <p>
            Fecha de caducidad
            (formato yyyy-MM-dd)</p>
        <p>
            <asp:TextBox ID="tbFechaCad" runat="server"></asp:TextBox>
        </p>
        <p>
            Fecha de hoy (formato yyyy-MM-dd)</p>
        <p>
            <asp:TextBox ID="tbFechaHoy" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="subirBut" runat="server" Text="Subir" OnClick="subirBut_Click" />
        </p>
        <p>
            <asp:Label ID="lbCheck1" runat="server" Text=" "></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Actualizar un producto vendido</p>
        <p>
            Producto (ID)</p>
        <p>
            <asp:DropDownList ID="ddlProdID" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            Fecha de venta (formato yyyy-MM-dd)</p>
        <p>
            <asp:TextBox ID="tbFechaVenta" runat="server"></asp:TextBox>
        </p>
        <p>
            Nombre del comprador</p>
        <p>
            <asp:TextBox ID="tbNomComp" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="actBut" runat="server" Text="Actualizar" OnClick="actBut_Click" />
        </p>
    </form>
</body>
</html>
