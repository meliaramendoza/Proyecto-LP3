<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Registro.aspx.cs" Inherits="Proyecto_LP3.Registro" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="padding:15px; height: 798px;">


        <table class="nav-justified" style="height: 385px">
            <tr>
                <td colspan="2" style="font-size: xx-large; font-weight: bold; font-family: 'Times New Roman', Times, serif; height: 41px;">
                    <asp:Label ID="lblBienvenida" runat="server" Text="¡Regístrame!"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="font-size: medium; font-weight: bold; font-family: 'Segoe Print'; height: 42px;">Ingrese los siguientes datos requeridos:<br />
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Nombre de Usuario:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="txtNombreUsuario" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Contraseña:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="txtContrasenaUsuario" runat="server" Width="400px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Tipo de Usuario:</td>
                <td style="height: 40px">
                    <asp:RadioButton ID="rbtnAlumno" runat="server" Text="ALUMNO" />
                </td>
            </tr>
            <tr>
                <td style="width: 293px; height: 71px;"></td>
                <td style="height: 71px">
                    <asp:Button ID="btnRegistrarUsuario" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="White" Height="34px" Text="Enviar Registro" Width="157px" OnClick="btnEnviarRegistro_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
            <tr>
                <td style="width: 293px; height: 68px;"></td>
                <td style="height: 68px">
                    <asp:Button ID="btnIniciarSesion" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="White" Height="34px" Text="Inciar Sesión" Width="157px" OnClick="btnIniciarsesion_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
        </table>

    </div>
</asp:Content>
