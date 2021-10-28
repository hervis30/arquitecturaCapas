<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formularioCitas.aspx.cs" Inherits="arquitecturaC.formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 335px;
        }
        .auto-style3 {
            width: 298px;
        }
        .auto-style4 {
            width: 335px;
            height: 23px;
        }
        .auto-style5 {
            width: 298px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            width: 335px;
            height: 26px;
        }
        .auto-style8 {
            width: 298px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">CODCITA:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtcodcita" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">FECHA:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">HORA:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txthora" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">ID_PACIENTE:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtidpaciente" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style2">ID_MEDICO:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtidmedico" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">VALOR</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtvalor" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style4">DIAGNOSTICO:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtdiagnostico" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style7">NOMBRE ACOMPAÑANTE:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtnombreAcompañante" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Label ID="lblrespuesta" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnconsultar" runat="server" Text="Consultar" OnClick="btnconsultar_Click" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="txteliminar" runat="server" Text="Eliminar" OnClick="txteliminar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnguardar" runat="server" Text="Guardar" OnClick="btnguardar_Click" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
