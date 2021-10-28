<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formularioPaciente.aspx.cs" Inherits="arquitecturaC.formularioPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 379px;
        }
        .auto-style3 {
            width: 237px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">IDPACIENTE</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtidpaciente" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">TIPODOCUMENTO</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txttipodocumento" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">NOMPACIENTE</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtnompaciente" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">DIRPACIENTE</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtdirpaciente" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">TELPACIENTE</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txttelpaciente" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">CELPACIENTE</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtcelpaciente" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="lblrespuesta" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnconsultar" runat="server" OnClick="btnconsultar_Click" Text="Consultar" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btneliminar" runat="server" OnClick="btneliminar_Click" Text="Eliminar" />
                </td>
                <td>
                    <asp:Button ID="btnguardar" runat="server" OnClick="btnguardar_Click" Text="Guardar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
