<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CargaPuntos-VistaADM.aspx.cs" Inherits="Proyecto_LP3.CargaPuntos_VistaADM" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="padding:15px">


        <table class="nav-justified">
            <tr>
                <td colspan="2" style="font-size: xx-large; font-weight: bold; font-family: 'Times New Roman', Times, serif; height: 41px;" id="lblBienvenidaADM">
                    <asp:Label ID="lblBienvenida" runat="server" Text="¡Bienvenido/a!"></asp:Label>
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="font-size: medium; font-weight: bold; font-family: 'Segoe Print'; height: 42px;">Ingrese los siguientes datos requeridos:<br />
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Código:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="tbxCodigo" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Nombres:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="tbxNombres" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Apellidos:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="tbxApellidos" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Carrera:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="tbxCarrera" runat="server" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Curso:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="tbxCurso" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 41px;">Actividad:</td>
                <td style="height: 41px">
                    <asp:TextBox ID="tbxActi" runat="server" Width="400px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <%--<td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">&nbsp;</td>
                <td style="height: 40px; font-weight: bold;">
                    &nbsp;&nbsp;&nbsp;&nbsp; MM/DD/AAAA</td>
            </tr>--%>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Fecha:</td>
                <td style="height: 40px">
                    <strong>
                    <asp:TextBox ID="tbxFecha" runat="server" TextMode="DateTime">DD/MM/AAAA</asp:TextBox>
                    </strong>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Total de Créditos Acumulados:</td>
                <td style="height: 40px">
                    <asp:TextBox ID="tbxCA" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 293px; height: 72px;"></td>
                <td style="height: 72px">
                    <asp:Button ID="btnCargaDatos" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="White" Height="34px" Text="Cargar Datos" Width="157px" OnClick="btnCargaDatosADM_Click" style="font-weight: bold" />
                    <asp:Button ID="btnActualizacion" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="White" Height="34px" Text="Actuallizar Datos" Width="157px" OnClick="btnActualizarDatosADM_Click" style="font-weight: bold" />
                    <asp:Button ID="btnEliminar" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="White" Height="34px" Text="Eliminar Datos" Width="157px" OnClick="btnEliminarDatosADM_Click" OnClientClick="return confirm('Está seguro que desea eliminar?')" style="margin-top: 0; font-weight: bold;" />
                    <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </b>
                    <asp:Button ID="btnSolicitudes" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="White" Height="40px" Text="Solicitudes Disponibles" Width="210px" OnClick="btnSolicitudes_Click" style="font-weight: bold" />
                </td>
            </tr>
            <tr>
                <td style="height: 63px;" colspan="2">
                    <asp:GridView ID="GridView1" runat="server" ForeColor="Black" Width="1226px" Font-Bold="False">
                        <HeaderStyle BackColor="#666666" ForeColor="White" />
                    </asp:GridView>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>