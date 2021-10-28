<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formularioMedico.aspx.cs" Inherits="arquitecturaC.formularioMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>IDMEDICO</td>
                    <td>
                        <asp:TextBox ID="txtidmedico" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>NOMEDICO</td>
                    <td>
                        <asp:TextBox ID="txtnomedico" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>ESPECIALIDAD</td>
                    <td>
                        <asp:TextBox ID="txtespecialidad" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">TELMEDICO</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txttelmedico" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblrespuesta" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnconsultar" runat="server" OnClick="btnconsultar_Click" Text="Consultar" />
                    </td>
                    <td>
                        <asp:Button ID="btneliminar" runat="server" OnClick="btneliminar_Click" Text="Eliminar" />
                    </td>
                    <td>
                        <asp:Button ID="btnguardar" runat="server" OnClick="btnguardar_Click" Text="Guardar" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
