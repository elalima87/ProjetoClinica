<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="Funcionario.aspx.cs" Inherits="Site.Pages.Funcionario" %>
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

    

    <div class="col-xs-9 col-sm-4">
			<div class="well">
				<h4 class="page-header">CADASTRO DE FUNCIONÁRIOS</h4>
				<form id="formulario" runat="server">
				
                    <label>Nome do Funcionario:</label>
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" />
					<br />
					
					<label>Login:</label>
						<asp:TextBox ID="txtLogin" runat="server" CssClass="form-control" />
					<br />
					
                    <label>Senha:</label>
						<asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" />
					<br />
                                                         
                    
                   <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar Funcionário"
                                CssClass="btn btn-primary"
                                OnClick="btnCadastro_Click" />
                                        					
				</form>
			</div>

            <div class="panel-footer">
                <asp:Label ID="lblMensagem" runat="server" />
            </div>
     </div>
</div>
</asp:Content>
