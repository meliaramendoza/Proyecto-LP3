<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CargaPuntos-VistaALUMNOS.aspx.cs" Inherits="Proyecto_LP3.CargaPuntos_VistaALUMNOS" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="padding:15px; height: 798px;">


        <table class="nav-justified" style="height: 626px">
            <tr>
                <td colspan="2" style="font-size: xx-large; font-weight: bold; font-family: 'Times New Roman', Times, serif; height: 41px;">
                    <asp:Label ID="lblBienvenida" runat="server" Text="¡Bienvenido / a!"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="font-size: medium; font-weight: bold; font-family: 'Segoe Print'; height: 42px;">Ingrese los siguientes datos requeridos para el envío de su solicitud:<br />
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Código:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="txtCodigoAlumnos" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Nombres:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="txtNombresAlumnos" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Apellidos:</td>
                <td style="height: 40px">
                    <strong>
                    <asp:TextBox ID="txtApellidosAlumnos" runat="server" Width="400px"></asp:TextBox>
                    </strong>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Carrera:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="txtCarreraAlumnos" runat="server" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Curso:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="txtCursoAlumnos" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 41px;">Actividad:</td>
                <td style="height: 41px">
                    <asp:TextBox ID="txtActiAlumnos" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
                <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">&nbsp;</td>
                <td style="height: 40px; font-weight: bold;">
                    &nbsp;&nbsp;&nbsp;&nbsp; MM/DD/AAAA</td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Fecha:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="txtFechaActividadAlumnos" runat="server" TextMode="DateTime"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 60px;">Total de Créditos Acumulados:</td>
                <td style="height: 60px">
                    <asp:TextBox ID="txtCreditosAcumuladosAlumnos" runat="server" Enabled="False">0</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; height: 68px;"></td>
                <td style="height: 68px">
                    <asp:Button ID="btnEnviarSolicitud" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="White" Height="34px" Text="Enviar Solicitud" Width="157px" OnClick="btnEnviarDatosALUMNOS_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnVerMisCreditos" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="White" Height="40px" Text="Mis Créditos Académicos" Width="210px" style="margin-top: 12" OnClick="btnVerMisCreditos_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
            <tr>
                <td style="height: 63px;" colspan="2">
                    <asp:GridView ID="GridView1" runat="server" ForeColor="Black" Width="1226px" Font-Bold="False" >
                        <HeaderStyle BackColor="#666666" ForeColor="White" />
                    </asp:GridView>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
