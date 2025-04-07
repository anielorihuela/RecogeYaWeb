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
            Mis compras<br />
            <asp:Label ID="lbCheck" runat="server" Text=" "></asp:Label>
            <br />
            <asp:GridView ID="gvMisCompras" runat="server" OnSelectedIndexChanged="gvMisCompras_SelectedIndexChanged">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="regresarBut" runat="server" Text="Regresar" OnClick="regresarBut_Click" />
        </div>
    </form>
</body>
</html>
