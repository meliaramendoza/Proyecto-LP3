
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="InicioSesion.aspx.cs" Inherits="Proyecto_LP3.InicioSesion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="padding:15px; height: 559px;">
        <div>
            <div>
                <div style="height: 253px">
                <div style="font-weight: 700">

                    <table class="nav-justified" style="height: 52px">
                        <tr>
                            <td>&nbsp;</td>
                            <td style="width: 110px">&nbsp;</td>
                            <td style="width: 578px; font-size: medium; font-weight: bold; font-family: 'Segoe Print';">
                                ¡Bienvenido/a al Sistema de Gestión de Créditos Académicos Extracurriculares de la Facultad de Ciencias y Tecnologías de la Universidad Católica &quot;Nuestra Señora de la Asunción&quot; - Campús Guairá</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>

                </div>
                    <table class="nav-justified" style="height: 179px">
                        <tr>
                            <td style="height: 127px"></td>
                            <td style="height: 127px; width: 175px"></td>
                            <td style="height: 127px; width: 560px">
                                <asp:Image ID="Image1" runat="server" Height="183px" ImageUrl="~/244201719_263067802488206_936819081549297112_n.png" style="margin-top: 34px" Width="700px" />
                            </td>
                            <td style="height: 127px"></td>
                            <td style="height: 127px"></td>
                        </tr>

                    </table>
                </div>
            </div>
            
            <div style="height: 202px">
                <table class="nav-justified" style="height: 142px; margin-top: 110px;">
                    <tr>
                        <td style="height: 63px"></td>
                        <td class="modal-sm" style="height: 63px; width: 271px"></td>
                        <td style="width: 119px; font-size: medium; font-family: 'Britannic Bold'; height: 63px;">Usuario:</td>
                        <td class="modal-sm" style="width: 553px; height: 63px">
                            <asp:TextBox ID="txtUsuario" runat="server" style="margin-left: 0" Width="308px"></asp:TextBox>
                        </td>
                        <td style="width: 89px; height: 63px"></td>
                        <td style="height: 63px"></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td class="modal-sm" style="width: 271px">&nbsp;</td>
                        <td style="width: 119px; font-size: medium; font-family: 'Britannic Bold';">Contraseña:</td>
                        <td class="modal-sm" style="width: 553px">
                            <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" Width="308px"></asp:TextBox>
                        </td>
                        <td style="width: 89px">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <table class="nav-justified" style="height: 61px; margin-bottom: 0px">
                    <tr>
                        <td style="height: 20px; width: 205px;"></td>
                        <td style="height: 20px; width: 264px"></td>
                        <td style="height: 20px; width: 266px">
                            <asp:Button ID="btnLogin" runat="server" Font-Bold="True" Height="34px" CssClass="btn btn-primary btn-dark" OnClick="btnLogin_Click" style="margin-left: 0" Text="Iniciar Sesión" Width="225px" />
                        </td>
                        <td style="height: 20px">&nbsp;</td>
                        <td style="height: 20px"></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <div>
            
        <table class="nav-justified" style="height: 82px">
            <tr>
                <td style="width: 124px">&nbsp;</td>
                <td class="modal-sm" style="width: 376px">&nbsp;</td>
                <td>
                    <asp:Label ID="labelMensajeError" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
            
    </div>
    <div>
            
        <table class="nav-justified" style="height: 82px">
            <tr>
                <td style="width: 124px; height: 131px;"></td>
                <td class="modal-sm" style="width: 363px; height: 131px;"></td>
                <td class="modal-sm" style="width: 268px; height: 131px">
                    <table class="nav-justified">
                        <tr>
                            <td style="height: 56px">&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="10pt" Text="          Aún no estás registrado?"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                            <asp:Button ID="btnRegistro" runat="server" Font-Bold="True" Height="34px" CssClass="btn btn-primary btn-dark" OnClick="btnRegistro_Click" style="margin-left: 0" Text="Registrarme" Width="225px" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td style="height: 131px"></td>
                <td style="height: 131px"></td>
            </tr>
        </table>
            
    </div>
</asp:Content>
