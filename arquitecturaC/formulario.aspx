<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario.aspx.cs" Inherits="arquitecturaC.formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 432px;
        }
        .auto-style3 {
            width: 279px;
        }
        .auto-style4 {
            width: 432px;
            height: 42px;
        }
        .auto-style5 {
            width: 279px;
            height: 42px;
        }
        .auto-style6 {
            height: 42px;
        }
        .auto-style7 {
            width: 432px;
            height: 30px;
        }
        .auto-style8 {
            width: 279px;
            height: 30px;
        }
        .auto-style9 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">CODIGO CITA:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtcita" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnconsultarcita" runat="server" OnClick="btnconsultarcita_Click" Text="Consultar Cita" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">FECHA:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">HORA:<br />
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txthora" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">ID PACIENTE:</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtidpaciente" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:Button ID="btnconsultarPaciente" runat="server" OnClick="btnconsultarPaciente_Click" Text="Consultar Paciente" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="lblresultado" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">ID MEDICO:</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtidmedico" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnguardarcita" runat="server" OnClick="btnguardarcita_Click" Text="Guardar Cita" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">VALOR:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtvalor" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblmensaje" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">DIAGNOSTICO:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtdiagnostico" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">NOMBRE DEL ACOMPAÑANTE:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtnomacomp" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
