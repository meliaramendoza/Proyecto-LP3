<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="Proyecto_LP3.Solicitudes" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="padding:15px">


        <table class="nav-justified">
            <tr>
                <td style="font-size: xx-large; font-weight: bold; font-family: 'Times New Roman', Times, serif; height: 98px;">Solicitudes Pendientes</td>
            </tr>
            <tr>
                <td style="height: 109px">
                    <table class="nav-justified" style="height: 92px">
                        <tr>
                            <td>
                                <table class="nav-justified">
                                    <tr>
                                        <td style="height: 65px"></td>
                                        <td class="modal-sm" style="width: 777px; height: 65px;"></td>
                                        <td class="modal-sm" style="width: 194px; height: 65px;">
                    <asp:Button ID="btnActualizacionSolicitudes" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="White" Height="34px" Text="Actuallizar Datos" Width="157px" OnClick="btnActualizarDatosADMSol_Click" style="font-weight: bold" />
                                        </td>
                                        <td style="height: 65px">
                    <asp:Button ID="btnEliminarSolicitudes" runat="server" BackColor="#333333" Font-Bold="True" ForeColor="White" Height="34px" Text="Eliminar Datos" Width="157px" OnClick="btnEliminarDatosADM_Click" OnClientClick="return confirm('Está seguro que desea eliminar?')" style="margin-top: 0; font-weight: bold;" />
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