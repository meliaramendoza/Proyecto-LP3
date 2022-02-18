<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="MisCreditosAcademicos.aspx.cs" Inherits="Proyecto_LP3.MisCreditosAcademicos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="padding:15px; height: 696px;">


        <table class="nav-justified" style="height: 551px">
            <tr>
                <td colspan="2" style="font-size: xx-large; font-weight: bold; font-family: 'Times New Roman', Times, serif; height: 49px;"><strong>Mis Créditos Académicos</td>
            </tr>
            <tr>
                <td style="height: 63px;" colspan="2">
                    <table class="nav-justified" style="height: 551px">
                        <tr>
                            <td style="height: 65px">
                                <table class="nav-justified">
                                    <tr>
                                        <td class="modal-lg" style="width: 227px; font-weight: bold; font-family: 'Arial Narrow'; font-size: medium; height: 40px;">Ingrese su Nº de Código:</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="modal-lg" colspan="2" style="height: 62px">
                                            <strong>
                                            <asp:TextBox ID="txtBusqCodigo" runat="server" Height="23px" Width="257px"></asp:TextBox>
                                            </strong>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="modal-lg" colspan="2" style="height: 45px">
                    <asp:Button ID="btnBusquedaCreditosPorCodigo" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="White" Height="34px" Text="Buscar" Width="157px" OnClick="btnBusquedaCreditosPorCodigo_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                    <asp:GridView ID="GridView1" runat="server" ForeColor="Black" Width="1226px" Font-Bold="False">
                        <HeaderStyle BackColor="#666666" ForeColor="White" />
                    </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>