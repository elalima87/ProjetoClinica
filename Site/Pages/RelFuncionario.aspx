<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="RelFuncionario.aspx.cs" Inherits="Site.Pages.RelFuncionario" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="conteudo" runat="server">

    <form id="formulario" runat="server">

        <div class="row">
            <div class="col-md-4">

                <div class="panel panel-primary">
                    <div class="panel-heading">
                        Pesquisa de Funcionários
                    </div>
                    <div class="panel-body">

                        <label>Nome:</label>
                        <asp:TextBox ID="txtNomeF" runat="server" 
                                     CssClass="form-control" />
                        <br />

                        <asp:Button ID="btnPesquisa" runat="server" 
                                    Text="Pesquisar Funcionários" 
                                    CssClass="btn btn-danger btn-block"
                                    OnClick="btnPesquisa_Click" />

                        <p>
                            <asp:Label ID="lblMensagem" runat="server" />
                        </p>

                       </div>
                </div>

            </div>

                        <div class="col-md-8">
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <rsweb:ReportViewer ID="ReportViewer" runat="server" Width="100%" Height="600" SizeToReportContent="true"></rsweb:ReportViewer>
                        </div>
         </div>
           
</form>
</asp:Content>
