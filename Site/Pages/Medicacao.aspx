<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="Medicacao.aspx.cs" Inherits="Site.Pages.Medicacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="conteudo" runat="server">    

<div class="container">
	<div class="col-xs-3 col-sm-4">
			
			<div class="list-group">
				<a href="" class="list-group-item">CONSULTAS</a>
				<a href="" class="list-group-item">PACIENTES</a>
				<a href="" class="list-group-item">FUNCIONÁRIOS</a>
				<a href="" class="list-group-item">TRATAMENTO</a>
			</div>
	</div>

    <div class="col-xs-9 col-sm-8">
			<div class="well">
				<h4 class="page-header">CADASTRO DE MEDICAMENTOS</h4>
				<form id="formulario" runat="server">
				
                    <label>Nome do Medicamento:</label>
                    <asp:TextBox ID="txtMedicamento" runat="server" CssClass="form-control" />
					<br />
					
					<label>Descrição:</label>
						<asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control" />
					<br />
					                    
                   <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar Medicamento"
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
