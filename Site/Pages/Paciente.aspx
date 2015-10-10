<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="Paciente.aspx.cs" Inherits="Site.Pages.Paciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">
	<div class="col-xs-3 col-sm-4">
			
			<div class="list-group">
				<a href="#" class="list-group-item">CONSULTAS</a>
				<a href="#" class="list-group-item">PACIENTES</a>
				<a href="RelFuncionario.aspx" class="list-group-item">FUNCIONÁRIOS</a>
				<a href="#" class="list-group-item">TRATAMENTO</a>
			</div>
	</div>
                
    <div class="col-xs-9 col-sm-8 well">
			    <h4 class="page-header-">CADASTRO DE PACIENTES</h4>
				<form id="formulario" runat="server">
				
                    <div class="col-xs-9 col-sm-12">
                        <label >Nome do Paciente:</label>
                        <asp:TextBox ID="txtNomePac" runat="server" CssClass="form-control"  />
					</div>
					
                    <div class="col-xs-9 col-sm-3">
					    <label>Email:</label>
						<asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
					</div>

                    <div class="col-xs-9 col-sm-3">
                        <label>DataNasc:</label>
						<asp:TextBox ID="txtDataNasc" runat="server" CssClass="form-control" />
					</div>

                    <div class="col-xs-9 col-sm-3">
                        <label>NumeroTel:</label>
						<asp:TextBox ID="txtNumeroTel" runat="server" CssClass="form-control" />
					</div>

                    <div class="col-xs-9 col-sm-3">
                        <label>TipoTel:</label>
						<asp:TextBox ID="txtTipoTel" runat="server" CssClass="form-control" />
					</div>

                    <div class="col-xs-9 col-sm-12">
                        <label>Logradouro:</label>
						<asp:TextBox ID="txtLogradouro" runat="server" CssClass="form-control" />
					</div>

                    <div class="col-xs-9 col-sm-6">
                        <label>Bairro:</label>
						<asp:TextBox ID="txtBairro" runat="server" CssClass="form-control" />
					</div>

                    <div class="col-xs-9 col-sm-6">
                        <label>Cidade:</label>
						<asp:TextBox ID="txtCidade" runat="server" CssClass="form-control" />
					</div>
      
                    <div class="col-xs-9 col-sm-2">
                        <label>UF:</label>
						<asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" />
					</div>

                    <div class="col-xs-9 col-sm-6">
                        <label>Cep:</label>
						<asp:TextBox ID="txtCep" runat="server" CssClass="form-control" />
					</div>
                       
                    <div class="col-xs-9 col-sm-12">
                                                     
                    <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar Paciente"
                                CssClass="btn btn-primary"
                                OnClick="btnCadastro_Click" />
                    </div>                   
                                        					
				</form>
			</div>

            <div class="panel-footer">
                <asp:Label ID="lblMensagem" runat="server" />
            </div>
     
</div>


</asp:Content>
